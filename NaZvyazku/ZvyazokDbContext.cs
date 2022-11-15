using Microsoft.EntityFrameworkCore;
using NaZvyazku.Controller;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaZvyazku
{
    public class ZvyazokDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<PersonalArea> personalAreas { get; set; }
        public DbSet<Authorization> authorizations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(GetConnectionStrings());
        }

        public static string GetConnectionStrings()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings stringSettings in settings)
                {
                    return stringSettings.ConnectionString;
                }
            }
            return "";
        }
    }
}
