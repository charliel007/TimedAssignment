using System.Collections.Generic;

namespace TimedAssignment.Models
{
    public class PostEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public Guid AuthorId { get; set; }

        public PostEntity()
        {

        }
    }
}