using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; } = string.Empty;
        public string AboutDetails2 { get; set; } = string.Empty;
        public string AboutImagel { get; set; } = string.Empty;
        public string AboutImage2 { get; set; } = string.Empty;

        public string AboutMapLocation { get; set; } = string.Empty;

        public bool AboutStatus { get; set; }
    }
}