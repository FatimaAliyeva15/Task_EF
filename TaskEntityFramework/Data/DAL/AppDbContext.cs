using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-6KN5926\\SQLEXPRESS;Database=TaskEntityFramework; Trusted_Connection=true;Integrated Security=true;Encrypt=false");
        }

        public DbSet<Student> Students { get; set; }
    }
}
