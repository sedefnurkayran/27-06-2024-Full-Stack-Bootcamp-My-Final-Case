using System.ComponentModel.DataAnnotations;
using BlogWebsite.Models;

namespace BlogApp.Models
{

    public class Tag
    {
        [Key]
        public int TagId { get; set; }
        public string? Text { get; set; }
        public List<Blog> Blogs { get; set; } = new List<Blog>();
    }
}