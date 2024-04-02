using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaRestFullApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VillasDb",
                columns: new[] { "Id", "Amenity", "CreateDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nice White Villa", "https://demo.sirv.com/nuphar.jpg?w=400", "Royal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cool Villa", "https://www.google.com/imgres?imgurl=https%3A%2F%2Fres.cloudinary.com%2Fdemo%2Fimage%2Fupload%2Fv1312461204%2Fsample.jpg&tbnid=4WNHiXYnskNjjM&vet=12ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY..i&imgrefurl=https%3A%2F%2Fcloudinary.com%2Fdocumentation%2Fadvanced_url_delivery_options&docid=vpbUSBPYu_DD9M&w=864&h=576&q=small%20size%20image%20url&ved=2ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY", "My Villa", 6, 700.0, 540, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nice  Villa", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3ATaj_Mahal_N-UP-A28-a.jpg&psig=AOvVaw06O3T4BLBamaWkxuVThvtZ&ust=1707291284097000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOD7weWZloQDFQAAAAAdAAAAABAE", "White Villa", 4, 300.0, 450, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
