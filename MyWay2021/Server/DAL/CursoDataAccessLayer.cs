using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Tabelas;
using System;
using System.Collections;
using System.Linq;

namespace MyWay2021.Shared.DAL
{
    public interface ICursoDataAccessLayer
    {
        IEnumerable GetAllCursos();
        void AddCurso(Curso curso);
        void UpdateCurso(Curso curso);
        Curso GetCursoData(Guid id);
        void DeleteCurso(Guid id);
    }

    public class CursoDataAccessLayer : ICursoDataAccessLayer
    {
        private AppDBContext _context;
        public CursoDataAccessLayer(AppDBContext context)
        {
            _context = context;
        }

        //To Get all Cursos details   
        public IEnumerable GetAllCursos()
        {
            try
            {
                return _context.Cursos.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //To Add new Curso record     
        public void AddCurso(Curso curso)
        {
            try
            {
                _context.Cursos.Add(curso);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee    
        public void UpdateCurso(Curso curso)
        {
            try
            {
                _context.Entry(curso).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular Curso    
        public Curso GetCursoData(Guid id)
        {
            try
            {
                Curso curso = _context.Cursos.Find(id);
                return curso;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular curso    
        public void DeleteCurso(Guid id)
        {
            try
            {
                Curso curso = _context.Cursos.Find(id);
                _context.Cursos.Remove(curso);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}