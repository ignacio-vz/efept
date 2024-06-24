using efept.Entities;

namespace efept.Services
{
    public interface ILibroService
    {
        Task<Libro> CreateLibro(Libro libro);
        Task<List<Libro>> GetLibros();
        Task<Libro?> GetLibro(int id);
        Task<Libro> UpdateLibro(int id, Libro libro);
        Task<Libro?> DeleteLibro(int id);
        Task<List<Libro>> GetLibrosByCategoria(string categoria);
    }
}
