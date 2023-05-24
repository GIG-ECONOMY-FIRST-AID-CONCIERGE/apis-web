using GigEconomyCore.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Infra.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }

        public DbSet<T_ADRESS> T_Address{ get; set; }
        public DbSet<T_ASSISTANCE> T_Assistance { get; set; }
        public DbSet<T_ASSISTANCE_RECORDS> T_Assistance_Records { get; set; }
        public DbSet<T_PARTNER> T_Partner { get; set; }
        public DbSet<T_SINISTER> T_Sinister { get; set; }
        public DbSet<T_VEHICLE> T_Vehicle { get; set; }
    }

}

