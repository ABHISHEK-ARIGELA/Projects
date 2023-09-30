using Microsoft.EntityFrameworkCore;
using MVC_DbFirst.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DbFirst.EFPersistanceLayer
{
    public class AbhishekContext
    {
        public static bool CreateEmployee(Abhishek e)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483Context> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483Context>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483Context db = new Abhishek100483Context(optionsBuilder.Options);
                db.Abhisheks.Add(e);
                db.SaveChanges();
                return true;

            }
            catch
            {
                throw;
            }
        }

        public static List<Abhishek> getEmployees()
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483Context> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483Context>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483Context db = new Abhishek100483Context(optionsBuilder.Options);
                List<Abhishek> l = db.Abhisheks.ToList();
                return l;

            }
            catch
            {
                throw;
            }

        }

        public static void UpdateEmployee(Abhishek e)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483Context> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483Context>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483Context db = new Abhishek100483Context(optionsBuilder.Options);
                db.Abhisheks.Update(e);
                db.SaveChanges();

            }
            catch
            {
                throw;
            }

        }

        public static void DeleteEmployee(int id)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483Context> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483Context>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483Context db = new Abhishek100483Context(optionsBuilder.Options);
                Abhishek e = db.Abhisheks.Find(id);
                db.Abhisheks.Remove(e);
                db.SaveChanges();

            }
            catch
            {
                throw;
            }

        }

        public static Abhishek getEmployeeById(int id)
        {

            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483Context> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483Context>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483Context db = new Abhishek100483Context(optionsBuilder.Options);
                Abhishek e = db.Abhisheks.Find(id);
                return e;

            }
            catch
            {
                throw;
            }
        }
    }
}
