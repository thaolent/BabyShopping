﻿// <auto-generated />
using System;
using Baby_ShoppingOnline.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Baby_ShoppingOnline.Data.Migrations
{
    [DbContext(typeof(BabyCareContext))]
    [Migration("20241024110458_SeedCategory")]
    partial class SeedCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            Email = "thanhthao110889@gmail.com",
                            Password = "12345678",
                            Phone = "0982345167",
                            Username = "thaolent"
                        },
                        new
                        {
                            AccountId = 2,
                            Email = "kisshoang@gmail.com",
                            Password = "12345678",
                            Phone = "0982345168",
                            Username = "dungdq"
                        });
                });

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Diapers",
                            Description = "Diaper for infant and baby"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Powdered Milk",
                            Description = "A dairy product made by evaporating milk to dryness"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Reconstituted milk",
                            Description = "Mixing milk powder with water to create liquid milk"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Baby Food",
                            Description = "This food is specifically made to meet the nutritional needs of infants and toddlers, ensuring they get the essential vitamins and minerals for proper growth and development"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Vitamins",
                            Description = " vitamins are essential for their growth and development"
                        });
                });

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AveragePoint")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RefCategoryIdCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("RefCategoryIdCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AveragePoint = 7.5m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7662),
                            Description = "Platinum",
                            Image = "D:\\.NET\\BabyShopping_Image\\Diaper\\Huggies.jpg",
                            Price = 195000.0m,
                            ProductName = "Huggies Nature Made",
                            RefCategoryIdCategoryId = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7684)
                        },
                        new
                        {
                            ProductId = 2,
                            AveragePoint = 5.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7686),
                            Description = "Bobby for baby",
                            Image = "D:\\.NET\\BabyShopping_Image\\Diaper\\bobby.jpg",
                            Price = 189900.0m,
                            ProductName = "Bobby",
                            RefCategoryIdCategoryId = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7687)
                        },
                        new
                        {
                            ProductId = 3,
                            AveragePoint = 9.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7689),
                            Description = "Gooby Extra Newborn Little ",
                            Image = "D:\\.NET\\BabyShopping_Image\\Diaper\\gooby.jpg",
                            Price = 205000.0m,
                            ProductName = "Gooby",
                            RefCategoryIdCategoryId = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7690)
                        },
                        new
                        {
                            ProductId = 4,
                            AveragePoint = 7.2m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7691),
                            Description = "Bland, soft fabric. - Ultra-soft fabric using the super-microfiber ",
                            Image = "D:\\.NET\\BabyShopping_Image\\Diaper\\nabizam.jpg",
                            Price = 234098.0m,
                            ProductName = "Nabizam",
                            RefCategoryIdCategoryId = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7692)
                        },
                        new
                        {
                            ProductId = 5,
                            AveragePoint = 6.1m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7693),
                            Description = "MAMOGOM Premium CARE ORGANIC KOREAN PREMIUM CARE  ",
                            Image = "D:\\.NET\\BabyShopping_Image\\Diaper\\mamogom.jpg",
                            Price = 245000.0m,
                            ProductName = "Mamogom",
                            RefCategoryIdCategoryId = 1,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7694)
                        },
                        new
                        {
                            ProductId = 6,
                            AveragePoint = 7.5m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7798),
                            Description = "Aptamil NewZeland",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\aptamil_bac.jpg",
                            Price = 195000.0m,
                            ProductName = "Aptamil",
                            RefCategoryIdCategoryId = 2,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7799)
                        },
                        new
                        {
                            ProductId = 7,
                            AveragePoint = 5.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7800),
                            Description = "For infant",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\blackmore.jpg",
                            Price = 189900.0m,
                            ProductName = "Blackmores",
                            RefCategoryIdCategoryId = 2,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7801)
                        },
                        new
                        {
                            ProductId = 8,
                            AveragePoint = 9.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7804),
                            Description = "Colos for baby",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\colosbaby.jpg",
                            Price = 205000.0m,
                            ProductName = "ColosBaby",
                            RefCategoryIdCategoryId = 2,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7804)
                        },
                        new
                        {
                            ProductId = 9,
                            AveragePoint = 7.2m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7806),
                            Description = "Well-cooked, pureed legumes such as beans, lentils and chickpeas.",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\enfamil.jpg",
                            Price = 234098.0m,
                            ProductName = "Enfamil A+",
                            RefCategoryIdCategoryId = 2,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7807)
                        },
                        new
                        {
                            ProductId = 10,
                            AveragePoint = 6.1m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7808),
                            Description = "HiPP becomes Germany's third company and first food manufacturer",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Powdered milk\\hipp.jpg",
                            Price = 245000.0m,
                            ProductName = "HiPP",
                            RefCategoryIdCategoryId = 2,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7809)
                        },
                        new
                        {
                            ProductId = 11,
                            AveragePoint = 7.5m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7810),
                            Description = "Abott Grow",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\abottgrow.jpg",
                            Price = 195000.0m,
                            ProductName = "Abott Grow",
                            RefCategoryIdCategoryId = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7811)
                        },
                        new
                        {
                            ProductId = 12,
                            AveragePoint = 5.6m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7813),
                            Description = "Aptakid",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\aptakid.jpg",
                            Price = 189900.0m,
                            ProductName = "Aptakid",
                            RefCategoryIdCategoryId = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7813)
                        },
                        new
                        {
                            ProductId = 13,
                            AveragePoint = 4.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7815),
                            Description = "Colos for baby",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\colosbaby.jpg",
                            Price = 205000.0m,
                            ProductName = "ColosBaby",
                            RefCategoryIdCategoryId = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7815)
                        },
                        new
                        {
                            ProductId = 14,
                            AveragePoint = 7.4m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7817),
                            Description = "DalatMilk",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\dalatmilk.jpg",
                            Price = 123000.0m,
                            ProductName = "DalatMilk",
                            RefCategoryIdCategoryId = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7818)
                        },
                        new
                        {
                            ProductId = 15,
                            AveragePoint = 9.8m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7820),
                            Description = "Vinamil Green farm",
                            Image = "D:\\.NET\\BabyShopping_Image\\Milk\\Liquid milk\\vinamilk xanh.jpg",
                            Price = 134000.0m,
                            ProductName = "Vinamilk",
                            RefCategoryIdCategoryId = 3,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7820)
                        },
                        new
                        {
                            ProductId = 16,
                            AveragePoint = 7.5m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7822),
                            Description = "Banh an dam",
                            Image = "D:\\.NET\\BabyShopping_Image\\Baby Food\\banhandamGerber.jpg",
                            Price = 195000.0m,
                            ProductName = "Gerber Puffs",
                            RefCategoryIdCategoryId = 4,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7822)
                        },
                        new
                        {
                            ProductId = 17,
                            AveragePoint = 5.6m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7824),
                            Description = "Bot an dam vi lua mach",
                            Image = "D:\\.NET\\BabyShopping_Image\\Baby Food\\botbiokid.jpg",
                            Price = 189900.0m,
                            ProductName = "BioKids",
                            RefCategoryIdCategoryId = 4,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7825)
                        },
                        new
                        {
                            ProductId = 18,
                            AveragePoint = 4.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7826),
                            Description = "Bot an dam vij sua",
                            Image = "D:\\.NET\\BabyShopping_Image\\Baby Food\\botHeinz.jpg",
                            Price = 205000.0m,
                            ProductName = "Bot Heinz",
                            RefCategoryIdCategoryId = 4,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7827)
                        },
                        new
                        {
                            ProductId = 19,
                            AveragePoint = 7.4m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7828),
                            Description = "Bot an dam Hipp",
                            Image = "D:\\.NET\\BabyShopping_Image\\Baby Food\\botHipp.jpg",
                            Price = 123000.0m,
                            ProductName = "Bot HiPP Organic",
                            RefCategoryIdCategoryId = 4,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7829)
                        },
                        new
                        {
                            ProductId = 20,
                            AveragePoint = 9.8m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7830),
                            Description = "Vang sua trai cay",
                            Image = "D:\\.NET\\BabyShopping_Image\\Baby Food\\vangsuahoff.jpg",
                            Price = 134000.0m,
                            ProductName = "Vang sua Hoff",
                            RefCategoryIdCategoryId = 4,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7831)
                        },
                        new
                        {
                            ProductId = 21,
                            AveragePoint = 7.5m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7833),
                            Description = "Men tieu hoa",
                            Image = "D:\\.NET\\BabyShopping_Image\\Vitamin\\biogaia.jpg",
                            Price = 195000.0m,
                            ProductName = "BioGaia",
                            RefCategoryIdCategoryId = 5,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7833)
                        },
                        new
                        {
                            ProductId = 22,
                            AveragePoint = 5.6m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7835),
                            Description = "D3K2",
                            Image = "D:\\.NET\\BabyShopping_Image\\Vitamin\\sunday natural.jpg",
                            Price = 189900.0m,
                            ProductName = "Sunday Natural",
                            RefCategoryIdCategoryId = 5,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7835)
                        },
                        new
                        {
                            ProductId = 23,
                            AveragePoint = 4.0m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7837),
                            Description = "An ngon ngu ngon",
                            Image = "D:\\.NET\\BabyShopping_Image\\Vitamin\\fitobimbi.jpg",
                            Price = 205000.0m,
                            ProductName = "Fitobimbi",
                            RefCategoryIdCategoryId = 5,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7837)
                        },
                        new
                        {
                            ProductId = 24,
                            AveragePoint = 7.4m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7839),
                            Description = "MultiVitamins",
                            Image = "D:\\.NET\\BabyShopping_Image\\Vitamin\\pediakid.jpg",
                            Price = 123000.0m,
                            ProductName = "PediaKid",
                            RefCategoryIdCategoryId = 5,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7840)
                        },
                        new
                        {
                            ProductId = 25,
                            AveragePoint = 9.8m,
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7841),
                            Description = "Probiotic",
                            Image = "D:\\.NET\\BabyShopping_Image\\Vitamin\\pribiotic.jpg",
                            Price = 134000.0m,
                            ProductName = "Kid Smart drops",
                            RefCategoryIdCategoryId = 5,
                            UpdatedBy = "Admin",
                            UpdatedDate = new DateTime(2024, 10, 24, 18, 4, 57, 441, DateTimeKind.Local).AddTicks(7842)
                        });
                });

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RefProductIdProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingId");

                    b.HasIndex("RefProductIdProductId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            Comment = "This iss rating for product 1",
                            Point = 5,
                            RefProductIdProductId = 1
                        },
                        new
                        {
                            RatingId = 2,
                            Comment = "This iss rating for product 6",
                            Point = 7,
                            RefProductIdProductId = 6
                        },
                        new
                        {
                            RatingId = 3,
                            Comment = "This iss rating for product 10",
                            Point = 8,
                            RefProductIdProductId = 10
                        },
                        new
                        {
                            RatingId = 4,
                            Comment = "This iss rating for product 19",
                            Point = 6,
                            RefProductIdProductId = 19
                        },
                        new
                        {
                            RatingId = 5,
                            Comment = "This iss rating for product 22",
                            Point = 9,
                            RefProductIdProductId = 22
                        });
                });

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Product", b =>
                {
                    b.HasOne("Baby_ShoppingOnline.Entity.Category", "RefCategoryId")
                        .WithMany()
                        .HasForeignKey("RefCategoryIdCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RefCategoryId");
                });

            modelBuilder.Entity("Baby_ShoppingOnline.Entity.Rating", b =>
                {
                    b.HasOne("Baby_ShoppingOnline.Entity.Product", "RefProductId")
                        .WithMany()
                        .HasForeignKey("RefProductIdProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RefProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
