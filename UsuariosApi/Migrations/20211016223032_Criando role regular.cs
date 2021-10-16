using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "75cab14e-a97d-428b-94aa-f783c02c6de5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "036e70bd-4748-4a7b-8797-f4bbf9b074d7", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b504607c-b14e-454c-aee5-6dd2edd2b514", "AQAAAAEAACcQAAAAEP5YR8vhA9cNDGv8eSB/NfFYPH1TQHqgjieJ37tECzshH8q8Ozx1rc8/93brnNCIig==", "47b6269c-bf83-4664-a5fe-f0f0c01117ec" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "827d680a-9404-4471-962a-3e222aeb4cf8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d11ca38-2199-446a-a4eb-a22be449fe37", "AQAAAAEAACcQAAAAEBVA+w9gUFghtwZSfWJP9HZi8PYjJeZhRkls3AAbQ0WMQqSgLWtN1asG4jFJbxCwkA==", "6045940e-4756-4ff0-aac9-045b404d876a" });
        }
    }
}
