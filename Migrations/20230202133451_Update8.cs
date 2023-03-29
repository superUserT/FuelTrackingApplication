using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuelTrackingapplication.Migrations
{
    /// <inheritdoc />
    public partial class Update8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "accKilometerTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "accKilometeres",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "accLitres",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "accLitresTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "consumptionKm",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "consumptionKmTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "consumptionLitres",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "consumptionlitresTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costOfTheKm",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "odometerTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "refilCostTotal",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "refillCost",
                table: "FuelData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "accKilometerTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "accKilometeres",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "accLitres",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "accLitresTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "consumptionKm",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "consumptionKmTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "consumptionLitres",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "consumptionlitresTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "costOfTheKm",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "odometerTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "refilCostTotal",
                table: "FuelData");

            migrationBuilder.DropColumn(
                name: "refillCost",
                table: "FuelData");
        }
    }
}
