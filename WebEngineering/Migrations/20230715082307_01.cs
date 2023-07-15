using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebEngineering.Migrations
{
    /// <inheritdoc />
    public partial class _01 : Migration
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ViewModel_Lieferungen_LieferungId",
                        column: x => x.LieferungId,
                        principalTable: "Lieferungen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ViewModel_Produkte_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.InsertData(
                table: "Produkte",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -20, "Metallschalter" },
                    { -19, "Gummikabel" },
                    { -18, "Silberunterlegscheiben" },
                    { -17, "Silberzahnräder" },
                    { -16, "Plexiglasmuttern" },
                    { -15, "Aluminiummuttern" },
                    { -14, "Bronzebolzen" },
                    { -13, "Kunststoffdichtungen" },
                    { -12, "Kupferdichtungen" },
                    { -11, "Plexiglasunterlegscheiben" },
                    { -10, "Papiergehäuse" },
                    { -9, "Betonriemen" },
                    { -8, "Steindichtungen" },
                    { -7, "Keramikventile" },
                    { -6, "Gummimuttern" },
                    { -5, "Stahlkabel" },
                    { -4, "Aluminiumgehäuse" },
                    { -3, "Aluminiumriemen" },
                    { -2, "Aluminiumsensoren" },
                    { -1, "Textilfilter" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50da61af-5496-4e5f-bba0-510c14c6e5f7", "0921b8ab-d5c6-4619-81e0-b43f92072264" });

            migrationBuilder.InsertData(
                table: "Bestellungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -80, new DateTime(2023, 2, 14, 4, 28, 0, 0, DateTimeKind.Unspecified), 186, -3 },
                    { -79, new DateTime(2023, 7, 19, 9, 34, 0, 0, DateTimeKind.Unspecified), 3, -4 },
                    { -78, new DateTime(2023, 8, 13, 5, 55, 0, 0, DateTimeKind.Unspecified), 43, -10 },
                    { -77, new DateTime(2023, 7, 28, 0, 20, 0, 0, DateTimeKind.Unspecified), 8, -18 },
                    { -76, new DateTime(2023, 3, 16, 13, 5, 0, 0, DateTimeKind.Unspecified), 162, -12 },
                    { -75, new DateTime(2023, 3, 18, 19, 15, 0, 0, DateTimeKind.Unspecified), 146, -14 },
                    { -74, new DateTime(2023, 1, 14, 2, 17, 0, 0, DateTimeKind.Unspecified), 258, -12 },
                    { -73, new DateTime(2022, 7, 9, 14, 26, 0, 0, DateTimeKind.Unspecified), 131, -18 },
                    { -72, new DateTime(2022, 12, 19, 21, 39, 0, 0, DateTimeKind.Unspecified), 150, -3 },
                    { -71, new DateTime(2022, 6, 3, 17, 49, 0, 0, DateTimeKind.Unspecified), 136, -15 },
                    { -70, new DateTime(2022, 11, 21, 14, 36, 0, 0, DateTimeKind.Unspecified), 125, -17 },
                    { -69, new DateTime(2022, 8, 12, 19, 51, 0, 0, DateTimeKind.Unspecified), 222, -20 },
                    { -68, new DateTime(2023, 2, 24, 19, 25, 0, 0, DateTimeKind.Unspecified), 95, -18 },
                    { -67, new DateTime(2023, 2, 13, 20, 29, 0, 0, DateTimeKind.Unspecified), 5, -13 },
                    { -66, new DateTime(2023, 2, 15, 5, 56, 0, 0, DateTimeKind.Unspecified), 68, -12 },
                    { -65, new DateTime(2022, 8, 3, 7, 27, 0, 0, DateTimeKind.Unspecified), 101, -8 },
                    { -64, new DateTime(2023, 2, 5, 7, 39, 0, 0, DateTimeKind.Unspecified), 69, -12 },
                    { -63, new DateTime(2023, 3, 12, 9, 1, 0, 0, DateTimeKind.Unspecified), 258, -2 },
                    { -62, new DateTime(2023, 5, 12, 8, 44, 0, 0, DateTimeKind.Unspecified), 260, -18 },
                    { -61, new DateTime(2023, 6, 24, 8, 17, 0, 0, DateTimeKind.Unspecified), 1, -18 },
                    { -60, new DateTime(2023, 11, 21, 12, 12, 0, 0, DateTimeKind.Unspecified), 61, -8 },
                    { -59, new DateTime(2023, 10, 13, 5, 6, 0, 0, DateTimeKind.Unspecified), 192, -7 },
                    { -58, new DateTime(2023, 12, 3, 7, 43, 0, 0, DateTimeKind.Unspecified), 202, -19 },
                    { -57, new DateTime(2022, 11, 27, 11, 20, 0, 0, DateTimeKind.Unspecified), 271, -7 },
                    { -56, new DateTime(2022, 5, 1, 11, 18, 0, 0, DateTimeKind.Unspecified), 216, -14 },
                    { -55, new DateTime(2023, 9, 21, 8, 28, 0, 0, DateTimeKind.Unspecified), 123, -2 },
                    { -54, new DateTime(2023, 12, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), 177, -5 },
                    { -53, new DateTime(2022, 9, 15, 7, 39, 0, 0, DateTimeKind.Unspecified), 119, -18 },
                    { -52, new DateTime(2023, 8, 3, 17, 51, 0, 0, DateTimeKind.Unspecified), 131, -11 },
                    { -51, new DateTime(2023, 9, 9, 23, 8, 0, 0, DateTimeKind.Unspecified), 165, -12 },
                    { -50, new DateTime(2022, 7, 5, 11, 57, 0, 0, DateTimeKind.Unspecified), 37, -20 },
                    { -49, new DateTime(2023, 7, 3, 2, 13, 0, 0, DateTimeKind.Unspecified), 12, -17 },
                    { -48, new DateTime(2022, 5, 21, 7, 29, 0, 0, DateTimeKind.Unspecified), 45, -2 },
                    { -47, new DateTime(2022, 9, 8, 19, 14, 0, 0, DateTimeKind.Unspecified), 292, -12 },
                    { -46, new DateTime(2023, 6, 4, 15, 39, 0, 0, DateTimeKind.Unspecified), 166, -2 },
                    { -45, new DateTime(2022, 10, 23, 14, 36, 0, 0, DateTimeKind.Unspecified), 297, -1 },
                    { -44, new DateTime(2022, 12, 2, 3, 14, 0, 0, DateTimeKind.Unspecified), 212, -3 },
                    { -43, new DateTime(2023, 2, 3, 14, 9, 0, 0, DateTimeKind.Unspecified), 196, -17 },
                    { -42, new DateTime(2022, 2, 28, 2, 10, 0, 0, DateTimeKind.Unspecified), 121, -15 },
                    { -41, new DateTime(2023, 6, 18, 19, 24, 0, 0, DateTimeKind.Unspecified), 197, -18 },
                    { -40, new DateTime(2023, 8, 2, 2, 22, 0, 0, DateTimeKind.Unspecified), 237, -15 },
                    { -39, new DateTime(2022, 5, 5, 6, 57, 0, 0, DateTimeKind.Unspecified), 298, -10 },
                    { -38, new DateTime(2023, 1, 10, 7, 42, 0, 0, DateTimeKind.Unspecified), 136, -10 },
                    { -37, new DateTime(2023, 8, 8, 12, 37, 0, 0, DateTimeKind.Unspecified), 222, -9 },
                    { -36, new DateTime(2023, 7, 3, 4, 53, 0, 0, DateTimeKind.Unspecified), 235, -13 },
                    { -35, new DateTime(2022, 4, 3, 7, 26, 0, 0, DateTimeKind.Unspecified), 134, -17 },
                    { -34, new DateTime(2022, 12, 1, 19, 34, 0, 0, DateTimeKind.Unspecified), 173, -7 },
                    { -33, new DateTime(2023, 6, 20, 2, 7, 0, 0, DateTimeKind.Unspecified), 117, -10 },
                    { -32, new DateTime(2022, 3, 10, 23, 30, 0, 0, DateTimeKind.Unspecified), 262, -11 },
                    { -31, new DateTime(2022, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, -4 },
                    { -30, new DateTime(2022, 10, 16, 23, 30, 0, 0, DateTimeKind.Unspecified), 260, -19 },
                    { -29, new DateTime(2022, 9, 30, 13, 33, 0, 0, DateTimeKind.Unspecified), 103, -4 },
                    { -28, new DateTime(2022, 7, 15, 10, 8, 0, 0, DateTimeKind.Unspecified), 53, -2 },
                    { -27, new DateTime(2023, 7, 4, 22, 19, 0, 0, DateTimeKind.Unspecified), 201, -8 },
                    { -26, new DateTime(2022, 4, 17, 7, 2, 0, 0, DateTimeKind.Unspecified), 181, -8 },
                    { -25, new DateTime(2023, 3, 8, 5, 41, 0, 0, DateTimeKind.Unspecified), 183, -13 },
                    { -24, new DateTime(2023, 12, 16, 9, 47, 0, 0, DateTimeKind.Unspecified), 149, -14 },
                    { -23, new DateTime(2022, 3, 22, 9, 41, 0, 0, DateTimeKind.Unspecified), 226, -16 },
                    { -22, new DateTime(2023, 8, 8, 4, 47, 0, 0, DateTimeKind.Unspecified), 98, -19 },
                    { -21, new DateTime(2023, 1, 30, 7, 35, 0, 0, DateTimeKind.Unspecified), 249, -15 },
                    { -20, new DateTime(2023, 6, 5, 16, 51, 0, 0, DateTimeKind.Unspecified), 212, -17 },
                    { -19, new DateTime(2022, 11, 20, 19, 20, 0, 0, DateTimeKind.Unspecified), 183, -17 },
                    { -18, new DateTime(2023, 5, 5, 6, 48, 0, 0, DateTimeKind.Unspecified), 213, -17 },
                    { -17, new DateTime(2022, 11, 11, 10, 13, 0, 0, DateTimeKind.Unspecified), 22, -5 },
                    { -16, new DateTime(2022, 10, 19, 14, 7, 0, 0, DateTimeKind.Unspecified), 155, -12 },
                    { -15, new DateTime(2022, 2, 3, 19, 38, 0, 0, DateTimeKind.Unspecified), 103, -15 },
                    { -14, new DateTime(2023, 1, 23, 20, 40, 0, 0, DateTimeKind.Unspecified), 287, -12 },
                    { -13, new DateTime(2022, 11, 17, 15, 18, 0, 0, DateTimeKind.Unspecified), 128, -12 },
                    { -12, new DateTime(2023, 5, 18, 10, 55, 0, 0, DateTimeKind.Unspecified), 97, -19 },
                    { -11, new DateTime(2022, 6, 25, 22, 17, 0, 0, DateTimeKind.Unspecified), 198, -6 },
                    { -10, new DateTime(2022, 5, 10, 21, 12, 0, 0, DateTimeKind.Unspecified), 247, -9 },
                    { -9, new DateTime(2023, 5, 10, 2, 47, 0, 0, DateTimeKind.Unspecified), 147, -12 },
                    { -8, new DateTime(2023, 2, 28, 12, 22, 0, 0, DateTimeKind.Unspecified), 43, -5 },
                    { -7, new DateTime(2023, 4, 16, 19, 56, 0, 0, DateTimeKind.Unspecified), 295, -14 },
                    { -6, new DateTime(2023, 1, 18, 18, 19, 0, 0, DateTimeKind.Unspecified), 270, -19 },
                    { -5, new DateTime(2023, 12, 26, 1, 0, 0, 0, DateTimeKind.Unspecified), 210, -19 },
                    { -4, new DateTime(2022, 8, 11, 20, 19, 0, 0, DateTimeKind.Unspecified), 248, -18 },
                    { -3, new DateTime(2023, 2, 21, 19, 11, 0, 0, DateTimeKind.Unspecified), 77, -19 },
                    { -2, new DateTime(2023, 12, 14, 15, 48, 0, 0, DateTimeKind.Unspecified), 143, -14 },
                    { -1, new DateTime(2023, 5, 22, 18, 3, 0, 0, DateTimeKind.Unspecified), 279, -18 }
                });

            migrationBuilder.InsertData(
                table: "Lieferungen",
                columns: new[] { "Id", "Date", "Menge", "ProduktId" },
                values: new object[,]
                {
                    { -20, new DateTime(2022, 4, 1, 21, 33, 0, 0, DateTimeKind.Unspecified), 1374, -2 },
                    { -19, new DateTime(2023, 4, 30, 13, 39, 0, 0, DateTimeKind.Unspecified), 4634, -8 },
                    { -18, new DateTime(2022, 9, 29, 12, 24, 0, 0, DateTimeKind.Unspecified), 4839, -11 },
                    { -17, new DateTime(2022, 3, 21, 17, 37, 0, 0, DateTimeKind.Unspecified), 1261, -10 },
                    { -16, new DateTime(2022, 10, 25, 12, 5, 0, 0, DateTimeKind.Unspecified), 3328, -20 },
                    { -15, new DateTime(2023, 4, 7, 15, 17, 0, 0, DateTimeKind.Unspecified), 2672, -17 },
                    { -14, new DateTime(2023, 1, 1, 3, 23, 0, 0, DateTimeKind.Unspecified), 603, -2 },
                    { -13, new DateTime(2022, 4, 6, 13, 11, 0, 0, DateTimeKind.Unspecified), 2119, -11 },
                    { -12, new DateTime(2022, 7, 14, 20, 6, 0, 0, DateTimeKind.Unspecified), 779, -11 },
                    { -11, new DateTime(2022, 4, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), 4202, -5 },
                    { -10, new DateTime(2023, 2, 24, 4, 18, 0, 0, DateTimeKind.Unspecified), 3835, -12 },
                    { -9, new DateTime(2023, 4, 12, 14, 12, 0, 0, DateTimeKind.Unspecified), 1423, -19 },
                    { -8, new DateTime(2022, 5, 26, 14, 38, 0, 0, DateTimeKind.Unspecified), 1210, -20 },
                    { -7, new DateTime(2022, 5, 19, 13, 35, 0, 0, DateTimeKind.Unspecified), 2980, -14 },
                    { -6, new DateTime(2023, 12, 9, 3, 46, 0, 0, DateTimeKind.Unspecified), 3844, -4 },
                    { -5, new DateTime(2022, 7, 11, 16, 59, 0, 0, DateTimeKind.Unspecified), 2374, -12 },
                    { -4, new DateTime(2022, 4, 5, 15, 15, 0, 0, DateTimeKind.Unspecified), 1931, -16 },
                    { -3, new DateTime(2023, 11, 28, 22, 48, 0, 0, DateTimeKind.Unspecified), 4695, -11 },
                    { -2, new DateTime(2023, 4, 2, 16, 9, 0, 0, DateTimeKind.Unspecified), 4933, -4 },
                    { -1, new DateTime(2023, 9, 27, 20, 31, 0, 0, DateTimeKind.Unspecified), 3681, -13 }
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
