﻿// <auto-generated />
using HotelListingApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListingApi.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20240509163140_SeededCountriesAndHotels")]
    partial class SeededCountriesAndHotels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HotelListingApi.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nigeria",
                            ShortName = "NGN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "United States Of America",
                            ShortName = "USA"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United Kingdom",
                            ShortName = "UK"
                        },
                        new
                        {
                            Id = 4,
                            Name = "France",
                            ShortName = "FRA"
                        });
                });

            modelBuilder.Entity("HotelListingApi.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Ikeja, Lagos",
                            CountryId = 1,
                            Name = "Sheratton Hotel",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 2,
                            Address = "Victoria Island, Lagos",
                            CountryId = 1,
                            Name = "Eko Hotel",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "Brooklyn, New York",
                            CountryId = 2,
                            Name = "Burge Khalifa",
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 4,
                            Address = "Lincoln, London",
                            CountryId = 3,
                            Name = "The Grand Hotel",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "Paris",
                            CountryId = 4,
                            Name = "Rochester Champs Elysees",
                            Rating = 4.2000000000000002
                        });
                });

            modelBuilder.Entity("HotelListingApi.Data.Hotel", b =>
                {
                    b.HasOne("HotelListingApi.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListingApi.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}