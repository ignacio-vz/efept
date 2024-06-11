using efept.Entities;

namespace efept.Services
{
    public interface IAboutService
    {
        Task<About?> GetAbout();
        Task<About> UpdateAbout(About about);
        Task<About?> DeleteAbout();
    }
}
