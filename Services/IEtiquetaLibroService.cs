using efept.Entities;

namespace efept.Services
{
    public interface IEtiquetaLibroService
    {
        Task<EtiquetaLibro> CreateEtiquetaLibro(EtiquetaLibro etiquetaLibro);
        Task<List<Etiqueta>> GetEtiquetasByLibro(int id);
        Task<List<Libro>> GetLibrosByEtiqueta(int id);
        Task<EtiquetaLibro> UpdateEtiquetaLibro(int id, EtiquetaLibro etiquetaLibro);
        Task<EtiquetaLibro?> DeleteEtiquetaLibro(int id);
    }
}
