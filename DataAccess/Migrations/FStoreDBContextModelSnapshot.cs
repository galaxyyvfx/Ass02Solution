﻿// <auto-generated />
using System;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(FStoreDBContext))]
    partial class FStoreDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<string>("City")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Country")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.HasKey("MemberId");

                    b.ToTable("Member", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<decimal?>("Freight")
                        .HasColumnType("money");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId");

                    b.HasIndex("MemberId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.OrderDetail", b =>
                {
                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("money");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<decimal?>("UnitPrice")
                        .HasColumnType("money");

                    b.Property<int?>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ProductId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Order", b =>
                {
                    b.HasOne("DataAccess.Models.Member", "Member")
                        .WithMany("Orders")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("FK__Order__MemberId__38996AB5");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("DataAccess.Models.OrderDetail", b =>
                {
                    b.HasOne("DataAccess.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__OrderDeta__Order__3C69FB99");

                    b.HasOne("DataAccess.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__OrderDeta__Produ__3D5E1FD2");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DataAccess.Models.Member", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
