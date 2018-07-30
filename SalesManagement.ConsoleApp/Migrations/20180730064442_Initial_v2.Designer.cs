﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesManagement.ConsoleApp.Domain.Data.EF;

namespace SalesManagement.ConsoleApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180730064442_Initial_v2")]
    partial class Initial_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("OriginalPrice");

                    b.Property<decimal>("Price");

                    b.Property<decimal?>("PromotionPrice");

                    b.Property<string>("SeoAlias")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(255);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(255);

                    b.Property<string>("SeoPageTitle")
                        .HasMaxLength(255);

                    b.Property<int>("Status");

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.Property<string>("Unit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("SeoAlias")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(255);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(255);

                    b.Property<string>("SeoPageTitle")
                        .HasMaxLength(255);

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .HasMaxLength(255);

                    b.Property<string>("Path")
                        .HasMaxLength(255);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductQuantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorId");

                    b.Property<int>("CorlorId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("CorlorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductQuantities");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductTag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 64)))
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ProductId");

                    b.Property<string>("TagId")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.WholePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromQuantity");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("ToQuantity");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("WholePrices");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", b =>
                {
                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductQuantity", b =>
                {
                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("CorlorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.ProductTag", b =>
                {
                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("SalesManagement.ConsoleApp.Domain.Data.Entities.WholePrice", b =>
                {
                    b.HasOne("SalesManagement.ConsoleApp.Domain.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
