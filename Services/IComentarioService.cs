using efept.Entities;
using System.Security.Claims;

namespace efept.Services
{
    public interface IComentarioService
    {
        Task<Comentario> AddComentario(int id, string comentario, string usuario);
        Task<List<Comentario>> GetComentarios();
        Task<Comentario?> GetComentario(int id);
        Task<List<Comentario>> GetComentariosByPost(int id);
        Task<List<Comentario>> GetComentariosByUsuario(int id);
        Task<Comentario> UpdateComentario(int id, Comentario comentario);
        Task<Comentario?> DeleteComentario(int id);
    }
}
