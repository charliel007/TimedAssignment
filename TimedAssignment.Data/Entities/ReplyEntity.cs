using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ReplyEntity
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Text { get; set; }
    
    [Required]
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public virtual User User { get; set; }
}
