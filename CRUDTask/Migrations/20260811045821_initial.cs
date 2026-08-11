using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CRUDTask.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Rate" },
                values: new object[,]
                {
                    { 1, "Samsung flagship smartphone with excellent performance and camera.", "Samsung Galaxy S24", 799.99m, 4.7000000000000002 },
                    { 2, "Apple smartphone with A16 Bionic chip and advanced camera system.", "iPhone 15", 699.99m, 4.7999999999999998 },
                    { 3, "Google smartphone with an excellent camera and clean Android experience.", "Google Pixel 8", 599.99m, 4.5999999999999996 },
                    { 4, "Powerful Xiaomi smartphone with a high-quality AMOLED display.", "Xiaomi 14", 649.99m, 4.5 },
                    { 5, "Fast Android smartphone with a powerful processor and large battery.", "OnePlus 12", 749.99m, 4.5999999999999996 },
                    { 6, "Mid-range Samsung smartphone with a great display and long battery life.", "Samsung Galaxy A55", 449.99m, 4.4000000000000004 },
                    { 7, "Reliable Apple smartphone with a powerful processor and great camera.", "iPhone 14", 599.99m, 4.7000000000000002 },
                    { 8, "Affordable smartphone with AMOLED display and strong battery performance.", "Xiaomi Redmi Note 13", 299.99m, 4.2999999999999998 },
                    { 9, "Modern Android smartphone with a unique design and smooth performance.", "Nothing Phone 2", 549.99m, 4.4000000000000004 },
                    { 10, "Affordable performance-focused smartphone with a premium design.", "OnePlus Nord 4", 399.99m, 4.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
