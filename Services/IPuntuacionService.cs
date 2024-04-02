using efept.Entities;

namespace efept.Services
{
    public interface IPuntuacionService
    {
        Task<Puntuacion> CreatePuntuacion(Puntuacion puntuacion);
        Task<List<Puntuacion>> GetPuntuacionesByUsuario(int id);
        Task<List<Puntuacion>> GetPuntuacionesByUsuarioAndPost(int idUsuario, int idPost);
        Task<Puntuacion> UpdatePuntuacion(int id, Puntuacion puntuacion);
        Task<Puntuacion?> DeletePuntuacion(int id);
    }
}
