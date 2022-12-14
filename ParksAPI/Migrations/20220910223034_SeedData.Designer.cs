// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    [Migration("20220910223034_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParksAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Feature")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ParkName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            City = "Coos Bay",
                            Feature = "yurts",
                            ParkName = "Bullards Beach",
                            State = "Oregon",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 2,
                            City = "The Dalles",
                            Feature = "fishing",
                            ParkName = "Cottonwood Canyon",
                            State = "Oregon",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 3,
                            City = "Astoria",
                            Feature = "swimming",
                            ParkName = "Fort Stevens State Park",
                            State = "Oregon",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 4,
                            City = "Crater Lake",
                            Feature = "biking",
                            ParkName = "Crater Lake",
                            State = "Oregon",
                            Type = "National"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
