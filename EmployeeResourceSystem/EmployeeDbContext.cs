using EmployeeResourceSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeResourceSystem
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
