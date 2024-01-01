using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook_Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "BarandID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "luggage",
                table: "Cars",
                newName: "Luggage");

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Luggage",
                table: "Cars",
                newName: "luggage");

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarandID",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
