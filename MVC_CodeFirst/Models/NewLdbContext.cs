using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Models
{
    public class NewLdbContext : DbContext
    {
        public NewLdbContext(DbContextOptions<NewLdbContext> options) : base(options)
        { }
        public DbSet<Abhishek> Abhisheks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
