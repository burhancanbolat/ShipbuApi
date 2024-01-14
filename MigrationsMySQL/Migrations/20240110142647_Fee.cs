using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class Fee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Fee",
                table: "TransportOrderItemFeatures",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "TransportMethods",
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
                    table.PrimaryKey("PK_TransportMethods", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportRegions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsOrigin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDestination = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportRegions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportDistricts",
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
                    table.PrimaryKey("PK_TransportDistricts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportDistricts_TransportRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "TransportRegions",
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
                    ETAMin = table.Column<int>(type: "int", nullable: true),
                    ETAMax = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportRegionMethod", x => new { x.MethodId, x.RegionId });
                    table.ForeignKey(
                        name: "FK_TransportRegionMethod_TransportMethods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "TransportMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportRegionMethod_TransportRegions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "TransportRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportFees",
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
                    table.PrimaryKey("PK_TransportFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportFees_TransportDistricts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "TransportDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportFees_TransportMethods_MethodId",
                        column: x => x.MethodId,
                        principalTable: "TransportMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TransportMethods",
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
                table: "TransportRegions",
                columns: new[] { "Id", "Enabled", "IsDestination", "IsOrigin", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("39887e51-8a46-42c1-b621-699d96326883"), true, true, false, "Europe", "Avrupa" },
                    { new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), true, true, false, "UK", "İngiltere" },
                    { new Guid("a524039f-30f6-4adf-8cd3-2e0859fd08ab"), true, false, true, "China", "Çin" },
                    { new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), true, true, false, "Canada", "Kanada" },
                    { new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), true, true, false, "USA", "ABD" }
                });

            migrationBuilder.InsertData(
                table: "TransportDistricts",
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
                columns: new[] { "MethodId", "RegionId", "ETAMax", "ETAMin", "Volume" },
                values: new object[,]
                {
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 }
                });

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("04a25995-6c5c-4963-b1e9-bdccc364050c"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("04bdd099-ecf0-457e-8a64-b051be40d6dc"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("0796435a-f654-4f63-9702-3443ed22a2dc"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("11f9ecf8-239a-41f5-ad95-1a85ea3fc861"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("15ca3c1b-bb7c-49a1-899e-e8cffa8bc5af"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("164bcda9-cdb1-46e1-b44a-a1d4c010a658"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("1d3a6321-c72a-4a16-9803-1ab660e454ba"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("25c22d18-3f33-48ab-9b4e-eaed18ca3bb9"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("25f0613c-057b-461e-a833-1e1e410a9eb0"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2855f597-8346-429c-86c3-7faa74b31274"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2c96cab5-1adb-4af4-a5e5-f1e21f49acc3"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("2eb3d650-4381-434c-ad17-df0a12a7e286"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("33846f05-ab36-4cd8-b533-5df9750d7c1d"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("35dcb471-69c3-4d62-b868-3d2a76bba64a"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("36c78ebf-a791-462a-990c-604d92a802e1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("398ed365-a002-4a0f-bd4c-f81fecb94c4c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("43d02c82-0058-48e5-9afe-716f24064d71"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("45b505d0-cb65-4917-a90e-5896f0681603"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("46eef368-11c6-4d31-94cb-9afbcba28af5"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("487aeb28-7ec5-4f84-aa0b-8a9a88c0e696"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("4aa30780-9a5f-4556-ad52-0223a80a0d3d"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("4b5da2ab-dd87-43cc-9743-c009b7d7a38c"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("4ddb4b44-da6b-4d44-ad8b-29d07c5af57d"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("4f45eb41-6bf2-405e-9a44-fa8b1a7b09bb"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("4fc067cf-2a73-436f-8194-655a5c090388"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("50e708d0-a8f2-4479-8a0f-56eff44468f1"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("54f870bb-08c1-4839-90ca-33303a3b667a"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("5d673b03-146a-4e73-aa23-d9aa3c579c02"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("60405a7d-2022-41ff-b7f7-4c5ddcfa1173"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6ba60da0-6279-4af1-ab62-a7cff3026e68"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("6c709ad0-8d64-4584-93c1-b1372d0dc5ac"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6ce28814-f616-459a-ad68-ed6fd2d5646e"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("6d7d1ac5-b3fd-4ead-bfdc-450d2156fc90"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("6e48ebd3-b8e4-4b34-8f75-9408c2800bb6"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("6e8367ac-0ff3-4ebd-bcc2-ced56c950a8f"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("6e8cc39c-6223-41c0-b6c6-b0cf6c777126"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("7ce9f819-3e03-412a-8187-a1b89e9ded8b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("7f52b243-b773-4132-aeea-fa5ffc2c176f"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("7f80ff19-3956-41bd-9541-f24536f4e522"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("812a9c0b-7398-4cdc-a1e3-f87a12041ade"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("83dc4c30-28fa-4f3a-b584-bb0b05b2b24b"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("8459e2a9-c586-4122-8007-ce27ad46c983"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("86bb1f00-24dd-4a71-a628-e3a7a752e9c1"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("99a4dcec-5945-4d39-bc81-b337b3c137a7"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9fcb1d3e-ceb4-41d0-9057-c0bc218ad263"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9fefdcc2-2a67-43ca-9b48-0195435e28d3"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("9ffb2b07-ad26-46d3-87e9-bff911b64811"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("a0cd2113-7eb8-426b-8500-aa3479eb6af1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("a31778f1-c625-4a04-b3e4-910547360339"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a740a5bb-8f26-4708-9e4a-32545d164b6c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("ab86a408-9821-4db5-b3af-0d8bd4b40fe0"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("acd696d3-6a01-4a74-b3aa-db74c03ec1b2"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("ad91fd9e-7b92-4d9e-a596-9d537a6616e5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("ae086619-8921-4dd9-a585-a8b320446f48"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("b3dfd1aa-afd0-4e90-b8ee-bf8afc94b1c0"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("b55de380-10f9-4150-9a6a-b680df6bf4be"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("b79e928b-88bc-4cc2-865b-d518371ea8bb"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("b9cbf07c-5c06-4092-ab16-36a9c942c404"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("baf72862-41b7-43bb-b1b0-5a8e79829c04"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("bb0f2f46-47ac-46f4-ac9b-86f3d1aabe2e"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("bec66dba-50da-4f5e-9b5f-f8ed0ce5ecc4"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c42211c1-51f3-4287-9800-6ed9dbc14fa0"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("c6780d41-12f3-463d-b0ff-10cf2f3d6b22"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("c912db18-5116-45e7-b273-d5fc40c8ccba"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d1f888d9-d6b5-4039-b3df-5087e638cad1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("d34c0829-3cf9-4910-a7b1-2a74b6d9053d"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d4789a3b-748d-4f5d-8890-d807cb92575a"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("d4cd4ec0-1d33-4bbf-a49a-df423317fc23"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("d53ff9ab-bf5b-43eb-b2b2-9c0d1bc7c8fd"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d821b2cc-e214-4ac6-88e3-916bbbdde894"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("dae7545f-b27c-4063-9189-5d4ad38b48b5"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("db877960-597f-410c-b327-c5fca0c4c36c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("dd04c8b4-1a01-4dec-b511-f2cfae47b469"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("dfe4659d-fee4-49c4-a22e-bff0400032d3"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("e18d1bc3-0265-4d9a-86fb-bea9872ae177"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("e80b98ef-de69-4a31-a8be-9a2b5eada15d"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e8214c9b-8e45-435b-a97e-09bf9ad6efae"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("ece1a8f1-c748-4414-b187-22fab61de63f"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f05ce716-ac44-43f3-a4aa-f166f90e17a3"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("f06582a4-5da5-4fef-9bdc-e453ca04a56e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("fb63d0d8-6572-4240-a027-1b2e1315071e"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("fbefd00b-0d2e-440b-9ffb-319539862aef"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("fdf57edc-6075-4ac0-9163-ca9e6a3056e5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransportDistricts_RegionId",
                table: "TransportDistricts",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportFees_DistrictId",
                table: "TransportFees",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportFees_MethodId",
                table: "TransportFees",
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
                name: "TransportFees");

            migrationBuilder.DropTable(
                name: "TransportRegionMethod");

            migrationBuilder.DropTable(
                name: "TransportDistricts");

            migrationBuilder.DropTable(
                name: "TransportMethods");

            migrationBuilder.DropTable(
                name: "TransportRegions");

            migrationBuilder.DropColumn(
                name: "Fee",
                table: "TransportOrderItemFeatures");
        }
    }
}
