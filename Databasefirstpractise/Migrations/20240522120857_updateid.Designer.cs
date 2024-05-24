﻿// <auto-generated />
using System;
using Databasefirstpractise.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Databasefirstpractise.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    [Migration("20240522120857_updateid")]
    partial class updateid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Databasefirstpractise.Models.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("empId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpId"));

                    b.Property<int>("Salary")
                        .HasColumnType("int")
                        .HasColumnName("salary");

                    b.HasKey("EmpId");

                    b.ToTable("employee", (string)null);
                });

            modelBuilder.Entity("Databasefirstpractise.Models.Person", b =>
                {
                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("personId");

                    b.ToTable("person", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
