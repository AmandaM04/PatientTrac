using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Data.Migrations
{
    public partial class StopDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "069f4cdc-85f1-4a5b-8287-08aeb65d2687", "8cb63aef-48a2-4edb-9a80-3c6a8c2e2ace" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "ef2beb35-b8d7-47de-bb65-4c90c140310c", 0, "b5734860-d2dc-4846-9abc-460a9860bc10", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBeXVZYjWDxqFJdc3qFi5en9X9i7+kbxpGAWmoZdHcYyd5oKwlzQdBgFajOkdp32mQ==", null, false, "b4fbcdba-4522-40b1-be98-37d669d18f3a", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ef2beb35-b8d7-47de-bb65-4c90c140310c", "b5734860-d2dc-4846-9abc-460a9860bc10" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "069f4cdc-85f1-4a5b-8287-08aeb65d2687", 0, "8cb63aef-48a2-4edb-9a80-3c6a8c2e2ace", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEADTJNJHz3mtUIFar4jKSFll6/XYoNIRDCB4oT+yZl5EqURyJEFCsv6Zr1MEM45ylA==", null, false, "482b96fb-8c58-48c3-bfd3-cd2e688cad89", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
