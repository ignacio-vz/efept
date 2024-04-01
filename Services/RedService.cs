using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class RedService : IRedService
    {
        private readonly ApplicationDbContext _context;

        public RedService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Red> CreateRed(Red red)
        {
            _context.Redes.Add(red);
            await _context.SaveChangesAsync();
            return red;
        }

        public async Task<List<Red>> GetRedes()
        {
            return await _context.Redes.ToListAsync();
        }

        public async Task<Red?> GetRed(int id)
        {
            return await _context.Redes.FindAsync(id);
        }

        public async Task<Red> UpdateRed(int id, Red red)
        {
            red.Id = id;
            _context.Redes.Update(red);
            await _context.SaveChangesAsync();
            return red;
        }

        public async Task<Red?> DeleteRed(int id)
        {
            var red = await _context.Redes.FindAsync(id);
            if (red == null)
            {
                return null;
            }
            _context.Redes.Remove(red);
            await _context.SaveChangesAsync();
            return red;
        }
    }
}
