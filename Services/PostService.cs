using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Post> CreatePost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post?> GetPost(int id)
        {
            return await _context.Posts.FindAsync(id);
        }

        public async Task<List<Post>> GetPostsByCategory(string categoria)
        {
            return await _context.Posts.Where(p => p.Categoria == categoria).ToListAsync();
        }

        public async Task<Post?> GetPostAleatorio()
        {
            return await _context.Posts.OrderBy(p => Guid.NewGuid()).FirstOrDefaultAsync();
        }

        public async Task<Post?> GetPostAleatorioByCategory(string categoria)
        {
            return await _context.Posts.Where(p => p.Categoria == categoria).OrderBy(p => Guid.NewGuid()).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPostsByPopularity()
        {
            return await _context.Posts.OrderByDescending(p => p.Puntuacion).ToListAsync();
        }

        public async Task<List<Post>> GetPostsByCategoryAndPopularity(string categoria)
        {
            return await _context.Posts.Where(p => p.Categoria == categoria).OrderByDescending(p => p.Puntuacion).ToListAsync();
        }

        public async Task<Post> UpdatePost(int id, Post post)
        {
            post.Id = id;
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task<Post?> DeletePost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return null;
            }
            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return post;
        }
    }
}
