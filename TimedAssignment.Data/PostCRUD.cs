using ElevenNote.Data.ElevenNoteContext;
using Microsoft.EntityFrameworkCore;
using TimedAssignment.Models;

namespace TimedAssignment.Data
{
    public class PostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<PostEntity>> GetAllPosts()
        {

            return await _context.Posts.ToListAsync();
        }

        public async Task<PostEntity> GetPostById(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(post => post.Id == id);
        }

        public async Task<bool> CreatePost(PostEntity post)
        {
            _context.Posts.Add(post);
            var numberOfChanges = await _context.SaveChangesAsync();

            return numberOfChanges == 1;
        }

        public async Task<PostEntity> UpdatePost(PostEntity post)
        {
            return new PostEntity();
        }

        public async Task<bool> DeletePost(PostEntity post)
        {
            return true;
        }

    }
}