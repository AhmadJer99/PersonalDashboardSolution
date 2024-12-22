using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace PersonalDashboard.Models
{
    public class PersonalDashboardContext : DbContext
    {
        public PersonalDashboardContext(DbContextOptions options) : base(options)
        {

        }
        public PersonalDashboardContext()
        {

        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            }
        }
    }
}