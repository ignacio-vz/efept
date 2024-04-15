using Microsoft.AspNetCore.Identity;
using efept.Entities;
using System.Security.Claims;

namespace efept.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public required List<Comentario> Comentarios { get; set; }

        public required List<Puntuacion> Puntuaciones { get; set; }
    }

}
