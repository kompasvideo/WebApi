﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransNeftEnergo.Data;

#nullable disable

namespace TransNeftEnergo.WebAPI.Migrations
{
    [DbContext(typeof(OrganizationDb))]
    [Migration("20241005164113_decimaltostring")]
    partial class decimaltostring
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.AccountingPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AccountingPeriods");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.CalculationDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ElectricitySupplyPointId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ElectricitySupplyPointId");

                    b.ToTable("CalculationDevices");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.CurrentTransformer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ElectricityMeasurementPointId")
                        .HasColumnType("int");

                    b.Property<string>("KTT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityMeasurementPointId")
                        .IsUnique();

                    b.ToTable("CurrentTransformers");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricEnergyMeter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ElectricityMeasurementPointId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityMeasurementPointId")
                        .IsUnique();

                    b.ToTable("ElectricEnergyMeters");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectOfConsumptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectOfConsumptionId");

                    b.ToTable("ElectricityMeasurementPoints");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricitySupplyPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("MaxPower")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectOfConsumptionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectOfConsumptionId");

                    b.ToTable("ElectricitySupplyPoints");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ObjectOfConsumption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubsidiaryOrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubsidiaryOrganizationId");

                    b.ToTable("ObjectOfConsumptions");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.SubsidiaryOrganization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("SubsidiaryOrganizations");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.VoltageTransformer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ElectricityMeasurementPointId")
                        .HasColumnType("int");

                    b.Property<string>("KTN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("VerificationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ElectricityMeasurementPointId")
                        .IsUnique();

                    b.ToTable("VoltageTransformers");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.CalculationDevice", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ElectricitySupplyPoint", "ElectricitySupplyPoint")
                        .WithMany("CalculationDevices")
                        .HasForeignKey("ElectricitySupplyPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricitySupplyPoint");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.CurrentTransformer", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", "ElectricityMeasurementPoint")
                        .WithOne("CurrentTransformer")
                        .HasForeignKey("TransNeftEnergo.Data.Entity.CurrentTransformer", "ElectricityMeasurementPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasurementPoint");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricEnergyMeter", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", "ElectricityMeasurementPoint")
                        .WithOne("ElectricEnergyMeter")
                        .HasForeignKey("TransNeftEnergo.Data.Entity.ElectricEnergyMeter", "ElectricityMeasurementPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasurementPoint");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ObjectOfConsumption", "ObjectOfConsumption")
                        .WithMany("ElectricityMeasurementPoints")
                        .HasForeignKey("ObjectOfConsumptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ObjectOfConsumption");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricitySupplyPoint", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ObjectOfConsumption", "ObjectOfConsumption")
                        .WithMany("ElectricitySupplyPoints")
                        .HasForeignKey("ObjectOfConsumptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ObjectOfConsumption");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ObjectOfConsumption", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.SubsidiaryOrganization", "SubsidiaryOrganization")
                        .WithMany("ObjectOfConsumptions")
                        .HasForeignKey("SubsidiaryOrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubsidiaryOrganization");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.SubsidiaryOrganization", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.Organization", "Organization")
                        .WithMany("SubsidiaryOrganizations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.VoltageTransformer", b =>
                {
                    b.HasOne("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", "ElectricityMeasurementPoint")
                        .WithOne("VoltageTransformer")
                        .HasForeignKey("TransNeftEnergo.Data.Entity.VoltageTransformer", "ElectricityMeasurementPointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ElectricityMeasurementPoint");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricityMeasurementPoint", b =>
                {
                    b.Navigation("CurrentTransformer");

                    b.Navigation("ElectricEnergyMeter");

                    b.Navigation("VoltageTransformer");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ElectricitySupplyPoint", b =>
                {
                    b.Navigation("CalculationDevices");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.ObjectOfConsumption", b =>
                {
                    b.Navigation("ElectricityMeasurementPoints");

                    b.Navigation("ElectricitySupplyPoints");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.Organization", b =>
                {
                    b.Navigation("SubsidiaryOrganizations");
                });

            modelBuilder.Entity("TransNeftEnergo.Data.Entity.SubsidiaryOrganization", b =>
                {
                    b.Navigation("ObjectOfConsumptions");
                });
#pragma warning restore 612, 618
        }
    }
}
