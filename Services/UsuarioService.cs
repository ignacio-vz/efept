﻿using efept.Data;
using Microsoft.EntityFrameworkCore;

namespace efept.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> CreateUsuario(ApplicationUser usuario)
        {
            _context.Users.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<List<ApplicationUser>> GetUsuarios()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ApplicationUser?> GetUsuario(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<ApplicationUser?> GetUsuarioByNombre(string nombre)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == nombre);
        }

        public async Task<ApplicationUser?> GetUsuarioByCorreo(string correo)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == correo);
        }

        public async Task<ApplicationUser> UpdateUsuario(int id, ApplicationUser usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<ApplicationUser?> DeleteUsuario(int id)
        {
            var usuario = await _context.Users.FindAsync(id);
            if (usuario == null)
            {
                return null;
            }
            _context.Users.Remove(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }
    }
}
