using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
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
    }


}
