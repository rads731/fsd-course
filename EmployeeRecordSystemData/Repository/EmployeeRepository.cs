using EmployeeResourceSystemData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordSystemData.Repository
{
    public class EmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> Get()
        {
            return await _context.Employee.ToListAsync();
        }

        public async Task<Employee> Get(string id)
        {
            return await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);
        }

        public async Task Add(Employee employee)
        {
            _context.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> Edit(string id)
        {
            return await _context.Employee.FirstAsync(m => m.EmployeeID == id);
        }

        public async Task Update(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> Delete(string id)
        {
            return await _context.Employee.FirstOrDefaultAsync(m => m.EmployeeID == id);

        }

        public async Task DeleteConfirmed(string id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Employee.AnyAsync(m => m.EmployeeID == id);
        }
    }
}
