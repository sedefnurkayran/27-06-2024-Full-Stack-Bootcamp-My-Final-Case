using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class Writer
    {
        [Key]

        public int WriterId { get; set; }
        public string? WriterName { get; set; } //= null!;
        //public string? UserSurname { get; set; }// = null!;

        // public string NameSurname
        // {
        //     get
        //     {
        //         return this.UserName + " " + this.UserSurname;
        //     }
        // }
        public string? WriterAbout { get; set; }
        public string? WriterImage { get; set; }
        public string? WriterMail { get; set; } //= null!;
        public string? WriterPassword { get; set; } //= null!;
        public bool WriterStatus { get; set; }

        //RELATIONSHIPS       
        public List<Blog> Blogs { get; set; } = new List<Blog>();
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}