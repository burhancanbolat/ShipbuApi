using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class Values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransportMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMethod", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportRegion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportRegion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportDistrict",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RegionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsAmazonDepot = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportDistrict", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportDistrict_TransportRegion_RegionId",
                        column: x => x.RegionId,
                        principalTable: "TransportRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportRegionMethod",
                columns: table => new
                {
                    RegionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MethodId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Volume = table.Column<int>(type: "int", nullable: false),
                    ETATr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ETAEn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportRegionMethod", x => new { x.MethodId, x.RegionId });
                    table.ForeignKey(
                        name: "FK_TransportRegionMethod_TransportMethod_MethodId",
                        column: x => x.MethodId,
                        principalTable: "TransportMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportRegionMethod_TransportRegion_RegionId",
                        column: x => x.RegionId,
                        principalTable: "TransportRegion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportFee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DistrictId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MethodId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Value = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MinWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportFee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportFee_TransportDistrict_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "TransportDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportFee_TransportMethod_MethodId",
                        column: x => x.MethodId,
                        principalTable: "TransportMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TransportMethod",
                columns: new[] { "Id", "Enabled", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), true, "Fast Vessel", "Speed Boat" },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), true, "Air", "Uçak" },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), true, "Sea Slow", "Yavaş Gemi" },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), true, "Railway", "Tren" },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), true, "Truck", "TIR" },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), true, "Sea Fast", "Hızlı Gemi" }
                });

            migrationBuilder.InsertData(
                table: "TransportRegion",
                columns: new[] { "Id", "Enabled", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("39887e51-8a46-42c1-b621-699d96326883"), true, "Europe", "Avrupa" },
                    { new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), true, "UK", "İngiltere" },
                    { new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), true, "Canada", "Kanada" },
                    { new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), true, "USA", "ABD" }
                });

            migrationBuilder.InsertData(
                table: "TransportDistrict",
                columns: new[] { "Id", "Enabled", "IsAmazonDepot", "NameEn", "NameTr", "RegionId" },
                values: new object[,]
                {
                    { new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), true, false, "Eastern USA", "Doğu Amerika", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), true, false, "Central USA", "Merkez Amerika", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), true, true, "SJC7", "SJC7", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), true, false, "Monaco", "Monako", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), true, false, "Slovenia", "Slovenya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), true, true, "ONT8", "ONT8", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), true, false, "Western USA", "Batı Amerika", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), true, false, "Austria", "Avusturya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), true, false, "Romania", "Romanya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), true, true, "LGB8", "LGB8", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), true, false, "Sweden", "İsveç", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), true, false, "Bussiness Private Address", "Kurumsal/Bireysel Adres", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), true, false, "Netherlands", "Hollanda", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), true, true, "Toronto YYZ", "Toronto YYZ", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), true, true, "Vancouver YVR", "Vancouver YVR", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), true, false, "Greece", "Yunanistan", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), true, true, "KRB4", "KRB4", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), true, true, "GYR3", "GYR3", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), true, true, "Calgary YYC", "Calgary YYC", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), true, false, "Belgium", "Belçika", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), true, true, "SCK4", "SCK4", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), true, true, "SBD3", "SBD3", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), true, false, "Hungary", "Macaristan", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), true, true, "GYR2", "GYR2", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), true, true, "SMF3", "SMF3", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), true, true, "LAS1", "LAS1", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("78587899-2653-4be7-b07e-13a7596d5649"), true, false, "France", "Fransa", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), true, false, "Spain", "İspanya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), true, false, "Ireland", "Irlanda", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), true, true, "VGT3", "VGT2", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("82060812-b989-4340-bd2e-8840585a8acf"), true, true, "Calgary YEG", "Calgary YEG", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), true, true, "Ottawa YOW", "Ottawa YOW", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), true, false, "Luxembourg", "Lüksemburg", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), true, false, "Bulgaria", "Bulgaristan", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), true, false, "Italy", "İtalya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), true, true, "Edmonton YEG1", "Edmonton YEG1", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), true, true, "KRB1", "KRB1", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), true, true, "Vancouver YXX", "Vancouver YXX", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), true, true, "SBD2", "SBD2", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("b93226d5-2642-4705-99ca-734af02c624b"), true, false, "Estonia", "Estonya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), true, true, "Toronto YHM", "Toronto YHM", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), true, false, "Slovakia", "Slovakya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), true, false, "Czech Rep.", "Çekya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), true, false, "Germany", "Almanya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), true, true, "SBD1", "SBD1", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), true, true, "FTW1", "FTW1", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), true, false, "Finland", "Fillandiya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), true, false, "Latvia", "Latviya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), true, true, "LAX9", "LAX9", new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa") },
                    { new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), true, true, "Toronto YOO", "Toronto YOO", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") },
                    { new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), true, false, "Poland", "Polonya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), true, false, "Croatia", "Hırvatistan", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), true, false, "UK", "İngiltere", new Guid("5d751653-be94-44f4-afbe-5baf410ae321") },
                    { new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), true, false, "Portugal", "Portekiz", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), true, false, "Denmark", "Danimarka", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
                    { new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), true, true, "Ottawa YUL", "Ottawa YUL", new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f") }
                });

            migrationBuilder.InsertData(
                table: "TransportRegionMethod",
                columns: new[] { "MethodId", "RegionId", "ETAEn", "ETATr", "Volume" },
                values: new object[,]
                {
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), "25-28 days", "25-28 gün", 6000 },
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), "18-22 days", "18-22 gün", 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), "3 days", "3 gün", 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), "3 days", "3 gün", 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), "3 days", "3 gün", 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), "3 days", "3 gün", 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), "40-45 days", "40-45 gün", 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), "38-40 days", "38-40 gün", 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), "45-50 days", "45-50 gün", 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), "30-35 days", "30-35 gün", 6000 },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), "35-38 days", "35-38 gün", 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), "22-28 days", "22-28 gün", 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), "25-30 days", "25-30 gün", 6000 },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), "35-40 days", "35-40 gün", 6000 }
                });

            migrationBuilder.InsertData(
                table: "TransportFee",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("10a4964b-0e4c-43ee-896d-ec377a80db04"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("14f02df5-71f2-44ed-be64-caa1ebc8db3b"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("1802b5f9-58e6-4d1e-8e82-73b1e535d5ec"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("2580f783-661e-4a5a-98c3-c44ea8379f7c"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("2a57f44a-ddd2-4f67-bbb9-65f7af95d254"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("368bbba9-1e48-4a69-ba46-3c66b9e375ef"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("38a018b1-b001-4248-8f9e-320121150f23"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("39122789-4544-4340-8114-9ac0bd30c84e"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("47384446-8e41-46ea-bacd-6cc5c12a2855"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("4d7990d2-9bd1-4331-afa5-ee2fd1031136"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("4e3cdf4e-9aec-4280-8f0b-9687adb4e878"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("50d0ff3d-ea78-4b87-9ec0-a69f45d3a0b6"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("50e3cf59-0372-4403-81f4-e460fcd2a20d"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("55f57ee4-298d-4677-a4d3-a00ee87f0164"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("579d4237-a1a9-4b3b-b353-7f97374f581b"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("5990ac38-7703-4ef7-bfab-3074f9095987"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("64685eb3-da0f-49f4-84e4-78da3f2e9adf"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("654993a4-4eae-4dd9-9376-1677f9118640"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("6e2ede54-f979-452c-92fb-f61d535f545a"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("76befa43-33ce-405e-9ab7-900b6b4716c8"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("7b46f5e4-78ac-44b7-b8a3-9bfc8fe98aac"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("867bf9f2-478e-49b9-be55-44ec378edce9"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("8b4f2048-6fb2-40cd-a0cc-11950b3283aa"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("8fe04e63-e8d9-4a93-b73b-22b1ecac5cf7"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("90bb9331-c7f0-4c9b-b29f-3e0e25ac88c9"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("93b8dbff-a28b-4c68-b215-187d47823a4e"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("94f70b4b-1da0-4acb-95a6-6de2dcc84087"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("9654ae1c-2fd4-41b6-9262-9a78f4d975f8"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("96aec6fe-80a3-4373-b71a-6d6011fde0b4"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("978b8e30-a2cf-491e-b350-8709e56c9545"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("9b90531b-1a8d-45a6-9707-35f416a2b0af"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("9f2da2d4-78c0-4d57-b0d3-27d070f20822"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("a0bca75d-678d-4e60-8f76-73fcbd0d7b0d"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("a65498e7-1afe-4f90-bf1c-a63ef43e8b8d"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("aadaaef7-62b3-4266-a995-8756301da2eb"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("ab12d112-3f2a-4bf7-96f2-473e0c837a0c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("af2e3dae-28f6-479a-b34a-5a2bb5eb6678"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("b388d4b3-2583-4193-a5cb-72df686459c8"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("b9660b08-4899-476b-95c7-1d90cb04cf77"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("bf3dbdd2-e2b8-4236-82c7-0778ddf7e6f0"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("bfb0b85f-e21d-4b78-af01-77b0e69427bd"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("c0a50b68-7d28-4751-8932-8c95b674f1c3"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("c2deed51-b961-46e3-aef0-3f0792fbd41d"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("e6716f98-205a-4e65-847b-6c2cb48cb57b"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("e680a11d-4f8f-4211-95ae-99b542264fe4"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("f249a953-ebdd-4497-a485-495789c15d0a"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f2a960e2-0d21-41d7-8be8-4fa324cd46d5"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("f3324683-89dd-4aed-b26f-19ff27a536ee"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("f85351bd-fc30-4232-9a7d-6d0f75f3fd19"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("fbc47c70-8bf6-4f8c-a73b-e10bfcaa50eb"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportDistrict_RegionId",
                table: "TransportDistrict",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportFee_DistrictId",
                table: "TransportFee",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportFee_MethodId",
                table: "TransportFee",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportRegionMethod_RegionId",
                table: "TransportRegionMethod",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportFee");

            migrationBuilder.DropTable(
                name: "TransportRegionMethod");

            migrationBuilder.DropTable(
                name: "TransportDistrict");

            migrationBuilder.DropTable(
                name: "TransportMethod");

            migrationBuilder.DropTable(
                name: "TransportRegion");
        }
    }
}
