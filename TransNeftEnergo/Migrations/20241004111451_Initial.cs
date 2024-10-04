using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransNeftEnergo.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "SubsidiaryOrganizations",
                columns: table => new
                {
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubsidiaryOrganizations", x => x.OrganizationId);
                    table.ForeignKey(
                        name: "FK_SubsidiaryOrganizations_Organizations_OrganizationKey",
                        column: x => x.OrganizationKey,
                        principalTable: "Organizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObjectOfConsumptions",
                columns: table => new
                {
                    ObjectOfConsumptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubsidiaryOrganizationKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectOfConsumptions", x => x.ObjectOfConsumptionId);
                    table.ForeignKey(
                        name: "FK_ObjectOfConsumptions_SubsidiaryOrganizations_SubsidiaryOrganizationKey",
                        column: x => x.SubsidiaryOrganizationKey,
                        principalTable: "SubsidiaryOrganizations",
                        principalColumn: "OrganizationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricitySupplyPoints",
                columns: table => new
                {
                    ElectricitySupplyPointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxPower = table.Column<float>(type: "real", nullable: false),
                    ObjectOfConsumptionKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricitySupplyPoints", x => x.ElectricitySupplyPointId);
                    table.ForeignKey(
                        name: "FK_ElectricitySupplyPoints_ObjectOfConsumptions_ObjectOfConsumptionKey",
                        column: x => x.ObjectOfConsumptionKey,
                        principalTable: "ObjectOfConsumptions",
                        principalColumn: "ObjectOfConsumptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingPeriods",
                columns: table => new
                {
                    AccountingPeriodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalculationDeviceKey = table.Column<int>(type: "int", nullable: false),
                    ElectricityMeasurementPointKey = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingPeriods", x => x.AccountingPeriodId);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDevices",
                columns: table => new
                {
                    ElectricitySupplyPointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElectricitySupplyPointKey = table.Column<int>(type: "int", nullable: false),
                    AccountingPeriodKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDevices", x => x.ElectricitySupplyPointId);
                    table.ForeignKey(
                        name: "FK_CalculationDevices_AccountingPeriods_AccountingPeriodKey",
                        column: x => x.AccountingPeriodKey,
                        principalTable: "AccountingPeriods",
                        principalColumn: "AccountingPeriodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalculationDevices_ElectricitySupplyPoints_ElectricitySupplyPointKey",
                        column: x => x.ElectricitySupplyPointKey,
                        principalTable: "ElectricitySupplyPoints",
                        principalColumn: "ElectricitySupplyPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeasurementPoints",
                columns: table => new
                {
                    ElectricityMeasurementPointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectOfConsumptionKey = table.Column<int>(type: "int", nullable: false),
                    AccountingPeriodKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeasurementPoints", x => x.ElectricityMeasurementPointId);
                    table.ForeignKey(
                        name: "FK_ElectricityMeasurementPoints_AccountingPeriods_AccountingPeriodKey",
                        column: x => x.AccountingPeriodKey,
                        principalTable: "AccountingPeriods",
                        principalColumn: "AccountingPeriodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricityMeasurementPoints_ObjectOfConsumptions_ObjectOfConsumptionKey",
                        column: x => x.ObjectOfConsumptionKey,
                        principalTable: "ObjectOfConsumptions",
                        principalColumn: "ObjectOfConsumptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentTransformers",
                columns: table => new
                {
                    CurrentTransformerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KTT = table.Column<float>(type: "real", nullable: false),
                    ElectricityMeasurementPointKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTransformers", x => x.CurrentTransformerId);
                    table.ForeignKey(
                        name: "FK_CurrentTransformers_ElectricityMeasurementPoints_ElectricityMeasurementPointKey",
                        column: x => x.ElectricityMeasurementPointKey,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "ElectricityMeasurementPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricEnergyMeters",
                columns: table => new
                {
                    ElectricEnergyMeterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ElectricityMeasurementPointKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricEnergyMeters", x => x.ElectricEnergyMeterId);
                    table.ForeignKey(
                        name: "FK_ElectricEnergyMeters_ElectricityMeasurementPoints_ElectricityMeasurementPointKey",
                        column: x => x.ElectricityMeasurementPointKey,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "ElectricityMeasurementPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoltageTransformers",
                columns: table => new
                {
                    VoltageTransformerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KTN = table.Column<float>(type: "real", nullable: false),
                    ElectricityMeasurementPointKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltageTransformers", x => x.VoltageTransformerId);
                    table.ForeignKey(
                        name: "FK_VoltageTransformers_ElectricityMeasurementPoints_ElectricityMeasurementPointKey",
                        column: x => x.ElectricityMeasurementPointKey,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "ElectricityMeasurementPointId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_CalculationDeviceKey",
                table: "AccountingPeriods",
                column: "CalculationDeviceKey");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_ElectricityMeasurementPointKey",
                table: "AccountingPeriods",
                column: "ElectricityMeasurementPointKey");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDevices_AccountingPeriodKey",
                table: "CalculationDevices",
                column: "AccountingPeriodKey");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDevices_ElectricitySupplyPointKey",
                table: "CalculationDevices",
                column: "ElectricitySupplyPointKey");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTransformers_ElectricityMeasurementPointKey",
                table: "CurrentTransformers",
                column: "ElectricityMeasurementPointKey");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricEnergyMeters_ElectricityMeasurementPointKey",
                table: "ElectricEnergyMeters",
                column: "ElectricityMeasurementPointKey");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasurementPoints_AccountingPeriodKey",
                table: "ElectricityMeasurementPoints",
                column: "AccountingPeriodKey");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasurementPoints_ObjectOfConsumptionKey",
                table: "ElectricityMeasurementPoints",
                column: "ObjectOfConsumptionKey");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricitySupplyPoints_ObjectOfConsumptionKey",
                table: "ElectricitySupplyPoints",
                column: "ObjectOfConsumptionKey");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectOfConsumptions_SubsidiaryOrganizationKey",
                table: "ObjectOfConsumptions",
                column: "SubsidiaryOrganizationKey");

            migrationBuilder.CreateIndex(
                name: "IX_SubsidiaryOrganizations_OrganizationKey",
                table: "SubsidiaryOrganizations",
                column: "OrganizationKey");

            migrationBuilder.CreateIndex(
                name: "IX_VoltageTransformers_ElectricityMeasurementPointKey",
                table: "VoltageTransformers",
                column: "ElectricityMeasurementPointKey");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriods_CalculationDevices_CalculationDeviceKey",
                table: "AccountingPeriods",
                column: "CalculationDeviceKey",
                principalTable: "CalculationDevices",
                principalColumn: "ElectricitySupplyPointId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingPeriods_ElectricityMeasurementPoints_ElectricityMeasurementPointKey",
                table: "AccountingPeriods",
                column: "ElectricityMeasurementPointKey",
                principalTable: "ElectricityMeasurementPoints",
                principalColumn: "ElectricityMeasurementPointId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriods_CalculationDevices_CalculationDeviceKey",
                table: "AccountingPeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountingPeriods_ElectricityMeasurementPoints_ElectricityMeasurementPointKey",
                table: "AccountingPeriods");

            migrationBuilder.DropTable(
                name: "CurrentTransformers");

            migrationBuilder.DropTable(
                name: "ElectricEnergyMeters");

            migrationBuilder.DropTable(
                name: "VoltageTransformers");

            migrationBuilder.DropTable(
                name: "CalculationDevices");

            migrationBuilder.DropTable(
                name: "ElectricitySupplyPoints");

            migrationBuilder.DropTable(
                name: "ElectricityMeasurementPoints");

            migrationBuilder.DropTable(
                name: "AccountingPeriods");

            migrationBuilder.DropTable(
                name: "ObjectOfConsumptions");

            migrationBuilder.DropTable(
                name: "SubsidiaryOrganizations");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
