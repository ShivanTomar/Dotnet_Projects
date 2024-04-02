using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaRestFullApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingVillaNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                });

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 15, 50, 26, 556, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 15, 50, 26, 556, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 15, 50, 26, 556, DateTimeKind.Local).AddTicks(6622));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 13, 9, 48, 483, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 13, 9, 48, 483, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 6, 13, 9, 48, 483, DateTimeKind.Local).AddTicks(7182));
        }
    }
}
