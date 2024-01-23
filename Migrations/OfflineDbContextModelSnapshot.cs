﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Offline_System;

#nullable disable

namespace Offline_System.Migrations
{
    [DbContext(typeof(OfflineDbContext))]
    partial class OfflineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Offline_System.Models.Data.Departments", b =>
                {
                    b.Property<int>("departId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("departId"));

                    b.Property<int>("departActive")
                        .HasColumnType("int");

                    b.Property<string>("departName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departId");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Offline_System.Models.Data.Employees", b =>
                {
                    b.Property<int>("EmployeesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeesID"));

                    b.Property<string>("EmployeesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeesID");

                    b.ToTable("employees");
                });
#pragma warning restore 612, 618
        }
    }
}