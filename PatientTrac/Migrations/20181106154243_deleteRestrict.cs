using Microsoft.EntityFrameworkCore.Migrations;

namespace PatientTrac.Migrations
{
    public partial class deleteRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7da40450-a847-4893-a472-ff38b1fa5a35", "99ecbace-6652-4c06-8ee4-f334cefa1304" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "00173bcb-58ce-41be-af0c-f6a55d1946f9", 0, "ce145750-ed75-45a3-b6c8-bf213005ec90", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFDk+dVxT07Nab2UWkvpWHMdp6aYN9val+wrk0VMkmcAxMMf2P/aJfRTZGMEqh1dfg==", null, false, "52ee3dc7-2388-43ab-b685-d632629595f8", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "00173bcb-58ce-41be-af0c-f6a55d1946f9", "ce145750-ed75-45a3-b6c8-bf213005ec90" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Facility", "FirstName", "LastName" },
                values: new object[] { "7da40450-a847-4893-a472-ff38b1fa5a35", 0, "99ecbace-6652-4c06-8ee4-f334cefa1304", "Doctor", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJNnHy0zu/aJ05AUDoq8rORhM2ot2v20evweJfxmv5+dh8WUprh91yOctxs8PDS0yw==", null, false, "1264b4d0-bb20-494d-9e34-e1ce1b073e35", false, "admin@admin.com", "Vanderbilt", "Jill", "Scott" });
        }
    }
}
