using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{

    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string? UserName { get; set; } //= null!;
        public string? ContactEmail { get; set; } //= null!;
        public string? ContactSubject { get; set; } //= string.Empty;
        public string? ContactMessage { get; set; } //= null!;
        public DateTime ContactDate { get; set; }
        public bool ContactStatus { get; set; }

        // public string ContactAddress { get; set; } = string.Empty;
        // public string ContactPhone{ get; set; } = string.Empty;
        //public string ContactMail{get;set;}
    }
}