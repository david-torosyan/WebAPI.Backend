using Microsoft.EntityFrameworkCore;
using API.Domain;

namespace API.DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
    }
}
