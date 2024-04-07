using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class TarjetaService : ITarjetaService
    {
        private readonly ApplicationDbContext _context;

        public TarjetaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tarjeta>> GetTarjetasAsync()
        {
            return await _context.Tarjetas.ToListAsync();
        }

        public async Task<Tarjeta?> GetTarjetaAsync(int id)
        {
            return await _context.Tarjetas.FindAsync(id);
        }

        public async Task<Tarjeta?> GetTarjetaAsync(string tituloNormalizado)
        {
            if (tituloNormalizado != null)
            { 
                return await _context.Tarjetas.FirstOrDefaultAsync(t => t.TituloNormalizado == tituloNormalizado);
            }
            return null;
        }

        public async Task<Tarjeta> CreateTarjetaAsync(Tarjeta tarjeta)
        {
            _context.Tarjetas.Add(tarjeta);
            await _context.SaveChangesAsync();
            return tarjeta;
        }

        public async Task<Tarjeta> UpdateTarjetaAsync(int id, Tarjeta tarjeta)
        {
            tarjeta.Id = id;
            _context.Tarjetas.Update(tarjeta);
            await _context.SaveChangesAsync();
            return tarjeta;
        }

        public async Task DeleteTarjetaAsync(int id)
        {
            var tarjeta = await _context.Tarjetas.FindAsync(id);
            if (tarjeta != null)
            {
                _context.Tarjetas.Remove(tarjeta);
                await _context.SaveChangesAsync();
            }
        }
    }
}
