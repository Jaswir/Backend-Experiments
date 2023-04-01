using Microsoft.EntityFrameworkCore;
using EmployeeesWebAPI.Models.Domain;

namespace EmployeeesWebAPI.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
