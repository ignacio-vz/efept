using efept.Entities;

namespace efept.Services
{
    public interface IBlogService
    {
        Task<Blog?> GetBlog();
        Task<Blog> UpdateBlog(Blog blog);
        Task<Blog?> DeleteBlog();
    }
}
