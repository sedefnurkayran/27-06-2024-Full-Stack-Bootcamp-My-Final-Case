using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } //= null!;
        public string? CategoryDescription { get; set; }// = string.Empty!;
        public bool CategoryStatus { get; set; }

        //RELATIONSHIPS       
        public List<Blog> Blogs { get; set; } = new List<Blog>();


    }


}

