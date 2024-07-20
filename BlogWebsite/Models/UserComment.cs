using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class UserComment
    {
        [Key]
        public int UserCommentId { get; set; }

        public string UserName { get; set; }
    }
}