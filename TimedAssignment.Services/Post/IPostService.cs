using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimedAssignment.Models.Post;

namespace TimedAssignment.Services.Post
{
    public interface IPostService
    {
        Task<bool> CreatePostAsync(PostCreate model);
    }
}