using efept.Entities;

namespace efept.Services
{
    public interface IPostService
    {
        Task<Post> CreatePost(Post post);
        Task<List<Post>> GetPosts();
        Task<Post?> GetPost(int id);
        Task<List<Post>> GetPostsByCategory(string categoria);
        Task<Post?> GetPostAleatorio();
        Task<Post?> GetPostAleatorioByCategory(string categoria);
        Task<List<Post>> GetPostsByPopularity();
        Task<List<Post>> GetPostsByCategoryAndPopularity(string categoria);
        Task<Post> UpdatePost(int id, Post post);
        Task<Post?> DeletePost(int id);
    }
}
