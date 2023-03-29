using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelTrackingapplication.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "odometerTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "fuelPrice",
                table: "FuelData",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "filledVolume",
                table: "FuelData",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "filled",
                table: "FuelData",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fillStationType",
                table: "FuelData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "fuelType",
                table: "FuelData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "siteLocation",
                table: "FuelData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vehicleMake",
                table: "FuelData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vehicleregistrationNumber",
                table: "FuelData",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fillStationType",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "fuelType",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "siteLocation",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "vehicleMake",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "vehicleregistrationNumber",
                table: "FuelData");

            migrationBuilder.AlterColumn<int>(
                name: "odometerTotal",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "fuelPrice",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "filledVolume",
                table: "FuelData",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "filled",
                table: "FuelData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
