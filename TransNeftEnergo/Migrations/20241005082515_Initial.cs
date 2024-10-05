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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubsidiaryOrganizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubsidiaryOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubsidiaryOrganizations_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObjectOfConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubsidiaryOrganizationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectOfConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ObjectOfConsumptions_SubsidiaryOrganizations_SubsidiaryOrganizationId",
                        column: x => x.SubsidiaryOrganizationId,
                        principalTable: "SubsidiaryOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricityMeasurementPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectOfConsumptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricityMeasurementPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricityMeasurementPoints_ObjectOfConsumptions_ObjectOfConsumptionId",
                        column: x => x.ObjectOfConsumptionId,
                        principalTable: "ObjectOfConsumptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricitySupplyPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxPower = table.Column<double>(type: "float", nullable: false),
                    ObjectOfConsumptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricitySupplyPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricitySupplyPoints_ObjectOfConsumptions_ObjectOfConsumptionId",
                        column: x => x.ObjectOfConsumptionId,
                        principalTable: "ObjectOfConsumptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentTransformers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KTT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElectricityMeasurementPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentTransformers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentTransformers_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                        column: x => x.ElectricityMeasurementPointId,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricEnergyMeters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ElectricityMeasurementPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricEnergyMeters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricEnergyMeters_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                        column: x => x.ElectricityMeasurementPointId,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VoltageTransformers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    VerificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KTN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElectricityMeasurementPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoltageTransformers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VoltageTransformers_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                        column: x => x.ElectricityMeasurementPointId,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalculationDevices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ElectricitySupplyPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculationDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalculationDevices_ElectricitySupplyPoints_ElectricitySupplyPointId",
                        column: x => x.ElectricitySupplyPointId,
                        principalTable: "ElectricitySupplyPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccountingPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalculationDeviceId = table.Column<int>(type: "int", nullable: false),
                    ElectricityMeasurementPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingPeriods_CalculationDevices_CalculationDeviceId",
                        column: x => x.CalculationDeviceId,
                        principalTable: "CalculationDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccountingPeriods_ElectricityMeasurementPoints_ElectricityMeasurementPointId",
                        column: x => x.ElectricityMeasurementPointId,
                        principalTable: "ElectricityMeasurementPoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_CalculationDeviceId",
                table: "AccountingPeriods",
                column: "CalculationDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountingPeriods_ElectricityMeasurementPointId",
                table: "AccountingPeriods",
                column: "ElectricityMeasurementPointId");

            migrationBuilder.CreateIndex(
                name: "IX_CalculationDevices_ElectricitySupplyPointId",
                table: "CalculationDevices",
                column: "ElectricitySupplyPointId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentTransformers_ElectricityMeasurementPointId",
                table: "CurrentTransformers",
                column: "ElectricityMeasurementPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricEnergyMeters_ElectricityMeasurementPointId",
                table: "ElectricEnergyMeters",
                column: "ElectricityMeasurementPointId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ElectricityMeasurementPoints_ObjectOfConsumptionId",
                table: "ElectricityMeasurementPoints",
                column: "ObjectOfConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricitySupplyPoints_ObjectOfConsumptionId",
                table: "ElectricitySupplyPoints",
                column: "ObjectOfConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectOfConsumptions_SubsidiaryOrganizationId",
                table: "ObjectOfConsumptions",
                column: "SubsidiaryOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SubsidiaryOrganizations_OrganizationId",
                table: "SubsidiaryOrganizations",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_VoltageTransformers_ElectricityMeasurementPointId",
                table: "VoltageTransformers",
                column: "ElectricityMeasurementPointId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountingPeriods");

            migrationBuilder.DropTable(
                name: "CurrentTransformers");

            migrationBuilder.DropTable(
                name: "ElectricEnergyMeters");

            migrationBuilder.DropTable(
                name: "VoltageTransformers");

            migrationBuilder.DropTable(
                name: "CalculationDevices");

            migrationBuilder.DropTable(
                name: "ElectricityMeasurementPoints");

            migrationBuilder.DropTable(
                name: "ElectricitySupplyPoints");

            migrationBuilder.DropTable(
                name: "ObjectOfConsumptions");

            migrationBuilder.DropTable(
                name: "SubsidiaryOrganizations");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
