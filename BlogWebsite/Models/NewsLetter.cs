using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class NewsLetter
    {
        [Key]
        public int MailId { get; set; }
        public string? Mail { get; set; }
        public bool MailStatus { get; set; }


    }
}