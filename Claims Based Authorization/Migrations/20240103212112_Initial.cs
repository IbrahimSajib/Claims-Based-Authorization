using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Claims_Based_Authorization.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01cf226c-9a88-4109-bd93-af54a6d53964", 0, "3f415d01-90b8-49e5-a810-1428103731d0", "Bangladeshi1@abc.com", false, false, null, "BANGLADESHI1@ABC.COM", "BANGLADESHI1@ABC.COM", "AQAAAAIAAYagAAAAEJjxBh4daV3wJwXSN4vg4eGNk5J2cwOfOBQ9xhkblowWjIxm4PhJzLNgEkjHFta3MA==", null, false, "24b2b9e3-4a23-4a3b-81ef-94900a325d1c", false, "Bangladeshi1@abc.com" },
                    { "0442b285-375d-48a0-8f47-d6e21bf342c9", 0, "0f0b8a81-673d-4742-91d6-6e06371dfba0", "Sajib@example.com", false, false, null, "SAJIB@EXAMPLE.COM", "SAJIB@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAdL8J8rbiWZynEimj2j54tdL3Kbl19ghsLPWanrWomPWJTMvqB91cllCGFweIyrqw==", null, false, "de378ce0-9b2f-4657-a35f-07c93dbe0678", false, "Sajib@example.com" },
                    { "176429b6-a988-40f6-825a-d1eed4e0eeb5", 0, "265e0976-15aa-43cc-92aa-d8a1526a3046", "Male1@abc.com", false, false, null, "MALE1@ABC.COM", "MALE1@ABC.COM", "AQAAAAIAAYagAAAAEMUs0kvAc5VznVbBouxjsEtZyyQKWT0wR5T7m/odO6bL9b0WWDP8EOJUGlLo//MNYg==", null, false, "52656863-4073-4bac-a5e0-c23aea1f6bc6", false, "Male1@abc.com" },
                    { "620b2b39-426e-42e1-8ca8-82551f11acc0", 0, "e4a5a25b-046e-4cb2-8d50-806da3b1129e", "Japanese1@abc.com", false, false, null, "JAPANESE1@ABC.COM", "JAPANESE1@ABC.COM", "AQAAAAIAAYagAAAAEGFxRHDCvQpTZrgPBSDHazxxrL7KdR/qukGAh+bRFcVsexB+gFVtntV4Mwo+f9EeyQ==", null, false, "d7791b10-83d9-4b29-a857-fd88f22f04a0", false, "Japanese1@abc.com" },
                    { "75293121-df2d-4e4b-abf1-a1ef0e7e4d0b", 0, "c297f4dd-b233-4c0f-839b-c137f5928c64", "Australians1@abc.com", false, false, null, "AUSTRALIANS1@ABC.COM", "AUSTRALIANS1@ABC.COM", "AQAAAAIAAYagAAAAEEQ1/jvU4HoXR1iuBq5RafHjkacQNjwhRJc2yjUbVzOpLus8jkaH2vRcCl2+sZqpOg==", null, false, "62f55f7a-7bb4-472c-8055-8693fb6ef5c3", false, "Australians1@abc.com" },
                    { "9702702f-df96-44e0-aad8-0222b618ed8f", 0, "c652a26a-bae4-4f79-82c1-405221b84b23", "Canadian1@abc.com", false, false, null, "CANADIAN1@ABC.COM", "CANADIAN1@ABC.COM", "AQAAAAIAAYagAAAAEP046aQw5wmcVTi9zjyQfwJH9eWg/LVoEmvJDwV0BUFhMmYWGqeqP5Ze9FaHAZA0nw==", null, false, "5ff005d0-95e7-49cc-8e0f-55b285329a7f", false, "Canadian1@abc.com" },
                    { "b6798a21-75db-46c5-b696-b47387c450f0", 0, "4bddc184-a6a7-44b5-ba6a-a85122063367", "HR1@abc.com", false, false, null, "HR1@ABC.COM", "HR1@ABC.COM", "AQAAAAIAAYagAAAAEF7Dmv6EPDHw/dq/Ndi8qzpli/pWcOe9UdXzUMKyD8gNjlEGQ2d1lgEmDuVkcNFgmg==", null, false, "dfb448f9-304a-4759-9f18-0ea71a893927", false, "HR1@abc.com" },
                    { "b7f46612-41d2-47ba-af30-f957a680d92a", 0, "663c1e96-9acb-433a-ae06-bddd27279f42", "Ibrahim@example.com", false, false, null, "IBRAHIM@EXAMPLE.COM", "IBRAHIM@EXAMPLE.COM", "AQAAAAIAAYagAAAAEI3a8AxinUQP2JihOdPoruk/wCKFPH9RNtt8fiSSAExk2FDvLmEdLY6d+t+SiD3GDA==", null, false, "e12089a9-dd49-40af-8a32-271230da465d", false, "Ibrahim@example.com" },
                    { "b96a4ff1-c4ec-40e6-9496-d45fd45085c1", 0, "acad1191-e379-4f01-b084-a5ec40810ffe", "Admin1@abc.com", false, false, null, "ADMIN1@ABC.COM", "ADMIN1@ABC.COM", "AQAAAAIAAYagAAAAEHy4mONEsFUoLRGpeJd39ZAc/MDVJboaK4+hzC6qUVxo4o96qr3014cYwSPZDxP8vg==", null, false, "6c854eb0-515c-44a3-883c-2c6cdbdcbe64", false, "Admin1@abc.com" },
                    { "c02f71c8-a822-4b3a-900c-5c62478b32f0", 0, "e21b4a01-ec93-4846-9411-d01135ac7c6c", "Admin1@gmail.com", false, false, null, "ADMIN1@GMAIL.COM", "ADMIN1@GMAIL.COM", "AQAAAAIAAYagAAAAELrk1C/NeyKzFcxY4w+wz3hArbxMlXs1m1+N9XFYv3mMO7d3uKaZr0yi3ztL52fVaw==", null, false, "25ed73cb-6fae-43ec-9df8-ea41e930c3c2", false, "Admin1@gmail.com" },
                    { "fc6937ab-d96b-4c2e-88a2-3de1afd319a1", 0, "cddcfc17-6359-49ab-b83a-f369adefd278", "Female1@abc.com", false, false, null, "FEMALE1@ABC.COM", "FEMALE1@ABC.COM", "AQAAAAIAAYagAAAAEKCXpoxPnZuukfLTyLi1GyXFoaV7nedDmnDiPp+2yU1sS9g/3JkC5OsTENKipCnphQ==", null, false, "05f4e225-17a6-42a5-a5d3-63e9e78489fa", false, "Female1@abc.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "Role", "Admin", "b96a4ff1-c4ec-40e6-9496-d45fd45085c1" },
                    { 2, "Role", "HR", "b6798a21-75db-46c5-b696-b47387c450f0" },
                    { 3, "Role", "Admin", "b7f46612-41d2-47ba-af30-f957a680d92a" },
                    { 4, "Role", "Admin", "0442b285-375d-48a0-8f47-d6e21bf342c9" },
                    { 5, "Gender", "Male", "176429b6-a988-40f6-825a-d1eed4e0eeb5" },
                    { 6, "Gender", "Female", "fc6937ab-d96b-4c2e-88a2-3de1afd319a1" },
                    { 7, "Country", "Bangladesh", "01cf226c-9a88-4109-bd93-af54a6d53964" },
                    { 8, "Country", "Japan", "620b2b39-426e-42e1-8ca8-82551f11acc0" },
                    { 9, "Country", "Australia", "75293121-df2d-4e4b-abf1-a1ef0e7e4d0b" },
                    { 10, "Country", "Canada", "9702702f-df96-44e0-aad8-0222b618ed8f" },
                    { 11, "Role", "Admin", "c02f71c8-a822-4b3a-900c-5c62478b32f0" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
