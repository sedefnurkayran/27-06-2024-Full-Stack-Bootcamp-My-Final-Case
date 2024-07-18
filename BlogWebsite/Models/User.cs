using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class User
    {
        [Key]

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserSurname { get; set; } = null!;

        public string NameSurname
        {
            get
            {
                return this.UserName + " " + this.UserSurname;
            }
        }
        public string UserImage { get; set; } = string.Empty;
        public string UserMail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public bool UserStatus { get; set; }

        //RELATIONSHIPS       
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; } = null!;

    }
}