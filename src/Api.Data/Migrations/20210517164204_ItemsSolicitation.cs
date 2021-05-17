using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ItemsSolicitation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    TotalValue = table.Column<decimal>(nullable: false),
                    Shipping = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemsSolicitation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    TotalValue = table.Column<decimal>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    SolicitationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsSolicitation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsSolicitation_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsSolicitation_Solicitation_SolicitationId",
                        column: x => x.SolicitationId,
                        principalTable: "Solicitation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSolicitation_ProductId",
                table: "ItemsSolicitation",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsSolicitation_SolicitationId",
                table: "ItemsSolicitation",
                column: "SolicitationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsSolicitation");

            migrationBuilder.DropTable(
                name: "Solicitation");
        }
    }
}
