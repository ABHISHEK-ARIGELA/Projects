using API_DbFirst.EFModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DbFirst.EFPersistanceLayer
{
    public class EmployeeContext
    {
        public static bool CreateEmployee(Employee e)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483NewContext> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483NewContext>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483NewContext db = new Abhishek100483NewContext(optionsBuilder.Options);
                db.Employees.Add(e);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public static List<Employee> GetEmployees()
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483NewContext> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483NewContext>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483NewContext db = new Abhishek100483NewContext(optionsBuilder.Options);
                List<Employee> l = db.Employees.ToList();
                return l;

            }
            catch
            {
                throw;
            }
        }

        public static Employee getEmployeeById(int id)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483NewContext> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483NewContext>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483NewContext db = new Abhishek100483NewContext(optionsBuilder.Options);
                Employee e = db.Employees.Find(id);

                return e;

            }
            catch
            {
                throw;
            }
        }

        public static bool UpdateEmployee(Employee e)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483NewContext> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483NewContext>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483NewContext db = new Abhishek100483NewContext(optionsBuilder.Options);
                db.Employees.Update(e);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteEmployee(int id)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<Abhishek100483NewContext> optionsBuilder = new DbContextOptionsBuilder<Abhishek100483NewContext>();
                optionsBuilder.UseSqlServer(connc);
                Abhishek100483NewContext db = new Abhishek100483NewContext(optionsBuilder.Options);
                Employee e = db.Employees.Find(id);
                db.Employees.Remove(e);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
