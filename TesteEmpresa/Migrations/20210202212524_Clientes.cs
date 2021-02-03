using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteEmpresa.Migrations
{
    public partial class Clientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Razao_Social = table.Column<string>(maxLength: 50, nullable: true),
                    CNPJ = table.Column<string>(maxLength: 14, nullable: true),
                    Data_Fundacao = table.Column<DateTime>(nullable: false),
                    Capital = table.Column<decimal>(nullable: false),
                    Quarentena = table.Column<string>(maxLength: 1, nullable: false),
                    Status_Cliente = table.Column<string>(maxLength: 1, nullable: false),
                    Classificacao = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
