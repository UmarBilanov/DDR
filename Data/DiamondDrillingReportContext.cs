using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DiamondDrillingReport.Models
{
    public class DiamondDrillingReportContext : DbContext
    {
        public DiamondDrillingReportContext (DbContextOptions<DiamondDrillingReportContext> options)
            : base(options)
        {
        }

        public DbSet<Hole> Hole { get; set; }

        public DbSet<HoleStatus> HoleStatus { get; set; }

        public DbSet<HoleZone> HoleZone { get; set; }

        public DbSet<Drill> Drill { get; set; }

        public DbSet<Area> Area { get; set; }

        public DbSet<DrillProgram> DrillProgram { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Crew> Crew { get; set; }

        public DbSet<CreateDailyReport> CreateDailyReport { get; set; }

        public DbSet<Equipment> Equipment { get; set; }

    }
}
