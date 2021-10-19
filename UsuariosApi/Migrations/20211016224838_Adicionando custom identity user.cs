using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "efb1c95a-8d88-4e37-8d00-ac42fd66308e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "3da38a6f-655b-4cbf-b2f6-8e2b62a5b0ed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c01a5f0-a4e7-4831-b05b-f305e1cd2102", "AQAAAAEAACcQAAAAELVFrOPPcKJyWrX3twSCCZ23Z8RTC1TOuD5Cby1lBCQVyKAJSRe3k0Cu1QCTKz8ERQ==", "acae6cb6-1af7-4cbf-a45e-bc59e939bea3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "036e70bd-4748-4a7b-8797-f4bbf9b074d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "75cab14e-a97d-428b-94aa-f783c02c6de5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b504607c-b14e-454c-aee5-6dd2edd2b514", "AQAAAAEAACcQAAAAEP5YR8vhA9cNDGv8eSB/NfFYPH1TQHqgjieJ37tECzshH8q8Ozx1rc8/93brnNCIig==", "47b6269c-bf83-4664-a5fe-f0f0c01117ec" });
        }
    }
}
