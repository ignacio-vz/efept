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

        public DbSet<About> About { get; set; }

        public DbSet<Blog> Blog { get; set; }

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
                new Tarjeta { Id = 1, Titulo = "FELICIDAD", Descripcion = "El ser humano se embarca en una búsqueda incansable hacia la conquista de ese estado pleno y sereno. ¿Qué sabemos sobre la felicidad? ¿A qué conclusiones llegaron los grandes pensadores? En esta sección descubrirás principios de grandes pensadores sobre esta búsqueda atemporal.", Imagen = "images/felicidad_300x200.webp" },
                new Tarjeta { Id = 2, Titulo = "RELACIONES PERSONALES", Descripcion = "En el tejido mismo de la existencia reside una verdad inquebrantable: la necesidad imperiosa de los demás. Cultivar habilidades para relacionarse con solidez y perspicacia se erige como un conocimiento vital, una sabiduría preclara que los grandes pensadores abrazaron yque ahora exploraremos. Adéntrate en el arte de edificar relaciones más robustas y trascendentes.", Imagen = "images/relaciones-personales_300x200.webp" },
                new Tarjeta { Id = 3, Titulo = "SALUD", Descripcion = "La salud otorga un valor inigualable a todo lo demás. Nuestro cuerpo nos acompaña a lo largo de toda la travesía vital, y optimizar su cuidado hasta llevarlo a su máxima expresión se erige como un pilar de plenitud y satisfacción. Volvamos la mirada al pasado, pues en él yace la sabiduría para reconectar con nuestro templo físico y alcanzar una vida plena y gratificante.", Imagen = "images/salud_300x200.webp" },
                new Tarjeta { Id = 4, Titulo = "MENTALIDAD", Descripcion = "Nuestra forma de interactuar con el mundo determina nuestra vida misma. Dominar la gestión emocional y adoptar paradigmas mentales efectivos posee el potencial de transformar de raíz nuestra realidad. En este segmento, nos sumergiremos en las enseñanzas de eminentes pensadores acerca de cómo dirigir el aprendizaje, orquestar las emociones, enfrentar la realidad, instaurar hábitos enriquecedores y mucho más.", Imagen = "images/mentalidad_300x200.webp" },
                new Tarjeta { Id = 5, Titulo = "SABIDURÍA", Descripcion = "La sabiduría es el conocimiento llevado a la acción. El individuo sabio orienta su entendimiento para tomar decisiones más acertadas, asistir a otros y guiar su propia existencia por rutas más perspicaces y enriquecedoras. Asumamos el legado de los sabios del ayer para así iluminar los senderos de nuestras vidas.", Imagen = "images/sabiduria_300x200.webp" }
                );

            modelBuilder.Entity<Legal>().HasData(
                new Legal { Id = 1, Nombre = "aviso", Descripcion = "Aviso legal", Texto = "Texto del aviso legal" },
                new Legal { Id = 2, Nombre = "privacidad", Descripcion = "Política de privacidad", Texto = "Texto de la política de privacidad" },
                new Legal { Id = 3, Nombre = "cookies", Descripcion = "Política de cookies", Texto = "Texto de la política de cookies" },
                new Legal { Id = 4, Nombre = "terminos", Descripcion = "Términos y condiciones", Texto = "Texto de los términos y condiciones" }
                );

            modelBuilder.Entity<About>().HasData(
                new About { Id = 1, Titulo = "Sobre mí", Texto = "Soy Rubén, un profesor enamorado del diálogo profundo, del arte de pronunciar la frase exacta en el momento preciso. Estoy en continua búsqueda de aquellas frases que motiven e inspiren a mis alumnos, pero también encuentro en cada reflexión una oportunidad para elevar mi propio aprendizaje.\r\nMe encanta explorar modelos mentales que me permitan pensar con mayor claridad, enriquecer mi conversación a través del conocimiento y descubrir frases eternas que marcan el camino.", ImagenG = "images/sobre-mi_1920x1080.webp", ImagenM = "images/sobre-mi_1280x720.webp" }
                );

            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, Titulo = "Este blog", Texto = "En este blog analizo frases breves con enorme significado de los grandes pensadores de la Historia. De esta forma podrás enriquecer tus conversaciones, tomar mejores decisiones y pensar con mayor claridad. Este espacio es para personas amantes del conocimiento que desean elevar su expresión y aumentar sus recursos mentales para pensar con mayor profundidad.\r\nCreo firmemente en el conocimiento como herramienta de transformación personal. Pero no basta con poseerlo; hay que aplicarlo.\r\nPor eso cada frase irá acompañada de aplicaciones prácticas, para implementar esa píldora de conocimiento en nuestra vida y nuestras conversaciones. Solo así se convertirá en verdadera sabiduría.\r\nLucho contra la trivialidad, las conversaciones monótonas y el estancamiento intelectual. Quiero contribuir a que puedas impactar más con tus palabras y conversaciones.\r\nSoy Rubén, un profesor enamorado del diálogo profundo, del arte de pronunciar la frase exacta en el momento preciso. En mi aula, busco inspirar y guiar a mis alumnos, pero también encuentro en cada reflexión una oportunidad para elevar mi propio aprendizaje.\r\nSúmate a este viaje. Juntos, dominaremos el arte de la conversación con frases eternas.", ImagenG = "images/blog_1920x1080.webp", ImagenM = "images/blog_1280x720.webp" }
                );
        }
    }
}