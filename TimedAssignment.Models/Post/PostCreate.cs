using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAssignment.Models.Post
{
    public class PostCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} Characters long.")]
        [MaxLength(100, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Title { get; set; }

        [MaxLength(8000, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Text { get; set; }
    }
}