using DatabaseOnDocker_Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseOnDocker_Demo.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
