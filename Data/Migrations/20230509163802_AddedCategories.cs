using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 9, 16, 38, 0, 689, DateTimeKind.Utc).AddTicks(392))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "72d1b1a6-9bf1-42e0-89f5-db763b66883a", null, "Role", "User", null },
                    { "91229b5d-0327-4423-a4ea-503650cf25b8", null, "Role", "Superuser", null },
                    { "cf64600e-2f4d-49c3-a6f1-75d5a092d00c", null, "Role", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Image", "Name", "Priority" },
                values: new object[,]
                {
                    { 1, "Cool laptops here", "laptop.jpg", "Laptops", 1 },
                    { 2, "Great phones for everyone", "phone.jpg", "Phones", 3 },
                    { 3, "Monitors for all uses", "monitor.jpg", "Monitors", 2 },
                    { 4, "Memory that your computer will enjoy", "ram.jpg", "RAM", 5 },
                    { 5, "Processors smarter than Einstein", "cpu.jpg", "CPU", 4 },
                    { 6, "Best graphics for not only games", "gpu.jpg", "GPU", 6 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09b7032a-b32e-4754-8b93-2f8c91878385", 0, "96f43646-1ae5-4d8e-9b68-e9e1fa3ee1f0", "john1997@gmail.com", false, false, null, "john1997@gmail.com", "john1997", "AQAAAAIAAYagAAAAEMaejbC0kt6wk4RqcAnkXBuEb+zhZW7S5/i9TvP8W2mAUOFQIFoCIk5WmFRiLWaAJQ==", null, false, "72d1b1a6-9bf1-42e0-89f5-db763b66883a", "9298ea64-302a-4cf6-8ead-31475ebbe28c", false, "john1997" },
                    { "36aeab20-371d-429a-abab-26bd3f0075ef", 0, "6b6c8ecd-79c9-421f-8127-4ff763385076", "mancool321@gmail.com", false, false, null, "mancool321@gmail.com", "coolman123", "AQAAAAIAAYagAAAAEARvRDSXiHhH9fT59FCkyE7cGXhSEIWZrCvB5537FMQYglRrmGPIHU1dpAsw12zXwQ==", null, false, "72d1b1a6-9bf1-42e0-89f5-db763b66883a", "87d09e37-0488-4ee6-9f69-af256280d847", false, "coolman123" },
                    { "dfb580b3-954a-4aae-913d-67019bb88427", 0, "a7ab9adc-d13d-42dd-9c89-609dca2b0aaf", "mymail@gmail.com", false, false, null, "mymail@gmail.com", "admin", "AQAAAAIAAYagAAAAENolmc/EZNVTaOW36+36RFgo7Qe3cnWRYjmQY6vz4C5oV/PI7Xs+07yXxS97yv0bYw==", null, false, "cf64600e-2f4d-49c3-a6f1-75d5a092d00c", "5b28d1ed-07b6-4e62-86a4-ac27de4aec6f", false, "admin" },
                    { "e7f59ece-676d-4e00-a847-9f8516474c18", 0, "aabdc053-6a6f-4684-87f4-2906c9dcf4cc", "iamthebest@gmail.com", false, false, null, "iamthebest@gmail.com", "friend_of_admin", "AQAAAAIAAYagAAAAEDndrotAMsovHUcj47CZdSvuZigS49n7nBzErEikMHD23Es+SEG9HLatVxMxK5TcGA==", null, false, "91229b5d-0327-4423-a4ea-503650cf25b8", "562253b7-2d74-4fb4-bdba-d7b52cbfb148", false, "friend_of_admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09b7032a-b32e-4754-8b93-2f8c91878385");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36aeab20-371d-429a-abab-26bd3f0075ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfb580b3-954a-4aae-913d-67019bb88427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7f59ece-676d-4e00-a847-9f8516474c18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72d1b1a6-9bf1-42e0-89f5-db763b66883a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91229b5d-0327-4423-a4ea-503650cf25b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf64600e-2f4d-49c3-a6f1-75d5a092d00c");

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
                    { "0503e0ef-cb60-4bda-be17-a14587199c71", 0, "3fc5e1cd-673d-4759-b618-06d69338a6ac", "mymail@gmail.com", false, false, null, "mymail@gmail.com", "admin", "AQAAAAIAAYagAAAAEN51AE6SNBXPklBPAiRTxNEMkXOf5ps8EabE+emkc3juxc/RKfUXDEoHXi/q3uc5Zg==", null, false, "22b52c15-45b3-4731-bdad-ff747a8f4fea", "2d50d678-720e-40bf-a40c-dc7a5ad90ef0", false, "admin" },
                    { "1e1dc581-9172-4439-b76b-ed56a3450ecc", 0, "92fb9c2d-57dd-44cf-ae73-c750fde93c95", "iamthebest@gmail.com", false, false, null, "iamthebest@gmail.com", "friend_of_admin", "AQAAAAIAAYagAAAAEC98Lw8nHMIJSFzWJNm3Bj+VFxDIJiJJTRwhwEBllacU8dyYeBJOVIqfBmmmv9QJIQ==", null, false, "5b7ba711-241f-40b3-8de4-27a5d8c1bba5", "c9baf9a0-f6cc-4250-b6e1-f466bccc8ca4", false, "friend_of_admin" },
                    { "4926ab53-025c-40c7-a0a3-e1cac01a0711", 0, "cb306b66-2898-4761-8b81-1fbaddc81006", "john1997@gmail.com", false, false, null, "john1997@gmail.com", "john1997", "AQAAAAIAAYagAAAAEE/tCQ6cdjk1DTgnVI8C03cKPuaMfnTStq0Vjs85P2ddO3syxfWblv2cs/tMmBoXcg==", null, false, "2412ba56-fa82-4630-80b7-4bc87acc0b85", "ed0bdf91-7657-4aed-973e-b6a0ddffea3e", false, "john1997" },
                    { "ddc78eeb-d1a5-4aa5-82c9-c4aa82ce5dae", 0, "3baae10b-ac50-476a-99f1-8f3428b7851a", "mancool321@gmail.com", false, false, null, "mancool321@gmail.com", "coolman123", "AQAAAAIAAYagAAAAEGLIq8z/s4bQmBCdN/siMYDVaKX27jIzVW8rRLRtcUW0xdku7FOeq6ujr2QR3v8UkA==", null, false, "70233513-1ce1-4905-8233-783df651a257", "b57fce38-21d5-422a-8acc-7366d90e3822", false, "coolman123" }
                });
        }
    }
}
