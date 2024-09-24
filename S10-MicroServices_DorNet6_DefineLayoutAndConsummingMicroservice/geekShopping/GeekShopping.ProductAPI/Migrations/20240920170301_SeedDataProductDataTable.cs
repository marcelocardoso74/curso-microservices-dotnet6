using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedDataProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 4L, "Action Figure", "NAVE DO HAN SOLO MILENNIUM FALCON", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 5L, "T-shirt", "Camista de comemoração de 30 anos do seriado FRIENDS", "https://github.com/marcelocardoso74/curso-microservices-dotnet6/blob/main/Imagens/camisetafriends.png?raw=true", "Camiseta Comemorativa FRIENDS", 69.9m });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[] { 6L, "Action Figure", "capacete comemorativo Darth Vader", "https://github.com/marcelocardoso74/curso-microservices-dotnet6/blob/main/Imagens/capacetedarthvader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m });
        }

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
