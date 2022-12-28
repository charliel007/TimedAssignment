
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;

public class PostEntity
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int Title { get; set; }
        
        [Required]
        public int Text { get; set; }
        
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        
        public virtual List<Comment> Comments { get; set; }

=======

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
>>>>>>> 9a80f8664290849baa877a2d0fd69db715cf2b89
    }
