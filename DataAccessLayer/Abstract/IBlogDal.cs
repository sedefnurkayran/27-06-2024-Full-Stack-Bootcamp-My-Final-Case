using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract;


public interface IBlogDal : IGenericDal<Blog>
{
    // IQueryable<Blog> Blogs { get; }
    // void CreateBlog(Blog blog);

    // //sdf
    // void DeleteBlog(Blog blog);
    // void UpdateBlog(Blog blog);
    // Blog GetById(int id);

    List<Blog> GetBlogListWithCategory();


    List<Blog> GetBlogListWithCategoryByWriter(int id); //Yazara gore kategorileri getir
}

