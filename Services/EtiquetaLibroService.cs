using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class EtiquetaLibroService : IEtiquetaLibroService
    {
        private readonly ApplicationDbContext _context;

        public EtiquetaLibroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<EtiquetaLibro> CreateEtiquetaLibro(EtiquetaLibro etiquetaLibro)
        {
            _context.EtiquetasLibros.Add(etiquetaLibro);
            await _context.SaveChangesAsync();
            return etiquetaLibro;
        }

        public async Task<List<Etiqueta>> GetEtiquetasByLibro(int id)
        {
            return await _context.EtiquetasLibros
                .Where(el => el.IdLibro == id)
                .Select(el => el.Etiqueta)
                .ToListAsync();
        }

        public async Task<List<Libro>> GetLibrosByEtiqueta(int id)
        {
            return await _context.EtiquetasLibros
                .Where(el => el.IdEtiqueta == id)
                .Select(el => el.Libro)
                .ToListAsync();
        }

        public async Task<EtiquetaLibro> UpdateEtiquetaLibro(int id, EtiquetaLibro etiquetaLibro)
        {
            var el = await _context.EtiquetasLibros.FindAsync(id);
            if (el == null)
            {
                throw new Exception("EtiquetaLibro not found");
            }

            el.IdEtiqueta = etiquetaLibro.IdEtiqueta;
            el.IdLibro = etiquetaLibro.IdLibro;
            _context.EtiquetasLibros.Update(el);

            await _context.SaveChangesAsync();
            return el;
        }

        public async Task<EtiquetaLibro?> DeleteEtiquetaLibro(int id)
        {
            var el = await _context.EtiquetasLibros.FindAsync(id);
            if (el == null)
            {
                return null;
            }

            _context.EtiquetasLibros.Remove(el);
            await _context.SaveChangesAsync();
            return el;
        }
    }
}
