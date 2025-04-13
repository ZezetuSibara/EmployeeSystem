using angularCRUDWebAPI2.Models;
using Microsoft.EntityFrameworkCore;

namespace angularCRUDWebAPI2.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
                
        }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Employees> employees { get; set; }
    }
}
