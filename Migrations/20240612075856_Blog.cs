using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efept.Migrations
{
    /// <inheritdoc />
    public partial class Blog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Texto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenG = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagenM = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "Id", "ImagenG", "ImagenM", "Texto", "Titulo" },
                values: new object[] { 1, "images/blog_1920x1080.webp", "images/blog_1280x720.webp", "En este blog analizo frases breves con enorme significado de los grandes pensadores de la Historia. De esta forma podrás enriquecer tus conversaciones, tomar mejores decisiones y pensar con mayor claridad. Este espacio es para personas amantes del conocimiento que desean elevar su expresión y aumentar sus recursos mentales para pensar con mayor profundidad.\r\nCreo firmemente en el conocimiento como herramienta de transformación personal. Pero no basta con poseerlo; hay que aplicarlo.\r\nPor eso cada frase irá acompañada de aplicaciones prácticas, para implementar esa píldora de conocimiento en nuestra vida y nuestras conversaciones. Solo así se convertirá en verdadera sabiduría.\r\nLucho contra la trivialidad, las conversaciones monótonas y el estancamiento intelectual. Quiero contribuir a que puedas impactar más con tus palabras y conversaciones.\r\nSoy Rubén, un profesor enamorado del diálogo profundo, del arte de pronunciar la frase exacta en el momento preciso. En mi aula, busco inspirar y guiar a mis alumnos, pero también encuentro en cada reflexión una oportunidad para elevar mi propio aprendizaje.\r\nSúmate a este viaje. Juntos, dominaremos el arte de la conversación con frases eternas.", "Este blog" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");
        }
    }
}
