﻿// <auto-generated />
using System;
using CleanWebAPI.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CleanWebAPI.Migrations
{
    [DbContext(typeof(MyPetContext))]
    [Migration("20230521152125_initDb")]
    partial class initDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CleanWebAPI.Models.MainModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("DefaultPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastTimeEdited")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("MainFileName")
                        .HasColumnType("text");

                    b.Property<string>("MainFilePath")
                        .HasColumnType("text");

                    b.Property<double?>("MaxPrice")
                        .HasColumnType("double precision");

                    b.Property<double?>("MinPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("ParsedUrl")
                        .HasColumnType("text");

                    b.Property<string>("ProductExtendedFullName")
                        .HasColumnType("text");

                    b.Property<string>("ProductFullName")
                        .HasColumnType("text");

                    b.Property<string>("ProductType")
                        .HasColumnType("text");

                    b.Property<int?>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}