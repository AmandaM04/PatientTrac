using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b2f391f0-2036-4533-a32c-71b99c37cf03", "b2bc1c03-a337-45da-a483-3bb82ab8d6ad" });

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Patient",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "54053d26-f643-4d56-a96e-810ecf36015f", 0, "a5f7d03e-b42b-42f8-a8ad-d5be7ed19a03", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENaKX/Jiqv8IYsVagcyta/+LbNRyFXSA9rscOjYtUoSWav+rKDBAVXlPvk9k+cjy3g==", null, false, "0f4b90cb-9709-4d33-a00c-fde4bd82bba4", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_IdentityUserId",
                table: "Patient",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_AspNetUsers_IdentityUserId",
                table: "Patient",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_AspNetUsers_IdentityUserId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_IdentityUserId",
                table: "Patient");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "54053d26-f643-4d56-a96e-810ecf36015f", "a5f7d03e-b42b-42f8-a8ad-d5be7ed19a03" });

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Patient");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "b2f391f0-2036-4533-a32c-71b99c37cf03", 0, "b2bc1c03-a337-45da-a483-3bb82ab8d6ad", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEz/ePYd48AgJKbvLoj4d6DmLpS23gek42hrUOqUwWNxy1VbI0Mub+EYoYKQ3rpxcw==", null, false, "aedfebb8-d0b2-4d82-bc33-6f20eceeced5", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
