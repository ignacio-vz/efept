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

        public async Task<Comentario> AddComentario(int id, string comentario, string usuario)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                throw new Exception("Post not found");
            }
            var comentarioObj = new Comentario
            {
                IdPost = id,
                IdUsuario = usuario.ToString(),
                Texto = comentario,
                Post = post,
                Usuario = await _context.Users.FindAsync(usuario) ?? throw new Exception("User not found")
            };
            _context.Comentarios.Add(comentarioObj);
            await _context.SaveChangesAsync();
            return comentarioObj;
        }

        public async Task<List<Comentario>> GetComentarios()
        {
            return await _context.Comentarios.ToListAsync();
        }

        public async Task<List<Comentario>> GetComentariosByPost(int id)
        {
            return await _context.Comentarios.Where(c => c.IdPost.Equals(id)).ToListAsync();
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
