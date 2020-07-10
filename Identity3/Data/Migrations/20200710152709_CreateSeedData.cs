using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity3.Data.Migrations
{
    public partial class CreateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "86f7e8c6-8ad6-4ced-8d06-9503a8942364", "Administrator", "ADMINSTRATOR" },
                    { "2", "257fa41c-f4da-4e0a-9fd7-2f69f27c0d65", "Vistitor", "VISITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "8ba367e4-3bd7-45e3-b908-5a401d9bc034", "admin@gmail.com", true, true, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE4pDy/Jt980k662s8KtBgGxKh0m8Ix8bGI2Cu7T8zuCnwHl6bP02Ldkk/3rg4DXIw==", null, false, "2ae0a8a1-92b6-4327-a41d-6e848254b015", false, "Admin@gmail.com" },
                    { "2", 0, "ca9fb323-9caa-4634-997f-14f1b4b03b8d", "mary.lamb@gmail.com", true, true, null, "MARY.LAMB@GMAIL.COM", "MARYLAMB@GMAIL.COM", "AQAAAAEAACcQAAAAEKQa6zt4DjnfCAN4+NujtKhsLeEenfUvexhsg6IP5pcCdb2T/O+hge2D5W4c2jA45g==", null, false, "d7496ffa-bc18-4e57-a3cc-9c4a3284945e", false, "mary.lamb@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");
        }
    }
}
