using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class AboutService : IAboutService
    {
        private readonly ApplicationDbContext _context;

        public AboutService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<About?> GetAbout()
        {
            return await _context.About.FirstOrDefaultAsync();
        }

        public async Task<About> UpdateAbout(About about)
        {
            var a = await _context.About.FirstOrDefaultAsync();
            if (a == null)
            {
                throw new Exception("About not found");
            }

            a.Titulo = about.Titulo;
            a.Texto = about.Texto;
            a.ImagenG = about.ImagenG;
            a.ImagenM = about.ImagenM;
            _context.About.Update(a);

            await _context.SaveChangesAsync();
            return a;
        }

        public async Task<About?> DeleteAbout()
        {
            var a = await _context.About.FirstOrDefaultAsync();
            if (a == null)
            {
                return null;
            }

            _context.About.Remove(a);
            await _context.SaveChangesAsync();
            return a;
        }
    }
}
