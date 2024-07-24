using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;

        }

        // public void AddCategory(Category category)
        // {
        //     _categoryDal.Insert(category);

        // }
        // public void DeleteCategory(Category category)
        // {
        //     _categoryDal.Delete(category);
        // }

        // public void UpdateCategory(Category category)
        // {
        //     _categoryDal.Update(category);
        // }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAllList();
        }


        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }


    }
}