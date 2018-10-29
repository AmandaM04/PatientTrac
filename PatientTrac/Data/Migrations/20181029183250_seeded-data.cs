using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Data.Migrations
{
    public partial class seededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "209deb31-cd46-4b67-b6d5-7cb159fbcb1e", 0, "978aa432-57c1-4381-836b-aa739ffce874", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEjx3hHiGt13bEgwWYvB4tU//HfkfuvqMLXzVEerKCbb/77UmYBgwXdBPWVJ1xqgPQ==", null, false, "7977f882-6801-4e4e-9b04-7053c11c8b10", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.InsertData(
                table: "Medication",
                columns: new[] { "MedicationId", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Ofloxacin", "Antibiotics" },
                    { 2, "Oxycodone", "Analgesics" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "PatientId", "Age", "FirstName", "LastName", "PhoneNumber", "Sex", "StreetAddress" },
                values: new object[,]
                {
                    { 1, 32, "Amanda", "Mitchell", "615-123-4567", "Female", "123 Book Street" },
                    { 2, 50, "John", "Doe", "931-380-9843", "Male", "789 Yellow Brick Rd" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "209deb31-cd46-4b67-b6d5-7cb159fbcb1e", "978aa432-57c1-4381-836b-aa739ffce874" });

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "MedicationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medication",
                keyColumn: "MedicationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "PatientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "PatientId",
                keyValue: 2);
        }
    }
}
