using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransNeftEnergo.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class addmanytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountingPeriods",
                table: "AccountingPeriods");

            migrationBuilder.RenameTable(
                name: "AccountingPeriods",
                newName: "AccountingPeriod");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountingPeriod",
                newName: "ElectricityMeasurementPointId");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "VerificationDate",
                table: "ElectricEnergyMeters",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "AccountingPeriod",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "ElectricityMeasurementPointId",
                table: "AccountingPeriod",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CalculationDeviceId",
                table: "AccountingPeriod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountingPeriod",
                table: "AccountingPeriod",
                columns: new[] { "CalculationDeviceId", "ElectricityMeasurementPointId" });

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriod_ElectricityMeasurementPointId",
                table: "AccountingPeriod",
                column: "ElectricityMeasurementPointId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_CalculationDevices_CalculationDeviceId",
                table: "AccountingPeriod");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriod_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                table: "AccountingPeriod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountingPeriod",
                table: "AccountingPeriod");

            migrationBuilder.DropIndex(
                name: "IX_AccountingPeriod_ElectricityMeasurementPointId",
                table: "AccountingPeriod");

            migrationBuilder.DropColumn(
                name: "CalculationDeviceId",
                table: "AccountingPeriod");

            migrationBuilder.RenameTable(
                name: "AccountingPeriod",
                newName: "AccountingPeriods");

            migrationBuilder.RenameColumn(
                name: "ElectricityMeasurementPointId",
                table: "AccountingPeriods",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VerificationDate",
                table: "ElectricEnergyMeters",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "AccountingPeriods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "AccountingPeriods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AccountingPeriods",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountingPeriods",
                table: "AccountingPeriods",
                column: "Id");
        }
    }
}
