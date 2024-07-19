using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);

        }


        public void DeleteCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepository.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepository.GetAllList();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}