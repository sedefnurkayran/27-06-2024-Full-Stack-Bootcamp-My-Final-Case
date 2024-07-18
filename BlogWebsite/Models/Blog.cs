using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; } = string.Empty;
        public string BlogContent { get; set; } = string.Empty;
        public string BlogThumbnailImage { get; set; } = string.Empty;
        public string BlogImage { get; set; } = string.Empty;
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }




        //RELATIONSHIPS
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    }
}