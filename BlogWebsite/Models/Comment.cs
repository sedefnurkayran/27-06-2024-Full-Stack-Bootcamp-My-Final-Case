using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string? CommentUserName { get; set; } //= null!;
        public string? CommentUserSurname { get; set; } //= null!;
        public string CommentTitle { get; set; } = string.Empty;
        public DateTime CommentCreateDate { get; set; }

        public bool CommentStatus { get; set; }

        //RELATIONSHIPS
        public int BlogId { get; set; }

        public Blog Blog { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}