using efept.Entities;

namespace efept.Services
{
    public interface IRedService
    {
        Task<Red> CreateRed(Red red);
        Task<List<Red>> GetRedes();
        Task<Red?> GetRed(int id);
        Task<Red> UpdateRed(int id, Red red);
        Task<Red?> DeleteRed(int id);
    }
}
