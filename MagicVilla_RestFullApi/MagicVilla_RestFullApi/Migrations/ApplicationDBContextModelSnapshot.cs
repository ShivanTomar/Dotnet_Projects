﻿// <auto-generated />
using System;
using MagicVilla_RestFullApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillaRestFullApi.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_RestFullApi.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int?>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VillasDb");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            CreateDate = new DateTime(2024, 2, 8, 15, 18, 39, 431, DateTimeKind.Local).AddTicks(1770),
                            Details = "Nice White Villa",
                            ImageUrl = "https://demo.sirv.com/nuphar.jpg?w=400",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            CreateDate = new DateTime(2024, 2, 8, 15, 18, 39, 431, DateTimeKind.Local).AddTicks(1785),
                            Details = "Cool Villa",
                            ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fres.cloudinary.com%2Fdemo%2Fimage%2Fupload%2Fv1312461204%2Fsample.jpg&tbnid=4WNHiXYnskNjjM&vet=12ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY..i&imgrefurl=https%3A%2F%2Fcloudinary.com%2Fdocumentation%2Fadvanced_url_delivery_options&docid=vpbUSBPYu_DD9M&w=864&h=576&q=small%20size%20image%20url&ved=2ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY",
                            Name = "My Villa",
                            Occupancy = 6,
                            Rate = 700.0,
                            Sqft = 540,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            CreateDate = new DateTime(2024, 2, 8, 15, 18, 39, 431, DateTimeKind.Local).AddTicks(1790),
                            Details = "Nice  Villa",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3ATaj_Mahal_N-UP-A28-a.jpg&psig=AOvVaw06O3T4BLBamaWkxuVThvtZ&ust=1707291284097000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOD7weWZloQDFQAAAAAdAAAAABAE",
                            Name = "White Villa",
                            Occupancy = 4,
                            Rate = 300.0,
                            Sqft = 450,
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MagicVilla_RestFullApi.Models.VillaNumber", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaID")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaID");

                    b.ToTable("VillaNumbers");
                });

            modelBuilder.Entity("MagicVilla_RestFullApi.Models.VillaNumber", b =>
                {
                    b.HasOne("MagicVilla_RestFullApi.Models.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
