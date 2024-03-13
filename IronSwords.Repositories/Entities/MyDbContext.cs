using IronSwords.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.Repositories.Entities
{
    public class MyDbContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Accommodation> Accommodations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=IronSwords;Trusted_Connection=True;");
        }
    }
}
