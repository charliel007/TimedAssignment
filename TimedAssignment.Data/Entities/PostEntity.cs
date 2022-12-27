using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimedAssignment.Models
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Guid AuthorId { get; set; }

        public PostEntity()
        {
        }
    }
}