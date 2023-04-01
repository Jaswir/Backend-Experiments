using DockerComposeDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
