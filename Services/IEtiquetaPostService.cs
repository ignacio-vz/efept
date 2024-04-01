using efept.Entities;

namespace efept.Services
{
    public interface IEtiquetaPostService
    {
        Task<EtiquetaPost> CreateEtiquetaPost(EtiquetaPost etiquetaPost);
        Task<List<Etiqueta>> GetEtiquetasByPost(int id);
        Task<List<Post>> GetPostsByEtiqueta(int id);
        Task<EtiquetaPost> UpdateEtiquetaPost(int id, EtiquetaPost etiquetaPost);
        Task<EtiquetaPost?> DeleteEtiquetaPost(int id);
    }
}
