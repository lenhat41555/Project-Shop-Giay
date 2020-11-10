using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopBanGiay.Migrations
{
    public partial class sg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Despition = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 1, "Giay da" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 2, "Giay the thao" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[] { 3, "Giay co" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Amount", "Brand", "CategoryId", "Color", "Despition", "Name", "Price" },
                values: new object[] { 3, 1, "Dior", 1, "cam", "", "giay da", 60000.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Amount", "Brand", "CategoryId", "Color", "Despition", "Name", "Price" },
                values: new object[] { 2, 1, "ev", 2, "đen", "", "the thao", 5000.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Amount", "Brand", "CategoryId", "Color", "Despition", "Name", "Price" },
                values: new object[] { 1, 1, "Dior", 3, "trắng", "", "giay co", 6000.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
