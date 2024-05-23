using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class Addcargaproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 4L, "Camisa", "Camisa polo", "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg", "Camisa", 10m },
                    { 5L, "Camisa", "Camisa polo", "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg", "Camisa", 10m },
                    { 6L, "Camisa", "Camisa polo", "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg", "Camisa", 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 6L);
        }
    }
}
