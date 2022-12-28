using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD

=======
using TimedAssignment.Models;
>>>>>>> 9a80f8664290849baa877a2d0fd69db715cf2b89

namespace TimedAssignment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

<<<<<<< HEAD
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<ReplyEntity> Replies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
=======
        public DbSet<PostEntity> Post { get; set; }
>>>>>>> 9a80f8664290849baa877a2d0fd69db715cf2b89
    }
}