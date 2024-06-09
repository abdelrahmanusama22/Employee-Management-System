using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet <Department> Departments { get; set; }
    }
}
