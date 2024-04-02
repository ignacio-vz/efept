using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class PuntuacionService : IPuntuacionService
    {
        private readonly ApplicationDbContext _context;

        public PuntuacionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Puntuacion> CreatePuntuacion(Puntuacion puntuacion)
        {
            _context.Puntuaciones.Add(puntuacion);
            await _context.SaveChangesAsync();
            return puntuacion;
        }

        public async Task<Puntuacion?> DeletePuntuacion(int id)
        {
            var puntuacion = await _context.Puntuaciones.FindAsync(id);
            if (puntuacion == null)
            {
                return null;
            }

            _context.Puntuaciones.Remove(puntuacion);
            await _context.SaveChangesAsync();
            return puntuacion;
        }

        public async Task<List<Puntuacion>> GetPuntuacionesByUsuario(int id)
        {
            return await _context.Puntuaciones
                .Where(p => p.IdUsuario == id.ToString())
                .ToListAsync();
        }

        public async Task<List<Puntuacion>> GetPuntuacionesByUsuarioAndPost(int idUsuario, int idPost)
        {
            return await _context.Puntuaciones
                .Where(p => p.IdUsuario == idUsuario.ToString() && p.IdPost == idPost)
                .ToListAsync();
        }

        public async Task<Puntuacion> UpdatePuntuacion(int id, Puntuacion puntuacion)
        {
            if (id != puntuacion.Id)
            {
                throw new ArgumentException("Id de puntuación no coincide con el id de la puntuación a actualizar");
            }

            var p = await _context.Puntuaciones.FindAsync(id);
            if (p == null)
            {
                throw new Exception("Puntuación no encontrada");
            }
            p.Id = id;
            p.IdUsuario = puntuacion.IdUsuario;
            p.IdPost = puntuacion.IdPost;
            p.Puntos = puntuacion.Puntos;
            _context.Puntuaciones.Update(p);
            await _context.SaveChangesAsync();
            return p;
        }

        private bool PuntuacionExists(int id)
        {
            return _context.Puntuaciones.Any(e => e.Id == id);
        }
    }
}
