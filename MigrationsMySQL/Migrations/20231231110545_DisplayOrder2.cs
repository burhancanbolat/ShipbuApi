using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationsMySQL.Migrations
{
    /// <inheritdoc />
    public partial class DisplayOrder2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "TransportStaticPages",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "TransportStaticPages");
        }
    }
}
