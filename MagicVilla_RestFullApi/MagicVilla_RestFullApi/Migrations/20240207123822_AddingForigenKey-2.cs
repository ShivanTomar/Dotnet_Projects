using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaRestFullApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingForigenKey2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 18, 8, 21, 963, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 18, 8, 21, 963, DateTimeKind.Local).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 18, 8, 21, 963, DateTimeKind.Local).AddTicks(8989));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 17, 52, 47, 463, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 17, 52, 47, 463, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "VillasDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 2, 7, 17, 52, 47, 463, DateTimeKind.Local).AddTicks(4946));
        }
    }
}
