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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0df742c-e23b-4b52-b2bd-f9f0880d3263", "c93aee0a-2d27-49bd-85f9-ba259dc8d5a7", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3c23a689-91bd-4cac-bcd7-c359d1f88f51", 0, "6d332665-6258-4c65-96eb-8999f080f39e", null, false, false, null, null, "DEMO03@GMAIL.COM", "AQAAAAEAACcQAAAAEMqsuWdoqBcrzg9PvGuMNysE34Tk3JbSSDolg2cZVzFbr7MegNAQVeD53ePWTbwi9w==", null, false, "f8b0683e-f26c-4b1e-a0ea-9641dddb81d6", false, "demo03@gmail.com" },
                    { "9fad4c83-847d-4fac-88d1-013234a00b30", 0, "a4d6837f-9b0d-4c9d-ad81-2dfb9130f452", null, false, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELVmg0Va4AR2EcDqEf9V346p7myjabz/GynD+W6WfLmqtnypMtufR4y7hA6EpNceYg==", null, false, "95b4e9e1-1382-4109-8dd9-76e42bfeaeed", false, "admin@gmail.com" },
                    { "c60023c7-82ac-4424-9824-7f1bb03a62c7", 0, "35c5bc97-0889-427e-ac90-0698c4dfab9e", null, false, false, null, null, "DEMO02@GMAIL.COM", "AQAAAAEAACcQAAAAEKXUzdwaFlJ4I6oi2u97ZeTGTg4urVnSXtpxIL4PuJ/pGycowFC2G4QCzw63+80rPA==", null, false, "39b8187c-803d-47b5-9c97-600cb61a7d96", false, "demo02@gmail.com" },
                    { "fab4f32a-be2c-4391-b38a-fc877ffa67a6", 0, "4d1289d3-f15f-462f-a59a-bc77d6f4ed20", null, false, false, null, null, "DEMO01@GMAIL.COM", "AQAAAAEAACcQAAAAENiijOdcpZB+hDgOlJVin1Fl0Po9tiPkS6GZfvQJGmWycZE4ji+nAFLR43rAQtgpcg==", null, false, "af305aac-9bbd-4372-8a1f-d208ac6dead5", false, "demo01@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Produkte",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -20, "Goldbolzen" },
                    { -19, "Silbermuttern" },
                    { -18, "Keramikzahnräder" },
                    { -17, "Kupferdichtungen" },
                    { -16, "Acryldichtungen" },
                    { -15, "Aluminiumunterlegscheiben" },
                    { -14, "Aluminiumschrauben" },
                    { -13, "Steinrohre" },
                    { -12, "Keramikschalter" },
                    { -11, "Glaszahnräder" },
                    { -10, "Titanrohre" },
                    { -9, "Metallventile" },
                    { -8, "Kupferkabel" },
                    { -7, "Textilschalter" },
                    { -6, "Aluminiumgehäuse" },
                    { -5, "Papiersensoren" },
                    { -4, "Acrylbolzen" },
                    { -3, "Aluminiumplatten" },
                    { -2, "Glaskabel" },
                    { -1, "Glaskabel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f0df742c-e23b-4b52-b2bd-f9f0880d3263", "9fad4c83-847d-4fac-88d1-013234a00b30" });

            migrationBuilder.InsertData(
                table: "Bestellungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -80, new DateTime(2023, 1, 29, 0, 57, 0, 0, DateTimeKind.Unspecified), 173, -13 },
                    { -79, new DateTime(2023, 9, 22, 5, 53, 0, 0, DateTimeKind.Unspecified), 16, -4 },
                    { -78, new DateTime(2023, 3, 23, 0, 48, 0, 0, DateTimeKind.Unspecified), 292, -20 },
                    { -77, new DateTime(2022, 3, 29, 5, 48, 0, 0, DateTimeKind.Unspecified), 23, -13 },
                    { -76, new DateTime(2022, 6, 12, 18, 4, 0, 0, DateTimeKind.Unspecified), 118, -7 },
                    { -75, new DateTime(2023, 11, 13, 17, 36, 0, 0, DateTimeKind.Unspecified), 15, -10 },
                    { -74, new DateTime(2023, 11, 16, 10, 42, 0, 0, DateTimeKind.Unspecified), 53, -5 },
                    { -73, new DateTime(2023, 5, 18, 11, 15, 0, 0, DateTimeKind.Unspecified), 37, -20 },
                    { -72, new DateTime(2022, 9, 18, 22, 38, 0, 0, DateTimeKind.Unspecified), 255, -4 },
                    { -71, new DateTime(2022, 6, 16, 9, 37, 0, 0, DateTimeKind.Unspecified), 153, -7 },
                    { -70, new DateTime(2022, 1, 13, 16, 55, 0, 0, DateTimeKind.Unspecified), 237, -16 },
                    { -69, new DateTime(2023, 4, 5, 2, 18, 0, 0, DateTimeKind.Unspecified), 203, -12 },
                    { -68, new DateTime(2022, 6, 26, 23, 12, 0, 0, DateTimeKind.Unspecified), 217, -1 },
                    { -67, new DateTime(2023, 7, 4, 6, 30, 0, 0, DateTimeKind.Unspecified), 237, -7 },
                    { -66, new DateTime(2022, 12, 31, 21, 49, 0, 0, DateTimeKind.Unspecified), 11, -18 },
                    { -65, new DateTime(2022, 7, 19, 17, 40, 0, 0, DateTimeKind.Unspecified), 78, -9 },
                    { -64, new DateTime(2022, 12, 29, 16, 39, 0, 0, DateTimeKind.Unspecified), 88, -8 },
                    { -63, new DateTime(2022, 8, 10, 21, 30, 0, 0, DateTimeKind.Unspecified), 269, -10 },
                    { -62, new DateTime(2023, 4, 25, 1, 36, 0, 0, DateTimeKind.Unspecified), 32, -8 },
                    { -61, new DateTime(2023, 3, 1, 5, 31, 0, 0, DateTimeKind.Unspecified), 27, -8 },
                    { -60, new DateTime(2022, 4, 28, 20, 2, 0, 0, DateTimeKind.Unspecified), 1, -7 },
                    { -59, new DateTime(2023, 5, 3, 8, 58, 0, 0, DateTimeKind.Unspecified), 298, -16 },
                    { -58, new DateTime(2023, 2, 9, 15, 51, 0, 0, DateTimeKind.Unspecified), 270, -10 },
                    { -57, new DateTime(2023, 3, 22, 23, 8, 0, 0, DateTimeKind.Unspecified), 63, -17 },
                    { -56, new DateTime(2023, 8, 12, 17, 21, 0, 0, DateTimeKind.Unspecified), 103, -14 },
                    { -55, new DateTime(2022, 5, 14, 13, 40, 0, 0, DateTimeKind.Unspecified), 103, -11 },
                    { -54, new DateTime(2022, 8, 8, 1, 6, 0, 0, DateTimeKind.Unspecified), 156, -8 },
                    { -53, new DateTime(2023, 1, 28, 17, 5, 0, 0, DateTimeKind.Unspecified), 64, -14 },
                    { -52, new DateTime(2023, 2, 8, 10, 28, 0, 0, DateTimeKind.Unspecified), 33, -4 },
                    { -51, new DateTime(2023, 1, 28, 20, 6, 0, 0, DateTimeKind.Unspecified), 255, -10 },
                    { -50, new DateTime(2022, 8, 8, 23, 44, 0, 0, DateTimeKind.Unspecified), 84, -16 },
                    { -49, new DateTime(2022, 7, 23, 7, 24, 0, 0, DateTimeKind.Unspecified), 71, -4 },
                    { -48, new DateTime(2022, 3, 26, 0, 35, 0, 0, DateTimeKind.Unspecified), 241, -3 },
                    { -47, new DateTime(2022, 8, 9, 6, 50, 0, 0, DateTimeKind.Unspecified), 30, -3 },
                    { -46, new DateTime(2022, 9, 13, 5, 25, 0, 0, DateTimeKind.Unspecified), 247, -18 },
                    { -45, new DateTime(2022, 1, 21, 17, 19, 0, 0, DateTimeKind.Unspecified), 25, -14 },
                    { -44, new DateTime(2022, 12, 14, 12, 42, 0, 0, DateTimeKind.Unspecified), 141, -7 },
                    { -43, new DateTime(2022, 3, 3, 1, 58, 0, 0, DateTimeKind.Unspecified), 61, -10 },
                    { -42, new DateTime(2023, 10, 22, 5, 5, 0, 0, DateTimeKind.Unspecified), 161, -10 },
                    { -41, new DateTime(2023, 10, 5, 22, 14, 0, 0, DateTimeKind.Unspecified), 87, -13 },
                    { -40, new DateTime(2023, 11, 18, 1, 54, 0, 0, DateTimeKind.Unspecified), 189, -20 },
                    { -39, new DateTime(2022, 5, 14, 12, 18, 0, 0, DateTimeKind.Unspecified), 9, -2 },
                    { -38, new DateTime(2023, 3, 22, 18, 13, 0, 0, DateTimeKind.Unspecified), 28, -11 },
                    { -37, new DateTime(2023, 6, 4, 22, 14, 0, 0, DateTimeKind.Unspecified), 4, -10 },
                    { -36, new DateTime(2022, 9, 3, 2, 14, 0, 0, DateTimeKind.Unspecified), 48, -16 },
                    { -35, new DateTime(2022, 1, 25, 2, 37, 0, 0, DateTimeKind.Unspecified), 4, -5 },
                    { -34, new DateTime(2023, 3, 31, 13, 43, 0, 0, DateTimeKind.Unspecified), 71, -8 },
                    { -33, new DateTime(2023, 7, 15, 3, 8, 0, 0, DateTimeKind.Unspecified), 269, -5 },
                    { -32, new DateTime(2022, 3, 19, 22, 9, 0, 0, DateTimeKind.Unspecified), 219, -5 },
                    { -31, new DateTime(2022, 10, 3, 5, 33, 0, 0, DateTimeKind.Unspecified), 203, -2 },
                    { -30, new DateTime(2023, 8, 3, 0, 17, 0, 0, DateTimeKind.Unspecified), 132, -1 },
                    { -29, new DateTime(2023, 8, 9, 4, 52, 0, 0, DateTimeKind.Unspecified), 60, -3 },
                    { -28, new DateTime(2022, 10, 5, 10, 25, 0, 0, DateTimeKind.Unspecified), 173, -17 },
                    { -27, new DateTime(2023, 2, 27, 4, 34, 0, 0, DateTimeKind.Unspecified), 112, -7 },
                    { -26, new DateTime(2022, 6, 28, 18, 9, 0, 0, DateTimeKind.Unspecified), 2, -10 },
                    { -25, new DateTime(2023, 12, 29, 3, 39, 0, 0, DateTimeKind.Unspecified), 295, -6 },
                    { -24, new DateTime(2022, 6, 25, 21, 46, 0, 0, DateTimeKind.Unspecified), 250, -11 },
                    { -23, new DateTime(2022, 3, 29, 2, 7, 0, 0, DateTimeKind.Unspecified), 119, -7 },
                    { -22, new DateTime(2023, 12, 28, 10, 1, 0, 0, DateTimeKind.Unspecified), 201, -4 },
                    { -21, new DateTime(2022, 9, 13, 4, 22, 0, 0, DateTimeKind.Unspecified), 194, -19 },
                    { -20, new DateTime(2022, 12, 20, 14, 42, 0, 0, DateTimeKind.Unspecified), 54, -20 },
                    { -19, new DateTime(2023, 12, 25, 3, 12, 0, 0, DateTimeKind.Unspecified), 97, -18 },
                    { -18, new DateTime(2023, 4, 10, 18, 58, 0, 0, DateTimeKind.Unspecified), 65, -5 },
                    { -17, new DateTime(2023, 10, 22, 21, 48, 0, 0, DateTimeKind.Unspecified), 220, -19 },
                    { -16, new DateTime(2022, 8, 1, 9, 37, 0, 0, DateTimeKind.Unspecified), 22, -9 },
                    { -15, new DateTime(2022, 4, 9, 3, 3, 0, 0, DateTimeKind.Unspecified), 55, -3 },
                    { -14, new DateTime(2023, 7, 4, 10, 55, 0, 0, DateTimeKind.Unspecified), 126, -4 },
                    { -13, new DateTime(2023, 2, 22, 21, 27, 0, 0, DateTimeKind.Unspecified), 163, -9 },
                    { -12, new DateTime(2022, 8, 26, 22, 57, 0, 0, DateTimeKind.Unspecified), 145, -11 },
                    { -11, new DateTime(2022, 11, 27, 12, 1, 0, 0, DateTimeKind.Unspecified), 227, -4 },
                    { -10, new DateTime(2023, 1, 6, 17, 22, 0, 0, DateTimeKind.Unspecified), 179, -15 },
                    { -9, new DateTime(2022, 7, 28, 3, 26, 0, 0, DateTimeKind.Unspecified), 194, -7 },
                    { -8, new DateTime(2023, 11, 23, 12, 42, 0, 0, DateTimeKind.Unspecified), 252, -18 },
                    { -7, new DateTime(2023, 5, 10, 21, 39, 0, 0, DateTimeKind.Unspecified), 112, -17 },
                    { -6, new DateTime(2023, 1, 31, 16, 35, 0, 0, DateTimeKind.Unspecified), 40, -15 },
                    { -5, new DateTime(2022, 9, 30, 9, 24, 0, 0, DateTimeKind.Unspecified), 175, -3 },
                    { -4, new DateTime(2022, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 141, -17 },
                    { -3, new DateTime(2022, 5, 31, 3, 0, 0, 0, DateTimeKind.Unspecified), 127, -12 },
                    { -2, new DateTime(2023, 2, 7, 5, 28, 0, 0, DateTimeKind.Unspecified), 207, -11 },
                    { -1, new DateTime(2022, 4, 28, 8, 57, 0, 0, DateTimeKind.Unspecified), 103, -1 }
                });

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -20, new DateTime(2023, 3, 7, 9, 30, 0, 0, DateTimeKind.Unspecified), 1184, -10 },
                    { -19, new DateTime(2022, 5, 13, 10, 29, 0, 0, DateTimeKind.Unspecified), 1848, -16 },
                    { -18, new DateTime(2022, 12, 5, 1, 56, 0, 0, DateTimeKind.Unspecified), 2630, -15 },
                    { -17, new DateTime(2023, 11, 15, 10, 53, 0, 0, DateTimeKind.Unspecified), 842, -19 },
                    { -16, new DateTime(2023, 7, 5, 2, 59, 0, 0, DateTimeKind.Unspecified), 3374, -11 },
                    { -15, new DateTime(2022, 10, 11, 7, 17, 0, 0, DateTimeKind.Unspecified), 2946, -15 },
                    { -14, new DateTime(2023, 4, 22, 15, 34, 0, 0, DateTimeKind.Unspecified), 4045, -6 },
                    { -13, new DateTime(2023, 11, 15, 22, 20, 0, 0, DateTimeKind.Unspecified), 1089, -20 },
                    { -12, new DateTime(2022, 6, 30, 14, 44, 0, 0, DateTimeKind.Unspecified), 849, -16 },
                    { -11, new DateTime(2023, 9, 24, 21, 23, 0, 0, DateTimeKind.Unspecified), 930, -12 },
                    { -10, new DateTime(2023, 10, 26, 7, 8, 0, 0, DateTimeKind.Unspecified), 2024, -12 },
                    { -9, new DateTime(2023, 12, 23, 14, 23, 0, 0, DateTimeKind.Unspecified), 576, -5 },
                    { -8, new DateTime(2023, 6, 22, 21, 44, 0, 0, DateTimeKind.Unspecified), 1779, -16 },
                    { -7, new DateTime(2022, 4, 10, 19, 9, 0, 0, DateTimeKind.Unspecified), 1804, -5 },
                    { -6, new DateTime(2023, 5, 27, 7, 27, 0, 0, DateTimeKind.Unspecified), 1698, -16 },
                    { -5, new DateTime(2023, 12, 14, 19, 49, 0, 0, DateTimeKind.Unspecified), 2047, -8 },
                    { -4, new DateTime(2023, 5, 19, 15, 44, 0, 0, DateTimeKind.Unspecified), 4773, -13 },
                    { -3, new DateTime(2023, 10, 2, 23, 31, 0, 0, DateTimeKind.Unspecified), 1462, -3 },
                    { -2, new DateTime(2023, 8, 3, 15, 6, 0, 0, DateTimeKind.Unspecified), 1243, -17 },
                    { -1, new DateTime(2022, 9, 30, 8, 2, 0, 0, DateTimeKind.Unspecified), 755, -2 }
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
                name: "Bestellungen");

            migrationBuilder.DropTable(
                name: "Lieferungen");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Produkte");
        }
    }
}
