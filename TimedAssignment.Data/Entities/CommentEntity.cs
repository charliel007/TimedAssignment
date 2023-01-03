using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimedAssignment.Data.Entities
{
    public class CommentEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTimeOffset CommentDate { get; set; }

        [ForeignKey(nameof (Posted))]
        public int PostedId { get; set; }
        public PostEntity Posted { get; set; }
    }
}