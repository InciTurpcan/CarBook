using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook_Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_location_reservation_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProccesses_Cars_CarId",
                table: "RentACarProccesses");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProccesses_Customers_CustomerId",
                table: "RentACarProccesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProccesses",
                table: "RentACarProccesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "RentACarProccesses",
                newName: "RentACarProccess");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProccesses_CustomerId",
                table: "RentACarProccess",
                newName: "IX_RentACarProccess_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProccesses_CarId",
                table: "RentACarProccess",
                newName: "IX_RentACarProccess_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProccess",
                table: "RentACarProccess",
                column: "RentACarProccessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    PickUpLocationID = table.Column<int>(type: "int", nullable: true),
                    DropOffLocationID = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DriverLicenceYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationID);
                    table.ForeignKey(
                        name: "FK_Reservations_Locations_DropOffLocationID",
                        column: x => x.DropOffLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                    table.ForeignKey(
                        name: "FK_Reservations_Locations_PickUpLocationID",
                        column: x => x.PickUpLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DropOffLocationID",
                table: "Reservations",
                column: "DropOffLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_PickUpLocationID",
                table: "Reservations",
                column: "PickUpLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProccess_Cars_CarId",
                table: "RentACarProccess",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProccess_Customer_CustomerId",
                table: "RentACarProccess",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProccess_Cars_CarId",
                table: "RentACarProccess");

            migrationBuilder.DropForeignKey(
                name: "FK_RentACarProccess_Customer_CustomerId",
                table: "RentACarProccess");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentACarProccess",
                table: "RentACarProccess");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "RentACarProccess",
                newName: "RentACarProccesses");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProccess_CustomerId",
                table: "RentACarProccesses",
                newName: "IX_RentACarProccesses_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_RentACarProccess_CarId",
                table: "RentACarProccesses",
                newName: "IX_RentACarProccesses_CarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentACarProccesses",
                table: "RentACarProccesses",
                column: "RentACarProccessId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProccesses_Cars_CarId",
                table: "RentACarProccesses",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentACarProccesses_Customers_CustomerId",
                table: "RentACarProccesses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
