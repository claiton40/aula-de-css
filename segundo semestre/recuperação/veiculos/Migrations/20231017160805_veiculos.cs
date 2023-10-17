using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace veiculos.Migrations
{
    /// <inheritdoc />
    public partial class veiculos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    IdFabricante = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.IdFabricante);
                });

            migrationBuilder.CreateTable(
                name: "Veiculo",
                columns: table => new
                {
                    IdVeiculo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Preco = table.Column<double>(type: "FLOAT", nullable: false),
                    IdFabricante = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculo", x => x.IdVeiculo);
                    table.ForeignKey(
                        name: "FK_Veiculo_Fabricante_IdFabricante",
                        column: x => x.IdFabricante,
                        principalTable: "Fabricante",
                        principalColumn: "IdFabricante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_IdFabricante",
                table: "Veiculo",
                column: "IdFabricante");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veiculo");

            migrationBuilder.DropTable(
                name: "Fabricante");
        }
    }
}
