﻿// <auto-generated />
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelListing.API.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    partial class HotelListingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            Name = "Ho Chi Minh",
                            ShortName = "HCM"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ha Noi",
                            ShortName = "HN"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Da Nang",
                            ShortName = "DN"
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                            Address = "235 Đ. Nguyễn Văn Cừ, Phường Nguyễn Cư Trinh, Quận 1, Thành phố Hồ Chí Minh",
                            CountryId = 1,
                            Name = "Hotel Nikko Saigon",
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            Id = 2,
                            Address = "38 P. Gia Ngư, Hàng Bạc, Hoàn Kiếm, Hà Nội",
                            CountryId = 2,
                            Name = "Hanoi Tirant Hotel",
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 3,
                            Address = "216 Võ Nguyên Giáp, Phước Mỹ, Sơn Trà, Đà Nẵng",
                            CountryId = 3,
                            Name = "Belle Maison Parosand Danang",
                            Rating = 4.7000000000000002
                        });
                });

            modelBuilder.Entity("HotelListing.API.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.API.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
