using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
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
                    { new Guid("2add124b-9a78-4b78-96d1-523e658f77a4"), true, "Sea Slow + Truck", "Yavaş Gemi + TIR" },
                    { new Guid("4f2febe8-3273-4086-89a4-0a0282f003a8"), true, "Sea Fast + Truck", "Hızlı Gemi + TIR" },
                    { new Guid("730cd01e-fb25-4347-8932-2b4056252e73"), true, "Fast Vessel", "Speed Boat" },
                    { new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), true, "Air", "Uçak" },
                    { new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), true, "Sea Slow + Express", "Yavaş Gemi + Ekspress" },
                    { new Guid("a5fe9692-ef46-4376-919f-43aeaa0c07a0"), true, "Railway", "Tren" },
                    { new Guid("af3e3b1a-06d9-413f-99ad-3378458be832"), true, "Truck", "TIR" },
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
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("aaaa0d64-abd7-4e96-aa49-35d4253e014f"), 5, 3, 6000 },
                    { new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), new Guid("c194434c-7a4d-4d70-98df-1ecc78a333aa"), 5, 3, 6000 }
                });

            migrationBuilder.InsertData(
                table: "TransportFees",
                columns: new[] { "Id", "DistrictId", "MaxWeight", "MethodId", "MinWeight", "Value" },
                values: new object[,]
                {
                    { new Guid("02e7ddfa-e34f-4479-92bc-21ad9582194a"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.55m },
                    { new Guid("04e5d48a-4a7f-4072-bd76-8f289d2dbbe1"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.37m },
                    { new Guid("07deca2d-5cb6-40dc-851c-2023e81e0c49"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("08d340c8-ff2d-4695-ac87-17dd7e58ed55"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("0a163a44-44f8-4e25-83f8-83a414e3acf8"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.80m },
                    { new Guid("12298cfd-f5dd-4b0b-890b-58911230a23b"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.08m },
                    { new Guid("12c43827-c84c-4618-8fbc-51e542749ef7"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("17f30cb1-f960-4e9d-846d-6fe5548c1757"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.43m },
                    { new Guid("17fd5b7a-896f-4d93-958e-1039e2446345"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("189a1c7b-4243-4c43-ac9e-f8d235059248"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("18ff438b-9241-4c1d-a01f-24a247dc9c53"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("19a6b9c9-c0bc-40ee-a074-9208ff71f85b"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("2037cb4a-6fda-4c85-b0cd-faf03baf9399"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("23852359-1b68-4dd0-b37e-2501688f88f9"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("26971170-d6ef-4fca-8f07-0e044a2a0ada"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.82m },
                    { new Guid("2942a071-004a-47f8-9a20-df7444b7e3bd"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 1.93m },
                    { new Guid("2e09c676-cb2b-4949-b7ad-42e880dae9ae"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.95m },
                    { new Guid("2e2b91ca-7702-4411-b7df-32b7f1695733"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("30768e6b-2a1d-47ff-a666-ad86c2ccca32"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 1501, 1.66m },
                    { new Guid("330ec2eb-9080-4a45-8223-8dc47624a66a"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.84m },
                    { new Guid("3563f464-8016-4556-8dd3-1b831f602764"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("35b7d77a-eb96-42a1-9fd2-72e6bf02ec58"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("39a5a90c-bb99-4108-b27f-0d6b1bff76a7"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.41m },
                    { new Guid("3db133c1-7d66-40ba-bcc2-df6a78a58f0c"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("46d876e5-9d11-4ae3-8623-2a7eeb5dd34f"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("49e0259c-288b-4340-bdf1-4ce813490a27"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.98m },
                    { new Guid("4bf39ecb-f9f8-4863-9c01-df98222713be"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("4d598414-f4e3-4fdb-bab8-3a0b33d27406"), new Guid("80ff3e90-dcb9-4bc3-9590-e3a2c331a0ec"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("4da92934-6053-459a-afe1-4f7de9d4a60a"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("5088e751-1014-4183-98c6-1ecdb3c8564d"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.76m },
                    { new Guid("5292c147-227d-41c6-981e-e3dd446e6ee8"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("53378603-e281-4aed-88e1-38998e330b43"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("54a43556-0a7a-4b4d-958f-028b9023930f"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.55m },
                    { new Guid("557c4d84-0bae-4285-a256-f6edc04d632c"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.36m },
                    { new Guid("608a33eb-520d-42d5-9a19-1347493eca11"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.47m },
                    { new Guid("64a5a01c-c576-4ea9-a5dc-349b2e4a837f"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 71, 2.70m },
                    { new Guid("6ae3cd0b-670f-4646-a1a6-402f6d5b9b3d"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("6ba1fbaf-83fa-40e1-aa03-36005bfeab1e"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("6e0c1486-8360-4150-865f-7fcb75e7f29e"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("70f5904a-5320-4866-90dd-46acf71450a3"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("72c1cd80-9d36-4ca5-8777-65ee11c26779"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("73c4d86a-6c24-4aa3-839d-0a97e9055f48"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.46m },
                    { new Guid("762ea0a3-a90d-4db5-93ee-a34e7c2bf2b7"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.50m },
                    { new Guid("78fc5202-c331-499b-8af1-927eb8850110"), new Guid("5f0411d9-fc63-4dd4-a03f-50c26f0829c6"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("7a106dc7-061e-42ea-98fa-2218e2113300"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("7d67824c-2627-4d68-9ea7-7ce3af98558d"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("7ea110d7-35db-4dea-8604-5ad6a8bbee74"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("82330603-03c9-4eb6-91d4-69c04a09f67c"), new Guid("b90943d8-f764-42d3-8fca-da1ba2378634"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("854ef12e-7cbe-4a73-8afa-090c8a47b633"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("880197a6-4872-4f73-bb10-89c2677a0cdb"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.97m },
                    { new Guid("8fd8d49a-9920-4eb3-9803-324aa6c2eaee"), new Guid("6d332a8f-0bcd-4b81-9c59-6965f4ab40ae"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("905be703-ac63-4ef0-9e64-f696404bec4f"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.92m },
                    { new Guid("92cfa85c-8418-4440-9cc4-bfd181b3e57b"), new Guid("2b26b58b-050c-46a7-8567-2325c31fa6fb"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.43m },
                    { new Guid("98099be5-4554-460c-8a3a-c6fbc08804c5"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 23, 2.22m },
                    { new Guid("99344f70-c5c2-4b11-b672-08c30301c4c5"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a0746f18-d973-4356-9f5b-28be8ed36fd4"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("a1535794-5315-435b-80e9-235d01ee5c39"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.08m },
                    { new Guid("a4551a37-3a9b-4404-ad4f-838324791de2"), new Guid("3bf2da8a-0a2c-4a8f-99c9-35742cb7fa2e"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("a5a62f7c-db32-434c-a06a-989c1e070acf"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 100, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 71, 2.22m },
                    { new Guid("addb5d94-7c46-4cb8-8a33-e67750a9cdd8"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 300, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.57m },
                    { new Guid("ae61ab44-0e85-43bf-94d7-9a136de3df3d"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 70, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 23, 2.70m },
                    { new Guid("af137e28-cd70-43ef-a0c1-49937ac54bed"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("b9fcb6e7-a598-4ed7-9d4f-bfd86dd48b12"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 2.06m },
                    { new Guid("c031305c-7806-44e3-a485-5e8d0d783a74"), new Guid("ccd6ecfe-c907-4777-96ad-40ab41b7ac06"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("c6eceec6-8b0c-4534-9d8b-89cc5a3ba563"), new Guid("76e0d1b5-4fb7-4dc7-bcb1-1fadff9acc92"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("ce26527d-1109-4208-b8a7-cb9f59c74dcb"), new Guid("72516348-d8e7-4ce3-af4e-f97b77897f89"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.53m },
                    { new Guid("cf7ac8c4-48ba-4249-a05d-92bb2f0354c5"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 301, 1.82m },
                    { new Guid("cfa6ba4a-405c-4fb5-a35e-a3730251f331"), new Guid("76adc0f7-ac5d-43cd-9983-eae135865030"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.00m },
                    { new Guid("d2112068-e17d-48f2-963c-e58a1505c067"), new Guid("6d63584c-813f-48de-9b19-df143f83d2f7"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.17m },
                    { new Guid("dab89f42-2c3f-4d93-aa24-a0d10f6dc089"), new Guid("05bb9082-20a8-4114-946b-cce72cedab19"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("db3b152b-b877-4092-b9fa-b6ab7f5df1a4"), new Guid("dbe61b00-89ef-493c-8930-9d41a402a987"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 0.87m },
                    { new Guid("e4fb310c-2c0a-42b5-b28d-ca16235ae6ed"), new Guid("98ead996-828c-4a6f-99c2-914b7c8110ef"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("e521c127-7906-45e0-b2a0-a056b04ea6c8"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.69m },
                    { new Guid("ea6c3ff5-b256-4caa-9288-05fd71d59990"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 300, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.90m },
                    { new Guid("eb75b5f8-8b87-4aca-a51a-3b1d0a681f63"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 1501, 1.33m },
                    { new Guid("ec8f7650-611b-4333-b6c1-8f0e7924944f"), new Guid("0c02aa0a-b0d4-477a-b4e9-0a5073d323bf"), 1500, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 301, 1.83m },
                    { new Guid("effe178e-34d4-4bf2-ba36-b066dc64ce2e"), new Guid("5abcb711-259a-48dc-9817-2e5b988d690a"), null, new Guid("cbf432c2-fd9e-4618-9b8f-60be075beef1"), 101, 1.61m },
                    { new Guid("f188b7d5-6a0e-4a94-9539-24689910ebc1"), new Guid("d484cf5d-d07d-4e01-8aa4-c87747fa68fe"), null, new Guid("96e1ef5b-916c-4885-ae5b-08a98541e92a"), 101, 1.40m },
                    { new Guid("f562c765-ba35-4399-acca-23c1d3f08fab"), new Guid("123a8e96-b5f2-4459-a896-da06599036cf"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m },
                    { new Guid("f8c5c62f-6387-43ae-a0ac-db22d8e34e21"), new Guid("34e425db-ff6c-4ab7-ac14-a1bd7a7c94a8"), null, new Guid("7875cc3c-a338-480a-98d8-8d3296575000"), 0, 10m }
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
