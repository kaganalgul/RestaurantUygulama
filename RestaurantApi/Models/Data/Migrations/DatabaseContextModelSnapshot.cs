﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantApi.Models.Data;

namespace RestaurantApi.Models.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantApi.Models.Entity.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurantApi.Models.Entity.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEmpty")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 2,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 3,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 4,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 5,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 6,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 7,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 8,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 9,
                            IsEmpty = true
                        },
                        new
                        {
                            Id = 10,
                            IsEmpty = true
                        });
                });

            modelBuilder.Entity("RestaurantApi.Models.Entity.Customer", b =>
                {
                    b.HasOne("RestaurantApi.Models.Entity.Table", "Table")
                        .WithOne("Customer")
                        .HasForeignKey("RestaurantApi.Models.Entity.Customer", "TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantApi.Models.Entity.Table", b =>
                {
                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}