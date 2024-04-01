using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using efept.Entities;

namespace efept.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Tarjeta> Tarjetas { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Red> Redes { get; set; }

        public DbSet<Etiqueta> Etiquetas { get; set; }

        public DbSet<EtiquetaPost> EtiquetasPosts { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<EtiquetaLibro> EtiquetasLibros { get; set; }

        public DbSet<Puntuacion> Puntuaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comentarios)
                .HasForeignKey(c => c.IdPost);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Comentarios)
                .HasForeignKey(c => c.IdUsuario);

            modelBuilder.Entity<EtiquetaPost>()
                .HasOne(ep => ep.Etiqueta)
                .WithMany(e => e.Posts)
                .HasForeignKey(ep => ep.IdEtiqueta);

            modelBuilder.Entity<EtiquetaPost>()
                .HasOne(ep => ep.Post)
                .WithMany(p => p.Etiquetas)
                .HasForeignKey(ep => ep.IdPost);

            modelBuilder.Entity<EtiquetaLibro>()
                .HasOne(el => el.Etiqueta)
                .WithMany(e => e.Libros)
                .HasForeignKey(el => el.IdEtiqueta);

            modelBuilder.Entity<EtiquetaLibro>()
                .HasOne(el => el.Libro)
                .WithMany(l => l.Etiquetas)
                .HasForeignKey(el => el.IdLibro);

            modelBuilder.Entity<Puntuacion>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Puntuaciones)
                .HasForeignKey(p => p.IdUsuario);

            modelBuilder.Entity<ApplicationUser>()
                .HasKey(u => u.Id);
        }
    }
}
