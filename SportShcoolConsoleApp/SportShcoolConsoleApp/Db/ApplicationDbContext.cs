using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp.Db
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<CoachingStaff> coachingStaffs { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<HospitalCard> hospitalCards { get; set; }
        public DbSet<KindOfSport> kindOfSports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.AppSettings["ConnectionString"]/*"Host=localhost;Port=5432;Database=SportSchool;Username=postgres;Password=root"*/);
        }
    }
}
