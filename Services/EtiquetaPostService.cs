using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class EtiquetaPostService : IEtiquetaPostService
    {
        private readonly ApplicationDbContext _context;

        public EtiquetaPostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<EtiquetaPost> CreateEtiquetaPost(EtiquetaPost etiquetaPost)
        {
            _context.EtiquetasPosts.Add(etiquetaPost);
            await _context.SaveChangesAsync();
            return etiquetaPost;
        }

        public async Task<List<Etiqueta>> GetEtiquetasByPost(int id)
        {
            return await _context.EtiquetasPosts
                .Where(ep => ep.IdPost == id)
                .Select(ep => ep.Etiqueta)
                .ToListAsync();
        }

        public async Task<List<Post>> GetPostsByEtiqueta(int id)
        {
            return await _context.EtiquetasPosts
                .Where(ep => ep.IdEtiqueta == id)
                .Select(ep => ep.Post)
                .ToListAsync();
        }

        public async Task<EtiquetaPost> UpdateEtiquetaPost(int id, EtiquetaPost etiquetaPost)
        {
            var ep = await _context.EtiquetasPosts.FindAsync(id);
            if (ep == null)
            {
                throw new Exception("EtiquetaPost not found");
            }

            ep.IdEtiqueta = etiquetaPost.IdEtiqueta;
            ep.IdPost = etiquetaPost.IdPost;
            _context.EtiquetasPosts.Update(ep);

            await _context.SaveChangesAsync();
            return ep;
        }

        public async Task<EtiquetaPost?> DeleteEtiquetaPost(int id)
        {
            var ep = await _context.EtiquetasPosts.FindAsync(id);
            if (ep == null)
            {
                return null;
            }

            _context.EtiquetasPosts.Remove(ep);
            await _context.SaveChangesAsync();
            return ep;
        }
    }
}
