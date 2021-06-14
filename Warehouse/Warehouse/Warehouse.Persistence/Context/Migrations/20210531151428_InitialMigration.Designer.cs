﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Persistence.Context;

namespace Warehouse.Persistence.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20210531151428_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Warehouse.Persistence.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint")
                        .HasColumnName("State");

                    b.HasKey("Id");

                    b.ToTable("Category", "Warehouse");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Item.Entities.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActualOwnerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ActualOwnerId");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<Guid?>("OwnerId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OwnerId");

                    b.Property<byte>("QualityLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("QualityLevel");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint")
                        .HasColumnName("State");

                    b.HasKey("Id");

                    b.HasIndex("ActualOwnerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Items", "Warehouse");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Item.Entities.LoanHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BorrowerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BorrowerId");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ItemId");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ReceiverId");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("LoanHistories", "Warehouse");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Squad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint")
                        .HasColumnName("State");

                    b.HasKey("Id");

                    b.ToTable("Squads", "Warehouse");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.User.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("LastName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varbinary(256)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte>("PermissionLevel")
                        .HasColumnType("tinyint")
                        .HasColumnName("PermissionLevel");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("PhoneNumber");

                    b.Property<Guid>("SquadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint")
                        .HasColumnName("State");

                    b.HasKey("Id");

                    b.HasIndex("SquadId");

                    b.ToTable("Users", "Warehouse");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Item.Entities.Item", b =>
                {
                    b.HasOne("Warehouse.Persistence.Entities.User.Entities.User", null)
                        .WithMany("OwnedItems")
                        .HasForeignKey("ActualOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Persistence.Entities.Category", null)
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Warehouse.Persistence.Entities.User.Entities.User", null)
                        .WithMany("StoredItems")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Item.Entities.LoanHistory", b =>
                {
                    b.HasOne("Warehouse.Persistence.Entities.Item.Entities.Item", null)
                        .WithMany("LoanHistories")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.User.Entities.User", b =>
                {
                    b.HasOne("Warehouse.Persistence.Entities.Squad", null)
                        .WithMany("Users")
                        .HasForeignKey("SquadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Item.Entities.Item", b =>
                {
                    b.Navigation("LoanHistories");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.Squad", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Warehouse.Persistence.Entities.User.Entities.User", b =>
                {
                    b.Navigation("OwnedItems");

                    b.Navigation("StoredItems");
                });
#pragma warning restore 612, 618
        }
    }
}