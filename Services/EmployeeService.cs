using EmployeeManagment.Data;
using EmployeeManagment.Models;
using EmployeeManagment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Services
{
    public class EmployeeService : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Employee? employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                throw new KeyNotFoundException("Employee not found");
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }
    }
}
