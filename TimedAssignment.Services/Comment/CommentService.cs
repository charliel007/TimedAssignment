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
        public CommentService(IHttpContextAccessor httpContextAccessor, ApplicationDbContext dbContext)
        {
            _PostedId = 2;
            var userClaims = httpContextAccessor.HttpContext.User.Identity as ClaimsIdentity;
            var value = userClaims.FindFirst("Id")?.Value;
            var validId = int.TryParse(value, out _PostedId);
            if (!validId)
                throw new Exception("Attempted to build Post without Post Id claim.");
                
            _dbContext = dbContext;
        }

            public async Task<bool> CreateCommentAsync(CommentCreate request)
            {
                var commentEntity = new CommentEntity
                {
                    Text = request.Text,
                    PostedId = _PostedId
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