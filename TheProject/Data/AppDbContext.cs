using Microsoft.EntityFrameworkCore;
using TheProject.Models;

namespace TheProject.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Grocery> Groceries { get; set; }
    }
}
