using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeedAndAddAutoId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "421914d1-f2b1-4e50-b987-21dd2e279170");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "478c5a02-eafb-4a2d-b337-1a27a0812694");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf3e7e61-848b-41aa-9d86-e6e53c278e96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4817cb1a-4558-46b1-a5a5-7eb130578ba6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b246ce7e-5c26-43d8-9324-cf26d66d0f00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d500fa10-9d57-4ce5-92fb-233f4433e8d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f3052ff1-fa76-47ae-bc98-0c796d25ae79");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bb03100-aee9-4ea4-8f83-aab5723cd945", null, "Role", "Admin", null },
                    { "1eef442e-2da2-4da0-9b8f-1d77fbcb3a01", null, "Role", "Superuser", null },
                    { "f7c525b1-1255-4572-a1db-8e43237e5aee", null, "Role", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0503e0ef-cb60-4bda-be17-a14587199c71", 0, "3fc5e1cd-673d-4759-b618-06d69338a6ac", "mymail@gmail.com", false, false, null, "mymail@gmail.com", "admin", "AQAAAAIAAYagAAAAEN51AE6SNBXPklBPAiRTxNEMkXOf5ps8EabE+emkc3juxc/RKfUXDEoHXi/q3uc5Zg==", null, false, "1bb03100-aee9-4ea4-8f83-aab5723cd945", "2d50d678-720e-40bf-a40c-dc7a5ad90ef0", false, "admin" },
                    { "1e1dc581-9172-4439-b76b-ed56a3450ecc", 0, "92fb9c2d-57dd-44cf-ae73-c750fde93c95", "iamthebest@gmail.com", false, false, null, "iamthebest@gmail.com", "friend_of_admin", "AQAAAAIAAYagAAAAEC98Lw8nHMIJSFzWJNm3Bj+VFxDIJiJJTRwhwEBllacU8dyYeBJOVIqfBmmmv9QJIQ==", null, false, "1eef442e-2da2-4da0-9b8f-1d77fbcb3a01", "c9baf9a0-f6cc-4250-b6e1-f466bccc8ca4", false, "friend_of_admin" },
                    { "4926ab53-025c-40c7-a0a3-e1cac01a0711", 0, "cb306b66-2898-4761-8b81-1fbaddc81006", "john1997@gmail.com", false, false, null, "john1997@gmail.com", "john1997", "AQAAAAIAAYagAAAAEE/tCQ6cdjk1DTgnVI8C03cKPuaMfnTStq0Vjs85P2ddO3syxfWblv2cs/tMmBoXcg==", null, false, "f7c525b1-1255-4572-a1db-8e43237e5aee", "ed0bdf91-7657-4aed-973e-b6a0ddffea3e", false, "john1997" },
                    { "ddc78eeb-d1a5-4aa5-82c9-c4aa82ce5dae", 0, "3baae10b-ac50-476a-99f1-8f3428b7851a", "mancool321@gmail.com", false, false, null, "mancool321@gmail.com", "coolman123", "AQAAAAIAAYagAAAAEGLIq8z/s4bQmBCdN/siMYDVaKX27jIzVW8rRLRtcUW0xdku7FOeq6ujr2QR3v8UkA==", null, false, "f7c525b1-1255-4572-a1db-8e43237e5aee", "b57fce38-21d5-422a-8acc-7366d90e3822", false, "coolman123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb03100-aee9-4ea4-8f83-aab5723cd945");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1eef442e-2da2-4da0-9b8f-1d77fbcb3a01");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7c525b1-1255-4572-a1db-8e43237e5aee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0503e0ef-cb60-4bda-be17-a14587199c71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e1dc581-9172-4439-b76b-ed56a3450ecc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4926ab53-025c-40c7-a0a3-e1cac01a0711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ddc78eeb-d1a5-4aa5-82c9-c4aa82ce5dae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "421914d1-f2b1-4e50-b987-21dd2e279170", null, "Role", "Admin", null },
                    { "478c5a02-eafb-4a2d-b337-1a27a0812694", null, "Role", "Superuser", null },
                    { "cf3e7e61-848b-41aa-9d86-e6e53c278e96", null, "Role", "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4817cb1a-4558-46b1-a5a5-7eb130578ba6", 0, "9f97c14d-ad1b-48e7-994a-9c65b9143854", "iamthebest@gmail.com", false, false, null, null, "friend_of_admin", "AQAAAAIAAYagAAAAEIW6FVBt2lKs33xDitxJTNLc6y1GdVOkQxuWouPQhPVZqXnqzH+Re1W4RYfBaZDVfQ==", null, false, "a8813f4f-5966-4f72-bf28-50a5d8e21feb", "5997fada-0876-4e08-b48c-038cca8e2dca", false, "friend_of_admin" },
                    { "b246ce7e-5c26-43d8-9324-cf26d66d0f00", 0, "240735e1-bb7e-4181-aa0c-ce7de7193906", "mymail@gmail.com", false, false, null, null, "admin", "AQAAAAIAAYagAAAAEBx+3VN8TpX9w13ZF/Y7V/oIwJ/8OrZBKW2qS3wKVUGpymuP/S9WeREdB0s5y0WlVw==", null, false, "0f52bfd6-88b6-4f41-832d-b0b123098d96", "ff98313b-3f00-436b-a9de-22b4fe16cbdf", false, "admin" },
                    { "d500fa10-9d57-4ce5-92fb-233f4433e8d2", 0, "9e3ac679-75d3-48a2-9ba2-0ff4fd983ff3", "mancool321@gmail.com", false, false, null, null, "coolman123", "AQAAAAIAAYagAAAAEAcPkhjdTMBZIdKXAYacZZxDR6OW6+HoMrCvm77dLEx9GNeXjnwWrPLKO8ETpiu3RQ==", null, false, "5894674b-05a4-4b4e-ae1e-e2e952dcd094", "23e1fd39-b0d6-49cd-a38b-1b1bdb51f6ba", false, "coolman123" },
                    { "f3052ff1-fa76-47ae-bc98-0c796d25ae79", 0, "f89f4e8c-8156-4ef7-9a6f-9eee05392c6d", "john1997@gmail.com", false, false, null, null, "john1997", "AQAAAAIAAYagAAAAEMwshI4Ir7IQxH8pHPRkyFjiwGJOp+K2xilCGsZPDlAB1VcfciSlhLSU1Rhx3eXB0w==", null, false, "b8049bfb-11ae-4c78-af28-df89850d2c8d", "eacf0379-ad8f-4e1d-828e-6446bfada64c", false, "john1997" }
                });
        }
    }
}
