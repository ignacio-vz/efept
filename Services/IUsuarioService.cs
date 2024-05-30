using efept.Data;

namespace efept.Services
{
    public interface IUsuarioService
    {
        Task<ApplicationUser> CreateUsuario(ApplicationUser usuario);
        Task<List<ApplicationUser>> GetUsuarios();
        Task<ApplicationUser?> GetUsuario(string id);
        Task<ApplicationUser?> GetUsuarioByNombre(string nombre);
        Task<ApplicationUser?> GetUsuarioByCorreo(string correo);
        Task<ApplicationUser> UpdateUsuario(int id, ApplicationUser usuario);
        Task<ApplicationUser?> DeleteUsuario(int id);
        Task<ApplicationUser?> ModifyUserName(ApplicationUser user, string newName);
        Task<ApplicationUser?> ModifyNormalizedUserName(ApplicationUser user);
        Task<string> GetUserName(ApplicationUser user);
        Task<string> GetUserEmail(ApplicationUser user);
    }
}
