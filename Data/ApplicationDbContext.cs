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

        public DbSet<Legal> Legales { get; set; }

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

            modelBuilder.Entity<Legal>()
                .HasIndex(l => l.Nombre)
                .IsUnique();

            // Seed data
            modelBuilder.Entity<Tarjeta>().HasData(
                new Tarjeta { Id = 1, Titulo = "FELICIDAD", Descripcion = "El ser humano se embarca en una b�squeda incansable hacia la conquista de ese estado pleno y sereno. �Qu� sabemos sobre la felicidad? �A qu� conclusiones llegaron los grandes pensadores? En esta secci�n descubrir�s principios de grandes pensadores sobre esta b�squeda atemporal.", Imagen = "images/felicidad_300x200.webp" },
                new Tarjeta { Id = 2, Titulo = "RELACIONES PERSONALES", Descripcion = "En el tejido mismo de la existencia reside una verdad inquebrantable: la necesidad imperiosa de los dem�s. Cultivar habilidades para relacionarse con solidez y perspicacia se erige como un conocimiento vital, una sabidur�a preclara que los grandes pensadores abrazaron yque ahora exploraremos. Ad�ntrate en el arte de edificar relaciones m�s robustas y trascendentes.", Imagen = "images/relaciones-personales_300x200.webp" },
                new Tarjeta { Id = 3, Titulo = "SALUD", Descripcion = "La salud otorga un valor inigualable a todo lo dem�s. Nuestro cuerpo nos acompa�a a lo largo de toda la traves�a vital, y optimizar su cuidado hasta llevarlo a su m�xima expresi�n se erige como un pilar de plenitud y satisfacci�n. Volvamos la mirada al pasado, pues en �l yace la sabidur�a para reconectar con nuestro templo f�sico y alcanzar una vida plena y gratificante.", Imagen = "images/salud_300x200.webp" },
                new Tarjeta { Id = 4, Titulo = "MENTALIDAD", Descripcion = "Nuestra forma de interactuar con el mundo determina nuestra vida misma. Dominar la gesti�n emocional y adoptar paradigmas mentales efectivos posee el potencial de transformar de ra�z nuestra realidad. En este segmento, nos sumergiremos en las ense�anzas de eminentes pensadores acerca de c�mo dirigir el aprendizaje, orquestar las emociones, enfrentar la realidad, instaurar h�bitos enriquecedores y mucho m�s.", Imagen = "images/mentalidad_300x200.webp" },
                new Tarjeta { Id = 5, Titulo = "SABIDUR�A", Descripcion = "La sabidur�a es el conocimiento llevado a la acci�n. El individuo sabio orienta su entendimiento para tomar decisiones m�s acertadas, asistir a otros y guiar su propia existencia por rutas m�s perspicaces y enriquecedoras. Asumamos el legado de los sabios del ayer para as� iluminar los senderos de nuestras vidas.", Imagen = "images/sabiduria_300x200.webp" }
                );

            modelBuilder.Entity<Legal>().HasData(
                new Legal { Id = 1, Nombre = "aviso", Descripcion = "Aviso legal", Texto = "Texto del aviso legal" },
                new Legal { Id = 2, Nombre = "privacidad", Descripcion = "Pol�tica de privacidad", Texto = "Texto de la pol�tica de privacidad" },
                new Legal { Id = 3, Nombre = "cookies", Descripcion = "Pol�tica de cookies", Texto = "Texto de la pol�tica de cookies" },
                new Legal { Id = 4, Nombre = "terminos", Descripcion = "T�rminos y condiciones", Texto = "Texto de los t�rminos y condiciones" }
                );
        }
    }
}
