using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class EtiquetaService : IEtiquetaService
    {
        private readonly ApplicationDbContext _context;

        public EtiquetaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Etiqueta> CreateEtiqueta(Etiqueta etiqueta)
        {
            _context.Etiquetas.Add(etiqueta);
            await _context.SaveChangesAsync();
            return etiqueta;
        }

        public async Task<List<Etiqueta>> GetEtiquetas()
        {
            return await _context.Etiquetas.ToListAsync();
        }

        public async Task<Etiqueta?> GetEtiqueta(int id)
        {
            return await _context.Etiquetas.FindAsync(id);
        }

        public async Task<Etiqueta> UpdateEtiqueta(int id, Etiqueta etiqueta)
        {
            etiqueta.Id = id;
            _context.Etiquetas.Update(etiqueta);
            await _context.SaveChangesAsync();
            return etiqueta;
        }

        public async Task<Etiqueta?> DeleteEtiqueta(int id)
        {
            var etiqueta = await _context.Etiquetas.FindAsync(id);
            if (etiqueta == null)
            {
                return null;
            }

            _context.Etiquetas.Remove(etiqueta);
            await _context.SaveChangesAsync();
            return etiqueta;
        }
    }
}
