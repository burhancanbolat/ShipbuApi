using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class DisplayOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttachmentDescriptionEn",
                table: "TransportOrderItemFeatures",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "AttachmentDescriptionTr",
                table: "TransportOrderItemFeatures",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "TransportOrderItemFeatures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "TransportOrderItemContainerTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentDescriptionEn",
                table: "TransportOrderItemFeatures");

            migrationBuilder.DropColumn(
                name: "AttachmentDescriptionTr",
                table: "TransportOrderItemFeatures");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "TransportOrderItemFeatures");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "TransportOrderItemContainerTypes");
        }
    }
}
