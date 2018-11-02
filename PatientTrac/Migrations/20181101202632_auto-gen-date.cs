using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class autogendate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2601bfa6-8dfe-4a13-8b52-fc4ddd664806", "28888e74-b3f5-45c4-aa6a-3b5e891ef357" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "2dee5146-db04-4c1b-9007-b993145c36b6", 0, "73a358d9-deda-49ed-9cc8-52c45dae86e2", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO5z8tNAijkbnI1CGBlYKoCYQJK4dT3b1Jhw5oV+waqYr02Y0RcXwqlkYQyLTB5WBQ==", null, false, "affa0122-a8d3-4cd9-b5a6-fa6b9ec0432a", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "2dee5146-db04-4c1b-9007-b993145c36b6", "73a358d9-deda-49ed-9cc8-52c45dae86e2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "2601bfa6-8dfe-4a13-8b52-fc4ddd664806", 0, "28888e74-b3f5-45c4-aa6a-3b5e891ef357", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIayr46Fz7Y+JNh7rkYiev5cDmtvK2lOuxTinbtTA//Sh6RFlrLc31TeNtMd8XCVSQ==", null, false, "7386a051-ca15-4f59-bdbb-bf1a7ab5e6b5", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
