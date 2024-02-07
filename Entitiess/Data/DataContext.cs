using Entitiess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiess.Data
{

    public class DataContext : DbContext
    {

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public virtual DbSet<ParentCategory> ParentCategory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Manufaturer> Manufaturers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-EN72J61\\SQLEXPRESS;Initial Catalog=KarryKart;Integrated Security=True;TrustServerCertificate=True;");

    }
}
