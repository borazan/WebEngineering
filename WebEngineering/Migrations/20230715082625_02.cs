using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class _02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50da61af-5496-4e5f-bba0-510c14c6e5f7", "0921b8ab-d5c6-4619-81e0-b43f92072264" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8112e46a-4766-442e-9fc5-4376440acbe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fc8cf74-57e4-469b-9b64-ecf9640f7e25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e63e539a-a8ba-4d8c-82b3-7b1aa86fe992");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed8a1276-4583-4260-afbd-d974a42de397");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50da61af-5496-4e5f-bba0-510c14c6e5f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0921b8ab-d5c6-4619-81e0-b43f92072264");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "3c907fdf-38e3-481e-9de8-240bdcbf3812", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3547d056-87ed-4dc1-adeb-3b03b588f2b8", 0, "77b9bfa8-b88f-459f-8eeb-26b19659c73d", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAEFXFkC9ofPn87AhIHpvomP7uAVnHzLHKKEl+0qBS0CUJ4Q//IG0lmDjnDJsXZ1Qewg==", null, false, "27dcc8f3-dc32-4131-b19a-5c5090c81022", false, "demo01@gmail.com" },
                    { "73939acc-e242-4942-9091-0249c06ee341", 0, "589c6a0e-881d-43ec-9640-c5903c1a9c53", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEO6IDF8iXfyvAZSI8fbxiyJh3cKfOPWkHx4PID/Dkpui3j8ADWme32zd84lDRX1Blg==", null, false, "95456dbb-69f9-41c8-8f44-e0fb270f2a2e", false, "demo03@gmail.com" },
                    { "82b1a4ca-6cf4-4b12-8b5d-5391ffc24f7a", 0, "e3567953-a7bd-4d3a-b832-63f1f7c908d8", null, false, false, null, null, "DEMO04@GMAIL.COM", "AQAAAAEAACcQAAAAEBx9gLsjHQF+BJgko0acAQ3aY4Zj31h4J1JROOigSbQ4ZF04ObfjGwjxf8jCjgcuaQ==", null, false, "0254c1f8-0097-4203-be27-9446a8c717a7", false, "demo04@gmail.com" },
                    { "8d9095ea-cf62-442a-94a2-e237df42bbbf", 0, "29c6a031-b0b3-4eb7-97c3-eef5b6805cd7", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAECEPkT/N1c0y9QIf4KXN8dOlf3ER+bSNyYtRQl5kA5WQ0m+YJ7pDWOcTrfwImWTa/Q==", null, false, "24f24c5b-450b-42a9-b7c0-a0c51da97215", false, "demo02@gmail.com" },
                    { "cabd83c0-5826-465d-b401-604cd1955566", 0, "0c004468-e518-4de2-bb56-b4ff4bcbf3b3", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEM1/JhUui5DIxg4LW6KMRBa+xS9xUtvRh7Wssit/nukRD0Ck+91eeKcsmhZpcGggTg==", null, false, "d8b2ee83-48aa-48ea-8bc7-55021eeb2a5a", false, "admin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 4, 15, 59, 0, 0, DateTimeKind.Unspecified), 168, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 15, 4, 0, 0, 0, DateTimeKind.Unspecified), 250, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 10, 19, 2, 0, 0, DateTimeKind.Unspecified), 145, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 22, 14, 29, 0, 0, DateTimeKind.Unspecified), 54, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 9, 4, 40, 0, 0, DateTimeKind.Unspecified), 179, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 7, 3, 4, 0, 0, DateTimeKind.Unspecified), 44, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 23, 22, 54, 0, 0, DateTimeKind.Unspecified), 162, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 3, 24, 1, 38, 0, 0, DateTimeKind.Unspecified), 261 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 2, 2, 31, 0, 0, DateTimeKind.Unspecified), 157, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 26, 11, 34, 0, 0, DateTimeKind.Unspecified), 292, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 22, 18, 19, 0, 0, DateTimeKind.Unspecified), 155, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 8, 4, 23, 33, 0, 0, DateTimeKind.Unspecified), 38 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 24, 18, 1, 0, 0, DateTimeKind.Unspecified), 52, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 16, 5, 11, 0, 0, DateTimeKind.Unspecified), 201, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 10, 4, 29, 0, 0, DateTimeKind.Unspecified), 162, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 14, 1, 46, 0, 0, DateTimeKind.Unspecified), 238, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 8, 14, 50, 0, 0, DateTimeKind.Unspecified), 119, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 31, 3, 36, 0, 0, DateTimeKind.Unspecified), 131, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 27, 10, 34, 0, 0, DateTimeKind.Unspecified), 193, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 31, 4, 20, 0, 0, DateTimeKind.Unspecified), 132, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 2, 4, 49, 0, 0, DateTimeKind.Unspecified), 74, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 10, 10, 8, 0, 0, DateTimeKind.Unspecified), 260, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 29, 4, 53, 0, 0, DateTimeKind.Unspecified), 110, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 24, 14, 23, 0, 0, DateTimeKind.Unspecified), 257, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 30, 5, 49, 0, 0, DateTimeKind.Unspecified), 42, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 30, 11, 38, 0, 0, DateTimeKind.Unspecified), 281, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 10, 1, 50, 0, 0, DateTimeKind.Unspecified), 237, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 3, 17, 51, 0, 0, DateTimeKind.Unspecified), 78, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 24, 4, 56, 0, 0, DateTimeKind.Unspecified), 156, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 31, 3, 56, 0, 0, DateTimeKind.Unspecified), 125, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 4, 18, 12, 0, 0, DateTimeKind.Unspecified), 93, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 8, 17, 7, 0, 0, DateTimeKind.Unspecified), 166, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 21, 6, 51, 0, 0, DateTimeKind.Unspecified), 195, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 10, 15, 25, 0, 0, DateTimeKind.Unspecified), 159, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 23, 14, 25, 0, 0, DateTimeKind.Unspecified), 298, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 12, 5, 38, 0, 0, DateTimeKind.Unspecified), 287, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 9, 19, 56, 0, 0, DateTimeKind.Unspecified), 30, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 19, 21, 21, 0, 0, DateTimeKind.Unspecified), 236, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 21, 8, 45, 0, 0, DateTimeKind.Unspecified), 140, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 27, 18, 23, 0, 0, DateTimeKind.Unspecified), 224, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 33, 0, 0, DateTimeKind.Unspecified), 65, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 25, 3, 4, 0, 0, DateTimeKind.Unspecified), 215, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 30, 6, 42, 0, 0, DateTimeKind.Unspecified), 207, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 20, 1, 8, 0, 0, DateTimeKind.Unspecified), 152, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 5, 5, 57, 0, 0, DateTimeKind.Unspecified), 260, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 9, 2, 18, 0, 0, DateTimeKind.Unspecified), 281, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 18, 22, 22, 0, 0, DateTimeKind.Unspecified), 154, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 25, 1, 32, 0, 0, DateTimeKind.Unspecified), 288, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 15, 13, 32, 0, 0, DateTimeKind.Unspecified), 194, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 18, 4, 6, 0, 0, DateTimeKind.Unspecified), 105, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 12, 8, 3, 26, 0, 0, DateTimeKind.Unspecified), 216 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 56, 0, 0, DateTimeKind.Unspecified), 27, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 11, 1, 41, 0, 0, DateTimeKind.Unspecified), 268, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 18, 4, 55, 0, 0, DateTimeKind.Unspecified), 132, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 2, 20, 0, 26, 0, 0, DateTimeKind.Unspecified), 126 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 20, 23, 22, 0, 0, DateTimeKind.Unspecified), 167, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), 177, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 27, 10, 44, 0, 0, DateTimeKind.Unspecified), 230, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 4, 9, 3, 0, 0, DateTimeKind.Unspecified), 295, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 8, 4, 12, 58, 0, 0, DateTimeKind.Unspecified), 138 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 1, 13, 29, 0, 0, DateTimeKind.Unspecified), 184, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 23, 12, 29, 0, 0, DateTimeKind.Unspecified), 156, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 20, 6, 39, 0, 0, DateTimeKind.Unspecified), 18, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 14, 9, 10, 0, 0, DateTimeKind.Unspecified), 25, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 13, 10, 22, 0, 0, DateTimeKind.Unspecified), 58, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 20, 0, 33, 0, 0, DateTimeKind.Unspecified), 25, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 19, 8, 56, 0, 0, DateTimeKind.Unspecified), 184, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 19, 1, 18, 0, 0, DateTimeKind.Unspecified), 268, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 13, 20, 52, 0, 0, DateTimeKind.Unspecified), 263, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 13, 0, 0, DateTimeKind.Unspecified), 137 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 4, 16, 49, 0, 0, DateTimeKind.Unspecified), 170, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 27, 22, 30, 0, 0, DateTimeKind.Unspecified), 12, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 2, 23, 2, 0, 0, DateTimeKind.Unspecified), 163, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 25, 2, 48, 0, 0, DateTimeKind.Unspecified), 127, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 26, 10, 51, 0, 0, DateTimeKind.Unspecified), 211, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 3, 4, 35, 0, 0, DateTimeKind.Unspecified), 88, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 11, 18, 7, 19, 0, 0, DateTimeKind.Unspecified), 254 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 27, 5, 35, 0, 0, DateTimeKind.Unspecified), 132, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 19, 6, 19, 0, 0, DateTimeKind.Unspecified), 293, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 18, 22, 24, 0, 0, DateTimeKind.Unspecified), 2060, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 5, 14, 42, 0, 0, DateTimeKind.Unspecified), 4681, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 1, 4, 6, 0, 0, DateTimeKind.Unspecified), 2475, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 7, 17, 53, 0, 0, DateTimeKind.Unspecified), 2554, -14 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 7, 15, 15, 0, 0, DateTimeKind.Unspecified), 854, -6 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 15, 9, 9, 0, 0, DateTimeKind.Unspecified), 1604, -3 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 18, 13, 15, 0, 0, DateTimeKind.Unspecified), 3939, -18 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 6, 12, 22, 0, 0, DateTimeKind.Unspecified), 992, -14 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 21, 23, 10, 0, 0, DateTimeKind.Unspecified), 2587, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 8, 8, 52, 0, 0, DateTimeKind.Unspecified), 4231, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 2, 8, 50, 0, 0, DateTimeKind.Unspecified), 2800, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 13, 21, 13, 0, 0, DateTimeKind.Unspecified), 1341, -6 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 2, 0, 0, DateTimeKind.Unspecified), 4036, -15 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 1, 9, 6, 0, 0, DateTimeKind.Unspecified), 4836, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 11, 17, 3, 44, 0, 0, DateTimeKind.Unspecified), 1286 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 29, 4, 34, 0, 0, DateTimeKind.Unspecified), 3265, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 25, 20, 14, 0, 0, DateTimeKind.Unspecified), 860, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 19, 13, 22, 0, 0, DateTimeKind.Unspecified), 2461, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 8, 7, 37, 0, 0, DateTimeKind.Unspecified), 1249, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 23, 11, 43, 0, 0, DateTimeKind.Unspecified), 4504, -17 });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -20,
                column: "Name",
                value: "Golddichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -19,
                column: "Name",
                value: "Steinventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -18,
                column: "Name",
                value: "Gummifilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -17,
                column: "Name",
                value: "Gummifilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -16,
                column: "Name",
                value: "Plexiglasfedern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -15,
                column: "Name",
                value: "Titanriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -14,
                column: "Name",
                value: "Aluminiumfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -13,
                column: "Name",
                value: "Plexiglasventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -12,
                column: "Name",
                value: "Goldplatten");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -11,
                column: "Name",
                value: "Titangehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -10,
                column: "Name",
                value: "Bronzeriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -9,
                column: "Name",
                value: "Aluminiumfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -8,
                column: "Name",
                value: "Goldmuttern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -7,
                column: "Name",
                value: "Bronzedichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -6,
                column: "Name",
                value: "Keramikzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -5,
                column: "Name",
                value: "Kupferfilter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -4,
                column: "Name",
                value: "Metallkabel");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -3,
                column: "Name",
                value: "Keramikfedern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -2,
                column: "Name",
                value: "Stahlventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -1,
                column: "Name",
                value: "Textildichtungen");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "cabd83c0-5826-465d-b401-604cd1955566" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1b08697c-2966-4480-a747-99abecda42dc", "cabd83c0-5826-465d-b401-604cd1955566" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3547d056-87ed-4dc1-adeb-3b03b588f2b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73939acc-e242-4942-9091-0249c06ee341");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b1a4ca-6cf4-4b12-8b5d-5391ffc24f7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d9095ea-cf62-442a-94a2-e237df42bbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b08697c-2966-4480-a747-99abecda42dc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cabd83c0-5826-465d-b401-604cd1955566");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50da61af-5496-4e5f-bba0-510c14c6e5f7", "6c560b26-a37b-4b26-9f2b-a1e4f7bff109", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0921b8ab-d5c6-4619-81e0-b43f92072264", 0, "c7bfd898-ddba-4b5a-88e1-231dcd414241", null, false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEIrEIOaV6iCheSbpS245QYC9nQThQF95XfBwZJadLW45fXWFKd50ln2fYTG+iHe4YA==", null, false, "c7b664b5-f5d3-4980-afaf-4fce43132783", false, "admin" },
                    { "8112e46a-4766-442e-9fc5-4376440acbe8", 0, "7071c698-c1c8-46b0-82e5-c69db353a337", null, false, false, null, null, "DEMO01", "AQAAAAEAACcQAAAAECY9sCe7ncZEhU0/D31WNcE5VexdcQ40Su+eybUjmsAbXcj9SFeFeeu/X73nKcuoxw==", null, false, "223e7de1-e1c2-4883-aa20-ce1b4a5a1318", false, "demo01" },
                    { "8fc8cf74-57e4-469b-9b64-ecf9640f7e25", 0, "bfcdc538-13fa-4a26-a25b-930c76f0c5a6", null, false, false, null, null, "DEMO04", "AQAAAAEAACcQAAAAEH+hhSh7PdFcgDKB/71hGRiOFO0vdP0/FeEHj8+fvhpcI1cqujkGYPFeV/991MCgaQ==", null, false, "cd65ad0c-b8a8-4efa-b9a4-581fb4c9be6a", false, "demo04" },
                    { "e63e539a-a8ba-4d8c-82b3-7b1aa86fe992", 0, "5e04f3be-b906-44be-add7-0e64e7ed7791", null, false, false, null, null, "DEMO03", "AQAAAAEAACcQAAAAEBZNv8bHuhhAOX+x2qwu6M/ZY6K31haHdXiMlszxTKl4gb8z+jaVgpfDukNRPn1bug==", null, false, "a34a6538-2ab7-4c2c-b753-e4a85306b89a", false, "demo03" },
                    { "ed8a1276-4583-4260-afbd-d974a42de397", 0, "bcb03b0b-6e4e-4155-af25-37947247012b", null, false, false, null, null, "DEMO02", "AQAAAAEAACcQAAAAEN+MphtsmQtaXo1/pEWwpodVHm0HBF+M7bo1Ie8sS3tNtXb8bpMT5LNcjioHP3cUiA==", null, false, "54aabf48-9267-4433-ada1-5572d782560a", false, "demo02" }
                });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 14, 4, 28, 0, 0, DateTimeKind.Unspecified), 186, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 19, 9, 34, 0, 0, DateTimeKind.Unspecified), 3, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 13, 5, 55, 0, 0, DateTimeKind.Unspecified), 43, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 28, 0, 20, 0, 0, DateTimeKind.Unspecified), 8, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 16, 13, 5, 0, 0, DateTimeKind.Unspecified), 162, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 18, 19, 15, 0, 0, DateTimeKind.Unspecified), 146, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 14, 2, 17, 0, 0, DateTimeKind.Unspecified), 258, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 9, 14, 26, 0, 0, DateTimeKind.Unspecified), 131, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 12, 19, 21, 39, 0, 0, DateTimeKind.Unspecified), 150 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 3, 17, 49, 0, 0, DateTimeKind.Unspecified), 136, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 21, 14, 36, 0, 0, DateTimeKind.Unspecified), 125, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 12, 19, 51, 0, 0, DateTimeKind.Unspecified), 222, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 2, 24, 19, 25, 0, 0, DateTimeKind.Unspecified), 95 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 13, 20, 29, 0, 0, DateTimeKind.Unspecified), 5, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 15, 5, 56, 0, 0, DateTimeKind.Unspecified), 68, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 3, 7, 27, 0, 0, DateTimeKind.Unspecified), 101, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 5, 7, 39, 0, 0, DateTimeKind.Unspecified), 69, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 3, 12, 9, 1, 0, 0, DateTimeKind.Unspecified), 258, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 12, 8, 44, 0, 0, DateTimeKind.Unspecified), 260, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 24, 8, 17, 0, 0, DateTimeKind.Unspecified), 1, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 21, 12, 12, 0, 0, DateTimeKind.Unspecified), 61, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 10, 13, 5, 6, 0, 0, DateTimeKind.Unspecified), 192, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 3, 7, 43, 0, 0, DateTimeKind.Unspecified), 202, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 27, 11, 20, 0, 0, DateTimeKind.Unspecified), 271, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 216, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 21, 8, 28, 0, 0, DateTimeKind.Unspecified), 123, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), 177, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 15, 7, 39, 0, 0, DateTimeKind.Unspecified), 119, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 3, 17, 51, 0, 0, DateTimeKind.Unspecified), 131, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 9, 23, 8, 0, 0, DateTimeKind.Unspecified), 165, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 5, 11, 57, 0, 0, DateTimeKind.Unspecified), 37, -20 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 3, 2, 13, 0, 0, DateTimeKind.Unspecified), 12, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 21, 7, 29, 0, 0, DateTimeKind.Unspecified), 45, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 8, 19, 14, 0, 0, DateTimeKind.Unspecified), 292, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 4, 15, 39, 0, 0, DateTimeKind.Unspecified), 166, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 23, 14, 36, 0, 0, DateTimeKind.Unspecified), 297, -1 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 212, -3 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 3, 14, 9, 0, 0, DateTimeKind.Unspecified), 196, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 28, 2, 10, 0, 0, DateTimeKind.Unspecified), 121, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 18, 19, 24, 0, 0, DateTimeKind.Unspecified), 197, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 237, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 5, 6, 57, 0, 0, DateTimeKind.Unspecified), 298, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 10, 7, 42, 0, 0, DateTimeKind.Unspecified), 136, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 8, 12, 37, 0, 0, DateTimeKind.Unspecified), 222, -9 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 3, 4, 53, 0, 0, DateTimeKind.Unspecified), 235, -13 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 3, 7, 26, 0, 0, DateTimeKind.Unspecified), 134, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 12, 1, 19, 34, 0, 0, DateTimeKind.Unspecified), 173, -7 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 6, 20, 2, 7, 0, 0, DateTimeKind.Unspecified), 117, -10 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 10, 23, 30, 0, 0, DateTimeKind.Unspecified), 262, -11 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, -4 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 16, 23, 30, 0, 0, DateTimeKind.Unspecified), 260, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 9, 30, 13, 33, 0, 0, DateTimeKind.Unspecified), 103 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 15, 10, 8, 0, 0, DateTimeKind.Unspecified), 53, -2 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 7, 4, 22, 19, 0, 0, DateTimeKind.Unspecified), 201, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 17, 7, 2, 0, 0, DateTimeKind.Unspecified), 181, -8 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 3, 8, 5, 41, 0, 0, DateTimeKind.Unspecified), 183 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 47, 0, 0, DateTimeKind.Unspecified), 149, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 22, 9, 41, 0, 0, DateTimeKind.Unspecified), 226, -16 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 8, 8, 4, 47, 0, 0, DateTimeKind.Unspecified), 98, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 30, 7, 35, 0, 0, DateTimeKind.Unspecified), 249, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 6, 5, 16, 51, 0, 0, DateTimeKind.Unspecified), 212 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 20, 19, 20, 0, 0, DateTimeKind.Unspecified), 183, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 5, 6, 48, 0, 0, DateTimeKind.Unspecified), 213, -17 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 11, 10, 13, 0, 0, DateTimeKind.Unspecified), 22, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 19, 14, 7, 0, 0, DateTimeKind.Unspecified), 155, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 2, 3, 19, 38, 0, 0, DateTimeKind.Unspecified), 103, -15 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 23, 20, 40, 0, 0, DateTimeKind.Unspecified), 287, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 11, 17, 15, 18, 0, 0, DateTimeKind.Unspecified), 128, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 18, 10, 55, 0, 0, DateTimeKind.Unspecified), 97, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 17, 0, 0, DateTimeKind.Unspecified), 198, -6 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2022, 5, 10, 21, 12, 0, 0, DateTimeKind.Unspecified), 247 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 10, 2, 47, 0, 0, DateTimeKind.Unspecified), 147, -12 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 28, 12, 22, 0, 0, DateTimeKind.Unspecified), 43, -5 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 16, 19, 56, 0, 0, DateTimeKind.Unspecified), 295, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 18, 18, 19, 0, 0, DateTimeKind.Unspecified), 270, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 26, 1, 0, 0, 0, DateTimeKind.Unspecified), 210, -19 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 8, 11, 20, 19, 0, 0, DateTimeKind.Unspecified), 248, -18 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 2, 21, 19, 11, 0, 0, DateTimeKind.Unspecified), 77 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 12, 14, 15, 48, 0, 0, DateTimeKind.Unspecified), 143, -14 });

            migrationBuilder.UpdateData(
                table: "Bestellungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 5, 22, 18, 3, 0, 0, DateTimeKind.Unspecified), 279, -18 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 1, 21, 33, 0, 0, DateTimeKind.Unspecified), 1374, -2 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 30, 13, 39, 0, 0, DateTimeKind.Unspecified), 4634, -8 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 9, 29, 12, 24, 0, 0, DateTimeKind.Unspecified), 4839, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 3, 21, 17, 37, 0, 0, DateTimeKind.Unspecified), 1261, -10 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 10, 25, 12, 5, 0, 0, DateTimeKind.Unspecified), 3328, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 7, 15, 17, 0, 0, DateTimeKind.Unspecified), 2672, -17 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 1, 1, 3, 23, 0, 0, DateTimeKind.Unspecified), 603, -2 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 6, 13, 11, 0, 0, DateTimeKind.Unspecified), 2119, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 14, 20, 6, 0, 0, DateTimeKind.Unspecified), 779, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 4202, -5 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 2, 24, 4, 18, 0, 0, DateTimeKind.Unspecified), 3835, -12 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 12, 14, 12, 0, 0, DateTimeKind.Unspecified), 1423, -19 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 26, 14, 38, 0, 0, DateTimeKind.Unspecified), 1210, -20 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 5, 19, 13, 35, 0, 0, DateTimeKind.Unspecified), 2980, -14 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Date", "Menge" },
                values: new object[] { new DateTime(2023, 12, 9, 3, 46, 0, 0, DateTimeKind.Unspecified), 3844 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 7, 11, 16, 59, 0, 0, DateTimeKind.Unspecified), 2374, -12 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 15, 0, 0, DateTimeKind.Unspecified), 1931, -16 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 11, 28, 22, 48, 0, 0, DateTimeKind.Unspecified), 4695, -11 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 4, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 4933, -4 });

            migrationBuilder.UpdateData(
                table: "Lieferungen",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Date", "Menge", "ProduktId" },
                values: new object[] { new DateTime(2023, 9, 27, 20, 31, 0, 0, DateTimeKind.Unspecified), 3681, -13 });

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -20,
                column: "Name",
                value: "Metallschalter");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -19,
                column: "Name",
                value: "Gummikabel");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -18,
                column: "Name",
                value: "Silberunterlegscheiben");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -17,
                column: "Name",
                value: "Silberzahnräder");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -16,
                column: "Name",
                value: "Plexiglasmuttern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -15,
                column: "Name",
                value: "Aluminiummuttern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -14,
                column: "Name",
                value: "Bronzebolzen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -13,
                column: "Name",
                value: "Kunststoffdichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -12,
                column: "Name",
                value: "Kupferdichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -11,
                column: "Name",
                value: "Plexiglasunterlegscheiben");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -10,
                column: "Name",
                value: "Papiergehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -9,
                column: "Name",
                value: "Betonriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -8,
                column: "Name",
                value: "Steindichtungen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -7,
                column: "Name",
                value: "Keramikventile");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -6,
                column: "Name",
                value: "Gummimuttern");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -5,
                column: "Name",
                value: "Stahlkabel");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -4,
                column: "Name",
                value: "Aluminiumgehäuse");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -3,
                column: "Name",
                value: "Aluminiumriemen");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -2,
                column: "Name",
                value: "Aluminiumsensoren");

            migrationBuilder.UpdateData(
                table: "Produkte",
                keyColumn: "Id",
                keyValue: -1,
                column: "Name",
                value: "Textilfilter");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50da61af-5496-4e5f-bba0-510c14c6e5f7", "0921b8ab-d5c6-4619-81e0-b43f92072264" });
        }
    }
}
