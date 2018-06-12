﻿// <auto-generated />
using CarShowRoom.Db;
using CarShowRoom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CarShowRoom.Migrations
{
    [DbContext(typeof(CRMContext))]
    [Migration("20180612150335_Partners")]
    partial class Partners
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("CarShowRoom.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarModelId");

                    b.Property<int?>("ClientId");

                    b.Property<int>("ColorId");

                    b.Property<int?>("DepotId");

                    b.Property<int>("PartnerId");

                    b.Property<decimal>("Price");

                    b.Property<bool>("TestDrive");

                    b.Property<string>("VIN")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("CarModelId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ColorId");

                    b.HasIndex("DepotId");

                    b.HasIndex("PartnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarShowRoom.Models.CarColor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Blue");

                    b.Property<byte>("Green");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte>("Red");

                    b.HasKey("Id");

                    b.ToTable("CarColors");
                });

            modelBuilder.Entity("CarShowRoom.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DriveUnitType");

                    b.Property<string>("EngineCapacity");

                    b.Property<int>("EngineType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("TransmissionType");

                    b.Property<int>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("CarShowRoom.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("Stage");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CarShowRoom.Models.Depot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Depots");
                });

            modelBuilder.Entity("CarShowRoom.Models.Partner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Requisites");

                    b.HasKey("Id");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("CarShowRoom.Models.PartType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Price")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("PartTypes");
                });

            modelBuilder.Entity("CarShowRoom.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CarShowRoom.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("CarShowRoom.Models.Car", b =>
                {
                    b.HasOne("CarShowRoom.Models.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarShowRoom.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarShowRoom.Models.CarColor", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarShowRoom.Models.Depot", "Depot")
                        .WithMany()
                        .HasForeignKey("DepotId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarShowRoom.Models.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CarShowRoom.Models.CarModel", b =>
                {
                    b.HasOne("CarShowRoom.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
