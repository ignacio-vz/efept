using efept.Entities;

namespace efept.Services
{
    public interface IComentarioService
    {
        Task<Comentario> CreateComentario(Comentario comentario);
        Task<List<Comentario>> GetComentarios();
        Task<Comentario?> GetComentario(int id);
        Task<List<Comentario>> GetComentariosByUsuario(int id);
        Task<Comentario> UpdateComentario(int id, Comentario comentario);
        Task<Comentario?> DeleteComentario(int id);
    }
}
