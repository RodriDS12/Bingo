using bingo_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace bingo_backend.Persistence
{
    // Context of database
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
