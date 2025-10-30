using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductCaching.Migrations
{
    /// <inheritdoc />
    public partial class DBInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Sản phẩm cao cấp số 1", "Điện thoại Apple 1", 150000m },
                    { 2, "Sản phẩm cao cấp số 2", "Tai nghe Samsung 2", 300000m },
                    { 3, "Sản phẩm cao cấp số 3", "Màn hình Sony 3", 450000m },
                    { 4, "Sản phẩm cao cấp số 4", "Bàn phím LG 4", 600000m },
                    { 5, "Sản phẩm cao cấp số 5", "Chuột Asus 5", 750000m },
                    { 6, "Sản phẩm cao cấp số 6", "Webcam Logitech 6", 900000m },
                    { 7, "Sản phẩm cao cấp số 7", "Loa HP 7", 1050000m },
                    { 8, "Sản phẩm cao cấp số 8", "Router Acer 8", 1200000m },
                    { 9, "Sản phẩm cao cấp số 9", "USB Lenovo 9", 1350000m },
                    { 10, "Sản phẩm cao cấp số 10", "Laptop Dell 10", 1000000m },
                    { 11, "Sản phẩm cao cấp số 11", "Điện thoại Apple 11", 1150000m },
                    { 12, "Sản phẩm cao cấp số 12", "Tai nghe Samsung 12", 1300000m },
                    { 13, "Sản phẩm cao cấp số 13", "Màn hình Sony 13", 1450000m },
                    { 14, "Sản phẩm cao cấp số 14", "Bàn phím LG 14", 1600000m },
                    { 15, "Sản phẩm cao cấp số 15", "Chuột Asus 15", 1750000m },
                    { 16, "Sản phẩm cao cấp số 16", "Webcam Logitech 16", 1900000m },
                    { 17, "Sản phẩm cao cấp số 17", "Loa HP 17", 2050000m },
                    { 18, "Sản phẩm cao cấp số 18", "Router Acer 18", 2200000m },
                    { 19, "Sản phẩm cao cấp số 19", "USB Lenovo 19", 2350000m },
                    { 20, "Sản phẩm cao cấp số 20", "Laptop Dell 20", 2000000m },
                    { 21, "Sản phẩm cao cấp số 21", "Điện thoại Apple 21", 2150000m },
                    { 22, "Sản phẩm cao cấp số 22", "Tai nghe Samsung 22", 2300000m },
                    { 23, "Sản phẩm cao cấp số 23", "Màn hình Sony 23", 2450000m },
                    { 24, "Sản phẩm cao cấp số 24", "Bàn phím LG 24", 2600000m },
                    { 25, "Sản phẩm cao cấp số 25", "Chuột Asus 25", 2750000m },
                    { 26, "Sản phẩm cao cấp số 26", "Webcam Logitech 26", 2900000m },
                    { 27, "Sản phẩm cao cấp số 27", "Loa HP 27", 3050000m },
                    { 28, "Sản phẩm cao cấp số 28", "Router Acer 28", 3200000m },
                    { 29, "Sản phẩm cao cấp số 29", "USB Lenovo 29", 3350000m },
                    { 30, "Sản phẩm cao cấp số 30", "Laptop Dell 30", 3000000m },
                    { 31, "Sản phẩm cao cấp số 31", "Điện thoại Apple 31", 3150000m },
                    { 32, "Sản phẩm cao cấp số 32", "Tai nghe Samsung 32", 3300000m },
                    { 33, "Sản phẩm cao cấp số 33", "Màn hình Sony 33", 3450000m },
                    { 34, "Sản phẩm cao cấp số 34", "Bàn phím LG 34", 3600000m },
                    { 35, "Sản phẩm cao cấp số 35", "Chuột Asus 35", 3750000m },
                    { 36, "Sản phẩm cao cấp số 36", "Webcam Logitech 36", 3900000m },
                    { 37, "Sản phẩm cao cấp số 37", "Loa HP 37", 4050000m },
                    { 38, "Sản phẩm cao cấp số 38", "Router Acer 38", 4200000m },
                    { 39, "Sản phẩm cao cấp số 39", "USB Lenovo 39", 4350000m },
                    { 40, "Sản phẩm cao cấp số 40", "Laptop Dell 40", 4000000m },
                    { 41, "Sản phẩm cao cấp số 41", "Điện thoại Apple 41", 4150000m },
                    { 42, "Sản phẩm cao cấp số 42", "Tai nghe Samsung 42", 4300000m },
                    { 43, "Sản phẩm cao cấp số 43", "Màn hình Sony 43", 4450000m },
                    { 44, "Sản phẩm cao cấp số 44", "Bàn phím LG 44", 4600000m },
                    { 45, "Sản phẩm cao cấp số 45", "Chuột Asus 45", 4750000m },
                    { 46, "Sản phẩm cao cấp số 46", "Webcam Logitech 46", 4900000m },
                    { 47, "Sản phẩm cao cấp số 47", "Loa HP 47", 5050000m },
                    { 48, "Sản phẩm cao cấp số 48", "Router Acer 48", 5200000m },
                    { 49, "Sản phẩm cao cấp số 49", "USB Lenovo 49", 5350000m },
                    { 50, "Sản phẩm cao cấp số 50", "Laptop Dell 50", 5000000m },
                    { 51, "Sản phẩm cao cấp số 51", "Điện thoại Apple 51", 5150000m },
                    { 52, "Sản phẩm cao cấp số 52", "Tai nghe Samsung 52", 5300000m },
                    { 53, "Sản phẩm cao cấp số 53", "Màn hình Sony 53", 5450000m },
                    { 54, "Sản phẩm cao cấp số 54", "Bàn phím LG 54", 5600000m },
                    { 55, "Sản phẩm cao cấp số 55", "Chuột Asus 55", 5750000m },
                    { 56, "Sản phẩm cao cấp số 56", "Webcam Logitech 56", 5900000m },
                    { 57, "Sản phẩm cao cấp số 57", "Loa HP 57", 6050000m },
                    { 58, "Sản phẩm cao cấp số 58", "Router Acer 58", 6200000m },
                    { 59, "Sản phẩm cao cấp số 59", "USB Lenovo 59", 6350000m },
                    { 60, "Sản phẩm cao cấp số 60", "Laptop Dell 60", 6000000m },
                    { 61, "Sản phẩm cao cấp số 61", "Điện thoại Apple 61", 6150000m },
                    { 62, "Sản phẩm cao cấp số 62", "Tai nghe Samsung 62", 6300000m },
                    { 63, "Sản phẩm cao cấp số 63", "Màn hình Sony 63", 6450000m },
                    { 64, "Sản phẩm cao cấp số 64", "Bàn phím LG 64", 6600000m },
                    { 65, "Sản phẩm cao cấp số 65", "Chuột Asus 65", 6750000m },
                    { 66, "Sản phẩm cao cấp số 66", "Webcam Logitech 66", 6900000m },
                    { 67, "Sản phẩm cao cấp số 67", "Loa HP 67", 7050000m },
                    { 68, "Sản phẩm cao cấp số 68", "Router Acer 68", 7200000m },
                    { 69, "Sản phẩm cao cấp số 69", "USB Lenovo 69", 7350000m },
                    { 70, "Sản phẩm cao cấp số 70", "Laptop Dell 70", 7000000m },
                    { 71, "Sản phẩm cao cấp số 71", "Điện thoại Apple 71", 7150000m },
                    { 72, "Sản phẩm cao cấp số 72", "Tai nghe Samsung 72", 7300000m },
                    { 73, "Sản phẩm cao cấp số 73", "Màn hình Sony 73", 7450000m },
                    { 74, "Sản phẩm cao cấp số 74", "Bàn phím LG 74", 7600000m },
                    { 75, "Sản phẩm cao cấp số 75", "Chuột Asus 75", 7750000m },
                    { 76, "Sản phẩm cao cấp số 76", "Webcam Logitech 76", 7900000m },
                    { 77, "Sản phẩm cao cấp số 77", "Loa HP 77", 8050000m },
                    { 78, "Sản phẩm cao cấp số 78", "Router Acer 78", 8200000m },
                    { 79, "Sản phẩm cao cấp số 79", "USB Lenovo 79", 8350000m },
                    { 80, "Sản phẩm cao cấp số 80", "Laptop Dell 80", 8000000m },
                    { 81, "Sản phẩm cao cấp số 81", "Điện thoại Apple 81", 8150000m },
                    { 82, "Sản phẩm cao cấp số 82", "Tai nghe Samsung 82", 8300000m },
                    { 83, "Sản phẩm cao cấp số 83", "Màn hình Sony 83", 8450000m },
                    { 84, "Sản phẩm cao cấp số 84", "Bàn phím LG 84", 8600000m },
                    { 85, "Sản phẩm cao cấp số 85", "Chuột Asus 85", 8750000m },
                    { 86, "Sản phẩm cao cấp số 86", "Webcam Logitech 86", 8900000m },
                    { 87, "Sản phẩm cao cấp số 87", "Loa HP 87", 9050000m },
                    { 88, "Sản phẩm cao cấp số 88", "Router Acer 88", 9200000m },
                    { 89, "Sản phẩm cao cấp số 89", "USB Lenovo 89", 9350000m },
                    { 90, "Sản phẩm cao cấp số 90", "Laptop Dell 90", 9000000m },
                    { 91, "Sản phẩm cao cấp số 91", "Điện thoại Apple 91", 9150000m },
                    { 92, "Sản phẩm cao cấp số 92", "Tai nghe Samsung 92", 9300000m },
                    { 93, "Sản phẩm cao cấp số 93", "Màn hình Sony 93", 9450000m },
                    { 94, "Sản phẩm cao cấp số 94", "Bàn phím LG 94", 9600000m },
                    { 95, "Sản phẩm cao cấp số 95", "Chuột Asus 95", 9750000m },
                    { 96, "Sản phẩm cao cấp số 96", "Webcam Logitech 96", 9900000m },
                    { 97, "Sản phẩm cao cấp số 97", "Loa HP 97", 10050000m },
                    { 98, "Sản phẩm cao cấp số 98", "Router Acer 98", 10200000m },
                    { 99, "Sản phẩm cao cấp số 99", "USB Lenovo 99", 10350000m },
                    { 100, "Sản phẩm cao cấp số 100", "Laptop Dell 100", 10000000m }
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
