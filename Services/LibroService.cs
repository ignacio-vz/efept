using efept.Data;
using efept.Entities;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class LibroService : ILibroService
    {
        private readonly ApplicationDbContext _context;

        public LibroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Libro> CreateLibro(Libro libro)
        {
            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return libro;
        }

        public async Task<List<Libro>> GetLibros()
        {
            return await _context.Libros.ToListAsync();
        }

        public async Task<Libro?> GetLibro(int id)
        {
            return await _context.Libros.FindAsync(id);
        }

        public async Task<Libro> UpdateLibro(int id, Libro libro)
        {
            var l = await _context.Libros.FindAsync(id);
            if (l == null)
            {
                throw new Exception("Libro not found");
            }
            l.Titulo = libro.Titulo;
            l.Autor = libro.Autor;
            l.Editorial = libro.Editorial;
            l.Ano = libro.Ano;
            l.Precio = libro.Precio;
            l.ISBN = libro.ISBN;
            l.Sinopsis = libro.Sinopsis;
            l.Imagen = libro.Imagen;
            _context.Libros.Update(l);
            await _context.SaveChangesAsync();
            return l;
        }

        public async Task<Libro?> DeleteLibro(int id)
        {
            var l = await _context.Libros.FindAsync(id);
            if (l == null)
            {
                return null;
            }
            _context.Libros.Remove(l);
            await _context.SaveChangesAsync();
            return l;
        }

        public async Task<List<Libro>> GetLibrosByCategoria(string categoria)
        {
            return await _context.Libros.Where(l => l.Categoria == categoria).ToListAsync();
        }
    }
}
