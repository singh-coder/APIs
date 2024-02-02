using System.Reflection;
using HealthCareMate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HealthCareMate.Persistence.Contexts
{
    public class HealthCareMateDbContext: DbContext
    {
        public HealthCareMateDbContext(DbContextOptions<HealthCareMateDbContext> options): base(options)
        {
            
        }

        public DbSet<Doctor> Doctors {get; set;}
        public DbSet<Department> Departments {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}