using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produkte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bestellungen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bestellungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bestellungen_Produkte_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkte",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lieferungen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieferungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lieferungen_Produkte_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkte",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktId = table.Column<int>(type: "int", nullable: false),
                    BestellungId = table.Column<int>(type: "int", nullable: false),
                    LieferungId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewModel_Bestellungen_BestellungId",
                        column: x => x.BestellungId,
                        principalTable: "Bestellungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewModel_Lieferungen_LieferungId",
                        column: x => x.LieferungId,
                        principalTable: "Lieferungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewModel_Produkte_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a1fa31e3-89db-408e-b7bd-cb90b6468a89", "18ffc6a9-42fe-4812-91e9-278b7812aee0", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06070146-1f25-49bc-8be7-b5a2b0b2abb4", 0, "37858770-cc61-4ba3-8ad0-d6c3fe06689f", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIQL99QUv+dVMq9zNSkdfpLUFv0hThSMOE+TjYvPrtOyV7HUZlsizaEa+NR4fsFVtg==", null, false, "767fe920-9325-4942-a794-e6008df4ee86", false, "admin@gmail.com" },
                    { "17419a28-5b7b-4ef7-b3c6-5dc087b04e60", 0, "98baba0a-e6ba-4ef0-8f9e-9852c43a4e12", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEMMX++vM0214m0MTMYh/J2EaMRBXbV9h0wjwLBvzsfvzz2j3X5TfuH8jXDgXeEzyqw==", null, false, "be886128-c8f6-40f2-bc66-c233552acfa9", false, "demo03@gmail.com" },
                    { "611000d3-5b87-4967-ac7a-1c7704edc533", 0, "c2413b22-45e3-4029-9ebc-44cf5b16c1d8", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAEDY0N0WeQEeBGurr2E142lDMQOysD4Kbj2cnlYf1d+f/D2grchH6Zt2Oyw4f9FvF1Q==", null, false, "17513adb-1c07-422e-b54f-988ea731ab77", false, "demo02@gmail.com" },
                    { "b7047b5c-1431-425b-b249-a7df9f6d4be0", 0, "cb663274-e84b-4f6b-85b6-dfa72a538cc8", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAEBzjOnt7Jke3H7jHwCIgJt9YC0RtA0rFVxEYVhq3xSCFtR8lrN3EsUgbesRP0cUa1g==", null, false, "35cb832e-5db1-489c-93bd-07713834fc22", false, "demo01@gmail.com" },
                    { "cb42b4b8-c148-48ba-a88a-213224928ba5", 0, "f3b5396f-89a3-4d9c-8f4f-a754ac1c62a8", null, false, false, null, null, "DEMO04@GMAIL.COM", "AQAAAAEAACcQAAAAEIthy7e3nRqj2aSCgtN3o1z1GwAh6/DRBFLK2WMWpKPLWF6kRJVvtEwvVLGRQ2OJag==", null, false, "630bfd0e-b9e3-47b3-8e3c-dfda8030302b", false, "demo04@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Produkte",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -20, "Textilgehäuse" },
                    { -19, "Textilkabel" },
                    { -18, "Keramikrohre" },
                    { -17, "Acrylzahnräder" },
                    { -16, "Silberkabel" },
                    { -15, "Textilriemen" },
                    { -14, "Glasunterlegscheiben" },
                    { -13, "Gummischrauben" },
                    { -12, "Kunststoffriemen" },
                    { -11, "Textilmuttern" },
                    { -10, "Keramikschrauben" },
                    { -9, "Silberschalter" },
                    { -8, "Glasunterlegscheiben" },
                    { -7, "Keramikunterlegscheiben" },
                    { -6, "Goldrohre" },
                    { -5, "Titangehäuse" },
                    { -4, "Textilfedern" },
                    { -3, "Acrylschalter" },
                    { -2, "Glasgehäuse" },
                    { -1, "Titanfilter" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1fa31e3-89db-408e-b7bd-cb90b6468a89", "06070146-1f25-49bc-8be7-b5a2b0b2abb4" });

            migrationBuilder.InsertData(
                table: "Bestellungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -80, new DateTime(2022, 7, 17, 4, 14, 0, 0, DateTimeKind.Unspecified), 243, -4 },
                    { -79, new DateTime(2022, 5, 15, 15, 36, 0, 0, DateTimeKind.Unspecified), 287, -7 },
                    { -78, new DateTime(2022, 5, 29, 1, 40, 0, 0, DateTimeKind.Unspecified), 253, -15 },
                    { -77, new DateTime(2023, 11, 19, 19, 25, 0, 0, DateTimeKind.Unspecified), 283, -3 },
                    { -76, new DateTime(2023, 4, 9, 5, 9, 0, 0, DateTimeKind.Unspecified), 174, -2 },
                    { -75, new DateTime(2022, 5, 22, 23, 33, 0, 0, DateTimeKind.Unspecified), 208, -2 },
                    { -74, new DateTime(2022, 3, 22, 18, 41, 0, 0, DateTimeKind.Unspecified), 267, -12 },
                    { -73, new DateTime(2023, 4, 24, 1, 3, 0, 0, DateTimeKind.Unspecified), 227, -13 },
                    { -72, new DateTime(2022, 11, 10, 14, 4, 0, 0, DateTimeKind.Unspecified), 5, -1 },
                    { -71, new DateTime(2022, 3, 5, 1, 49, 0, 0, DateTimeKind.Unspecified), 146, -11 },
                    { -70, new DateTime(2022, 8, 30, 2, 47, 0, 0, DateTimeKind.Unspecified), 98, -7 },
                    { -69, new DateTime(2022, 4, 12, 12, 36, 0, 0, DateTimeKind.Unspecified), 150, -16 },
                    { -68, new DateTime(2023, 6, 10, 10, 41, 0, 0, DateTimeKind.Unspecified), 183, -2 },
                    { -67, new DateTime(2022, 3, 20, 17, 21, 0, 0, DateTimeKind.Unspecified), 5, -9 },
                    { -66, new DateTime(2022, 7, 16, 12, 56, 0, 0, DateTimeKind.Unspecified), 261, -4 },
                    { -65, new DateTime(2023, 8, 15, 3, 57, 0, 0, DateTimeKind.Unspecified), 52, -11 },
                    { -64, new DateTime(2022, 11, 18, 21, 34, 0, 0, DateTimeKind.Unspecified), 36, -17 },
                    { -63, new DateTime(2022, 5, 29, 7, 38, 0, 0, DateTimeKind.Unspecified), 28, -12 },
                    { -62, new DateTime(2023, 7, 23, 11, 2, 0, 0, DateTimeKind.Unspecified), 156, -10 },
                    { -61, new DateTime(2023, 4, 29, 14, 43, 0, 0, DateTimeKind.Unspecified), 142, -6 },
                    { -60, new DateTime(2022, 3, 1, 23, 1, 0, 0, DateTimeKind.Unspecified), 171, -6 },
                    { -59, new DateTime(2023, 11, 18, 21, 14, 0, 0, DateTimeKind.Unspecified), 162, -17 },
                    { -58, new DateTime(2022, 3, 23, 21, 31, 0, 0, DateTimeKind.Unspecified), 164, -1 },
                    { -57, new DateTime(2022, 5, 13, 21, 2, 0, 0, DateTimeKind.Unspecified), 172, -5 },
                    { -56, new DateTime(2023, 12, 8, 9, 26, 0, 0, DateTimeKind.Unspecified), 268, -16 },
                    { -55, new DateTime(2023, 12, 21, 19, 9, 0, 0, DateTimeKind.Unspecified), 156, -13 },
                    { -54, new DateTime(2023, 6, 17, 15, 26, 0, 0, DateTimeKind.Unspecified), 246, -7 },
                    { -53, new DateTime(2023, 4, 7, 11, 55, 0, 0, DateTimeKind.Unspecified), 70, -20 },
                    { -52, new DateTime(2023, 5, 28, 10, 13, 0, 0, DateTimeKind.Unspecified), 184, -6 },
                    { -51, new DateTime(2022, 10, 4, 18, 47, 0, 0, DateTimeKind.Unspecified), 284, -15 },
                    { -50, new DateTime(2023, 9, 12, 4, 21, 0, 0, DateTimeKind.Unspecified), 119, -6 },
                    { -49, new DateTime(2022, 2, 11, 14, 45, 0, 0, DateTimeKind.Unspecified), 104, -20 },
                    { -48, new DateTime(2022, 2, 14, 16, 45, 0, 0, DateTimeKind.Unspecified), 223, -20 },
                    { -47, new DateTime(2023, 10, 2, 3, 26, 0, 0, DateTimeKind.Unspecified), 36, -9 },
                    { -46, new DateTime(2023, 8, 14, 23, 33, 0, 0, DateTimeKind.Unspecified), 149, -14 },
                    { -45, new DateTime(2022, 11, 30, 17, 22, 0, 0, DateTimeKind.Unspecified), 274, -10 },
                    { -44, new DateTime(2023, 3, 2, 21, 41, 0, 0, DateTimeKind.Unspecified), 158, -14 },
                    { -43, new DateTime(2023, 10, 26, 1, 45, 0, 0, DateTimeKind.Unspecified), 128, -3 },
                    { -42, new DateTime(2023, 6, 28, 23, 42, 0, 0, DateTimeKind.Unspecified), 237, -1 },
                    { -41, new DateTime(2022, 10, 7, 0, 7, 0, 0, DateTimeKind.Unspecified), 293, -1 },
                    { -40, new DateTime(2022, 9, 3, 9, 52, 0, 0, DateTimeKind.Unspecified), 65, -19 },
                    { -39, new DateTime(2022, 5, 23, 23, 29, 0, 0, DateTimeKind.Unspecified), 176, -20 },
                    { -38, new DateTime(2022, 12, 28, 13, 22, 0, 0, DateTimeKind.Unspecified), 165, -14 },
                    { -37, new DateTime(2023, 1, 21, 6, 56, 0, 0, DateTimeKind.Unspecified), 229, -8 },
                    { -36, new DateTime(2022, 10, 28, 21, 21, 0, 0, DateTimeKind.Unspecified), 186, -12 },
                    { -35, new DateTime(2023, 6, 25, 6, 52, 0, 0, DateTimeKind.Unspecified), 149, -3 },
                    { -34, new DateTime(2023, 8, 19, 23, 43, 0, 0, DateTimeKind.Unspecified), 125, -18 },
                    { -33, new DateTime(2022, 2, 24, 23, 55, 0, 0, DateTimeKind.Unspecified), 273, -18 },
                    { -32, new DateTime(2022, 4, 19, 15, 26, 0, 0, DateTimeKind.Unspecified), 192, -5 },
                    { -31, new DateTime(2023, 1, 11, 0, 29, 0, 0, DateTimeKind.Unspecified), 129, -12 },
                    { -30, new DateTime(2023, 11, 29, 23, 46, 0, 0, DateTimeKind.Unspecified), 268, -18 },
                    { -29, new DateTime(2023, 11, 21, 21, 59, 0, 0, DateTimeKind.Unspecified), 174, -17 },
                    { -28, new DateTime(2022, 1, 30, 17, 38, 0, 0, DateTimeKind.Unspecified), 78, -6 },
                    { -27, new DateTime(2023, 11, 19, 16, 18, 0, 0, DateTimeKind.Unspecified), 214, -4 },
                    { -26, new DateTime(2022, 5, 12, 1, 40, 0, 0, DateTimeKind.Unspecified), 163, -11 },
                    { -25, new DateTime(2022, 8, 19, 5, 14, 0, 0, DateTimeKind.Unspecified), 117, -18 },
                    { -24, new DateTime(2023, 12, 14, 7, 32, 0, 0, DateTimeKind.Unspecified), 42, -2 },
                    { -23, new DateTime(2023, 6, 22, 2, 24, 0, 0, DateTimeKind.Unspecified), 281, -14 },
                    { -22, new DateTime(2023, 7, 19, 0, 54, 0, 0, DateTimeKind.Unspecified), 101, -19 },
                    { -21, new DateTime(2023, 11, 17, 15, 47, 0, 0, DateTimeKind.Unspecified), 133, -14 },
                    { -20, new DateTime(2023, 7, 12, 14, 55, 0, 0, DateTimeKind.Unspecified), 158, -5 },
                    { -19, new DateTime(2022, 4, 25, 15, 34, 0, 0, DateTimeKind.Unspecified), 107, -14 },
                    { -18, new DateTime(2023, 4, 9, 3, 51, 0, 0, DateTimeKind.Unspecified), 250, -16 },
                    { -17, new DateTime(2023, 8, 4, 18, 50, 0, 0, DateTimeKind.Unspecified), 119, -8 },
                    { -16, new DateTime(2023, 10, 25, 19, 33, 0, 0, DateTimeKind.Unspecified), 210, -10 },
                    { -15, new DateTime(2022, 11, 26, 6, 42, 0, 0, DateTimeKind.Unspecified), 225, -8 },
                    { -14, new DateTime(2023, 11, 16, 23, 29, 0, 0, DateTimeKind.Unspecified), 293, -12 },
                    { -13, new DateTime(2022, 6, 4, 10, 39, 0, 0, DateTimeKind.Unspecified), 102, -18 },
                    { -12, new DateTime(2023, 7, 20, 22, 38, 0, 0, DateTimeKind.Unspecified), 197, -13 },
                    { -11, new DateTime(2022, 2, 3, 8, 41, 0, 0, DateTimeKind.Unspecified), 264, -7 },
                    { -10, new DateTime(2022, 4, 2, 3, 53, 0, 0, DateTimeKind.Unspecified), 85, -16 },
                    { -9, new DateTime(2022, 3, 9, 8, 49, 0, 0, DateTimeKind.Unspecified), 155, -14 },
                    { -8, new DateTime(2022, 2, 8, 15, 49, 0, 0, DateTimeKind.Unspecified), 119, -20 },
                    { -7, new DateTime(2023, 8, 25, 2, 54, 0, 0, DateTimeKind.Unspecified), 295, -3 },
                    { -6, new DateTime(2023, 10, 1, 21, 3, 0, 0, DateTimeKind.Unspecified), 185, -19 },
                    { -5, new DateTime(2023, 12, 3, 15, 9, 0, 0, DateTimeKind.Unspecified), 171, -17 },
                    { -4, new DateTime(2022, 12, 8, 5, 47, 0, 0, DateTimeKind.Unspecified), 288, -4 },
                    { -3, new DateTime(2022, 10, 28, 2, 9, 0, 0, DateTimeKind.Unspecified), 46, -19 },
                    { -2, new DateTime(2023, 4, 25, 10, 39, 0, 0, DateTimeKind.Unspecified), 209, -7 },
                    { -1, new DateTime(2023, 7, 10, 3, 15, 0, 0, DateTimeKind.Unspecified), 123, -3 }
                });

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -20, new DateTime(2023, 2, 9, 12, 39, 0, 0, DateTimeKind.Unspecified), 4276, -4 },
                    { -19, new DateTime(2022, 3, 11, 14, 23, 0, 0, DateTimeKind.Unspecified), 4923, -11 },
                    { -18, new DateTime(2022, 4, 29, 22, 19, 0, 0, DateTimeKind.Unspecified), 3790, -1 },
                    { -17, new DateTime(2022, 9, 30, 15, 29, 0, 0, DateTimeKind.Unspecified), 1497, -11 },
                    { -16, new DateTime(2022, 5, 6, 23, 50, 0, 0, DateTimeKind.Unspecified), 643, -16 },
                    { -15, new DateTime(2022, 3, 22, 13, 17, 0, 0, DateTimeKind.Unspecified), 3678, -5 },
                    { -14, new DateTime(2022, 11, 23, 23, 58, 0, 0, DateTimeKind.Unspecified), 4483, -14 },
                    { -13, new DateTime(2023, 9, 24, 21, 25, 0, 0, DateTimeKind.Unspecified), 3494, -11 },
                    { -12, new DateTime(2022, 4, 26, 0, 11, 0, 0, DateTimeKind.Unspecified), 2507, -11 },
                    { -11, new DateTime(2023, 7, 29, 9, 58, 0, 0, DateTimeKind.Unspecified), 4202, -1 },
                    { -10, new DateTime(2022, 1, 19, 1, 54, 0, 0, DateTimeKind.Unspecified), 2188, -3 },
                    { -9, new DateTime(2022, 10, 19, 5, 8, 0, 0, DateTimeKind.Unspecified), 2434, -9 },
                    { -8, new DateTime(2022, 12, 28, 9, 7, 0, 0, DateTimeKind.Unspecified), 922, -12 },
                    { -7, new DateTime(2022, 7, 4, 14, 26, 0, 0, DateTimeKind.Unspecified), 501, -6 },
                    { -6, new DateTime(2022, 4, 16, 23, 26, 0, 0, DateTimeKind.Unspecified), 4787, -11 },
                    { -5, new DateTime(2022, 4, 19, 19, 51, 0, 0, DateTimeKind.Unspecified), 942, -17 },
                    { -4, new DateTime(2022, 6, 20, 8, 40, 0, 0, DateTimeKind.Unspecified), 4682, -19 },
                    { -3, new DateTime(2022, 10, 18, 18, 23, 0, 0, DateTimeKind.Unspecified), 3494, -16 },
                    { -2, new DateTime(2022, 8, 28, 14, 8, 0, 0, DateTimeKind.Unspecified), 4533, -12 },
                    { -1, new DateTime(2023, 12, 2, 14, 59, 0, 0, DateTimeKind.Unspecified), 3932, -8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bestellungen_ProduktId",
                table: "Bestellungen",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_Lieferungen_ProduktId",
                table: "Lieferungen",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_BestellungId",
                table: "ViewModel",
                column: "BestellungId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_LieferungId",
                table: "ViewModel",
                column: "LieferungId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewModel_ProduktId",
                table: "ViewModel",
                column: "ProduktId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ViewModel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bestellungen");

            migrationBuilder.DropTable(
                name: "Lieferungen");

            migrationBuilder.DropTable(
                name: "Produkte");
        }
    }
}
