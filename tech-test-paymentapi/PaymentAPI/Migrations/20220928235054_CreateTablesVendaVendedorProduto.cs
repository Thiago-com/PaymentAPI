using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PaymentAPI.Migrations
{
    public partial class CreateTablesVendaVendedorProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_Vendedor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    CPF = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Telefone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Vendedor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_Venda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StatusVenda = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DataVenda = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "now()"),
                    VendedorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Venda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_Venda_TB_Vendedor_VendedorID",
                        column: x => x.VendedorID,
                        principalTable: "TB_Vendedor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_Produto",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    VendaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Produto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TB_Produto_TB_Venda_VendaID",
                        column: x => x.VendaID,
                        principalTable: "TB_Venda",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_Produto_VendaID",
                table: "TB_Produto",
                column: "VendaID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_Venda_VendedorID",
                table: "TB_Venda",
                column: "VendedorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_Produto");

            migrationBuilder.DropTable(
                name: "TB_Venda");

            migrationBuilder.DropTable(
                name: "TB_Vendedor");
        }
    }
}
