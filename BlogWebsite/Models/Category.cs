using System.ComponentModel.DataAnnotations;

namespace BlogWebsite.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string CategoryDescription { get; set; } = string.Empty!;
        public bool CategoryStatus { get; set; }

        //RELATIONSHIPS       
        public ICollection<Article> Articles { get; set; } = new List<Article>();


    }
}