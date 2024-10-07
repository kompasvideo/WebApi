using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransNeftEnergo.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class delrefaccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriods_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriods_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriods");

            migrationBuilder.DropIndex(
                name: "IX_AccountingPeriods_CalculationDeviceId",
                table: "AccountingPeriods");

            migrationBuilder.DropIndex(
                name: "IX_AccountingPeriods_ElectricityMeasurementPointId",
                table: "AccountingPeriods");

            migrationBuilder.DropColumn(
                name: "CalculationDeviceId",
                table: "AccountingPeriods");

            migrationBuilder.DropColumn(
                name: "ElectricityMeasurementPointId",
                table: "AccountingPeriods");

            migrationBuilder.AlterColumn<decimal>(
                name: "Number",
                table: "VoltageTransformers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Number",
                table: "CurrentTransformers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "VoltageTransformers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "CurrentTransformers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CalculationDeviceId",
                table: "AccountingPeriods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectricityMeasurementPointId",
                table: "AccountingPeriods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_CalculationDeviceId",
                table: "AccountingPeriods",
                column: "CalculationDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_ElectricityMeasurementPointId",
                table: "AccountingPeriods",
                column: "ElectricityMeasurementPointId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriods_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriods",
                column: "CalculationDeviceId",
                principalTable: "CalculationDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriods_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriods",
                column: "ElectricityMeasurementPointId",
                principalTable: "ElectricityMeasurementPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
