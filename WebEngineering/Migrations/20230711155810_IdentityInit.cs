using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class IdentityInit : Migration
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ProduktId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lieferungen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktId = table.Column<int>(type: "int", nullable: false),
                    BestellungId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Menge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lieferungen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lieferungen_Bestellungen_BestellungId",
                        column: x => x.BestellungId,
                        principalTable: "Bestellungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Lieferungen_Produkte_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Produkte",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -80, "Silberunterlegscheiben" },
                    { -79, "Keramikriemen" },
                    { -78, "Bronzesensoren" },
                    { -77, "Textilpumpen" },
                    { -76, "Keramikunterlegscheiben" },
                    { -75, "Titangehäuse" },
                    { -74, "Silberzahnräder" },
                    { -73, "Silberkabel" },
                    { -72, "Keramikfedern" },
                    { -71, "Steinsensoren" },
                    { -70, "Goldmuttern" },
                    { -69, "Gummigehäuse" },
                    { -68, "Gummipumpen" },
                    { -67, "Textilrohre" },
                    { -66, "Papierfilter" },
                    { -65, "Goldplatten" },
                    { -64, "Glasventile" },
                    { -63, "Metallmuttern" },
                    { -62, "Acryldichtungen" },
                    { -61, "Aluminiummuttern" },
                    { -60, "Silberrohre" },
                    { -59, "Plexiglasbolzen" },
                    { -58, "Keramikbolzen" },
                    { -57, "Aluminiumbolzen" },
                    { -56, "Keramikpumpen" },
                    { -55, "Glasriemen" },
                    { -54, "Acrylsensoren" },
                    { -53, "Acrylkabel" },
                    { -52, "Bronzemuttern" },
                    { -51, "Steinpumpen" },
                    { -50, "Steinfilter" },
                    { -49, "Kunststoffriemen" },
                    { -48, "Bronzebolzen" },
                    { -47, "Plexiglaspumpen" },
                    { -46, "Textilgehäuse" },
                    { -45, "Aluminiumventile" },
                    { -44, "Aluminiumventile" },
                    { -43, "Textilgehäuse" },
                    { -42, "Stahlschrauben" },
                    { -41, "Textilventile" },
                    { -40, "Bronzeventile" },
                    { -39, "Steindichtungen" },
                    { -38, "Titangehäuse" },
                    { -37, "Plexiglaspumpen" },
                    { -36, "Steinunterlegscheiben" },
                    { -35, "Steinbolzen" },
                    { -34, "Aluminiumunterlegscheiben" },
                    { -33, "Betonpumpen" },
                    { -32, "Plexiglasbolzen" },
                    { -31, "Betonrohre" },
                    { -30, "Textilsensoren" },
                    { -29, "Plexiglasventile" },
                    { -28, "Acrylriemen" },
                    { -27, "Betonplatten" },
                    { -26, "Betonrohre" },
                    { -25, "Keramiksensoren" },
                    { -24, "Keramikpumpen" },
                    { -23, "Aluminiumfilter" },
                    { -22, "Acrylventile" },
                    { -21, "Betongehäuse" },
                    { -20, "Acrylfilter" },
                    { -19, "Acrylunterlegscheiben" },
                    { -18, "Steinfilter" },
                    { -17, "Gummipumpen" },
                    { -16, "Gummiplatten" },
                    { -15, "Betonschrauben" },
                    { -14, "Golddichtungen" },
                    { -13, "Acrylunterlegscheiben" },
                    { -12, "Aluminiumschrauben" },
                    { -11, "Silberdichtungen" },
                    { -10, "Keramikschrauben" },
                    { -9, "Aluminiumschalter" },
                    { -8, "Glasschalter" },
                    { -7, "Silberventile" },
                    { -6, "Metalldichtungen" },
                    { -5, "Stahlplatten" },
                    { -4, "Papiersensoren" },
                    { -3, "Stahlschrauben" },
                    { -2, "Goldsensoren" },
                    { -1, "Steinplatten" }
                });

            migrationBuilder.InsertData(
                table: "Bestellungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -80, new DateTime(2022, 9, 20, 23, 35, 0, 0, DateTimeKind.Unspecified), 108, -80 },
                    { -79, new DateTime(2022, 5, 8, 20, 23, 0, 0, DateTimeKind.Unspecified), 194, -79 },
                    { -78, new DateTime(2023, 8, 15, 20, 57, 0, 0, DateTimeKind.Unspecified), 222, -78 },
                    { -77, new DateTime(2022, 3, 16, 4, 15, 0, 0, DateTimeKind.Unspecified), 259, -77 },
                    { -76, new DateTime(2022, 8, 22, 16, 10, 0, 0, DateTimeKind.Unspecified), 281, -76 },
                    { -75, new DateTime(2022, 3, 22, 19, 9, 0, 0, DateTimeKind.Unspecified), 234, -75 },
                    { -74, new DateTime(2022, 3, 29, 10, 3, 0, 0, DateTimeKind.Unspecified), 85, -74 },
                    { -73, new DateTime(2022, 10, 21, 11, 19, 0, 0, DateTimeKind.Unspecified), 139, -73 },
                    { -72, new DateTime(2022, 3, 27, 11, 50, 0, 0, DateTimeKind.Unspecified), 16, -72 },
                    { -71, new DateTime(2022, 12, 25, 13, 14, 0, 0, DateTimeKind.Unspecified), 137, -71 },
                    { -70, new DateTime(2022, 9, 27, 18, 15, 0, 0, DateTimeKind.Unspecified), 270, -70 },
                    { -69, new DateTime(2023, 2, 18, 19, 13, 0, 0, DateTimeKind.Unspecified), 19, -69 },
                    { -68, new DateTime(2022, 4, 23, 20, 3, 0, 0, DateTimeKind.Unspecified), 260, -68 },
                    { -67, new DateTime(2022, 3, 26, 15, 4, 0, 0, DateTimeKind.Unspecified), 147, -67 },
                    { -66, new DateTime(2022, 9, 14, 19, 16, 0, 0, DateTimeKind.Unspecified), 172, -66 },
                    { -65, new DateTime(2023, 10, 19, 6, 29, 0, 0, DateTimeKind.Unspecified), 118, -65 },
                    { -64, new DateTime(2023, 10, 22, 13, 15, 0, 0, DateTimeKind.Unspecified), 22, -64 },
                    { -63, new DateTime(2022, 3, 1, 7, 6, 0, 0, DateTimeKind.Unspecified), 76, -63 },
                    { -62, new DateTime(2023, 11, 2, 3, 20, 0, 0, DateTimeKind.Unspecified), 89, -62 },
                    { -61, new DateTime(2023, 11, 17, 17, 17, 0, 0, DateTimeKind.Unspecified), 71, -61 },
                    { -60, new DateTime(2023, 3, 22, 8, 2, 0, 0, DateTimeKind.Unspecified), 69, -60 },
                    { -59, new DateTime(2022, 8, 15, 20, 49, 0, 0, DateTimeKind.Unspecified), 30, -59 },
                    { -58, new DateTime(2023, 6, 27, 3, 29, 0, 0, DateTimeKind.Unspecified), 82, -58 },
                    { -57, new DateTime(2023, 8, 27, 20, 40, 0, 0, DateTimeKind.Unspecified), 296, -57 },
                    { -56, new DateTime(2022, 5, 22, 21, 52, 0, 0, DateTimeKind.Unspecified), 141, -56 },
                    { -55, new DateTime(2023, 1, 21, 13, 18, 0, 0, DateTimeKind.Unspecified), 7, -55 },
                    { -54, new DateTime(2023, 6, 4, 22, 52, 0, 0, DateTimeKind.Unspecified), 148, -54 },
                    { -53, new DateTime(2022, 7, 12, 11, 21, 0, 0, DateTimeKind.Unspecified), 143, -53 },
                    { -52, new DateTime(2023, 3, 23, 4, 42, 0, 0, DateTimeKind.Unspecified), 121, -52 },
                    { -51, new DateTime(2022, 1, 24, 17, 58, 0, 0, DateTimeKind.Unspecified), 264, -51 },
                    { -50, new DateTime(2022, 4, 2, 7, 19, 0, 0, DateTimeKind.Unspecified), 141, -50 },
                    { -49, new DateTime(2023, 6, 17, 4, 13, 0, 0, DateTimeKind.Unspecified), 206, -49 },
                    { -48, new DateTime(2022, 9, 22, 2, 12, 0, 0, DateTimeKind.Unspecified), 277, -48 },
                    { -47, new DateTime(2022, 1, 8, 8, 18, 0, 0, DateTimeKind.Unspecified), 257, -47 },
                    { -46, new DateTime(2023, 1, 14, 22, 14, 0, 0, DateTimeKind.Unspecified), 220, -46 },
                    { -45, new DateTime(2023, 3, 28, 10, 7, 0, 0, DateTimeKind.Unspecified), 79, -45 },
                    { -44, new DateTime(2023, 9, 19, 20, 38, 0, 0, DateTimeKind.Unspecified), 258, -44 },
                    { -43, new DateTime(2022, 1, 31, 18, 20, 0, 0, DateTimeKind.Unspecified), 73, -43 },
                    { -42, new DateTime(2022, 2, 21, 8, 48, 0, 0, DateTimeKind.Unspecified), 235, -42 },
                    { -41, new DateTime(2022, 2, 20, 18, 40, 0, 0, DateTimeKind.Unspecified), 99, -41 },
                    { -40, new DateTime(2023, 6, 15, 15, 13, 0, 0, DateTimeKind.Unspecified), 192, -40 },
                    { -39, new DateTime(2022, 11, 5, 5, 38, 0, 0, DateTimeKind.Unspecified), 248, -39 },
                    { -38, new DateTime(2022, 8, 22, 12, 46, 0, 0, DateTimeKind.Unspecified), 276, -38 },
                    { -37, new DateTime(2022, 3, 25, 6, 12, 0, 0, DateTimeKind.Unspecified), 29, -37 },
                    { -36, new DateTime(2023, 10, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 154, -36 },
                    { -35, new DateTime(2022, 11, 17, 18, 48, 0, 0, DateTimeKind.Unspecified), 140, -35 },
                    { -34, new DateTime(2023, 4, 10, 0, 13, 0, 0, DateTimeKind.Unspecified), 278, -34 },
                    { -33, new DateTime(2023, 5, 15, 22, 51, 0, 0, DateTimeKind.Unspecified), 202, -33 },
                    { -32, new DateTime(2023, 4, 15, 14, 22, 0, 0, DateTimeKind.Unspecified), 108, -32 },
                    { -31, new DateTime(2023, 10, 8, 17, 56, 0, 0, DateTimeKind.Unspecified), 136, -31 },
                    { -30, new DateTime(2022, 7, 13, 11, 34, 0, 0, DateTimeKind.Unspecified), 119, -30 },
                    { -29, new DateTime(2022, 2, 23, 10, 41, 0, 0, DateTimeKind.Unspecified), 52, -29 },
                    { -28, new DateTime(2022, 11, 17, 6, 0, 0, 0, DateTimeKind.Unspecified), 98, -28 },
                    { -27, new DateTime(2022, 1, 15, 8, 40, 0, 0, DateTimeKind.Unspecified), 87, -27 },
                    { -26, new DateTime(2023, 12, 28, 22, 15, 0, 0, DateTimeKind.Unspecified), 16, -26 },
                    { -25, new DateTime(2022, 3, 8, 7, 36, 0, 0, DateTimeKind.Unspecified), 63, -25 },
                    { -24, new DateTime(2023, 4, 20, 11, 54, 0, 0, DateTimeKind.Unspecified), 189, -24 },
                    { -23, new DateTime(2022, 1, 26, 17, 26, 0, 0, DateTimeKind.Unspecified), 161, -23 },
                    { -22, new DateTime(2023, 11, 13, 7, 48, 0, 0, DateTimeKind.Unspecified), 48, -22 },
                    { -21, new DateTime(2022, 6, 12, 23, 20, 0, 0, DateTimeKind.Unspecified), 227, -21 },
                    { -20, new DateTime(2023, 3, 30, 13, 29, 0, 0, DateTimeKind.Unspecified), 229, -20 },
                    { -19, new DateTime(2022, 8, 17, 16, 18, 0, 0, DateTimeKind.Unspecified), 237, -19 },
                    { -18, new DateTime(2023, 10, 18, 11, 26, 0, 0, DateTimeKind.Unspecified), 97, -18 },
                    { -17, new DateTime(2022, 1, 24, 20, 3, 0, 0, DateTimeKind.Unspecified), 260, -17 },
                    { -16, new DateTime(2023, 8, 2, 2, 26, 0, 0, DateTimeKind.Unspecified), 11, -16 },
                    { -15, new DateTime(2023, 11, 3, 6, 50, 0, 0, DateTimeKind.Unspecified), 150, -15 },
                    { -14, new DateTime(2022, 3, 29, 6, 29, 0, 0, DateTimeKind.Unspecified), 277, -14 },
                    { -13, new DateTime(2022, 1, 11, 22, 32, 0, 0, DateTimeKind.Unspecified), 237, -13 },
                    { -12, new DateTime(2022, 11, 13, 23, 36, 0, 0, DateTimeKind.Unspecified), 234, -12 },
                    { -11, new DateTime(2023, 1, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), 194, -11 },
                    { -10, new DateTime(2022, 1, 8, 5, 0, 0, 0, DateTimeKind.Unspecified), 110, -10 },
                    { -9, new DateTime(2022, 6, 18, 9, 54, 0, 0, DateTimeKind.Unspecified), 26, -9 },
                    { -8, new DateTime(2023, 9, 23, 16, 3, 0, 0, DateTimeKind.Unspecified), 83, -8 },
                    { -7, new DateTime(2022, 3, 20, 4, 58, 0, 0, DateTimeKind.Unspecified), 9, -7 },
                    { -6, new DateTime(2023, 8, 23, 15, 9, 0, 0, DateTimeKind.Unspecified), 189, -6 },
                    { -5, new DateTime(2023, 12, 2, 23, 53, 0, 0, DateTimeKind.Unspecified), 51, -5 },
                    { -4, new DateTime(2022, 12, 23, 16, 51, 0, 0, DateTimeKind.Unspecified), 175, -4 },
                    { -3, new DateTime(2022, 2, 1, 20, 29, 0, 0, DateTimeKind.Unspecified), 270, -3 },
                    { -2, new DateTime(2023, 1, 12, 9, 53, 0, 0, DateTimeKind.Unspecified), 184, -2 },
                    { -1, new DateTime(2023, 2, 19, 13, 26, 0, 0, DateTimeKind.Unspecified), 71, -1 }
                });

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "BestellungId", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -80, -80, new DateTime(2022, 9, 27, 23, 35, 0, 0, DateTimeKind.Unspecified), 108, -80 },
                    { -79, -79, new DateTime(2022, 5, 15, 20, 23, 0, 0, DateTimeKind.Unspecified), 194, -79 },
                    { -78, -78, new DateTime(2023, 8, 29, 20, 57, 0, 0, DateTimeKind.Unspecified), 222, -78 },
                    { -77, -77, new DateTime(2022, 3, 30, 4, 15, 0, 0, DateTimeKind.Unspecified), 259, -77 },
                    { -76, -76, new DateTime(2022, 8, 29, 16, 10, 0, 0, DateTimeKind.Unspecified), 281, -76 },
                    { -75, -75, new DateTime(2022, 3, 29, 19, 9, 0, 0, DateTimeKind.Unspecified), 234, -75 },
                    { -74, -74, new DateTime(2022, 4, 5, 10, 3, 0, 0, DateTimeKind.Unspecified), 85, -74 },
                    { -73, -73, new DateTime(2022, 10, 28, 11, 19, 0, 0, DateTimeKind.Unspecified), 139, -73 },
                    { -72, -72, new DateTime(2022, 4, 3, 11, 50, 0, 0, DateTimeKind.Unspecified), 16, -72 },
                    { -71, -71, new DateTime(2023, 1, 8, 13, 14, 0, 0, DateTimeKind.Unspecified), 137, -71 },
                    { -70, -70, new DateTime(2022, 10, 4, 18, 15, 0, 0, DateTimeKind.Unspecified), 270, -70 },
                    { -69, -69, new DateTime(2023, 3, 4, 19, 13, 0, 0, DateTimeKind.Unspecified), 19, -69 },
                    { -68, -68, new DateTime(2022, 4, 30, 20, 3, 0, 0, DateTimeKind.Unspecified), 260, -68 },
                    { -67, -67, new DateTime(2022, 4, 9, 15, 4, 0, 0, DateTimeKind.Unspecified), 147, -67 },
                    { -66, -66, new DateTime(2022, 9, 28, 19, 16, 0, 0, DateTimeKind.Unspecified), 172, -66 },
                    { -65, -65, new DateTime(2023, 11, 2, 6, 29, 0, 0, DateTimeKind.Unspecified), 118, -65 },
                    { -64, -64, new DateTime(2023, 11, 5, 13, 15, 0, 0, DateTimeKind.Unspecified), 22, -64 },
                    { -63, -63, new DateTime(2022, 3, 15, 7, 6, 0, 0, DateTimeKind.Unspecified), 76, -63 },
                    { -62, -62, new DateTime(2023, 11, 9, 3, 20, 0, 0, DateTimeKind.Unspecified), 89, -62 },
                    { -61, -61, new DateTime(2023, 12, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), 71, -61 },
                    { -60, -60, new DateTime(2023, 3, 29, 8, 2, 0, 0, DateTimeKind.Unspecified), 69, -60 },
                    { -59, -59, new DateTime(2022, 8, 29, 20, 49, 0, 0, DateTimeKind.Unspecified), 30, -59 },
                    { -58, -58, new DateTime(2023, 7, 11, 3, 29, 0, 0, DateTimeKind.Unspecified), 82, -58 },
                    { -57, -57, new DateTime(2023, 9, 10, 20, 40, 0, 0, DateTimeKind.Unspecified), 296, -57 },
                    { -56, -56, new DateTime(2022, 5, 29, 21, 52, 0, 0, DateTimeKind.Unspecified), 141, -56 },
                    { -55, -55, new DateTime(2023, 2, 4, 13, 18, 0, 0, DateTimeKind.Unspecified), 7, -55 },
                    { -54, -54, new DateTime(2023, 6, 18, 22, 52, 0, 0, DateTimeKind.Unspecified), 148, -54 },
                    { -53, -53, new DateTime(2022, 7, 19, 11, 21, 0, 0, DateTimeKind.Unspecified), 143, -53 },
                    { -52, -52, new DateTime(2023, 4, 6, 4, 42, 0, 0, DateTimeKind.Unspecified), 121, -52 },
                    { -51, -51, new DateTime(2022, 1, 31, 17, 58, 0, 0, DateTimeKind.Unspecified), 264, -51 },
                    { -50, -50, new DateTime(2022, 4, 9, 7, 19, 0, 0, DateTimeKind.Unspecified), 141, -50 },
                    { -49, -49, new DateTime(2023, 6, 24, 4, 13, 0, 0, DateTimeKind.Unspecified), 206, -49 },
                    { -48, -48, new DateTime(2022, 9, 29, 2, 12, 0, 0, DateTimeKind.Unspecified), 277, -48 },
                    { -47, -47, new DateTime(2022, 1, 15, 8, 18, 0, 0, DateTimeKind.Unspecified), 257, -47 },
                    { -46, -46, new DateTime(2023, 1, 28, 22, 14, 0, 0, DateTimeKind.Unspecified), 220, -46 },
                    { -45, -45, new DateTime(2023, 4, 4, 10, 7, 0, 0, DateTimeKind.Unspecified), 79, -45 },
                    { -44, -44, new DateTime(2023, 10, 3, 20, 38, 0, 0, DateTimeKind.Unspecified), 258, -44 },
                    { -43, -43, new DateTime(2022, 2, 14, 18, 20, 0, 0, DateTimeKind.Unspecified), 73, -43 },
                    { -42, -42, new DateTime(2022, 2, 28, 8, 48, 0, 0, DateTimeKind.Unspecified), 235, -42 },
                    { -41, -41, new DateTime(2022, 3, 6, 18, 40, 0, 0, DateTimeKind.Unspecified), 99, -41 },
                    { -40, -40, new DateTime(2023, 6, 29, 15, 13, 0, 0, DateTimeKind.Unspecified), 192, -40 },
                    { -39, -39, new DateTime(2022, 11, 19, 5, 38, 0, 0, DateTimeKind.Unspecified), 248, -39 },
                    { -38, -38, new DateTime(2022, 8, 29, 12, 46, 0, 0, DateTimeKind.Unspecified), 276, -38 },
                    { -37, -37, new DateTime(2022, 4, 1, 6, 12, 0, 0, DateTimeKind.Unspecified), 29, -37 },
                    { -36, -36, new DateTime(2023, 11, 11, 16, 0, 0, 0, DateTimeKind.Unspecified), 154, -36 },
                    { -35, -35, new DateTime(2022, 12, 1, 18, 48, 0, 0, DateTimeKind.Unspecified), 140, -35 },
                    { -34, -34, new DateTime(2023, 4, 24, 0, 13, 0, 0, DateTimeKind.Unspecified), 278, -34 },
                    { -33, -33, new DateTime(2023, 5, 29, 22, 51, 0, 0, DateTimeKind.Unspecified), 202, -33 },
                    { -32, -32, new DateTime(2023, 4, 29, 14, 22, 0, 0, DateTimeKind.Unspecified), 108, -32 },
                    { -31, -31, new DateTime(2023, 10, 15, 17, 56, 0, 0, DateTimeKind.Unspecified), 136, -31 },
                    { -30, -30, new DateTime(2022, 7, 20, 11, 34, 0, 0, DateTimeKind.Unspecified), 119, -30 },
                    { -29, -29, new DateTime(2022, 3, 2, 10, 41, 0, 0, DateTimeKind.Unspecified), 52, -29 },
                    { -28, -28, new DateTime(2022, 12, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 98, -28 },
                    { -27, -27, new DateTime(2022, 1, 22, 8, 40, 0, 0, DateTimeKind.Unspecified), 87, -27 },
                    { -26, -26, new DateTime(2024, 1, 4, 22, 15, 0, 0, DateTimeKind.Unspecified), 16, -26 },
                    { -25, -25, new DateTime(2022, 3, 22, 7, 36, 0, 0, DateTimeKind.Unspecified), 63, -25 },
                    { -24, -24, new DateTime(2023, 4, 27, 11, 54, 0, 0, DateTimeKind.Unspecified), 189, -24 },
                    { -23, -23, new DateTime(2022, 2, 9, 17, 26, 0, 0, DateTimeKind.Unspecified), 161, -23 },
                    { -22, -22, new DateTime(2023, 11, 27, 7, 48, 0, 0, DateTimeKind.Unspecified), 48, -22 },
                    { -21, -21, new DateTime(2022, 6, 19, 23, 20, 0, 0, DateTimeKind.Unspecified), 227, -21 },
                    { -20, -20, new DateTime(2023, 4, 13, 13, 29, 0, 0, DateTimeKind.Unspecified), 229, -20 },
                    { -19, -19, new DateTime(2022, 8, 31, 16, 18, 0, 0, DateTimeKind.Unspecified), 237, -19 },
                    { -18, -18, new DateTime(2023, 10, 25, 11, 26, 0, 0, DateTimeKind.Unspecified), 97, -18 },
                    { -17, -17, new DateTime(2022, 2, 7, 20, 3, 0, 0, DateTimeKind.Unspecified), 260, -17 },
                    { -16, -16, new DateTime(2023, 8, 16, 2, 26, 0, 0, DateTimeKind.Unspecified), 11, -16 },
                    { -15, -15, new DateTime(2023, 11, 17, 6, 50, 0, 0, DateTimeKind.Unspecified), 150, -15 },
                    { -14, -14, new DateTime(2022, 4, 12, 6, 29, 0, 0, DateTimeKind.Unspecified), 277, -14 },
                    { -13, -13, new DateTime(2022, 1, 25, 22, 32, 0, 0, DateTimeKind.Unspecified), 237, -13 },
                    { -12, -12, new DateTime(2022, 11, 27, 23, 36, 0, 0, DateTimeKind.Unspecified), 234, -12 },
                    { -11, -11, new DateTime(2023, 1, 15, 17, 42, 0, 0, DateTimeKind.Unspecified), 194, -11 },
                    { -10, -10, new DateTime(2022, 1, 15, 5, 0, 0, 0, DateTimeKind.Unspecified), 110, -10 },
                    { -9, -9, new DateTime(2022, 6, 25, 9, 54, 0, 0, DateTimeKind.Unspecified), 26, -9 },
                    { -8, -8, new DateTime(2023, 10, 7, 16, 3, 0, 0, DateTimeKind.Unspecified), 83, -8 },
                    { -7, -7, new DateTime(2022, 4, 3, 4, 58, 0, 0, DateTimeKind.Unspecified), 9, -7 },
                    { -6, -6, new DateTime(2023, 8, 30, 15, 9, 0, 0, DateTimeKind.Unspecified), 189, -6 },
                    { -5, -5, new DateTime(2023, 12, 9, 23, 53, 0, 0, DateTimeKind.Unspecified), 51, -5 },
                    { -4, -4, new DateTime(2023, 1, 6, 16, 51, 0, 0, DateTimeKind.Unspecified), 175, -4 },
                    { -3, -3, new DateTime(2022, 2, 8, 20, 29, 0, 0, DateTimeKind.Unspecified), 270, -3 },
                    { -2, -2, new DateTime(2023, 1, 26, 9, 53, 0, 0, DateTimeKind.Unspecified), 184, -2 },
                    { -1, -1, new DateTime(2023, 3, 5, 13, 26, 0, 0, DateTimeKind.Unspecified), 71, -1 }
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
                name: "IX_Lieferungen_BestellungId",
                table: "Lieferungen",
                column: "BestellungId");

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
                name: "Lieferungen");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Bestellungen");

            migrationBuilder.DropTable(
                name: "Produkte");
        }
    }
}
