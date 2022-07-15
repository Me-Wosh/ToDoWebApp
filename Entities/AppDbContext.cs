using Microsoft.EntityFrameworkCore;

namespace ToDoWebApp.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
              
        }

        public DbSet<ToDoTable> ToDoTable { get; set; }
    }
}
