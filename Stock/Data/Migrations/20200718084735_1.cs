using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(maxLength: 20, nullable: false),
                    ProductName = table.Column<string>(maxLength: 25, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(maxLength: 20, nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchase");
        }
    }
}
