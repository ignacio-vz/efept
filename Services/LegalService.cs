using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class LegalService : ILegalService
    {
        private readonly ApplicationDbContext _context;

        public LegalService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Legal> CreateLegal(Legal legal)
        {
            _context.Legales.Add(legal);
            await _context.SaveChangesAsync();
            return legal;
        }

        public async Task<List<Legal>> GetLegales()
        {
            return await _context.Legales.ToListAsync();
        }

        public async Task<Legal?> GetLegal(int id)
        {
            return await _context.Legales.FindAsync(id);
        }

        public async Task<Legal?> GetLegal(string nombre)
        {
            return await _context.Legales.FirstOrDefaultAsync(l => l.Nombre == nombre);
        }

        public async Task<Legal> UpdateLegal(int id, Legal legal)
        {
            var legalEntity = await _context.Legales.FindAsync(id) ?? throw new Exception("Legal not found");
            legalEntity.Nombre = legal.Nombre;
            legalEntity.Descripcion = legal.Descripcion;
            legalEntity.Texto = legal.Texto;
            _context.Legales.Update(legalEntity);
            await _context.SaveChangesAsync();
            return legalEntity;
        }

        public async Task<Legal?> DeleteLegal(int id)
        {
            var legal = await _context.Legales.FindAsync(id);
            if (legal == null)
            {
                return null;
            }

            _context.Legales.Remove(legal);
            await _context.SaveChangesAsync();
            return legal;
        }
    }
}
