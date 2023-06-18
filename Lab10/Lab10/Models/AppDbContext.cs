using Microsoft.EntityFrameworkCore;

namespace Lab10.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options): base(options) { }
        public DbSet<WebUser> Users { get; set; }
    }
}
