using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TimedAssignment.Data;
using TimedAssignment.Data.Entities;
using TimedAssignment.Models;
using TimedAssignment.Models.Post;

namespace TimedAssignment.Services.Post
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> CreatePostAsync(PostCreate model)
        {
            var entity = new PostEntity
            {
                Title = model.Title,
                Text = model.Text,
                CreatedDate = DateTimeOffset.Now
                
            };

            _context.Posts.Add(entity);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        
        public async Task<IEnumerable<PostDetail>> GetAllPostsAsync()
        {
            var posts =  await _context.Posts
            .Select(entity => new PostDetail
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    Text = entity.Text,
                    DateCreated = entity.CreatedDate
                }).ToListAsync();
                
            return posts;
        }

    }
}