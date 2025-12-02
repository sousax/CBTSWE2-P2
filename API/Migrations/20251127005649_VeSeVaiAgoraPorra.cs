using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class VeSeVaiAgoraPorra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Usuarios_IdUsuarioUpdate",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_IdUsuarioUpdate",
                table: "Produtos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdUsuarioUpdate",
                table: "Produtos",
                column: "IdUsuarioUpdate");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Usuarios_IdUsuarioUpdate",
                table: "Produtos",
                column: "IdUsuarioUpdate",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
