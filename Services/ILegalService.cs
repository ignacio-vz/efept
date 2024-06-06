using efept.Entities;

namespace efept.Services
{
    public interface ILegalService
    {
        Task<Legal> CreateLegal(Legal legal);
        Task<List<Legal>> GetLegales();
        Task<Legal?> GetLegal(int id);
        Task<Legal?> GetLegal(string nombre);
        Task<Legal> UpdateLegal(int id, Legal legal);
        Task<Legal?> DeleteLegal(int id);
    }
}
