using DatabaseOnDocker_Demo.Data;
using Microsoft.EntityFrameworkCore;

namespace DatabaseOnDocker_Demo.Services
{
    public static class DatabaseManagementService
    {

        public static void MigrationInitialization(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();
            }
        }
    }
}
