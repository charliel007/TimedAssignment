
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimedAssignment.Data.Entities

{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        public PostEntity()
        {
        }
    }
}