﻿using efept.Data;

namespace efept.Services
{
    public interface IUsuarioService
    {
        Task<ApplicationUser> CreateUsuario(ApplicationUser usuario);
        Task<List<ApplicationUser>> GetUsuarios();
        Task<ApplicationUser?> GetUsuario(int id);
        Task<ApplicationUser?> GetUsuarioByNombre(string nombre);
        Task<ApplicationUser?> GetUsuarioByCorreo(string correo);
        Task<ApplicationUser> UpdateUsuario(int id, ApplicationUser usuario);
        Task<ApplicationUser?> DeleteUsuario(int id);
    }
}
