using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillaRestFullApi.Migrations
{
    /// <inheritdoc />
    public partial class AddingForigenKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillaID",
                table: "VillaNumbers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_VillasDb_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "VillasDb",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_VillasDb_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers");

            migrationBuilder.DropColumn(
                name: "VillaID",
                table: "VillaNumbers");

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
    }
}
