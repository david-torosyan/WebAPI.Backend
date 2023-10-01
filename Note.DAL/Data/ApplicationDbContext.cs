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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Note>()
                    .HasIndex(s => s.Title)
                    .IsUnique();
        }


    }
}
