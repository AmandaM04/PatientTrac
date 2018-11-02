using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ae8292e5-c75a-4783-ad65-313349cecbd4", "228832a4-46fd-4779-aba5-80fc9661e8cd" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "ae8292e5-c75a-4783-ad65-313349cecbd4", 0, "228832a4-46fd-4779-aba5-80fc9661e8cd", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGvIZK41XuEEm8RaHE08kl5ljYtqNiRTCatYxgctIie9zZLwY6PDUs1MWt03lQNNxA==", null, false, "f83280c4-9fd8-404b-a7eb-727719e17cf6", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
