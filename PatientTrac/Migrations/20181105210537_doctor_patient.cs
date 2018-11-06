using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class doctor_patient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatient_AspNetUsers_DoctorId",
                table: "DoctorPatient");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatient_Patient_PatientId",
                table: "DoctorPatient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatient",
                table: "DoctorPatient");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "54053d26-f643-4d56-a96e-810ecf36015f", "a5f7d03e-b42b-42f8-a8ad-d5be7ed19a03" });

            migrationBuilder.RenameTable(
                name: "DoctorPatient",
                newName: "DoctorPatients");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatient_PatientId",
                table: "DoctorPatients",
                newName: "IX_DoctorPatients_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatient_DoctorId",
                table: "DoctorPatients",
                newName: "IX_DoctorPatients_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients",
                column: "DoctorPatientId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "7da40450-a847-4893-a472-ff38b1fa5a35", 0, "99ecbace-6652-4c06-8ee4-f334cefa1304", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJNnHy0zu/aJ05AUDoq8rORhM2ot2v20evweJfxmv5+dh8WUprh91yOctxs8PDS0yw==", null, false, "1264b4d0-bb20-494d-9e34-e1ce1b073e35", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatients_AspNetUsers_DoctorId",
                table: "DoctorPatients",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatients_Patient_PatientId",
                table: "DoctorPatients",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatients_AspNetUsers_DoctorId",
                table: "DoctorPatients");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorPatients_Patient_PatientId",
                table: "DoctorPatients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorPatients",
                table: "DoctorPatients");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7da40450-a847-4893-a472-ff38b1fa5a35", "99ecbace-6652-4c06-8ee4-f334cefa1304" });

            migrationBuilder.RenameTable(
                name: "DoctorPatients",
                newName: "DoctorPatient");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatients_PatientId",
                table: "DoctorPatient",
                newName: "IX_DoctorPatient_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorPatients_DoctorId",
                table: "DoctorPatient",
                newName: "IX_DoctorPatient_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorPatient",
                table: "DoctorPatient",
                column: "DoctorPatientId");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "54053d26-f643-4d56-a96e-810ecf36015f", 0, "a5f7d03e-b42b-42f8-a8ad-d5be7ed19a03", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENaKX/Jiqv8IYsVagcyta/+LbNRyFXSA9rscOjYtUoSWav+rKDBAVXlPvk9k+cjy3g==", null, false, "0f4b90cb-9709-4d33-a00c-fde4bd82bba4", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatient_AspNetUsers_DoctorId",
                table: "DoctorPatient",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorPatient_Patient_PatientId",
                table: "DoctorPatient",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
