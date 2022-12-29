using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using TimedAssignment.Data;
using TimedAssignment.Data.Entities;
using TimedAssignment.Models.Comment;

namespace TimedAssignment.Services.Comment
{
    public class CommentService : ICommentService
    {
        private readonly int _PostedId;
        private readonly ApplicationDbContext _dbContext;
        public CommentService(ApplicationDbContext dbContext)
        {
            
          
                
            _dbContext = dbContext;
        }

            public async Task<bool> CreateCommentAsync(CommentCreate request)
            {
                var commentEntity = new CommentEntity
                {
                    Text = request.Text,
                    PostedId = request.PostedId
                };

                _dbContext.Comments.Add(commentEntity);

                var numberOfChanges = await _dbContext.SaveChangesAsync();
                return numberOfChanges == 1;
            }
        
            public async Task<IEnumerable<CommentListItem>> GetAllCommentsAsync()
            {
                var comments = await _dbContext.Comments
                .Where(entity => entity.PostedId == _PostedId)
                .Select(entity => new CommentListItem
                {
                    Id = entity.Id,
                    Text = entity.Text,
                    CommentDate = entity.CommentDate
                })
                .ToListAsync();

                return comments;
            }
    }
}