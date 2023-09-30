using API_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CodeFirst.EFPersistanceLayer
{
    public class EmployeeContext
    {
        public static bool CreateEmployee(Employee e)
        {
            string connc = "Server=(localdb)\\mssqllocaldb;database=Abhishek100483New;integrated security=True";
            try
            {
                DbContextOptionsBuilder<EmployeeDataContext> optionsBuilder = new DbContextOptionsBuilder<EmployeeDataContext>();
                optionsBuilder.UseSqlServer(connc);
                EmployeeDataContext db = new EmployeeDataContext(optionsBuilder.Options);
                db.employees.Add(e);
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
                DbContextOptionsBuilder<EmployeeDataContext> optionsBuilder = new DbContextOptionsBuilder<EmployeeDataContext>();
                optionsBuilder.UseSqlServer(connc);
                EmployeeDataContext db = new EmployeeDataContext(optionsBuilder.Options);
               List<Employee> l =  db.employees.ToList();
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
                DbContextOptionsBuilder<EmployeeDataContext> optionsBuilder = new DbContextOptionsBuilder<EmployeeDataContext>();
                optionsBuilder.UseSqlServer(connc);
                EmployeeDataContext db = new EmployeeDataContext(optionsBuilder.Options);
              Employee e=   db.employees.Find(id);
                
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
                DbContextOptionsBuilder<EmployeeDataContext> optionsBuilder = new DbContextOptionsBuilder<EmployeeDataContext>();
                optionsBuilder.UseSqlServer(connc);
                EmployeeDataContext db = new EmployeeDataContext(optionsBuilder.Options);
                db.employees.Update(e);
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
                DbContextOptionsBuilder<EmployeeDataContext> optionsBuilder = new DbContextOptionsBuilder<EmployeeDataContext>();
                optionsBuilder.UseSqlServer(connc);
                EmployeeDataContext db = new EmployeeDataContext(optionsBuilder.Options);
                Employee e = db.employees.Find(id);
                db.employees.Remove(e);
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
