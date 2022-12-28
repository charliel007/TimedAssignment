using Microsoft.EntityFrameworkCore;


namespace TimedAssignment.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<ReplyEntity> Replies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
