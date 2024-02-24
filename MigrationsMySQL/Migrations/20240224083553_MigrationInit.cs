using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    RefreshToken = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportAcademyVideos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionTr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionEn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Url = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "varchar(2048)", unicode: false, maxLength: 2048, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportAcademyVideos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "TransportOrderItemContainerTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NameTr = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemContainerTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItemFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    NameTr = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameEn = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    AttachmentDescriptionTr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AttachmentDescriptionEn = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fee = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemFeatures", x => x.Id);
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
                name: "TransportStaticPages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Enabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LabelTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContentTr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LabelEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContentEn = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportStaticPages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportPayments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Amount = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportPayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportPayments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    MinWeight = table.Column<int>(type: "int", nullable: false),
                    MaxWeight = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "TransportOrders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    OriginId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DestinationId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TransportFeeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShippingNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrackingNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportOrders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportOrders_TransportDistricts_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "TransportDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportOrders_TransportFees_TransportFeeId",
                        column: x => x.TransportFeeId,
                        principalTable: "TransportFees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportOrders_TransportRegions_OriginId",
                        column: x => x.OriginId,
                        principalTable: "TransportRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TransportOrderId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportOrderItems_TransportOrders_TransportOrderId",
                        column: x => x.TransportOrderId,
                        principalTable: "TransportOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItemContainers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TransportOrderItemContainerTypeId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemContainers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportOrderItemContainers_TransportOrderItemContainerType~",
                        column: x => x.TransportOrderItemContainerTypeId,
                        principalTable: "TransportOrderItemContainerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportOrderItemContainers_TransportOrderItems_Id",
                        column: x => x.Id,
                        principalTable: "TransportOrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItemPackages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Width = table.Column<float>(type: "float", nullable: false),
                    Length = table.Column<float>(type: "float", nullable: false),
                    Height = table.Column<float>(type: "float", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Products = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemPackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportOrderItemPackages_TransportOrderItems_Id",
                        column: x => x.Id,
                        principalTable: "TransportOrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItemPallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Width = table.Column<float>(type: "float", nullable: false),
                    Length = table.Column<float>(type: "float", nullable: false),
                    Height = table.Column<float>(type: "float", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemPallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransportOrderItemPallets_TransportOrderItems_Id",
                        column: x => x.Id,
                        principalTable: "TransportOrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TransportOrderItemTransportOrderItemFeature",
                columns: table => new
                {
                    TransportOrderItemFeaturesId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TransportOrderItemsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportOrderItemTransportOrderItemFeature", x => new { x.TransportOrderItemFeaturesId, x.TransportOrderItemsId });
                    table.ForeignKey(
                        name: "FK_TransportOrderItemTransportOrderItemFeature_TransportOrderIt~",
                        column: x => x.TransportOrderItemFeaturesId,
                        principalTable: "TransportOrderItemFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransportOrderItemTransportOrderItemFeature_TransportOrderI~1",
                        column: x => x.TransportOrderItemsId,
                        principalTable: "TransportOrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TransportMethods",
                columns: new[] { "Id", "Enabled", "NameEn", "NameTr" },
                values: new object[,]
                {
                    { new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), true, "Sea + Limited Time", "Gemi + Sınırlı Zaman" },
                    { new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), true, "Sea Slow + Truck", "Yavaş Gemi + TIR" },
                    { new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), true, "Sea Fast + Truck", "Hızlı Gemi + TIR" },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), true, "Air", "Uçak" },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), true, "Sea Slow + Express", "Yavaş Gemi + Ekspress" },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), true, "Railway", "Tren" },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), true, "Truck", "TIR" },
                    { new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), true, "Fast Vessel+Truck+Limited Time ", "Gemi + Sınırlı Zaman + TIR" },
                    { new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), true, "Sea", "Gemi" },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), true, "Sea Fast + Express", "Hızlı Gemi + Ekspress" }
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
                    { new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), true, false, "Lithuania", "Litvanya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
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
                    { new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), true, false, "Finland", "Finlandiya", new Guid("39887e51-8a46-42c1-b621-699d96326883") },
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
                    { new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), new Guid("39887e51-8a46-42c1-b621-699d96326883"), 5, 3, 6000 },
                    { new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), new Guid("5d751653-be94-44f4-afbe-5baf410ae321"), 5, 3, 6000 },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 }
                });

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MaxWeight", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("0073a042-5f1c-4e04-bfa4-43f2e213b9be"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("00a7704c-783c-4bb7-8a43-f2c4ad59edad"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("01351672-9659-45ff-b3d9-4c01066c1b1d"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.81m },
                    { new Guid("01a1de25-bc68-4db1-8b33-e6360c098b45"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("0246b578-2699-411a-b842-0d0440a38a8c"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.47m },
                    { new Guid("025515d2-843f-47d6-b16e-b5f9fd40160f"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.32m },
                    { new Guid("02975b61-98f5-4426-ba8d-03264782e412"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("03e4c088-c7a9-4c0c-b0eb-6f984f14ee04"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.80m },
                    { new Guid("03e9080e-a661-4831-a900-47d0f8d9c123"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 101, 2.45m },
                    { new Guid("03f4f73d-0a81-4763-9442-256e448f7e23"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("049a374f-6809-4d92-8929-b4148f1eb58f"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("049d2d5a-857a-41a0-bf28-5a1ab431072e"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("04a4ed5d-fe75-4650-94d6-da0aaff22c9d"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 3.02m },
                    { new Guid("05fda3d3-a154-4d60-834b-056089c5aaa0"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 3.02m },
                    { new Guid("0616223a-82ae-447d-ad59-daa4565f4a1f"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("065a810e-a750-438a-ba82-543cd54024b6"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("0697f599-9ca7-4826-b934-d062092ade1f"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.74m },
                    { new Guid("06a56f90-0315-4e47-96e5-b1332caca830"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.17m },
                    { new Guid("0756f495-6ac6-4ef7-9a6b-6e8bdb2798a4"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("0844e360-f6d2-4aac-bd38-d5f0226cc4c5"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("086d5322-5f8d-4027-9231-e3ff623b1454"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 2.73m },
                    { new Guid("08bf2a1d-4ed3-49f0-b47c-e6f1c5a46398"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 2.01m },
                    { new Guid("09037970-e69f-44db-83c6-c36f58868934"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("0911524c-7185-4896-a612-710f56323fb4"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("093f36e9-8337-4d04-91c1-48afe61e11fc"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.74m },
                    { new Guid("0b53d6bf-c910-4c92-ba40-4fbb0d21d5b7"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("0b693a43-43af-4a3d-9e38-907ec66cad18"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("0be6211f-6fec-4201-b6e1-1ef8d74f3bd8"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("0c5472a9-551c-4363-bb9a-9b493388e512"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("0c782eac-3fad-4cc2-a099-1bee43204c24"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.47m },
                    { new Guid("0c956787-4655-42e5-bd84-b0a67d98ac17"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.31m },
                    { new Guid("0cc43ee8-a3e2-4959-b2aa-3f53ae478d7e"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.90m },
                    { new Guid("0ce08153-b9bc-4e1f-8209-4caf087a2506"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("0d14a4bf-839a-4714-a329-b34b20c094aa"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.37m },
                    { new Guid("0d66b125-da6a-45be-84d4-1afa920e52de"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("0d73085f-47d0-4435-9fff-4c3d6b316139"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("0dd4970c-8c03-4624-b340-3d25bd675159"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("0de88ea0-d72b-43d9-89a1-613bd4bbeb77"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("0e32ec0d-4f83-43ff-9d74-b9823bb5c34a"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("0e4a1833-841d-4a27-b1ce-7f4f256f0550"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.24m },
                    { new Guid("0eb6a429-5af9-440c-adac-75b19c43e195"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("0ebabc20-8148-4bd4-85dc-a0f923a08fee"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("0f27a426-7f3a-4713-98db-d490e72a0859"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("0f71805c-9733-4c51-987f-956c6b0a8c38"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.38m },
                    { new Guid("0f7d8c17-399d-454f-b11f-0402e1e57865"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("0fd10eb0-65f1-45de-bd0d-877eff45f1f5"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.22m },
                    { new Guid("0fe0027a-3b8b-406f-8fa7-bfdbc95f8794"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("101e90cb-d6e9-4067-9afb-a497218a7e2b"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.88m },
                    { new Guid("104c7abe-fa6c-4b12-ab35-b4bdd3b23c20"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("10aa8518-a37f-4bf4-a795-4afa28cf5845"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("10aacbb3-e950-49bf-97cd-205d14cadc39"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("10abc348-10a7-4b67-8565-ce7bd3137a45"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("10e73d0e-c304-4ae7-b379-c1ee7ee72348"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("10fa3a8e-928c-494e-a703-6677dc9bec38"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 500, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 301, 2.37m },
                    { new Guid("1124321c-5441-4966-a180-d51bf4ae999b"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("113eb159-2f5c-488b-b98c-69fe59813da7"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("11416243-53c1-4526-b84b-24983ec3d5de"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("115d559e-054f-42e3-83d2-46849cf3a9d8"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 1.91m },
                    { new Guid("117dd5a0-d4e3-4dfd-ad8b-8e34aec92d02"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("118fca54-7e4c-4b11-b2e7-17e804c0ae1c"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.32m },
                    { new Guid("11e57825-6ca8-4789-83d8-3d547b5aa313"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("1205b2df-410a-4f17-910e-00db5ebca569"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("123f9d36-f2c0-42f0-b950-6650fd9907fc"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.99m },
                    { new Guid("129d1696-85db-4a27-a9a9-ce82c118727f"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.80m },
                    { new Guid("1330882e-bbf1-457b-8fea-c49d6c9b9c7a"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("134d70d5-0ee3-4f92-b6f4-651a8c437741"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.02m },
                    { new Guid("1366f5ef-a3de-4b97-8f36-2b3768944226"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("1368d1da-da2a-4abc-b830-fcef2c40ed97"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.45m },
                    { new Guid("13bff28a-e171-4b3f-bb7c-ad8fe87b3d7f"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("13c43f67-ca38-4030-8b41-bab1f7a06ccb"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("13d47708-4922-4e87-8e6c-baf2ed607ca9"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 2.73m },
                    { new Guid("13edaf27-38ee-41c0-81cb-e0c88e82c6db"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("146d5684-7001-40df-b578-88225b8e2c34"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 1.73m },
                    { new Guid("147545e0-7748-4d4a-af3e-b8c211d02f91"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("1530be07-5f4b-49b2-b12e-4137db0df36c"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.60m },
                    { new Guid("158ef90d-c07f-4b01-9ec4-29ada3c18f1c"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.02m },
                    { new Guid("15b68f93-088e-4ef3-bc17-ef4729754d1a"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.23m },
                    { new Guid("15be0e3e-2ac7-4c9c-a466-e78431a5c525"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("15e45637-b8d5-4d0a-bb81-0838030ea018"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("16023e25-68e0-4682-aa82-be65e96770a7"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("16165255-3823-46ca-a16a-9a9ac894f29e"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("16649e67-8bb5-4193-91d5-4eceecfe23f3"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 2.09m },
                    { new Guid("17365044-dd14-4d77-998f-ba3c49e52c7a"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("17b55407-9275-4fbf-822b-d508eea2d0cc"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("17bb49f2-1c55-494c-ad4a-a72d4e6c09c3"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 2.73m },
                    { new Guid("180c89da-0d4b-4e1e-ac38-65ab4eb39796"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.59m },
                    { new Guid("181bd787-28cb-41a2-a360-100aaed6c1cc"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("18546e02-f3dd-4083-9571-fb224be063a4"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.58m },
                    { new Guid("185f2a76-a8e2-4358-ae71-65fceb71e70c"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("186b84f1-43e0-46f8-b2d5-e5bd9117f7e3"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("187cb6f8-6d39-419e-89b4-6e0d9ff2f12b"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 4.32m },
                    { new Guid("18999d8c-556b-4aba-8368-a57f914d54d9"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("18a9999c-7cf3-4f16-adec-d781d6156479"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("191f7dbe-20c9-4750-9fbf-0322b750048b"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("19aca4ee-7dc4-490d-8330-ee5d98ec4300"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("19c664f4-392f-455f-baa7-32d31e11a106"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("19d3bad6-a052-4db3-87b5-b2f7f32d949d"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.90m },
                    { new Guid("1a38e337-66dd-46ad-aa1e-f1507bc75d2c"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("1aa58d28-cc74-4c41-86cc-d52753706f9d"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("1ab054d4-868e-4197-8541-d109514c580c"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("1abdeacd-abc8-4df3-85f8-2c51783e9f31"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("1aed8389-25de-4c86-850b-13b846a5d115"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.76m },
                    { new Guid("1afc52ed-9f14-4cbb-ad48-9c52a3816b30"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 2.20m },
                    { new Guid("1b072721-a39f-468f-a048-84714e7ce7a7"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.97m },
                    { new Guid("1b6dc0e9-8c0a-455d-b3a0-ffff9129dda5"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("1b6e027e-79c9-4dff-9ab2-d41fdb95d989"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("1b842a4d-b213-47e3-8ae3-fe145ca59c6f"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("1b8b94b2-eae3-48fe-b439-1eb3f41e3fdf"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("1ba6248b-097d-4126-b467-93e239548e52"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.56m },
                    { new Guid("1ba93afd-57c9-4b28-b8fb-10d7802c4b3d"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("1c1b86b5-92fe-4cb7-98f3-885feeded2bb"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.56m },
                    { new Guid("1c6a6d81-3a95-4617-8907-553276435c8e"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("1c758767-cf5a-4094-9ff7-911b15481c43"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("1ca63fd2-c0d8-4cdb-a1b6-32149ac4afe2"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("1cab6f1a-298b-4f63-a041-58d1b6d1f976"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("1d46dbf0-0403-47fb-9898-e0408912a00d"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.95m },
                    { new Guid("1d4c0993-028b-4ea6-baab-9bf3fd6e2ae8"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("1e17af3a-9247-431f-9fdd-d6ecfc77ee89"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("1eca02bc-6adb-47bd-9dee-bd1d0157f7ea"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.24m },
                    { new Guid("1f93d4bb-0b30-4228-8c32-e2f65736bd80"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("205844e9-476f-4e0f-b05f-63b5ecc04c12"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("20936405-c63f-4213-9ce7-bb472fa3e103"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("20bf1ca0-6d8a-466d-890a-e5d3842cda8b"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("21060938-5486-422f-917a-90437eec3e96"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("21149358-e8ce-48d3-8281-54006d4cb21a"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("21abde0a-7317-44ff-b650-ffbd2e1e36db"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("21d69cc6-2b18-41a1-adbd-0390f6b73e67"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("228e511c-7bd6-4b5d-b956-0ebbbc7010ff"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.52m },
                    { new Guid("2338e3d3-3905-484c-ad38-f4d3cd644e50"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("2355d2da-910e-4bcb-8d34-53b4d9ede30c"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.40m },
                    { new Guid("23b1a84a-4602-43dc-b2fc-943b6e429fca"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.56m },
                    { new Guid("23b20561-9a7c-41d5-9ddc-934db0d357ad"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("24040c3a-1484-4288-b65c-22715c4c73c6"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.19m },
                    { new Guid("240bf2d1-de6c-4d18-87b5-e980f427b3f7"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.88m },
                    { new Guid("24be6375-d787-496d-a603-9d9565311768"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.94m },
                    { new Guid("24e184d7-a327-494e-8e1f-ed8e55d3807a"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("258bff90-b323-4e16-b4d7-f5ff575005f9"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("25ed827e-21bb-4934-9673-365639f78377"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("2619a6f9-2649-474d-98a2-d3f997095782"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("2649782c-44c1-4162-a38e-4afde919da39"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2695a963-dd94-4419-941c-67159230d77b"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.24m },
                    { new Guid("2724d6f8-7fc2-41d8-b6f6-9642902a840b"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.65m },
                    { new Guid("274b13b9-358d-464f-a698-3b576c319c26"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("27a50ae0-1130-46d1-9204-7c77d19dc58c"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.44m },
                    { new Guid("27ae7c97-cef6-4df4-935c-1bdb2df6e221"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("27e499c8-aa77-4530-bf9f-07ce6980ff5b"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("27ed5dfc-b5f8-4211-8f35-4bf43a6838c5"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("2846e085-0694-49f6-b4f4-9e2ef0f7134a"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("28f08987-b12e-4edc-a6cc-694856aa011a"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("298f581e-25e1-4ab1-aef5-67f5f1f1cf85"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 1.73m },
                    { new Guid("2a1a4b8d-a42e-4409-a6e5-cb44fa276cbc"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("2a922dca-dc71-4b52-b30d-3daffaad1980"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.85m },
                    { new Guid("2add179f-49f3-477c-9a0b-1e4915d130f2"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("2bd7e0d1-13b7-4176-9f68-b2542acb0a32"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("2befa810-c1fe-4f6c-9da3-24099e6dfb37"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("2c1ef292-75c9-4f84-82e0-817291642c99"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("2cd50667-f479-44b9-9e31-f87e9fe4560f"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.24m },
                    { new Guid("2e3044a4-8f4f-41a5-850e-696c5e63164d"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("2e3148cf-de77-43b4-b684-f932272a90d1"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("2e3cdab9-fc2e-455a-8b91-ecfdf35b0110"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("2eb2816e-e46b-476a-9707-647f486603d3"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("2f1bbbd7-2680-4981-8725-538d3f2858c2"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.81m },
                    { new Guid("2f47b5fa-e4f1-4930-9626-cb83cb71418d"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("2faecc28-ea70-4940-babd-c5b0481aa020"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("3007d7ad-9a23-443a-86a8-94d3be3b8e69"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("301b0399-85bb-4098-bfd7-8b98d07d536d"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("30395a03-8beb-4d92-af08-f4ecaefa1f34"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("303dc5fb-dd50-4278-a54b-32c234eab471"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("309d67d8-0933-4b67-9458-e946aac2dd41"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("30c4aa83-baf9-4c91-ab55-175ccaa139cc"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("3160d459-0244-4bdc-a827-c43d26254a81"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("3197e42c-28ee-435b-b4af-6ed900be51d2"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 2.73m },
                    { new Guid("319cb3ad-806a-45d6-8fbe-9fa1b78be8f3"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 300, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 101, 2.45m },
                    { new Guid("32ff6f4f-34b5-46c0-b803-f68fc18a4def"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("3370e1d6-3636-4a28-9713-e0deebb8e8a0"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("337c5d5f-74b3-408b-b3e0-27c3c3e90633"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.64m },
                    { new Guid("33cc5f87-c7e5-4221-8fe4-4baff665d5b9"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("33ce51ab-2b79-46ff-85e7-431f6b590bb7"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("33e279fc-03c0-4d3e-9ffb-bde760a7c95e"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("33f31cb2-22f0-4a7f-b970-00dd45060f24"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("342cc9d9-3516-41b6-ab26-1869a2cdb11a"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("34565cab-f664-4fd9-92d8-bae4ac08f129"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("34568b0c-91d3-4113-9932-7bb46fe4cec1"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("3468d19e-8e29-4824-86f5-98e8441e1669"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("34697070-2df3-4f98-8f4e-cd1eed798d68"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("34d8828c-a864-4480-a236-0e593b9188ac"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.01m },
                    { new Guid("34eba1d7-c4f7-4086-87d0-cc111a25a80c"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("350008b1-d858-422a-ae75-7237dd1dbcc7"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("3519b00d-6d93-4734-974c-b75b2e3226e8"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("356f63f8-d950-4cb1-931c-9dcff1928e41"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 2.66m },
                    { new Guid("3599ea30-f48b-49c9-a849-bfba11d47a68"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("367b8e39-95cc-46f2-a79c-9a8710e2a09d"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("367e7e53-f2ee-4b95-8539-070d6fb703cc"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.59m },
                    { new Guid("3680a920-b325-4a07-955a-f74db9a81eb7"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("370d04f9-3cfb-4f70-adea-125bea68008c"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.81m },
                    { new Guid("371a5baf-ca93-417e-a086-9b0e7e51ad8f"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("371c2a7d-1ff0-4566-a783-ec5fdaf5de7e"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("37332aa7-f5a1-4720-bfe5-968f5ecf47e8"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("377147d2-8164-4417-92ff-9dc418533188"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("378bb056-cf4f-4ead-8540-48275abbd0e4"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("37f61b20-d82c-429c-89ce-3b771da6fff2"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 1.95m },
                    { new Guid("384e878b-d95d-45c2-ae12-8d4c08c3af00"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("391a8b34-43a5-4301-9f6a-1dcf5ca807ea"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("3957079b-fa9a-4d81-909d-d9a181b7ab96"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("3961faca-10cf-489c-9f46-fc16039797e9"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.22m },
                    { new Guid("3a087d99-dc20-42db-b711-e65926e7db3e"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.25m },
                    { new Guid("3a760a22-881a-4a74-a843-70deb2fa8765"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("3ab708d8-ebed-4ee8-b751-804f11e72f5f"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 2.23m },
                    { new Guid("3aeeaba6-92db-4ff8-a4ad-a5477282def2"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 500, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 301, 2.37m },
                    { new Guid("3b5006e7-c539-4d00-9924-9ddc48b677e2"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.29m },
                    { new Guid("3b8bb607-776a-42ff-a70c-35b49e0a9502"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("3ba041f4-2605-419f-b7cb-daa3ab593778"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("3bd50164-dee7-49ad-95f4-285bd5c6527d"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.24m },
                    { new Guid("3c05dce0-7117-4604-a3db-c37f7fb3f074"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("3c83fa78-c904-414b-a41d-24872be6d901"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("3c9b4527-98ba-4e7a-91df-7e3ec46c3786"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("3cb3afe0-9676-42f5-aede-24b79c5c8ab6"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("3d3adb16-31ee-4049-87f2-a56f198b5627"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3d9a0f6b-14d0-4856-b071-d348288b9957"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("3dc4bf1f-4556-4533-910e-86c6be2b8eeb"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.88m },
                    { new Guid("3e9ea01d-fa38-40d4-a832-0ec3767e868e"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("3ea05b04-92f8-4f7b-916f-2fc96f093640"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("3ee1acb6-f0ed-4269-9f76-e164bf392799"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("3f0fe2c6-3969-4bce-8c56-612b54301769"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("3f6fcf26-b55f-42c4-aa6f-260c4291c833"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("3f8913b8-1046-4330-ad9a-03ff55df3602"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("3f91b542-2e31-4d06-b24d-6a720b59e977"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("3ffa6e4c-4e66-4e81-b714-873fff411c41"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 3.09m },
                    { new Guid("405c8f5c-ff36-4286-bf68-24d028d74351"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("4061fa12-dcd4-4520-995b-3156184d187d"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.38m },
                    { new Guid("4072f02f-70fc-40f7-abda-6e22fdc6c417"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("40fefe4b-d9db-475b-846b-5d3ffdb16a92"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.45m },
                    { new Guid("4202a9fa-f032-454a-9ee8-0cc6c35efdd6"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("420dbf82-0eaa-4a58-bd37-f7f95d7e3e4c"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.84m },
                    { new Guid("425624e2-f4be-4463-b7f4-6efbfb093ce7"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("425d2415-3ec3-49cc-83ee-6ac3c74bafd8"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("42b3c223-27a8-459f-876e-ff8fc97866eb"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("42b54cda-ed5c-4d33-9aa5-568b949e7ab5"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.23m },
                    { new Guid("4329c82a-1c36-467a-a193-d4cd47d013e6"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.68m },
                    { new Guid("4334d225-4b6c-4605-86e1-5e2e76be4003"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("43365ff0-2357-48b4-b786-19b3f1d45f3d"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("4351f3b5-cb50-4c88-821f-0ca4c55b06ee"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 2.66m },
                    { new Guid("439074e6-7347-4b75-97af-f7936b35ec3d"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.81m },
                    { new Guid("43a658be-a61e-4c13-880e-974b563cea59"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.23m },
                    { new Guid("43d4a2d5-d293-4432-9672-b944b760756d"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 2.13m },
                    { new Guid("43d7931c-d79a-46f7-8087-44767a85edc2"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("43dcae95-fc1a-4aea-b08c-e4cd0398b402"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("43f97463-6dcb-4e6b-aef0-7b45007d2c02"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("440d85d3-5385-4cd1-9032-25dfc20135a6"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("442bb162-9521-4411-8b73-20428174eeef"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("4433719f-f7ab-45b4-a380-2671d0a5f975"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("44707e96-1a59-482c-a30b-c751743686de"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("447af47c-fe76-4201-a2a8-b14e24bba16c"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("44a3c378-8829-4bc5-9a04-6a492e9be3a6"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 2.10m },
                    { new Guid("44ae81b6-3bff-4207-8f1d-0d01e215f3d0"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("4513a701-cb88-4b4d-aabb-014d08e6ec44"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.90m },
                    { new Guid("458319c0-4c26-4cf8-bd9f-95c4c3c3bf3d"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("45fa5487-2426-4aaa-8634-56e999925512"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("45fe89ac-4013-4b3f-be1b-6bde2e8a3608"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 2.01m },
                    { new Guid("4629df83-6518-46b9-ab8a-9dcaab268248"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("46bdefe9-5ea5-4e8b-ad9c-3dfa3dd7cfd0"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.01m },
                    { new Guid("46d06759-4870-4356-8e54-c773093b63d5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("46dffd4c-45f6-42c6-aaae-f332e2422836"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.15m },
                    { new Guid("47750d89-6f01-4b70-ae81-da5680939db9"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4775d28f-b148-4316-8a90-745dd3911d14"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.03m },
                    { new Guid("478595a7-c32a-4cf7-b1ef-37c2e2653479"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("47872944-7141-471d-b370-d69d644c32d4"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.70m },
                    { new Guid("48470ae4-5dc2-4dc7-892d-ff1f89107ae7"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("4898f4a3-a752-4d10-9b83-f26d2642cdad"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 1.87m },
                    { new Guid("48e9b1f9-29d6-4914-835f-f67591f5a28b"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("4903f6e6-7645-4112-abba-0a6a56010967"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("49741e42-044b-4e0c-abc8-131eaddc6a7c"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("4a2eafb4-12e0-4773-8def-981e106b47d0"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("4a547be0-fb02-4bd4-aaac-3264d45dae3b"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("4aca4f93-b288-4b10-9a81-38e58d00cd3b"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.30m },
                    { new Guid("4b80f0fd-af99-42dd-8843-30ba726b7d9f"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("4b8295a3-ee94-422d-8b90-73f801975f5f"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.80m },
                    { new Guid("4bbfc171-45e3-4f9d-abc4-ea7b22c39636"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("4c001157-273f-49c9-aecd-50bb3995f87e"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("4c833ee0-9947-465a-9845-04ada1476500"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.88m },
                    { new Guid("4cf70c10-f44b-4383-bbb7-4d56edef8178"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("4d866e25-3d35-4f67-885f-4ea6e31ffee4"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("4e03b4da-0fc0-4810-89a2-f6c505896388"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.29m },
                    { new Guid("4e084082-a997-4774-89a6-d5a35d40cb28"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 2.09m },
                    { new Guid("4e229484-5d0a-480a-9231-d8c79c5766bc"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.29m },
                    { new Guid("4e5d7afd-b41c-438f-a05f-7b548290930e"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("4e9da3b7-66c9-4008-ba93-43bd3c63868f"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("4eab32d3-9c43-420d-9f18-df1b5c612bdc"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("4ebe5045-6bcb-4672-ba9b-1155829515e7"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("4ef13269-7e7b-4a93-b450-5d5c6f2f854c"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("4f53f1c7-7b51-44e7-a504-6a8b78f5eaa2"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.47m },
                    { new Guid("4f7a1158-89b6-4422-9089-0af05853d06b"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("4f7fed13-2155-4c97-8aa1-7a7e270c8f69"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("4fa27a45-5381-4864-9ab6-94b2941e9adb"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("5029bcfb-4667-460c-813c-c81451abad34"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 1.87m },
                    { new Guid("50a16587-a9c9-43e3-8f69-64260861ceb0"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 1.61m },
                    { new Guid("50b61d86-18f7-4d16-b3d0-f15100544966"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.77m },
                    { new Guid("50e150ea-049a-4ecf-8efa-84b0debd9f03"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("515caed0-ed4f-4832-a0a5-9d3143cb3657"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("519c8d0f-166a-4465-abe1-5bb8b54cc970"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("51b0bd5c-4d47-4477-9189-fe5ca22e384b"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 2.88m },
                    { new Guid("526698de-12ef-4009-91de-c5c4e360b61f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("52a2ec1d-dceb-4abf-953f-6925e62af561"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.94m },
                    { new Guid("52ad9270-7bab-47eb-9025-287033959d0c"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.55m },
                    { new Guid("52c41803-c9fb-48a7-a269-0eb53d8335ce"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.77m },
                    { new Guid("52e3a226-d402-46b6-b6dd-f4fec4b577d0"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("5308a442-0a03-4663-89a6-76ff4b365eb5"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("531274f4-f2da-41ae-8e25-61367be161ef"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.58m },
                    { new Guid("538b64dc-9a2b-49b5-965d-5034a42bc9da"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("538ef07e-9ac4-4c56-8444-c3351cca6eac"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("53dbc981-7bc3-48be-871e-f8cccf17a6b8"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("53ffd56c-4e24-4781-9fef-5c184db556f0"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.02m },
                    { new Guid("542deb95-e11c-4e5a-937e-8a9f79bd8bbc"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.81m },
                    { new Guid("553ce010-509b-4fb4-aecb-1ea343ab33b7"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("556bdda2-9129-4492-b1b4-a574dd95eda4"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.94m },
                    { new Guid("5605c8f0-6775-45e0-a6aa-ef5735815ab6"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("562a3f0b-202c-4528-86df-2b8bf9f7dc05"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.29m },
                    { new Guid("568d0308-431d-43f8-9923-e2260c26286a"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("569e34ce-ae85-4195-8902-fc60f85eb373"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("56b72784-3607-47b8-a774-7ced17ce47e1"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("58091fd5-d9e1-43ac-9e77-9552e4a9703a"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("5833e75e-46a5-455e-b1cc-e8bcb37b2578"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("58737343-987a-4580-ab07-2c5a7b2212d7"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("58cec536-d02f-47b0-b117-864eef229ec7"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("58daf1ca-442a-4fef-9a7a-e6d2e68f3cfa"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("59808f6b-5cfd-4ca0-ba68-8e0bef8e7cc3"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.80m },
                    { new Guid("59e546bb-503e-4786-8bad-66847a017a21"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("5a69d6b2-bd50-48c7-90b6-545786dd760e"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.23m },
                    { new Guid("5aa20930-abb7-4844-8c83-5c67b6b316c4"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.80m },
                    { new Guid("5aa6fe4d-8692-464e-8c41-f15b45f2c9d2"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.01m },
                    { new Guid("5ade048a-8f04-4cc1-af66-8af9e50f6e37"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("5b8c4b19-882e-45ab-abfb-df389df85b7d"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.12m },
                    { new Guid("5bbe9f88-5123-492d-a235-2597891a8324"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.44m },
                    { new Guid("5bc959c0-39ac-4650-ba45-05483e64934b"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("5bccddc2-62ce-44c1-b7a2-585a9b530e33"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("5bceb63e-1145-43de-9379-0a21c373ccf8"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("5c192464-db72-4ea5-aade-04bbe8cc5046"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("5cd334a5-60a4-4298-bd6a-0c64271ceef5"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("5d3bd1bb-5bc0-4e95-8a91-a77e0f6dd49a"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 2.59m },
                    { new Guid("5d524fbe-0fff-4f5b-9701-f6fd76815b5e"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.30m },
                    { new Guid("5dd71143-af73-403d-82e4-015d8fabdb89"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 3.09m },
                    { new Guid("5df3a4d2-64cd-4325-b080-075bb3107b8f"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("5e0f661e-11d0-444e-965c-454bb473c887"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("5e127e71-ea06-4906-9e8d-6a9e06fc38e4"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("5e6cc737-c991-4c93-b63f-d8a94fc6fefe"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 999, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 501, 2.30m },
                    { new Guid("5e7522fb-49fe-4dfe-a409-34cb3251bb72"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("5e994b8d-7153-4743-ade7-752129030301"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.37m },
                    { new Guid("5ebb105a-d924-459f-9603-a823c545a560"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.60m },
                    { new Guid("5f511481-c3c4-4c7c-8be8-9118edb1e2a4"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.35m },
                    { new Guid("5fa5abba-a3c3-4e2b-ae75-94b3cac5e711"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("60f50415-7661-4c64-9e96-5a7aeb54d8c6"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("6121b667-d817-4591-b451-50f6198624b9"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("6168da32-7bb1-44d8-86aa-8d1ea2f94354"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("61a667cb-9ce2-4e4f-b6f2-d260be248281"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("61b4ee6d-f80f-4755-94cd-5cdab3c55db3"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("61d6854c-b94a-465c-98cc-533ff99be15a"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.77m },
                    { new Guid("61e35fa4-43a9-469e-9746-c25df0cd125e"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("62414aee-4330-44f3-94e7-c893866b97c5"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.44m },
                    { new Guid("631a3c1a-58d0-4f6d-a28b-861baea49dda"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.84m },
                    { new Guid("632141fb-3c55-4073-b00c-e714f5f27f6c"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.30m },
                    { new Guid("6327b949-aab4-4bcb-bb5c-e198a5cff173"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("639ed415-2367-48a9-b792-f09960c55f87"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.52m },
                    { new Guid("63dabe4a-ee74-4dcd-bd8e-49eb88a1abe6"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.70m },
                    { new Guid("644d6d99-d632-479e-8556-6f35eee6bf38"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("64c61b4a-8ef7-4d62-aae9-9f75421ed6f3"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("654191b7-4e58-46e3-a0c9-b00a6e19c776"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("654e23df-4337-4b72-85dc-c2e16c6159c2"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("657f7639-d053-4f3d-9482-02d0bf6fe050"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 3.09m },
                    { new Guid("659dc330-863a-4650-99fa-fde5d540d38f"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("65d1e875-9de7-4ee8-aab3-b70256c65f8d"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("661837a4-ab5d-4aee-99c8-daf0c81ea06e"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.94m },
                    { new Guid("6670291a-0374-472e-8f3a-ab0205b9daf7"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("67ac253b-e282-4278-8b50-d7d86614b80d"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("67dca7f0-650f-4a92-9d4d-0b17150c0673"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("680a7fde-1d28-4df7-90b3-ecb5a8701855"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("68fa138a-357b-4489-a6c4-5e953d9f4578"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("69562a37-2fc0-4523-b92f-03d65fcb1b7c"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("69ebb638-bd5c-42e1-b550-21418f52ac3a"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("6a11c662-3162-4b70-abfa-5067d053eee5"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.88m },
                    { new Guid("6a40d1a2-6ec7-4817-8788-b5df45c091ee"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("6ab78eeb-aaee-49e6-b853-f4649d5f2098"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("6acbc4e5-c1ed-4169-8b52-84ac71bc6647"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.30m },
                    { new Guid("6b4e0a0e-6aba-4478-ba91-04f1389c638b"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("6b53035a-feae-4fe8-8692-4c71fe7a1f82"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.59m },
                    { new Guid("6b6efae9-eab2-48e6-bf90-68995e7660f7"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("6b7d402a-8051-49c6-8efc-f3f9bc91495c"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("6c2ea0d4-67fe-45c5-bed9-c7779e921a10"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.29m },
                    { new Guid("6ce6c926-9947-4304-9ba0-e01fbab7fb25"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("6d051a4b-a7f2-43e6-bfce-56da9a0ec046"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("6db3f0e9-2a27-42a7-9180-c12e0130d3e9"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("6dd712e7-50e3-4f0f-9a99-cc846adf332b"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.67m },
                    { new Guid("6dfd4843-486b-43c3-89ee-34b9ce3308a4"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.37m },
                    { new Guid("6e1c847c-849c-4668-8ff8-94239a8e4a6a"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("6e5b1130-a2e0-436a-9567-cc079da96760"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6e6b9b68-176e-4f90-b365-a440925b0635"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("6e7a4be9-7691-43bc-9309-3c792eba71e2"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("6e7f3aab-19a7-42e5-aab9-73b6bfec950b"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("6e943fcd-cbf9-4771-b4bc-28d90af3fc99"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("6f266ea5-d8e7-46c1-bceb-f82ef250d791"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.32m },
                    { new Guid("6f43684d-0eed-4fe0-9e31-498ccddd1eba"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 101, 2.59m },
                    { new Guid("6f727dcb-6a49-452b-917b-d884b38aa99f"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("6f8a9687-04a2-40ca-92d3-501b405cc691"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("6fc15336-8373-499f-8de6-9076e7077238"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("6fff7f4f-1458-4035-9e8b-40a2afe3f839"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("700b2898-feb9-4d4d-9f71-46a2bd3ef7b8"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("702fd95e-cb78-4fe2-9059-fa8e1ebea0b0"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("70a98c58-deb2-4166-9e27-95060c3d03c0"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.01m },
                    { new Guid("71246c98-aa52-40a7-b1b1-238a5698e6a3"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 3.06m },
                    { new Guid("717e9e96-ae65-4ece-8a9c-3db694837ab0"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("71869c3e-48cd-4fdf-94a9-ec04753d58e9"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("7198566f-451b-43c6-ac41-0cf18ee604d8"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("719f3dcc-2f09-4b66-9a7d-0bb912e2e52a"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("71b9e3b3-bc17-43a9-a4ed-24fe758bd5f9"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("721b6913-67ed-4eed-813e-a3ef7cab3aa2"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("726bcf8f-90a1-42b7-a87f-aefec6bb8535"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("72a00314-4f0f-48f9-a2aa-f1c5820e4911"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("73cc3080-5e75-43e1-87ba-7ea8eb8e2220"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("74fc7562-7e47-4948-801c-c8ecc4b0400d"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("75dc534c-a0c9-4597-be38-71aead441b78"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 1.77m },
                    { new Guid("76094928-65b4-4762-82e3-b8e5fbfae095"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("760e8034-5ddd-418a-a6f5-083d701c5828"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("766e02d5-cc08-46c5-8e10-0b52bcc83142"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("76967fce-3e74-402b-a961-a8f41b159ffa"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("76efe39e-c61b-45b2-bc16-4592c587b5e9"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("777b0cae-e5e9-4040-b420-c4adba41d615"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.16m },
                    { new Guid("77bb460d-df29-469a-bbd9-6f3ae9e6a16a"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.52m },
                    { new Guid("77c56f37-7db3-4392-bac2-2297567e2085"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("785a4380-b9e1-4db5-a92c-482e82e80813"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("79217c68-6dbe-470e-9c43-f6b3e9755eeb"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.23m },
                    { new Guid("794b181e-2c1c-4a56-a594-723705c8bfa8"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.90m },
                    { new Guid("798cb2bf-4f7e-42f9-825e-4eb1116924b7"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 3.17m },
                    { new Guid("79a07e67-22a6-4870-96a8-59eb1978f509"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.22m },
                    { new Guid("79c3842c-2a0b-475c-b975-45b9af07c924"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.27m },
                    { new Guid("79d7b790-06be-4abe-85d1-73829c200d60"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("79d8d01d-233b-44b1-86cd-0d3511da17af"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("79d9b3f9-2091-49d3-b87b-d6145dd37bf0"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("79fb765b-a574-42a0-8288-f6ab1e85ca6e"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.33m },
                    { new Guid("7a5accf5-07dc-4f7a-b65d-d506d3ebcfbb"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("7b8ce110-7258-4bde-8e78-893cc5aba78f"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("7bc75594-79a9-4f46-860e-4499c0b15872"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.97m },
                    { new Guid("7bfd32ec-66ca-407d-b6e6-f44573700c18"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("7c7ed60b-124e-4f2b-9c07-d48a35b133a5"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("7ceb097a-e25f-41ad-94bd-78bcb8a1fc66"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("7d157a39-08fa-4b3b-b9e5-a4d0c227fddf"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("7d788216-8d92-4026-a387-f49a99c0a2c6"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.27m },
                    { new Guid("7d9d2068-b210-4bb1-a222-185949469849"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("7de229a4-3074-4a2c-be4f-823d5f5fbe15"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 1.87m },
                    { new Guid("7de90342-3e0a-415d-9b93-a58d7cd77403"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 2.01m },
                    { new Guid("7df36b08-d014-4104-95e3-c3177b1425fd"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.09m },
                    { new Guid("7e18ec0c-9f76-43b7-a96b-ee71a553b02e"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.76m },
                    { new Guid("7e2a91e4-1ef3-4eb2-af28-ddbcd4a360fa"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("7eb1bd29-de13-4e56-89c9-e8e1ae124eae"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("7f02541a-05b0-4b62-9807-46df220a8f1c"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("7f0bc2be-0e82-44e1-9a51-09dd1f4e642d"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.22m },
                    { new Guid("7f123cf7-4365-4cd2-9f00-e947c7590f70"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("7f4539a7-aac9-4957-8ef4-a31ceb9d0fc1"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.37m },
                    { new Guid("7f92ad43-bed9-418a-b364-081bb2ad5c19"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.15m },
                    { new Guid("80696384-34d3-47d9-beb6-be83d8c619c5"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("80fc790a-46eb-4e41-85d4-031d849a1ff3"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("817a016e-578f-400a-ae8c-8f77a4ba93ee"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.24m },
                    { new Guid("82a3798a-62cf-4ebd-911e-6d940b361c82"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("82eb049b-05c0-4de6-bde9-1c203a8abbad"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("83ac67ad-860f-4e4e-95c2-5bf3c199e2d3"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("83e8bc70-5f62-4be6-ae8e-da24329422f0"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("83fc3b66-554c-42a3-b88d-3c2074546e21"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("843d0cde-4a35-45f3-834b-66553b312282"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("8467871c-a3b3-40df-9565-24bbbe443a59"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("8475218e-9d26-414d-980c-0ccda8ed4b5f"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("852c6aaf-cc24-42f3-b4cb-103108d09af8"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("853a031a-9560-4106-ada4-fe7b3e129d55"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.44m },
                    { new Guid("8589ea87-4827-405d-8554-098a4a11ec8a"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 1000, 2.27m },
                    { new Guid("859d990d-087c-4880-94ad-ccd2cf5efaf5"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("85a4c418-2deb-4b61-ab18-8a8c2bde9368"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.02m },
                    { new Guid("861ad231-4684-44bb-8718-d9e7c540771f"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("863aac0d-c7d9-4c46-adf7-54b5750e1ff3"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("86a34b43-7aa7-43e4-9a22-9693ad24a883"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.74m },
                    { new Guid("86a613c6-143a-4ad1-af23-e010d9ad7492"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("87053ec9-2c60-4c31-81c0-6e20f2422663"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("8729b98c-d06c-4c5a-8f6b-f3a2d6965bc4"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("872fefc1-ebeb-4824-a6dc-5627f78ca563"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 2.95m },
                    { new Guid("8737aeaf-bd2d-49c4-ba95-454f531e937b"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.46m },
                    { new Guid("8779527a-f41f-4b41-ac2b-f675382c81a7"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.37m },
                    { new Guid("878823c6-3d73-4532-93ed-087cae2240ad"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("8807fff5-36ba-4146-84b1-429c7f35737d"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 2.59m },
                    { new Guid("880bccf4-9164-41cc-b909-fcdb98681f94"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("884712c3-13ef-49ec-b73c-083924cb4381"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("88586cfb-ffa0-4b87-8969-2aabf175d820"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("88a42f8f-91f1-421c-864b-19e132790696"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.67m },
                    { new Guid("89b962e0-c637-4282-8a67-c5a92a3e73e9"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("89ca7a37-12a2-48b1-8663-ce8052ab98a3"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 4.17m },
                    { new Guid("8a18b476-3f8f-4265-a80c-754e10da5cfb"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("8aa8e489-abe8-4aac-8ceb-a91876b26e0a"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.12m },
                    { new Guid("8ac067ce-1e0f-42a3-a44d-031f182a7f8b"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.12m },
                    { new Guid("8aec450e-d498-4c2a-b103-67840e091623"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("8affa4fa-eda0-4c07-86ac-d14582b84051"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("8b15c335-dfc5-49fa-96c8-1dfd335d1528"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("8b403c9a-5764-4a33-88af-44c112454af4"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("8bfb576f-dc8c-42ae-b08a-c2ec7d979e01"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("8c3016f6-ee70-4436-859e-8655821214f5"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.59m },
                    { new Guid("8cabf697-ca68-4b04-a715-86c05921dac2"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("8ccc7177-336d-4deb-ad93-7a2147ca4f10"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.58m },
                    { new Guid("8cd1d56c-bf8e-4302-b75d-7be176c1a318"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.77m },
                    { new Guid("8d13f375-b436-4bee-8dae-6f9bc1817162"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("8d425eb6-16a9-487e-a6d5-72394de0a61f"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.22m },
                    { new Guid("8d555cc5-6c31-47bc-a6e2-4fc1d2206310"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("8d77ba65-3363-4b01-8b21-6ee9eeabf81c"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 4.32m },
                    { new Guid("8d7c0667-a28b-47cc-ac43-4d4c56457a37"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("8daf6dc0-1172-40a2-849f-34c65ff406e8"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("8e995ae2-2192-4be4-aa0c-844e541a32a3"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("8e9da3c9-f5be-453d-93c5-31d565c2c2a7"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("8f9378d0-b1aa-4676-a9e4-4acfe03d7f7e"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.87m },
                    { new Guid("8fcf4e1f-e62b-419c-a49d-a1da6fa60d15"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("90bd17fb-0ed5-4873-9fb1-a9aa1db25522"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("90cbf23e-3853-4360-892c-f238d57da31a"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 3.74m },
                    { new Guid("90f448a6-eb11-4469-942c-ebcbd852d8f0"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.31m },
                    { new Guid("91106eec-832d-4f5e-870e-84e05ed64630"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("9115e1eb-0b7e-43ea-8cc3-ef0e009c1f52"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.78m },
                    { new Guid("914fbe0a-a962-42b0-8118-f5e703680a45"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("918e72a9-4622-4c1e-8c41-89317abd992f"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.81m },
                    { new Guid("919cd20e-b8c5-4aba-a52d-739943d6c5f9"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("91a3e056-1aaf-4248-b20e-642b99bd3230"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.20m },
                    { new Guid("91dd02cc-35d3-4c06-8b92-bc152e34ed95"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.84m },
                    { new Guid("91e37813-a957-4def-a728-1e1074b13d0e"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.45m },
                    { new Guid("91ea0322-0e74-4c2c-a487-c8c13392bb9d"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("92511d92-717d-4f07-ac2d-01da10f8f50e"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.74m },
                    { new Guid("92fddf24-4344-4da3-80dc-7229e3e51bf9"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.99m },
                    { new Guid("93860613-5392-48bc-84eb-572b0cd07723"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("93ce3e47-6abc-4d4d-a58f-044906ffa29f"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("941a2d48-61d1-4565-8ad8-45f152467816"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.80m },
                    { new Guid("9438da55-1601-4404-a8ee-f9ebf905513c"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 2.88m },
                    { new Guid("946e211d-f6b1-4c1c-83fb-d9d90db81807"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 300, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 101, 2.01m },
                    { new Guid("949a5c01-de21-42ef-aa84-31770de30f02"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("94aaecd8-6a04-406e-986e-b5f0415e6b46"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.37m },
                    { new Guid("94c8156e-e78f-4538-86e1-28390a747b3a"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.24m },
                    { new Guid("951f8bae-df79-4449-9b77-687ec2282501"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("95bf5f70-f294-48b5-abdb-6aa78e969cb3"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("95d24789-d31f-41e7-ae0b-15c47639a96b"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("96137c8f-516c-48e5-ad50-dc33c2d73bc1"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.40m },
                    { new Guid("9637351c-c9c8-4ef1-acd4-5a12d61bd0f9"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.37m },
                    { new Guid("96572e54-aca8-4da9-92ee-32a2763753e1"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("965cf58a-161b-4bde-8d23-7a228baff1e8"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("96e80475-70f1-4fde-b982-e95b0fa69a09"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.74m },
                    { new Guid("97230027-8187-412c-9b86-9a3a3d957f47"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.29m },
                    { new Guid("981e1b1d-76fd-4780-bd79-98e265e64183"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 2.95m },
                    { new Guid("983db8f5-a3c2-4340-bb0a-cd40aec829ef"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("98c69624-1c62-4df9-9851-179f6933039e"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.54m },
                    { new Guid("990249e9-2ab1-4264-a42e-e5fb553d9dda"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("99a8ceba-0463-400d-8d00-74a196657574"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.80m },
                    { new Guid("99cfe7c9-de57-4586-90fd-10ed4b9086a0"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("99f35613-0736-4681-8af2-31321f10bbad"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("9a91191a-2caa-4da6-965b-04db93752d41"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.37m },
                    { new Guid("9adeaae7-3ff5-4193-9ee7-803170894215"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("9ae91e51-6364-4d17-866b-841070ea0ae2"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 3.09m },
                    { new Guid("9bf4f297-fde9-4d02-8d02-4af26e20386d"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("9c3224d2-f9c9-4ce0-b2b3-03bc041b197a"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("9c365beb-86e5-4c26-b49a-8797977fa84b"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 46, 2.09m },
                    { new Guid("9c67dd62-e59b-47b7-b402-be94aa28182b"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("9c8a084d-222a-4c9a-9737-f563eb197945"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("9ccf5890-9cff-4ddd-bf2c-791fb733a05a"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("9d229d5d-bf13-4cca-8fde-4167cc5470f8"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.67m },
                    { new Guid("9d6dc845-de42-4cb4-b600-d55f4c50bafa"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("9d719270-96cd-484d-b117-49b4b45b0435"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("9ec8486d-bab0-429f-a6d5-333f71728f1b"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("9ef0e79b-d69a-4cc2-bd39-b25ad2797fd5"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("9f1c2c8b-7de1-475c-bc7e-f6de65aac552"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("9f6ffd82-a617-4afb-98f8-f15e081ddbe9"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 2.06m },
                    { new Guid("9fe2093e-36c2-41a0-a049-3af480ea5f3d"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.45m },
                    { new Guid("a0441da2-80dd-4689-a48a-a18d73be371c"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.24m },
                    { new Guid("a087653c-9c1d-4e8d-9e3c-0a92f88dfcc2"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("a0893959-58f7-46f8-ad93-ed429d2c8758"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.87m },
                    { new Guid("a0a6fdb3-37a9-453e-a6b5-69a3e5ca57c4"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("a1056042-48b2-4d97-a2f5-0820482db659"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("a1462e39-afa7-4c2f-99bf-c7536f14e94b"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("a15af657-0f1f-4daa-a466-96ced3726fd7"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.99m },
                    { new Guid("a166b197-7eb7-4f50-9c0f-7711af3cc958"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.95m },
                    { new Guid("a1a63df7-22f7-4d83-b3eb-c417306ce853"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.85m },
                    { new Guid("a1d329c4-4b9d-411e-910d-20e2e7af8120"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("a1f3f040-eafc-45a5-848f-b9cafb569252"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("a26c6cc5-0c58-410d-b37a-a019f4ac3061"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("a2f323da-aec5-4bd9-9a52-188592796667"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("a2f9dc49-21d7-4171-b58d-2e5d48a75ba6"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 2.81m },
                    { new Guid("a2ff007a-5b30-48a7-bd1e-5c918a1d96d9"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("a3be2ed9-c492-4a51-bbe1-71113caffa9f"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 2.6m },
                    { new Guid("a3d02500-55ef-46ab-927a-3b45d5304d96"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a46ae20d-1e1b-4aac-b312-48f5eaa1f008"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a4e71cf3-d954-4532-b29a-e22c40ef4a62"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.45m },
                    { new Guid("a534e6f8-a446-4127-b7f4-47b30d06ac44"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.81m },
                    { new Guid("a54b0092-9ab1-42f5-a844-4cce59c67013"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.80m },
                    { new Guid("a6909362-63d5-48f8-9375-dc631d34ac6b"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("a6c7d745-12af-43de-8641-74db7523d441"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.45m },
                    { new Guid("a70f73a5-237c-4b43-b084-458e30f8c0a1"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("a7563389-380f-496b-a04a-6dba2f0a9e23"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("a82e820a-b090-4af1-83e5-9473e226d1a3"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.55m },
                    { new Guid("a865bd52-76fd-408a-a29c-03f9f27e305b"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 3.02m },
                    { new Guid("a8828980-3427-480d-8716-e01037c7f580"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("a8cce183-5695-46c5-8d53-c976458bd524"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("a8dbb3d8-4ed2-415d-bf10-9a722eb72181"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.12m },
                    { new Guid("a9148e82-2ff9-4e81-9afd-d01aae44b6fd"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.51m },
                    { new Guid("a926151c-1ae6-46d8-a38c-ef0f387dea31"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.02m },
                    { new Guid("a93605ea-5eee-4782-a4fa-b49dd0021ff3"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.76m },
                    { new Guid("a94e485f-1750-4d7f-9f17-8a7ab10df939"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("a9be14f4-df5c-47a1-bdf5-45b2470bf601"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("aa291d93-3b87-45c8-8ec8-625a4691893f"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.19m },
                    { new Guid("aa89e2a5-197f-467e-af2f-4c0b91fb4847"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.30m },
                    { new Guid("ab33c5ed-a916-4cc9-a2b7-c0c0873af522"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 3.09m },
                    { new Guid("ab36fa0e-6764-4084-ba9f-fb526236c4b8"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("ab9883b3-4fd6-45cd-823c-0de967899586"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.16m },
                    { new Guid("abd1bb88-17cb-46d2-9ea7-4f95350f7b29"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("acad0be1-23b9-44df-b15f-1f472e95600f"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("acc67356-46b2-483b-bb4c-c83b25d77cf1"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.55m },
                    { new Guid("ad05072a-00a8-40b7-b5c8-c67aa43aeef7"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("ad9fa44c-f721-4497-b7d2-0c1ec389bbe5"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 501, 2.30m },
                    { new Guid("ada5ce9d-338c-475e-bcb7-13182a275ab2"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.31m },
                    { new Guid("ada6eb24-c153-4a03-bb14-c0e351b15890"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 45, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 23, 3.74m },
                    { new Guid("adbbd41f-d70b-477a-b93d-ead3015df12f"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("addeb80c-3943-4cfa-96b8-41a3ac0f5d15"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("ae0347e8-557b-4217-8c8e-43d4b60052ea"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), null, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 1000, 2.27m },
                    { new Guid("aef0d8b9-9a3a-4077-8dca-ca312c5d5030"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("af18c068-659f-4b4e-a19c-42bb60a7181f"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.65m },
                    { new Guid("afe5d421-40b7-4e8c-acb0-9a4c7becf830"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("aff33f06-2f6a-4f84-bd7c-8b54b4a7da0f"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.17m },
                    { new Guid("b01e8fcb-38c2-4607-b3f5-a1d00052c983"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.23m },
                    { new Guid("b02acea9-08b1-457c-8ebe-6c7ed77e388a"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.81m },
                    { new Guid("b02eaf2e-01f0-4af6-96a6-d8eefc93e890"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("b03714ea-03f9-4846-b809-aed3a9e8423d"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("b042234c-fbac-46bd-804a-f143dde3f3d2"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("b0569982-9c7f-4878-9e7f-750c040c80a1"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("b0f01634-0764-4991-85a6-21935a9cd498"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("b108f14a-a54d-4947-be3e-6988f2d39957"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.03m },
                    { new Guid("b10bba48-d92d-4853-a23a-133eed858f2f"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("b11fb093-e7b4-428a-afa8-00bb707f608d"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("b2c72dfb-3941-4f83-9ab7-1f5045f5bca9"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("b2fe3ffc-6a54-4ece-8f36-cbedd8bf3ace"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.09m },
                    { new Guid("b35ac40f-0e0c-47a7-9cd0-39dd84a4720d"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.16m },
                    { new Guid("b397e0db-fcea-4530-afa5-357e8c1d7d3d"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("b3a16816-ea05-4877-9ca6-b48e69082147"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("b3b6de3b-59cd-49e8-9cb4-efb468f7dab8"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("b481e3dc-dd56-478e-9115-de3c44ed6476"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("b49e403e-8918-416d-a467-c9c7cbe64d76"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b4c44f91-e371-4a3f-b3f3-352c770a8e71"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 2.81m },
                    { new Guid("b4dc73f8-6556-4aa9-8806-26f00d640cd1"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 3.10m },
                    { new Guid("b52cdb0d-cedf-4630-bef2-6e463dfb8719"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 2.09m },
                    { new Guid("b5aa79fd-0760-460c-9934-6b213b0459b6"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.68m },
                    { new Guid("b6e25ae8-a372-4e0b-a241-8b91b594c14e"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 2.09m },
                    { new Guid("b74bf573-0cd3-4309-90f4-59958a6aec00"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.94m },
                    { new Guid("b76822c0-3d6e-4c42-bf3c-d35ec33419c0"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("b77f1bf4-44a1-4ec5-a870-88e735ec4377"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.24m },
                    { new Guid("b7c4e065-2193-41ef-b8a0-37d7ad403913"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("b8cd3d79-bad2-4a75-81af-f83714955fad"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.59m },
                    { new Guid("b948964c-9e6f-42f2-a79e-caa1b52eae4c"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.73m },
                    { new Guid("b95d6e2a-c821-4591-85a8-1840b536cf12"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.88m },
                    { new Guid("b9b1494b-3ed3-4322-abf2-78774ca421cd"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("ba2a020a-5636-4d2b-952b-4fad791975ed"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.09m },
                    { new Guid("ba2e74ec-015d-45ad-a01a-5bcd62bc90d9"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("ba2fd725-ffd1-4fda-81be-fac40d43aae5"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.80m },
                    { new Guid("ba54e8df-6bff-4adf-9e2c-dddef944b8b4"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("ba59d07d-eb63-42fa-8377-941b7a8ae515"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("bb64f20c-7067-46b0-88ca-657126fef835"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("bb877e57-a7fd-415b-a5fb-054bfe6f12ed"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("bbd30396-ae0c-49cc-acc5-59ba270478fb"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.92m },
                    { new Guid("bbe9ba52-d880-4c34-9d17-2dea6af0e4d1"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("bc0140bb-fa7d-49f9-bca3-7a6eed3421d3"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("bc17a9d8-e9db-424e-91ca-c0ed873ecaff"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 2.19m },
                    { new Guid("bc367aa7-7469-4b3e-bcc1-35ca9df353f6"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.87m },
                    { new Guid("bc5a72c3-9038-4fa7-951a-0c582a484b78"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.74m },
                    { new Guid("bc731342-b122-4611-80d4-4ec9d98c4801"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 1.94m },
                    { new Guid("bca5bd3a-83a8-46d5-8c1d-96d087b2f951"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("bcefadc4-3517-414d-8904-467ddf34a084"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.25m },
                    { new Guid("bd0e76c9-3e62-4096-b32d-30fa11093d7c"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), null, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 1000, 1.19m },
                    { new Guid("bd949ae4-b8b3-401b-a7df-9a49ef7c8006"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("bd97754e-8486-4a83-8fd0-9eeb6b4670f9"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("be247b54-6b49-4d69-8c91-2d3b3405abcf"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("be285a10-b767-4999-bae9-8febb64ecfef"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.38m },
                    { new Guid("bef24ace-ed2e-4dde-8ac4-e79e492bfe1b"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("bf1f93c5-7713-49c8-b8d0-4351e8683c5c"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.37m },
                    { new Guid("bf320345-251f-4665-ac2b-044f46cb86cc"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("bf65a538-b86b-4c83-a3ac-dc7a3937ac04"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.65m },
                    { new Guid("bf82ddc8-a806-405e-8caa-cc5804656641"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 1.87m },
                    { new Guid("c019f402-81d1-4754-bf19-1f49c754ced9"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.40m },
                    { new Guid("c0635809-c8bb-4cf8-8bd4-a9f0460339c1"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 2.06m },
                    { new Guid("c0deccbf-02ee-42e5-b9f6-57f7c5190997"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.47m },
                    { new Guid("c0f7d283-93fb-4dc2-8c17-e1006932ecb9"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("c10637cf-5c63-47cc-88f3-6287747b897b"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("c2073579-04eb-4bbf-869f-c4637947ee6e"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("c2871b01-a881-4958-9886-ea3ea605f589"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.87m },
                    { new Guid("c3216c51-907d-4565-872d-248b3e659d78"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.61m },
                    { new Guid("c3b76527-6a67-47d9-b656-292d771a2a68"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.22m },
                    { new Guid("c48097dd-c023-4c76-b79a-251862af1edf"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.83m },
                    { new Guid("c4ec8324-0cfd-44cc-95f7-b928b80d38e2"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("c5132ac5-d4d0-4458-9b11-3d9e607baca3"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("c5396436-c181-48c5-942b-69eda32fa73a"), new Guid("3b2f9fd2-134d-438f-817b-74378c2ceb0b"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("c5ec71cd-6486-4ad1-96bf-185e852e932a"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.66m },
                    { new Guid("c6c551a7-8b97-4d71-ad3c-698ee6d1eb8f"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("c6fc8ff5-10a6-4a94-bb50-b0b45e5b8a35"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.90m },
                    { new Guid("c73fa142-fd97-444f-8ec6-9022b823feea"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.63m },
                    { new Guid("c7622d0d-c5e6-4783-9372-7157c02cdb43"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.56m },
                    { new Guid("c76a1b7b-a4d5-4378-b02d-adce30008caf"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 1.97m },
                    { new Guid("c78c6ef8-bb79-49d1-b258-e9d4d3b25e7d"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c79262dd-382a-4ca0-9623-a1e91b5588d6"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("c872ba5c-a0e3-4cd9-9434-392f1995f6c7"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.73m },
                    { new Guid("c96b2ea3-b063-4c7c-aa55-00b2d2947ee5"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 70, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 46, 3.74m },
                    { new Guid("c9ef37bc-e69f-4785-a8f0-77a4ab81da06"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("ca091819-1a56-49fa-9d57-3740c72a79e0"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("ca0d43a8-08a1-41d5-90e3-9b6d5c9551c4"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.52m },
                    { new Guid("cb4cce76-a059-445f-989e-fa6c91526f58"), new Guid("ff9e1ee3-91cc-404f-ae3f-4a4c8ad891f7"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.80m },
                    { new Guid("cbd77f63-f6f8-4a16-a610-508f8335444f"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 2.20m },
                    { new Guid("cc315b60-2fb2-4bee-9ac1-53879add12d9"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.88m },
                    { new Guid("ccb9e70a-d47d-401e-8d95-ae085bc03b21"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.22m },
                    { new Guid("ccfaf354-2264-459d-abce-d18139ffa07e"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 500, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 301, 2.37m },
                    { new Guid("cd43d5fb-784b-43b8-b984-8c667f0e313d"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("cd7ca884-f8b9-416c-b2a8-5d16945bc48f"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("cd7f30ba-f250-4c21-a2bb-a924d7ca1192"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("cda71658-a2fb-445b-8109-d59af0c275b8"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("cdaa5674-8e4b-42eb-b734-139e1c78a6b4"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("cdc97c73-4a9b-419d-a1eb-b705b82cab99"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("cdccb78c-ac45-4ec6-a9dc-3a1c023b219f"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("ce362868-ba38-4348-9c19-44256eca90d1"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 301, 2.45m },
                    { new Guid("ce824240-c082-4bb3-b501-95785c735c78"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("ce90b117-be64-4f89-b7f2-4a48b1f91bfb"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("ced7709d-2efa-4eab-a6c3-811e0e1ee164"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("cf84f4bf-88c9-4587-b593-cb81a40a8ba5"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 300, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 101, 2.01m },
                    { new Guid("cfbd07b5-0899-4dca-8a99-6886fac31b82"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 300, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 101, 1.29m },
                    { new Guid("cfdae811-0e98-4f48-8506-0bd85d6aa92e"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.31m },
                    { new Guid("d0b47b71-d879-4b11-9811-76dc74c97f90"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 999, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 501, 2.30m },
                    { new Guid("d10e59ea-4a20-49e0-b5bd-aaf98a0a97ed"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.80m },
                    { new Guid("d1172d55-191d-4c01-a937-1f71cb9a22b3"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.37m },
                    { new Guid("d12da9cc-444d-4b45-85da-0314b977a6cb"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.58m },
                    { new Guid("d13dc9ba-2770-4233-b849-fab767e05475"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.77m },
                    { new Guid("d1419efb-ff15-49c1-b0e2-3b207259ddd3"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("d15066ea-c979-4f7e-a558-0515c1cec820"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.29m },
                    { new Guid("d1d7f0e0-ae3a-49ef-823b-d066bcf8f639"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.66m },
                    { new Guid("d20a6683-3938-4254-9cfe-8906fc509407"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("d248de94-aaa4-4dd6-968e-c85ce85837f2"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("d267b0d7-514f-4371-abf3-6c2a2b8afcfd"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("d2732918-35e4-4c12-979d-a5763082abf2"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.87m },
                    { new Guid("d2ab65c8-b12a-4c3e-9551-cff78afe8039"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.66m },
                    { new Guid("d2dc8b71-4eb6-4868-8010-8ed857447082"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.38m },
                    { new Guid("d2df43b1-ddf9-4981-a8ec-ba6bc821e2ac"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.37m },
                    { new Guid("d3005760-1d17-496f-82c7-1c6858519a29"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("d3960b77-9aae-4d61-a167-8ecaa4347c20"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), null, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 1000, 2.27m },
                    { new Guid("d3b60a90-df38-4c79-983f-17b3f2090ecc"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("d46139c0-e616-4530-92f5-3408f4e6a6af"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("d49450d9-4090-4869-9ac8-c13ba165545e"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 2.23m },
                    { new Guid("d500bb5d-4520-4f67-b09f-9e80cda523ac"), new Guid("da7b0a60-d6ca-44d4-9e28-d5d804cd7a64"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("d58b3df1-b87d-48e9-b64d-d02333de8b2d"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("d747862b-646d-48d6-a8f3-d76aa317d22f"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 1.94m },
                    { new Guid("d7ae7c18-bba9-4bfb-918b-aa20af0f5c4e"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.30m },
                    { new Guid("d86627d1-28f9-4147-8c23-dc7fd2661be0"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 100, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 71, 2.09m },
                    { new Guid("d8a4d88e-2ad4-4641-9c96-677b617b4dd6"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("d8e3ae41-c16c-46ec-9301-fc206d8527b7"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 45, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.47m },
                    { new Guid("d9378537-c3c8-4117-aff4-4c740a0a9aaa"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("da1ef57b-145b-4c67-8ee0-57d230419e15"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), null, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 1000, 2.42m },
                    { new Guid("daa5ba71-5638-40d1-9a77-8877e0136029"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 2.16m },
                    { new Guid("dac11f0b-e843-40b4-83b6-870014d0da50"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("dac12275-9336-444d-9b95-cfe4b010a0e5"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("db566759-6cf3-4d4e-bf91-fa78c9ddc723"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("db8b8d30-12d3-4526-a3fb-930e8663359b"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.31m },
                    { new Guid("db979b1a-334f-4f5d-b500-5d625889fbf6"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("dbb4b444-a089-4e4b-ac5b-ac58c2992583"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.95m },
                    { new Guid("dce73747-411d-4b22-81d6-e677e431ae5c"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.24m },
                    { new Guid("dd44744b-fcb3-40d6-9914-e25dbc13f9e3"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.58m },
                    { new Guid("ddcf3769-ee85-4b9d-af46-e33bf8a3e880"), new Guid("de1cfc73-52a1-4c72-aed7-1c67a588e436"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.84m },
                    { new Guid("dddce00b-d469-43cc-b591-193c8bbc43b4"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.17m },
                    { new Guid("ddffd97a-e280-4915-9853-b177e99dddc7"), new Guid("da5d4f5e-79ac-4b69-b0f5-cf027053ec8c"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("de07b18a-e7da-41f4-9462-fac6940ecdd1"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("de1fff28-8d1c-45aa-8ccd-77b3b8632a50"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.24m },
                    { new Guid("de32eb6c-ee25-4194-a194-1f6eac08e832"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.59m },
                    { new Guid("de428ba3-5ca3-4374-8697-b15d22b4993b"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 3.09m },
                    { new Guid("dee2f3e7-1e31-4a8e-9863-7b970523e009"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 501, 2.45m },
                    { new Guid("df7961ef-7e3c-4432-9cb4-a402d2c8fd21"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("dfc5c2b9-fc02-4263-b37f-8a0d91824082"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("e0245b55-73e2-42fa-bd35-8d81ead875d7"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.83m },
                    { new Guid("e139a8ed-62a7-40d1-9463-754921f624cb"), new Guid("3c4fedcc-eaeb-4480-8574-c759e9aa2f9d"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.94m },
                    { new Guid("e16509ca-e923-4464-9f39-938f35bc548c"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 999, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 501, 1.15m },
                    { new Guid("e184278e-1bf3-4bcf-afb4-8eb2f9dec7aa"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("e1aa4f6b-8f9c-44ce-8aad-516bb663b58e"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("e250d018-fcc4-494c-8d64-757d850537ee"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("e2a28d3a-ba15-4810-8f37-3acdb8f49e31"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 2.73m },
                    { new Guid("e2be8894-f298-42ed-bc21-764f4244ee6f"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("e2d2679d-6582-43cd-b9dc-fcd99b3ec004"), new Guid("58a45e41-a7fe-4dec-9a8e-3bbf38455e5f"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("e30fd8b5-86c1-44d4-9f29-01513176ebaf"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("e382e72b-bc35-4d90-a330-ef98a543ce49"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("e3a28e03-8c40-466b-a00d-bdb629bf384e"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 1.94m },
                    { new Guid("e4d94399-57bc-4eed-8619-81cbf35cb622"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.66m },
                    { new Guid("e51e9b2e-ad03-4d23-b9be-e5a69257e93b"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.02m },
                    { new Guid("e53695b8-95e2-4626-89ca-a457aecdb531"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 2.88m },
                    { new Guid("e58249f6-4006-4d2f-b77a-ddbeb6195fa0"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("e6165561-a5b6-4b62-b3a4-ec99924beea4"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("e65a2eee-e9c5-4f5a-9643-45ecbdc90412"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e67e60cc-6a62-4673-934b-e72955cb6f54"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("e6918edf-9eb4-4d88-ba45-b81a347b1352"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e6adf39e-c5d3-496c-9e83-d9c86b1643f3"), new Guid("660348c5-b814-42bf-a1b9-df56696f3c75"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("e6e8c437-4b03-454a-b466-62ff94f4d2dc"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 3.45m },
                    { new Guid("e7311f2d-3f9f-4f45-8a5f-6cbcd1f0353d"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 100, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 71, 2.81m },
                    { new Guid("e7b9adc6-d4a1-4d27-bafb-1290f7aa1bab"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("e8350169-dc49-478d-89b8-7f728fe7d5b9"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 3.09m },
                    { new Guid("e83655c8-cb4d-4cda-8fde-b0aa8a0131ec"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.80m },
                    { new Guid("e84f7025-1839-471b-a58f-4cdd698dc5cb"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.88m },
                    { new Guid("e8951f27-0f6d-4eac-821d-8d39cc27fab2"), new Guid("8b08542b-6c77-4d8e-8d54-329ceec6c1e1"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.38m },
                    { new Guid("e8e22c8e-150b-4d34-9f37-22bc17764ec8"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("e8fef638-52f3-47c7-8324-50b43f10da46"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 1.32m },
                    { new Guid("ea49ce8f-3087-499c-9a48-00b89bfe9479"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.02m },
                    { new Guid("ea5a8c65-af0a-41f1-a5fe-381558745750"), new Guid("803e5fb5-2a8f-4e42-a544-071b0b9fcecf"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("ea5aa8ac-1c2e-4b51-83f1-164e218669af"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 2.85m },
                    { new Guid("eb2fd78c-5365-4221-a245-8a4f0b3f2706"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 46, 1.83m },
                    { new Guid("eb68d37b-7098-42b9-a411-dbe1c189205c"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), 500, new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), 301, 1.22m },
                    { new Guid("eb706022-8a8f-4a1e-8c16-84c1923645ac"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 2.59m },
                    { new Guid("eb733313-c90b-49e6-8366-9b6fc200eaeb"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1000, 1.37m },
                    { new Guid("ec1beeb3-3d85-40cb-90e6-6116ab95aade"), new Guid("431d73fb-827d-43c2-8ee3-98568d1cfcf8"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 3.06m },
                    { new Guid("eccca16f-ea97-4029-b380-8e38e30d0c15"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("ecf68fba-9f8b-4f0d-b15a-3022d02e0f04"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("ed0b9a55-16a4-4a60-9a71-7ce4f132f616"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 500, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 301, 3.38m },
                    { new Guid("eda6e00a-3b31-48d0-bda0-502ac5d4ffdd"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("ee0b33e0-9808-45fd-a374-3d152a43ac34"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 3.31m },
                    { new Guid("ee0e70a1-e2b1-4453-b254-29d2e2779d7b"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 500, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 301, 1.94m },
                    { new Guid("ef170244-359c-4845-b342-9b90ac4a19c9"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), null, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 1000, 2.99m },
                    { new Guid("ef644c69-1be9-4c39-8736-025e01acfafa"), new Guid("bc3767bc-68d7-400d-ae61-707fc3bb5878"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("ef7ead4b-ec82-48cc-a0e0-101d58160296"), new Guid("9495dd9f-53c2-41c5-8680-34539a483a42"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1000, 2.06m },
                    { new Guid("ef8f2552-87c3-444e-81af-332e1d42bf10"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.17m },
                    { new Guid("ef924649-49fd-4916-b9db-e7b5755036a0"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 999, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 501, 3.24m },
                    { new Guid("f02b7b23-8b7b-4c66-ab09-5c9cbcb554e2"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.77m },
                    { new Guid("f05ad94b-dd09-411e-8027-8e682c3491a7"), new Guid("e1371a95-daa6-4c22-8bcd-c86e5ee03203"), 100, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 71, 2.09m },
                    { new Guid("f1286572-66dd-4d53-97b8-1b90bc285338"), new Guid("38df3f9b-f88b-4c6d-9a36-76fe0d3e1792"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("f1eec282-c6c2-4b00-aef5-2c0af097731f"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("f213ede1-253f-4854-a123-7df4f6d4edaf"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("f2bef6d3-83de-4ef9-a477-510b5a8a22e2"), new Guid("545149ad-862b-4e00-a5d6-e3492d68463b"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.16m },
                    { new Guid("f2fa7300-7357-4263-b323-8cdb27472395"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 300, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 101, 3.02m },
                    { new Guid("f33a9cc0-11de-4c4c-8eb8-458bb313ae3a"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("f36ee0c3-3f5a-4b3b-93f3-ade8ac356d05"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.67m },
                    { new Guid("f3b06db9-29c6-4375-84dd-66f77918938a"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 70, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 46, 3.67m },
                    { new Guid("f3d33fcb-a3bc-49f0-9fb4-24869f774e44"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 999, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 501, 3.02m },
                    { new Guid("f3e8ceb6-0df2-4676-8465-5b4e73bf3c89"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 300, new Guid("c1637d89-ccb7-4a68-b382-40b4bb9e50d7"), 101, 2.45m },
                    { new Guid("f3e92e80-eeb6-4ef0-902f-37461b899c33"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("f47c3dce-8f16-4958-a6a5-75e1c5123ceb"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 1.40m },
                    { new Guid("f49e94a9-44d9-4be0-bfcd-5373e19f843b"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("f5b3d275-e463-435c-90a7-e2e31ecfb784"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 45, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.95m },
                    { new Guid("f64b5b49-19d5-4b05-80be-ddb98d2fcc78"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 500, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 301, 2.09m },
                    { new Guid("f6638bf0-ab56-4042-9b1b-f03265e53fe8"), new Guid("3a52e207-c517-49a2-98d4-2998f29f1ecd"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("f694bc8d-e644-4048-8249-2825e55daf98"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 999, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 501, 1.61m },
                    { new Guid("f7808f5c-d981-4e78-9eec-4f8b2fd21a83"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("f7c5b323-55ec-4e8c-ac3e-5b47ca204a56"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 100, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 71, 4.17m },
                    { new Guid("f88bbad8-2801-4bba-9e23-77be35b07a78"), new Guid("8603813c-d724-4d63-8013-c273c9fe5fbc"), 999, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 501, 1.65m },
                    { new Guid("f88c1bcb-3e98-4d17-8d93-facfb251f7c3"), new Guid("82060812-b989-4340-bd2e-8840585a8acf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.83m },
                    { new Guid("f8df2f26-82d6-40ae-b91c-0cd9aea43b13"), new Guid("291c8b1e-1eb6-4bc0-b714-86e79ed31316"), 300, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 101, 2.16m },
                    { new Guid("f90cb218-44fb-406d-88d3-58a4ebfc8ee1"), new Guid("78587899-2653-4be7-b07e-13a7596d5649"), null, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 1000, 1.63m },
                    { new Guid("f91dd520-88a7-451b-b2f8-3795d136cced"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("f95f035f-a02f-4389-84d9-f5afe4adcff4"), new Guid("e7a610f5-1fe9-41e2-8493-34424d982b9b"), 70, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 46, 1.83m },
                    { new Guid("f994604e-9a2e-4372-a4d7-8d9de65f7f7e"), new Guid("e7b21a66-1c15-49cf-9ff9-c8b3455ba57d"), 70, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 46, 3.09m },
                    { new Guid("fa0d6bfe-829e-424a-af59-ab352ea49a0c"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), 45, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 23, 2.95m },
                    { new Guid("fa7812b0-d36d-405c-90dc-cdd92b54d5ed"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.23m },
                    { new Guid("fa9240ca-7dcb-425f-8cc4-e0ec46804b84"), new Guid("18351822-a469-408c-b8a9-f17dbff1020a"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m },
                    { new Guid("fa995435-e08c-4661-8424-027f8856c010"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10.0m },
                    { new Guid("fac5bbaf-9ca5-437d-a61b-6ec4f82ebdb3"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.30m },
                    { new Guid("faeaa09d-6dc4-4f3a-bdd1-5c589beeadea"), new Guid("829f6814-b1a3-43f0-8d71-f2ea928e743b"), 500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.68m },
                    { new Guid("fb0104a9-8f0c-4952-906e-ab23589d4b19"), new Guid("bb88a4e3-a99f-45e4-a753-cb430b608a4f"), 999, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 501, 1.73m },
                    { new Guid("fb07d1fd-c5fd-4414-ba26-0a1226ad6d55"), new Guid("573da713-55b6-4505-9bb0-1e033f7c47e5"), 999, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 501, 1.80m },
                    { new Guid("fb2ae2aa-5367-4e08-8407-0bd0f0a60733"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 2.52m },
                    { new Guid("fb3ffc70-6f43-42b5-aa6a-bbb79440e067"), new Guid("ee896fe1-1434-4136-a70e-d2c9fa49d902"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("fc123996-40f3-42e2-bb81-474122ab110f"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.91m },
                    { new Guid("fc478221-245e-48ce-a2de-d84a2166deb3"), new Guid("869993cb-ccd8-498f-880c-97f0e02f2846"), 300, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 101, 3.38m },
                    { new Guid("fc4a4920-9e92-4661-a6a5-b1bf57c79806"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("fc5950eb-4f16-45cc-b139-3ed6bd6c704f"), new Guid("cb7fa78d-6de7-4838-9e54-c279bea798b0"), null, new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), 1000, 1.27m },
                    { new Guid("fc64c9c5-5e9f-41ec-ba3a-471fe67adf43"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("fcfdf88e-8a7d-4d10-a980-6d19012b2375"), new Guid("7ddb170b-5696-4abe-a5a8-b6424a966ba9"), 999, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 501, 1.80m },
                    { new Guid("fd85ca3b-37c5-4089-b87e-e05c655c3283"), new Guid("e7777c20-3abb-4a39-af05-11fcee8f7534"), null, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 1000, 3.21m },
                    { new Guid("fd8c06ec-d0c2-4507-9460-ef261d3d9c71"), new Guid("a42ea92c-d563-4eb8-bd25-83a3ac1217dc"), null, new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), 1000, 1.55m },
                    { new Guid("fea9ed6c-d33a-4ecb-90c3-b7c7c4906c9d"), new Guid("6de69db5-e0a5-4fe3-95a9-df3721f50d0b"), 500, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 301, 2.02m },
                    { new Guid("ff308696-cfdb-4bdc-b196-9d7cc49b21b0"), new Guid("637a3cf8-e91a-4e46-8ccf-d1bfcbaa19e3"), 500, new Guid("1ee2ba7b-97d2-4a3a-9b16-8b88563e91ad"), 301, 3.09m },
                    { new Guid("ff80326a-c2aa-44df-aa28-5c0bd78e6edd"), new Guid("b93226d5-2642-4705-99ca-734af02c624b"), 45, new Guid("c2a145a8-c7d9-4241-9d21-8bb4968c39cf"), 23, 3.31m },
                    { new Guid("ff85322b-3530-427a-882e-6a9412bfb60a"), new Guid("52e63491-43b4-47cc-b53e-8384aac7c07c"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.24m },
                    { new Guid("fffc3977-177b-4453-adc5-fdb533fe8cfa"), new Guid("cb39b0c9-34bb-4f55-a39b-a575aff157b2"), 45, new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), 23, 4.39m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportAcademyVideos_NameTr",
                table: "TransportAcademyVideos",
                column: "NameTr",
                unique: true);

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
                name: "IX_TransportOrderItemContainerTypes_NameTr",
                table: "TransportOrderItemContainerTypes",
                column: "NameTr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrderItemContainers_TransportOrderItemContainerType~",
                table: "TransportOrderItemContainers",
                column: "TransportOrderItemContainerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrderItemFeatures_NameEn",
                table: "TransportOrderItemFeatures",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrderItemFeatures_NameTr",
                table: "TransportOrderItemFeatures",
                column: "NameTr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrderItemTransportOrderItemFeature_TransportOrderIt~",
                table: "TransportOrderItemTransportOrderItemFeature",
                column: "TransportOrderItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrderItems_TransportOrderId",
                table: "TransportOrderItems",
                column: "TransportOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrders_DestinationId",
                table: "TransportOrders",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrders_OriginId",
                table: "TransportOrders",
                column: "OriginId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrders_TransportFeeId",
                table: "TransportOrders",
                column: "TransportFeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportOrders_UserId",
                table: "TransportOrders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPayments_UserId",
                table: "TransportPayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportRegionMethod_RegionId",
                table: "TransportRegionMethod",
                column: "RegionId");
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
                name: "TransportAcademyVideos");

            migrationBuilder.DropTable(
                name: "TransportOrderItemContainers");

            migrationBuilder.DropTable(
                name: "TransportOrderItemPackages");

            migrationBuilder.DropTable(
                name: "TransportOrderItemPallets");

            migrationBuilder.DropTable(
                name: "TransportOrderItemTransportOrderItemFeature");

            migrationBuilder.DropTable(
                name: "TransportPayments");

            migrationBuilder.DropTable(
                name: "TransportRegionMethod");

            migrationBuilder.DropTable(
                name: "TransportStaticPages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "TransportOrderItemContainerTypes");

            migrationBuilder.DropTable(
                name: "TransportOrderItemFeatures");

            migrationBuilder.DropTable(
                name: "TransportOrderItems");

            migrationBuilder.DropTable(
                name: "TransportOrders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TransportFees");

            migrationBuilder.DropTable(
                name: "TransportDistricts");

            migrationBuilder.DropTable(
                name: "TransportMethods");

            migrationBuilder.DropTable(
                name: "TransportRegions");
        }
    }
}
