using System.ComponentModel.DataAnnotations;
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

    }
