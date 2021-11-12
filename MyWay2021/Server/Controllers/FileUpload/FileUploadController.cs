using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Analise;
using MyWay2021.Shared.Models.Tabelas;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MyWay2021.Server.Controllers.FileUpload
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : Controller
    {
        private readonly IWebHostEnvironment hostingEnv;
        private readonly AppDBContext _db;

        private static string StatusKey { get; set; }
        private static string StatusValue { get; set; }
        private static int Inserted { get; set; }
        private static int Updated { get; set; }

        public FileUploadController(IWebHostEnvironment env, AppDBContext context)
        {
            hostingEnv = env;
            _db = context;
        }

        [HttpPost("[action]")]
        public void Save(IList<IFormFile> UploadFiles)
        {
            long size = 0;
            try
            {
                foreach (var file in UploadFiles)
                {
                    var filename = ContentDispositionHeaderValue
                            .Parse(file.ContentDisposition)
                            .FileName
                            .Trim('"');
                    filename = hostingEnv.ContentRootPath + $@"\UploadedFiles\{filename}";
                    size += (int)file.Length;
                    if (!System.IO.File.Exists(filename))
                    {
                        using (FileStream fs = System.IO.File.Create(filename))
                        {
                            file.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Response.Clear();
                Response.StatusCode = 204;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
        [HttpPost("[action]")]
        public void Remove(IList<IFormFile> UploadFiles)
        {
            try
            {
                var filename = hostingEnv.ContentRootPath + $@"\UploadedFiles\{UploadFiles[0].FileName}";
                if (System.IO.File.Exists(filename))
                {
                    System.IO.File.Delete(filename);
                }
            }
            catch (Exception e)
            {
                Response.Clear();
                Response.StatusCode = 200;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File removed successfully";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }

        public async Task ProcessFilesAsync()
        {
            StatusKey = null;
            var path = hostingEnv.ContentRootPath + $@"\UploadedFiles\";
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                DataTable excelTable = ReadFromExcel<DataTable>(file, true);

                if (IsAssistenciasPRM(excelTable))
                {
                    await AddAssistenciasPRM(excelTable);
                }
                //if (IsAirportData(excelTable))
                //{
                //    await AddAirportData(excelTable);
                //}
                else
                {
                    StatusKey = "Erro";
                    StatusValue = "BadFile";
                }

                DirectoryInfo di = new(path);

                foreach (FileInfo filetodelete in di.GetFiles())
                {
                    filetodelete.Delete();
                }
            }
        }

        private static T ReadFromExcel<T>(string path, bool hasHeader = true)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var excelPack = new ExcelPackage();
            //Load excel stream
            using (var stream = System.IO.File.OpenRead(path))
            {
                excelPack.Load(stream);
            }

            //Lets Deal with first worksheet.(You may iterate here if dealing with multiple sheets)
            var ws = excelPack.Workbook.Worksheets[0];

            //Get all details as DataTable -because Datatable make life easy :)
            DataTable excelasTable = new DataTable();
            foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
            {
                //Get colummn details
                if (!string.IsNullOrEmpty(firstRowCell.Text))
                {
                    string firstColumn = string.Format("Column {0}", firstRowCell.Start.Column);
                    excelasTable.Columns.Add(hasHeader ? firstRowCell.Text : firstColumn);
                }
            }
            var startRow = hasHeader ? 2 : 1;
            //Get row details
            for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
            {
                var wsRow = ws.Cells[rowNum, 1, rowNum, excelasTable.Columns.Count];
                DataRow row = excelasTable.Rows.Add();
                foreach (var cell in wsRow)
                {
                    row[cell.Start.Column - 1] = cell.Text;
                }
            }
            //Get everything as generics and let end user decides on casting to required type
            var generatedType = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(excelasTable));
            return (T)Convert.ChangeType(generatedType, typeof(T));
        }

        private static bool IsAssistenciasPRM(DataTable excelTable)
        {
            if (
                    excelTable.Columns.Contains("Aeroporto") &&
                    excelTable.Columns.Contains("Msg") &&
                    excelTable.Columns.Contains("Notif") &&
                    excelTable.Columns.Contains("Data") &&
                    excelTable.Columns.Contains("Voo") &&
                    excelTable.Columns.Contains("Mov") &&
                    excelTable.Columns.Contains("Orig Dest") &&
                    excelTable.Columns.Contains("Pax") &&
                    excelTable.Columns.Contains("SSR") &&
                    excelTable.Columns.Contains("AC") &&
                    excelTable.Columns.Contains("Stand") &&
                    excelTable.Columns.Contains("Exit") &&
                    excelTable.Columns.Contains("Ck In")
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task AddAssistenciasPRM(DataTable excelTable)
        {
            for (int i = 0; i < excelTable.Rows.Count; i++)
            {
                string aeroporto = (string)excelTable.Rows[i].ItemArray[0];
                string msg = (string)excelTable.Rows[i].ItemArray[1];
                string notif = (string)excelTable.Rows[i].ItemArray[2];
                DateTime data = DateTime.Parse((string)excelTable.Rows[i].ItemArray[3]);
                string voo = (string)excelTable.Rows[i].ItemArray[4];
                string mov = (string)excelTable.Rows[i].ItemArray[5];
                string origDest = (string)excelTable.Rows[i].ItemArray[6];
                string pax = (string)excelTable.Rows[i].ItemArray[7];
                string ssr = (string)excelTable.Rows[i].ItemArray[8];
                string ac = (string)excelTable.Rows[i].ItemArray[9];
                string stand = (string)excelTable.Rows[i].ItemArray[10];

                if (string.IsNullOrEmpty(stand))
                {
                    stand = "000";
                }

                string exit = (string)excelTable.Rows[i].ItemArray[11];
                string ckin = (string)excelTable.Rows[i].ItemArray[12];
                string gate = (string)excelTable.Rows[i].ItemArray[13];
                string transferencia = (string)excelTable.Rows[i].ItemArray[14];
                DateTime horaEmbarque = data.AddMinutes(-BrdTime(gate));
                DateTime saidaStaging = data.AddMinutes(-StagingTime(gate));
                DateTime estimaApresentacao = data.AddMinutes(-EstimaTime(gate));

                AssistenciasPRM currentExcel = new()
                {
                    Aeroporto = aeroporto,
                    Msg = msg,
                    Notif = notif,
                    Data = data,
                    Voo = voo,
                    Mov = mov,
                    OrigDest = origDest,
                    Pax = pax,
                    SSR = ssr,
                    AC = ac,
                    Stand = stand,
                    Exit = exit,
                    CkIn = ckin,
                    Gate = gate,
                    Transferencia = transferencia,
                    HoraEmbarque = horaEmbarque,
                    SaidaStaging = saidaStaging,
                    EstimaApresentacao = estimaApresentacao
                };

                AssistenciasPRM exists = new AssistenciasPRM();

                exists = _db.AssistenciasPRMS
                    .Where(d =>
                        d.Aeroporto == aeroporto &&
                        d.Data.Date.Day == data.Date.Day &&
                        d.Voo == voo &&
                        d.Mov == mov &&
                        d.Pax == pax
                        ).FirstOrDefault();

                if (exists != null)
                {
                    if (exists.ID != default || exists.ID != Guid.Empty)
                    {
                        exists.Aeroporto = currentExcel.Aeroporto;
                        exists.Msg = currentExcel.Msg;
                        exists.Notif = currentExcel.Notif;
                        exists.Data = currentExcel.Data;
                        exists.Voo = currentExcel.Voo;
                        exists.Mov = currentExcel.Mov;
                        exists.OrigDest = currentExcel.OrigDest;
                        exists.Pax = currentExcel.Pax;
                        exists.SSR = currentExcel.SSR;
                        exists.AC = currentExcel.AC;
                        exists.Stand = currentExcel.Stand;
                        exists.Exit = currentExcel.Exit;
                        exists.CkIn = currentExcel.CkIn;
                        exists.Gate = currentExcel.Gate;
                        exists.Transferencia = currentExcel.Transferencia;
                        exists.HoraEmbarque = currentExcel.HoraEmbarque;
                        exists.SaidaStaging = currentExcel.SaidaStaging;
                        exists.EstimaApresentacao = currentExcel.EstimaApresentacao;

                        Updated++;
                        _db.Entry(exists).State = EntityState.Modified;
                    }
                }
                else
                {
                    Inserted++;
                    _db.Add(currentExcel);
                }
            }
            await _db.SaveChangesAsync();
        }

        private int BrdTime(string gate)
        {
            bool gateExist = _db.Portas.Any(g => g.PortaNum.Equals(gate));

            if (gateExist)
            {
                Porta queryP = _db.Portas.FirstOrDefault(g => g.PortaNum.Equals(gate));

                bool schengen = queryP.Schengen;
                int tempoTotal = (schengen == true) ? 40 : 60;
                return tempoTotal;
            }
            else
            {
                return 0;
            }
        }

        private int StagingTime(string gate)
        {
            bool gateExist = _db.Portas.Any(g => g.PortaNum.Equals(gate));

            if (gateExist)
            {
                Porta queryP = _db.Portas.FirstOrDefault(g => g.PortaNum.Equals(gate));

                int portaTempo = queryP.PortaTempo;

                bool schengen = queryP.Schengen;
                int tempoTotal = (schengen == true) ? 40 + portaTempo : 60 + portaTempo;
                return tempoTotal;
            }
            else
            {
                return 0;
            }
        }

        private int EstimaTime(string gate)
        {
            bool gateExist = _db.Portas.Any(g => g.PortaNum.Equals(gate));

            if (gateExist)
            {
                Porta queryPorta = _db.Portas.FirstOrDefault(g => g.PortaNum.Equals(gate));

                bool schengen = queryPorta.Schengen;
                string paramNome = (schengen == true) ? "CPS" : "CPN";

                Parametro queryParam = _db.Parametros.FirstOrDefault(p => p.ParamNome.Equals(paramNome));
                int tempoTotal = queryParam.ParamValue;
                return tempoTotal;
            }
            else
            {
                return 0;
            }
        }


        private static bool IsAirportData(DataTable excelTable)
        {
            if (
                    excelTable.Columns.Contains("Mov Type") &&
                    excelTable.Columns.Contains("Registration") &&
                    excelTable.Columns.Contains("Capacity") &&
                    excelTable.Columns.Contains("Flight Nr") &&
                    excelTable.Columns.Contains("Arrival Belt") &&
                    excelTable.Columns.Contains("Gate") &&
                    excelTable.Columns.Contains("Check In Counters") &&
                    excelTable.Columns.Contains("Flight Destination") &&
                    excelTable.Columns.Contains("Flight Origin") &&
                    excelTable.Columns.Contains("Estimated Date Time") &&
                    excelTable.Columns.Contains("Schedule Date Time") &&
                    excelTable.Columns.Contains("Actual Date Time") &&
                    excelTable.Columns.Contains("Code Share")
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task AddAirportData(DataTable excelTable)
        {
            for (int i = 0; i < excelTable.Rows.Count; i++)
            {
                string mov = (string)excelTable.Rows[i].ItemArray[0];
                string reg = (string)excelTable.Rows[i].ItemArray[1];
                string voo = (string)excelTable.Rows[i].ItemArray[3];
                DateTime estimatedTime = DateTime.Parse((string)excelTable.Rows[i].ItemArray[9]);
                DateTime scheduleTime = DateTime.Parse((string)excelTable.Rows[i].ItemArray[10]);
                DateTime actualTime = DateTime.Parse((string)excelTable.Rows[i].ItemArray[11]);
                DateTime blockTime = DateTime.Parse((string)excelTable.Rows[i].ItemArray[13]);
                DateTime beginBRD = DateTime.Parse((string)excelTable.Rows[i].ItemArray[14]);
                DateTime endBRD = DateTime.Parse((string)excelTable.Rows[i].ItemArray[15]);
                DateTime estimatedTimeUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[25]);
                DateTime scheduleTimeUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[26]);
                DateTime actualTimeUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[27]);
                DateTime blockTimeUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[28]);
                DateTime beginBRDUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[29]);
                DateTime endBRDUTC = DateTime.Parse((string)excelTable.Rows[i].ItemArray[30]);

                DadosAeroporto currentExcel = new()
                {
                    Mov = mov,
                    Reg = reg,
                    Voo = voo,
                    EstimatedTime = estimatedTime,
                    ScheduleTime = scheduleTime,
                    ActualTime = actualTime,
                    BlockTime = blockTime,
                    BeginBRD = beginBRD,
                    EndBRD = endBRD,
                    EstimatedTimeUTC = estimatedTimeUTC,
                    ScheduleTimeUTC = scheduleTimeUTC,
                    ActualTimeUTC = actualTimeUTC,
                    BlockTimeUTC = blockTimeUTC,
                    BeginBRDUTC = beginBRDUTC,
                    EndBRDUTC = endBRDUTC
                };

                DadosAeroporto exists = new DadosAeroporto();

                exists = _db.DadosAeroportos
                    .Where(d =>
                        d.Mov == mov &&
                        d.Reg == reg &&
                        d.Voo == voo &&
                        d.ScheduleTime == scheduleTime &&
                        d.ScheduleTimeUTC == scheduleTimeUTC
                        ).FirstOrDefault();

                if (exists != null)
                {
                    if (exists.ID != default || exists.ID != Guid.Empty)
                    {
                        exists.Mov = currentExcel.Mov;
                        exists.Reg = currentExcel.Reg;
                        exists.Voo = currentExcel.Voo;
                        exists.EstimatedTime = currentExcel.EstimatedTime;
                        exists.ScheduleTime = currentExcel.ScheduleTime;
                        exists.ActualTime = currentExcel.ActualTime;
                        exists.BlockTime = currentExcel.BlockTime;
                        exists.BeginBRD = currentExcel.BeginBRD;
                        exists.EndBRD = currentExcel.EndBRD;
                        exists.EstimatedTimeUTC = currentExcel.EstimatedTimeUTC;
                        exists.ScheduleTimeUTC = currentExcel.ScheduleTimeUTC;
                        exists.ActualTimeUTC = currentExcel.ActualTimeUTC;
                        exists.BlockTimeUTC = currentExcel.BlockTimeUTC;
                        exists.BeginBRDUTC = currentExcel.BeginBRDUTC;
                        exists.EndBRDUTC = currentExcel.EndBRDUTC;

                        Updated++;
                        _db.Entry(exists).State = EntityState.Modified;
                    }
                }
                else
                {
                    Inserted++;
                    _db.Add(currentExcel);
                }
            }
            await _db.SaveChangesAsync();
        }
    }
}
