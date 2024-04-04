using efept.Entities;

namespace efept.Services
{
    public interface ITarjetaService
    {
        Task<List<Tarjeta>> GetTarjetasAsync();
        Task<Tarjeta?> GetTarjetaAsync(int id);
        Task<Tarjeta?> GetTarjetaAsync(string titulo);
        Task<Tarjeta> CreateTarjetaAsync(Tarjeta tarjeta);
        Task<Tarjeta> UpdateTarjetaAsync(int id, Tarjeta tarjeta);
        Task DeleteTarjetaAsync(int id);
    }
}
