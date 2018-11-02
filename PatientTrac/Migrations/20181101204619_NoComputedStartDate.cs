using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class NoComputedStartDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2dee5146-db04-4c1b-9007-b993145c36b6", "73a358d9-deda-49ed-9cc8-52c45dae86e2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "ae8292e5-c75a-4783-ad65-313349cecbd4", 0, "228832a4-46fd-4779-aba5-80fc9661e8cd", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGvIZK41XuEEm8RaHE08kl5ljYtqNiRTCatYxgctIie9zZLwY6PDUs1MWt03lQNNxA==", null, false, "f83280c4-9fd8-404b-a7eb-727719e17cf6", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "ae8292e5-c75a-4783-ad65-313349cecbd4", "228832a4-46fd-4779-aba5-80fc9661e8cd" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "2dee5146-db04-4c1b-9007-b993145c36b6", 0, "73a358d9-deda-49ed-9cc8-52c45dae86e2", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO5z8tNAijkbnI1CGBlYKoCYQJK4dT3b1Jhw5oV+waqYr02Y0RcXwqlkYQyLTB5WBQ==", null, false, "affa0122-a8d3-4cd9-b5a6-fa6b9ec0432a", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
