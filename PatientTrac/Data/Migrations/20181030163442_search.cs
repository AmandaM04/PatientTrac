using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Data.Migrations
{
    public partial class search : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "209deb31-cd46-4b67-b6d5-7cb159fbcb1e", "978aa432-57c1-4381-836b-aa739ffce874" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "069f4cdc-85f1-4a5b-8287-08aeb65d2687", 0, "8cb63aef-48a2-4edb-9a80-3c6a8c2e2ace", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEADTJNJHz3mtUIFar4jKSFll6/XYoNIRDCB4oT+yZl5EqURyJEFCsv6Zr1MEM45ylA==", null, false, "482b96fb-8c58-48c3-bfd3-cd2e688cad89", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "069f4cdc-85f1-4a5b-8287-08aeb65d2687", "8cb63aef-48a2-4edb-9a80-3c6a8c2e2ace" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "209deb31-cd46-4b67-b6d5-7cb159fbcb1e", 0, "978aa432-57c1-4381-836b-aa739ffce874", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEjx3hHiGt13bEgwWYvB4tU//HfkfuvqMLXzVEerKCbb/77UmYBgwXdBPWVJ1xqgPQ==", null, false, "7977f882-6801-4e4e-9b04-7053c11c8b10", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
