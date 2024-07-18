using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }
        public string Type { get; set; } = null!;
        public bool UserTypeStatus { get; set; }

        //RELATIONSHIPS       
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}