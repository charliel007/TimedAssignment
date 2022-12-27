using System.ComponentModel.DataAnnotations;
namespace TimedAssignment.Data.Entities
{
    public class PostEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Title { get; set; }
        [Required]
        public int Text { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public PostEntity()
        {
        }

    }
}