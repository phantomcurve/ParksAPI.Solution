﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksAPI.Models;

namespace ParksAPI.Migrations
{
    [DbContext(typeof(ParksAPIContext))]
    [Migration("20211121063951_Initial")]
    partial class Initial
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

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4");

                    b.Property<bool>("National")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}
