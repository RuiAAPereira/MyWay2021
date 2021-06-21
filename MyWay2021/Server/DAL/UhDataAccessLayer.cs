using Microsoft.EntityFrameworkCore;
using MyWay2021.Server.Data;
using MyWay2021.Shared.Models.Tabelas;

namespace MyWay2021.Server.DAL
{
    public class UhDataAccessLayer
    {
        private readonly AppDBContext db;
        public UhDataAccessLayer(AppDBContext context)
        {
            this.db = context;
        }

        //To Get all Orders details
        public DbSet<Uh> GetAllUhs()
        {
            try
            {
                return db.Uhs;
            }
            catch
            {
                throw;
            }
        }

    }
}
