using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class ComentarioService : IComentarioService
    {
        private readonly ApplicationDbContext _context;

        public ComentarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Comentario> CreateComentario(Comentario comentario)
        {
            _context.Comentarios.Add(comentario);
            await _context.SaveChangesAsync();
            return comentario;
        }

        public async Task<List<Comentario>> GetComentarios()
        {
            return await _context.Comentarios.ToListAsync();
        }

        public async Task<Comentario?> GetComentario(int id)
        {
            return await _context.Comentarios.FindAsync(id);
        }

        public async Task<List<Comentario>> GetComentariosByUsuario(int id)
        {
            return await _context.Comentarios.Where(c => c.IdUsuario.Equals(id.ToString())).ToListAsync();
        }

        public async Task<Comentario> UpdateComentario(int id, Comentario comentario)
        {
            comentario.Id = id;
            _context.Comentarios.Update(comentario);
            await _context.SaveChangesAsync();
            return comentario;
        }

        public async Task<Comentario?> DeleteComentario(int id)
        {
            var comentario = await _context.Comentarios.FindAsync(id);
            if (comentario == null)
            {
                return null;
            }
            _context.Comentarios.Remove(comentario);
            await _context.SaveChangesAsync();
            return comentario;
        }
    }
}
