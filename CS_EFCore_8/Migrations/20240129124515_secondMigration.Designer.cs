﻿// <auto-generated />
using System;
using System.Collections.Generic;
using CS_EFCore_8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CS_EFCore_8.Migrations
{
    [DbContext(typeof(EFCore8FeatureContext))]
    [Migration("20240129124515_secondMigration")]
    partial class secondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CS_EFCore_8.Models.BirthRecord", b =>
                {
                    b.Property<int>("BirthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BirthId"));

                    b.Property<string>("BirthName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("TimeOfBirth")
                        .HasColumnType("time");

                    b.HasKey("BirthId");

                    b.ToTable("BirthRecord");

                    b.HasData(
                        new
                        {
                            BirthId = 1,
                            BirthName = "Ganesh",
                            DateOfBirth = new DateOnly(2022, 1, 1),
                            TimeOfBirth = new TimeOnly(1, 0, 0)
                        });
                });

            modelBuilder.Entity("CS_EFCore_8.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ComplexProperty<Dictionary<string, object>>("Address", "CS_EFCore_8.Models.Person.Address#Address", b1 =>
                        {
                            b1.IsRequired();

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("FlatOrBungloNo")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PinCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");
                        });

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}