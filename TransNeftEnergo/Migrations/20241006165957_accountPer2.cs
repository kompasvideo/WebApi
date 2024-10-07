using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransNeftEnergo.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class accountPer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriod");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriod_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriod",
                column: "CalculationDeviceId",
                principalTable: "CalculationDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriod",
                column: "ElectricityMeasurementPointId",
                principalTable: "ElectricityMeasurementPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriod");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriod_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriod",
                column: "CalculationDeviceId",
                principalTable: "CalculationDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriod",
                column: "ElectricityMeasurementPointId",
                principalTable: "ElectricityMeasurementPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
