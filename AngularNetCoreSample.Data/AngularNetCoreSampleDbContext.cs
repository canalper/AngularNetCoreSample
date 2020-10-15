using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularNetCoreSample.Data
{
    public class AngularNetCoreSampleDbContext : DbContext
    {
        public DbSet<AnnualApplicationCount> AnnualApplicationCount { get; set; }

        public DbSet<TopClaimTopic> TopClaimTopic { get; set; }

        public DbSet<CallTurningIntoApplication> CallTurningIntoApplication { get; set; }

        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=AngularNetCoreSample.db");
    }
}
