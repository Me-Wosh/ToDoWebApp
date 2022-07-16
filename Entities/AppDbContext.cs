using Microsoft.EntityFrameworkCore;

namespace ToDoWebApp.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
              
        }

        public DbSet<ToDoTable> ToDoTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoTable>().HasData(
                new ToDoTable
                {
                    Id = 1,
                    Name = "Enjoying the App",
                    Details = "Simple as that!",
                    ImportanceLevel = 1
                }
            );
        }
    }
}
