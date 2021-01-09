﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantBaby.Data;

namespace PlantBaby.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    [Migration("20210109163344_myPlantBabyUpdates")]
    partial class myPlantBabyUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlantBaby.Models.MyPlantBaby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePlanted")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastWatered")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("PlantParentId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantParentId");

                    b.HasIndex("TypeId");

                    b.ToTable("MyPlantBabies");
                });

            modelBuilder.Entity("PlantBaby.Models.PlantParent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("PlantParents");
                });

            modelBuilder.Entity("PlantBaby.Models.PlantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Light")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("PlantParentId")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("SoilType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Water")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlantParentId");

                    b.ToTable("PlantTypes");
                });

            modelBuilder.Entity("PlantBaby.Models.MyPlantBaby", b =>
                {
                    b.HasOne("PlantBaby.Models.PlantParent", "PlantParent")
                        .WithMany()
                        .HasForeignKey("PlantParentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlantBaby.Models.PlantType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlantBaby.Models.PlantType", b =>
                {
                    b.HasOne("PlantBaby.Models.PlantParent", null)
                        .WithMany("SuggestedPlants")
                        .HasForeignKey("PlantParentId");
                });
#pragma warning restore 612, 618
        }
    }
}