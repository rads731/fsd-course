using EmployeeResourceSystemData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordSystemData.Repository
{
    public class DepartmentRepository
    {
        private readonly EmployeeDbContext _context;
        public DepartmentRepository(EmployeeDbContext context)
        {
            _context = context;
        }
       public async Task<List<Department>> Get()
       {
            return await _context.Department.ToListAsync();
       }

        public async Task<Department> Get(string id)
        {
            return await _context.Department.FirstOrDefaultAsync(m => m.DepartmentID == id);
        }

        public async Task Add(Department department)
        {
            _context.Add(department);
            await _context.SaveChangesAsync();
        }

        public async Task<Department> Edit(string id)
        {
            return await _context.Department.FirstAsync(m=>m.DepartmentID==id);
        }

        public async Task Update(Department department)
        {
            _context.Update(department);
            await _context.SaveChangesAsync();
        }

        public async Task<Department> Delete(string id)
        {
           return await _context.Department.FirstOrDefaultAsync(m => m.DepartmentID == id);
            
        }

        public async Task DeleteConfirmed(string id)
        {
            var department = await _context.Department.FindAsync(id);
            _context.Department.Remove(department);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string id)
        {
            return await _context.Department.AnyAsync(m => m.DepartmentID == id);
        }
    }
}
