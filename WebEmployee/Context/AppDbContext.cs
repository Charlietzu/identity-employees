using Microsoft.EntityFrameworkCore;
using WebEmployee.Models;

namespace WebEmployee.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Employee> Employees { get; set; }
    }
}
