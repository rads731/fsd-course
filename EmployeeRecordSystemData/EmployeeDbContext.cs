using EmployeeResourceSystemData.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeRecordSystemData
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
