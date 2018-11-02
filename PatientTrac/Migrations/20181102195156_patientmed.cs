using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class patientmed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medication_Patient_PatientId",
                table: "Medication");

            migrationBuilder.DropIndex(
                name: "IX_Medication_PatientId",
                table: "Medication");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "5b504f68-aa68-4efe-9d96-ceb17471d409", "1db88db5-a741-49fd-a5e4-2d3bbaecc035" });

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Medication");

            migrationBuilder.AddColumn<int>(
                name: "MedicationsMedicationId",
                table: "Patient",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "b2f391f0-2036-4533-a32c-71b99c37cf03", 0, "b2bc1c03-a337-45da-a483-3bb82ab8d6ad", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEEz/ePYd48AgJKbvLoj4d6DmLpS23gek42hrUOqUwWNxy1VbI0Mub+EYoYKQ3rpxcw==", null, false, "aedfebb8-d0b2-4d82-bc33-6f20eceeced5", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_MedicationsMedicationId",
                table: "Patient",
                column: "MedicationsMedicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Medication_MedicationsMedicationId",
                table: "Patient",
                column: "MedicationsMedicationId",
                principalTable: "Medication",
                principalColumn: "MedicationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Medication_MedicationsMedicationId",
                table: "Patient");

            migrationBuilder.DropIndex(
                name: "IX_Patient_MedicationsMedicationId",
                table: "Patient");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "b2f391f0-2036-4533-a32c-71b99c37cf03", "b2bc1c03-a337-45da-a483-3bb82ab8d6ad" });

            migrationBuilder.DropColumn(
                name: "MedicationsMedicationId",
                table: "Patient");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Medication",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "5b504f68-aa68-4efe-9d96-ceb17471d409", 0, "1db88db5-a741-49fd-a5e4-2d3bbaecc035", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBs/L9GpMH/AsXPj+0Bq8V7AdoQg5xK8mRAV+G3ros+eS6B8R+PhX/d2p2636bdLAA==", null, false, "3e488554-9afc-4a82-97cb-72bbffb142ac", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.CreateIndex(
                name: "IX_Medication_PatientId",
                table: "Medication",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medication_Patient_PatientId",
                table: "Medication",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
