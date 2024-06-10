﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efept.Data;

#nullable disable

namespace efept.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("efept.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("efept.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdPost");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("efept.Entities.Etiqueta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Etiquetas");
                });

            modelBuilder.Entity("efept.Entities.EtiquetaLibro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEtiqueta")
                        .HasColumnType("int");

                    b.Property<int>("IdLibro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEtiqueta");

                    b.HasIndex("IdLibro");

                    b.ToTable("EtiquetasLibros");
                });

            modelBuilder.Entity("efept.Entities.EtiquetaPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEtiqueta")
                        .HasColumnType("int");

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdEtiqueta");

                    b.HasIndex("IdPost");

                    b.ToTable("EtiquetasPosts");
                });

            modelBuilder.Entity("efept.Entities.Legal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Texto")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Legales");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Aviso legal",
                            Nombre = "aviso",
                            Texto = "Texto del aviso legal"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Política de privacidad",
                            Nombre = "privacidad",
                            Texto = "Texto de la política de privacidad"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Política de cookies",
                            Nombre = "cookies",
                            Texto = "Texto de la política de cookies"
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Términos y condiciones",
                            Nombre = "terminos",
                            Texto = "Texto de los términos y condiciones"
                        });
                });

            modelBuilder.Entity("efept.Entities.Libro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("Autor")
                        .HasColumnType("longtext");

                    b.Property<string>("Editorial")
                        .HasColumnType("longtext");

                    b.Property<string>("ISBN")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagen")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Sinopsis")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("efept.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Autor")
                        .HasColumnType("longtext");

                    b.Property<string>("Categoria")
                        .HasColumnType("longtext");

                    b.Property<string>("Cita")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagen")
                        .HasColumnType("longtext");

                    b.Property<int>("Puntuacion")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("efept.Entities.Puntuacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPost")
                        .HasColumnType("int");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("Puntos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.HasIndex("PostId");

                    b.ToTable("Puntuaciones");
                });

            modelBuilder.Entity("efept.Entities.Red", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Enlace")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Redes");
                });

            modelBuilder.Entity("efept.Entities.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagen")
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TituloNormalizado")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tarjetas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "El ser humano se embarca en una búsqueda incansable hacia la conquista de ese estado pleno y sereno. ¿Qué sabemos sobre la felicidad? ¿A qué conclusiones llegaron los grandes pensadores? En esta sección descubrirás principios de grandes pensadores sobre esta búsqueda atemporal.",
                            Imagen = "images/felicidad_300x200.webp",
                            Titulo = "FELICIDAD",
                            TituloNormalizado = "felicidad"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "En el tejido mismo de la existencia reside una verdad inquebrantable: la necesidad imperiosa de los demás. Cultivar habilidades para relacionarse con solidez y perspicacia se erige como un conocimiento vital, una sabiduría preclara que los grandes pensadores abrazaron yque ahora exploraremos. Adéntrate en el arte de edificar relaciones más robustas y trascendentes.",
                            Imagen = "images/relaciones-personales_300x200.webp",
                            Titulo = "RELACIONES PERSONALES",
                            TituloNormalizado = "relaciones-personales"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "La salud otorga un valor inigualable a todo lo demás. Nuestro cuerpo nos acompaña a lo largo de toda la travesía vital, y optimizar su cuidado hasta llevarlo a su máxima expresión se erige como un pilar de plenitud y satisfacción. Volvamos la mirada al pasado, pues en él yace la sabiduría para reconectar con nuestro templo físico y alcanzar una vida plena y gratificante.",
                            Imagen = "images/salud_300x200.webp",
                            Titulo = "SALUD",
                            TituloNormalizado = "salud"
                        },
                        new
                        {
                            Id = 4,
                            Descripcion = "Nuestra forma de interactuar con el mundo determina nuestra vida misma. Dominar la gestión emocional y adoptar paradigmas mentales efectivos posee el potencial de transformar de raíz nuestra realidad. En este segmento, nos sumergiremos en las enseñanzas de eminentes pensadores acerca de cómo dirigir el aprendizaje, orquestar las emociones, enfrentar la realidad, instaurar hábitos enriquecedores y mucho más.",
                            Imagen = "images/mentalidad_300x200.webp",
                            Titulo = "MENTALIDAD",
                            TituloNormalizado = "mentalidad"
                        },
                        new
                        {
                            Id = 5,
                            Descripcion = "La sabiduría es el conocimiento llevado a la acción. El individuo sabio orienta su entendimiento para tomar decisiones más acertadas, asistir a otros y guiar su propia existencia por rutas más perspicaces y enriquecedoras. Asumamos el legado de los sabios del ayer para así iluminar los senderos de nuestras vidas.",
                            Imagen = "images/sabiduria_300x200.webp",
                            Titulo = "SABIDURÍA",
                            TituloNormalizado = "sabiduria"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("efept.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("efept.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efept.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("efept.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("efept.Entities.Comentario", b =>
                {
                    b.HasOne("efept.Entities.Post", "Post")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efept.Data.ApplicationUser", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("efept.Entities.EtiquetaLibro", b =>
                {
                    b.HasOne("efept.Entities.Etiqueta", "Etiqueta")
                        .WithMany("Libros")
                        .HasForeignKey("IdEtiqueta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efept.Entities.Libro", "Libro")
                        .WithMany("Etiquetas")
                        .HasForeignKey("IdLibro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etiqueta");

                    b.Navigation("Libro");
                });

            modelBuilder.Entity("efept.Entities.EtiquetaPost", b =>
                {
                    b.HasOne("efept.Entities.Etiqueta", "Etiqueta")
                        .WithMany("Posts")
                        .HasForeignKey("IdEtiqueta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efept.Entities.Post", "Post")
                        .WithMany("Etiquetas")
                        .HasForeignKey("IdPost")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etiqueta");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("efept.Entities.Puntuacion", b =>
                {
                    b.HasOne("efept.Data.ApplicationUser", "Usuario")
                        .WithMany("Puntuaciones")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("efept.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("efept.Data.ApplicationUser", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Puntuaciones");
                });

            modelBuilder.Entity("efept.Entities.Etiqueta", b =>
                {
                    b.Navigation("Libros");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("efept.Entities.Libro", b =>
                {
                    b.Navigation("Etiquetas");
                });

            modelBuilder.Entity("efept.Entities.Post", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("Etiquetas");
                });
#pragma warning restore 612, 618
        }
    }
}
