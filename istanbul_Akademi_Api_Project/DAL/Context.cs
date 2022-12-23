using istanbul_Akademi_Api_Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace istanbul_Akademi_Api_Project.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YUNUS\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
