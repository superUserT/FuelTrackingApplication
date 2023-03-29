using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelTrackingapplication.Migrations
{
    /// <inheritdoc />
    public partial class Update4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "odometerTotal",
                table: "FuelData");

            migrationBuilder.AlterColumn<int>(
                name: "fuelType",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.AlterColumn<int>(
                name: "filled",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");

            migrationBuilder.AlterColumn<int>(
                name: "fillStationType",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(24)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "fuelType",
                table: "FuelData",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "filled",
                table: "FuelData",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "fillStationType",
                table: "FuelData",
                type: "nvarchar(24)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "odometerTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
