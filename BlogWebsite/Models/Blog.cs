using System.ComponentModel.DataAnnotations;
using BlogApp.Models;

namespace BlogWebsite.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string? BlogTitle { get; set; } //= string.Empty;
        public string? BlogContent { get; set; } //= string.Empty;
        public string? BlogThumbnailImage { get; set; }// = string.Empty;
        public string? BlogImage { get; set; } //= string.Empty;
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }




        //RELATIONSHIPS
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public List<Tag> Tags { get; set; } = new List<Tag>();

        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}