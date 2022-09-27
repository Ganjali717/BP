using Microsoft.EntityFrameworkCore;
using SimpleAPI.Models;

namespace SimpleAPI.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> context) : base(context)
        {

        }

        public DbSet<Issue> Issues { get; set; }
    }
}
