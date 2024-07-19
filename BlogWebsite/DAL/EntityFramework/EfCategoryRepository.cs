using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {

        public EfCategoryRepository(DataContext context) : base(context)
        {
        }

        // private DataContext _context;
        // public EfCategoryRepository(DataContext context)
        // {
        //     _context = context;
        // }

        // public void CreateCategory(Category category)
        // {
        //     _context.Add(category);
        //     _context.SaveChanges();
        // }

        // public void DeleteCategory(Category category)
        // {
        //     _context.Remove(category);
        //     _context.SaveChanges();
        // }

        // public Category GetById(int id)
        // {
        //     // return _context.categories.Find(id);

        //     var category = _context.categories.Find(id);
        //     if (category == null)
        //     {
        //         throw new Exception("Category not found");
        //     }
        //     return category;
        // }

        // public List<Category> ListAllCategories()
        // {
        //     return _context.categories.ToList();
        // }

        // public void UpdateCategory(Category category)
        // {
        //     _context.Update(category);
        //     _context.SaveChanges();
        // }
    }
}