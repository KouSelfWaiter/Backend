﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence.Contexts;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(SelfWaiterDbContext))]
    partial class SelfWaiterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Baskets.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("TableNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Domain.Entities.Baskets.BasketItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BasketId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("Domain.Entities.Baskets.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrderCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Entities.Files.ImageFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ImageFiles");
                });

            modelBuilder.Entity("Domain.Entities.Products.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3696),
                            IsActive = true,
                            IsDeleted = false,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3698)
                        },
                        new
                        {
                            Id = new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700),
                            IsActive = true,
                            IsDeleted = false,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3700)
                        },
                        new
                        {
                            Id = new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3702),
                            IsActive = true,
                            IsDeleted = false,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(3703)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Products.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.Products.ProductOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOptions");
                });

            modelBuilder.Entity("Domain.Entities.Products.SpecialMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("HasBeverage")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("SpecialMenus");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.CategoryTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RelationId")
                        .HasColumnType("uuid");

                    b.Property<int>("TranslationCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.ToTable("CategoryTranslations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("000ec947-a4f7-4785-9a48-d46e2a600001"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012),
                            Name = "Yiyecek",
                            RelationId = new Guid("000ec947-d4f7-4785-9a48-d46e2a600001"),
                            TranslationCode = 0,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4012)
                        },
                        new
                        {
                            Id = new Guid("000ec947-a4f7-4785-9a48-d46e2a600002"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4015),
                            Name = "İçecek",
                            RelationId = new Guid("000ec947-d4f7-4785-9a48-d46e2a600002"),
                            TranslationCode = 0,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4016)
                        },
                        new
                        {
                            Id = new Guid("000ec947-a4f7-4785-9a48-d46e2a600003"),
                            CreatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018),
                            Name = "Tatlı",
                            RelationId = new Guid("000ec947-d4f7-4785-9a48-d46e2a600003"),
                            TranslationCode = 0,
                            UpdatedDate = new DateTime(2023, 3, 28, 14, 49, 53, 544, DateTimeKind.Utc).AddTicks(4018)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.ProductOptionsTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RelationId")
                        .HasColumnType("uuid");

                    b.Property<int>("TranslationCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.ToTable("ProductOptionsTranslations");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.ProductTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RelationId")
                        .HasColumnType("uuid");

                    b.Property<int>("TranslationCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.ToTable("ProductTranslations");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.SpecialMenuTranslation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RelationId")
                        .HasColumnType("uuid");

                    b.Property<int>("TranslationCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("RelationId");

                    b.ToTable("SpecialMenuTranslations");
                });

            modelBuilder.Entity("ImageFileProduct", b =>
                {
                    b.Property<Guid>("ImageFilesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uuid");

                    b.HasKey("ImageFilesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ImageFileProduct");
                });

            modelBuilder.Entity("ProductSpecialMenu", b =>
                {
                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SpecialMenusId")
                        .HasColumnType("uuid");

                    b.HasKey("ProductsId", "SpecialMenusId");

                    b.HasIndex("SpecialMenusId");

                    b.ToTable("ProductSpecialMenu");
                });

            modelBuilder.Entity("Domain.Entities.Baskets.BasketItem", b =>
                {
                    b.HasOne("Domain.Entities.Baskets.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Products.Product", "Product")
                        .WithMany("BasketItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Baskets.Order", b =>
                {
                    b.HasOne("Domain.Entities.Baskets.Basket", "Basket")
                        .WithOne("Order")
                        .HasForeignKey("Domain.Entities.Baskets.Order", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");
                });

            modelBuilder.Entity("Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("Domain.Entities.Products.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entities.Products.ProductOption", b =>
                {
                    b.HasOne("Domain.Entities.Products.Product", "Product")
                        .WithMany("ProductOptions")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.CategoryTranslation", b =>
                {
                    b.HasOne("Domain.Entities.Products.Category", "Relation")
                        .WithMany("Translations")
                        .HasForeignKey("RelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relation");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.ProductOptionsTranslation", b =>
                {
                    b.HasOne("Domain.Entities.Products.ProductOption", "Relation")
                        .WithMany("Translations")
                        .HasForeignKey("RelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relation");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.ProductTranslation", b =>
                {
                    b.HasOne("Domain.Entities.Products.Product", "Relation")
                        .WithMany("Translations")
                        .HasForeignKey("RelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relation");
                });

            modelBuilder.Entity("Domain.Entities.Products.Translaitons.SpecialMenuTranslation", b =>
                {
                    b.HasOne("Domain.Entities.Products.SpecialMenu", "Relation")
                        .WithMany("Translations")
                        .HasForeignKey("RelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Relation");
                });

            modelBuilder.Entity("ImageFileProduct", b =>
                {
                    b.HasOne("Domain.Entities.Files.ImageFile", null)
                        .WithMany()
                        .HasForeignKey("ImageFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSpecialMenu", b =>
                {
                    b.HasOne("Domain.Entities.Products.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Products.SpecialMenu", null)
                        .WithMany()
                        .HasForeignKey("SpecialMenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Baskets.Basket", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Products.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Domain.Entities.Products.Product", b =>
                {
                    b.Navigation("BasketItems");

                    b.Navigation("ProductOptions");

                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Domain.Entities.Products.ProductOption", b =>
                {
                    b.Navigation("Translations");
                });

            modelBuilder.Entity("Domain.Entities.Products.SpecialMenu", b =>
                {
                    b.Navigation("Translations");
                });
#pragma warning restore 612, 618
        }
    }
}
