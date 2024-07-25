using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class UserComment
    {
        [Key]
        public int UserCommentId { get; set; }

        public string UserName { get; set; } = null!;
    }
}
