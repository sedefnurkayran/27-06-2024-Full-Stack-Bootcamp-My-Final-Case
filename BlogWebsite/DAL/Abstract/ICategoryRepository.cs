using BlogWebsite.Models;

namespace BlogWebsite.DAL.Abstract
{

    public interface ICategoryRepository
    {
        public List<Category> ListAllCategories();
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
    }
}