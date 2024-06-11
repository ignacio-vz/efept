using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efept.Migrations
{
    /// <inheritdoc />
    public partial class About : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
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
                    table.PrimaryKey("PK_About", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "Id", "ImagenG", "ImagenM", "Texto", "Titulo" },
                values: new object[] { 1, "images/sobre-mi_1920x1080.webp", "images/sobre-mi_1280x720.webp", "Soy Rubén, un profesor enamorado del diálogo profundo, del arte de pronunciar la frase exacta en el momento preciso. Estoy en continua búsqueda de aquellas frases que motiven e inspiren a mis alumnos, pero también encuentro en cada reflexión una oportunidad para elevar mi propio aprendizaje.\r\nMe encanta explorar modelos mentales que me permitan pensar con mayor claridad, enriquecer mi conversación a través del conocimiento y descubrir frases eternas que marcan el camino.", "Sobre mí" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");
        }
    }
}
