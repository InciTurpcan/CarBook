using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook_Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FooterAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "FooterAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FooterAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FooterAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "FooterAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "FooterAddresses");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "FooterAddresses");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FooterAddresses");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "FooterAddresses");
        }
    }
}
