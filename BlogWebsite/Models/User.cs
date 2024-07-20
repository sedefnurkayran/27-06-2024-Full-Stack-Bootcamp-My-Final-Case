using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class User
    {
        [Key]

        public int UserId { get; set; }
        public string? UserName { get; set; } //= null!;
        //public string? UserSurname { get; set; }// = null!;

        // public string NameSurname
        // {
        //     get
        //     {
        //         return this.UserName + " " + this.UserSurname;
        //     }
        // }
        public string? UserAbout { get; set; }
        public string UserImage { get; set; } = string.Empty;
        public string? UserMail { get; set; } //= null!;
        public string? UserPassword { get; set; } //= null!;
        public bool UserStatus { get; set; }

        //RELATIONSHIPS       
        public List<Blog> Blogs { get; set; } = new List<Blog>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}