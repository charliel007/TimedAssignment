using TimedAssignment.Models;

using Microsoft.EntityFrameworkCore;

namespace ElevenNote.Data.ElevenNoteContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PostEntity> Posts { get; set; }
    }
}