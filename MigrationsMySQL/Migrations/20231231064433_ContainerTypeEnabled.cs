using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class ContainerTypeEnabled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enabled",
                table: "TransportOrderItemContainerTypes",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enabled",
                table: "TransportOrderItemContainerTypes");
        }
    }
}
