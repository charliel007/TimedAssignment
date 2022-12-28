using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedAssignment.Data.Entities;
using TimedAssignment.Models.Post;

namespace TimedAssignment.Services.Post
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(PostCreate model);
        Task<IEnumerable<PostDetail>> GetAllPostsAsync();
    }
}