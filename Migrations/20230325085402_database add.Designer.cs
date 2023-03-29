﻿// <auto-generated />
using System;
using Fuel_Tracking_application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FuelTrackingapplication.Migrations
{
    [DbContext(typeof(FuelDbContext))]
    [Migration("20230325085402_database add")]
    partial class databaseadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fuel_Tracking_application.Models.Domain.Fuel", b =>
                {
                    b.Property<Guid>("dataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("accKilometerTotal")
                        .HasColumnType("float");

                    b.Property<double>("accKilometeres")
                        .HasColumnType("float");

                    b.Property<double>("accLitres")
                        .HasColumnType("float");

                    b.Property<double>("accLitresTotal")
                        .HasColumnType("float");

                    b.Property<double>("consumptionKm")
                        .HasColumnType("float");

                    b.Property<double>("consumptionKmTotal")
                        .HasColumnType("float");

                    b.Property<double>("consumptionLitres")
                        .HasColumnType("float");

                    b.Property<double>("consumptionlitresTotal")
                        .HasColumnType("float");

                    b.Property<double>("costOfTheKm")
                        .HasColumnType("float");

                    b.Property<string>("fillStationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("filled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("filledVolume")
                        .HasColumnType("float");

                    b.Property<double>("fuelPrice")
                        .HasColumnType("float");

                    b.Property<string>("fuelType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("odometerTotal")
                        .HasColumnType("float");

                    b.Property<double>("refilCostTotal")
                        .HasColumnType("float");

                    b.Property<double>("refillCost")
                        .HasColumnType("float");

                    b.Property<string>("reportingEmployee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("siteLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleMake")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicleregistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dataId");

                    b.ToTable("FuelData");
                });
#pragma warning restore 612, 618
        }
    }
}
