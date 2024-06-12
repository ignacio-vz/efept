using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class BlogService : IBlogService
    {
        private readonly ApplicationDbContext _context;

        public BlogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Blog?> GetBlog()
        {
            return await _context.Blog.FirstOrDefaultAsync();
        }

        public async Task<Blog> UpdateBlog(Blog blog)
        {
            var b = await _context.Blog.FirstOrDefaultAsync();
            if (b == null)
            {
                throw new Exception("Blog not found");
            }

            b.Titulo = blog.Titulo;
            b.Texto = blog.Texto;
            b.ImagenG = blog.ImagenG;
            b.ImagenM = blog.ImagenM;
            _context.Blog.Update(b);

            await _context.SaveChangesAsync();
            return b;
        }

        public async Task<Blog?> DeleteBlog()
        {
            var b = await _context.Blog.FirstOrDefaultAsync();
            if (b == null)
            {
                return null;
            }

            _context.Blog.Remove(b);
            await _context.SaveChangesAsync();
            return b;
        }
    }
}
