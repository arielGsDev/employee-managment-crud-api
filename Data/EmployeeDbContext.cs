using EmployeeManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Data
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
    }
}
