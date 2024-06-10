using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace efept.Migrations
{
    /// <inheritdoc />
    public partial class EditarLegal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Legales",
                columns: new[] { "Id", "Descripcion", "Nombre", "Texto" },
                values: new object[,]
                {
                    { 1, "Aviso legal", "aviso", "Texto del aviso legal" },
                    { 2, "Política de privacidad", "privacidad", "Texto de la política de privacidad" },
                    { 3, "Política de cookies", "cookies", "Texto de la política de cookies" },
                    { 4, "Términos y condiciones", "terminos", "Texto de los términos y condiciones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Legales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Legales",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Legales",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Legales",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
