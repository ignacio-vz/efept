using efept.Entities;

namespace efept.Services
{
    public interface IEtiquetaService
    {
        Task<Etiqueta> CreateEtiqueta(Etiqueta etiqueta);
        Task<List<Etiqueta>> GetEtiquetas();
        Task<Etiqueta?> GetEtiqueta(int id);
        Task<Etiqueta> UpdateEtiqueta(int id, Etiqueta etiqueta);
        Task<Etiqueta?> DeleteEtiqueta(int id);
    }
}
