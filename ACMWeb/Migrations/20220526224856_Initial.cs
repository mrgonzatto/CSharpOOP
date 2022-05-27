using Microsoft.EntityFrameworkCore.Migrations;

namespace ACMWeb.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityState = table.Column<int>(nullable: false),
                    HasChanges = table.Column<bool>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
