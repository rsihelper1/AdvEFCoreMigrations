﻿// <auto-generated />
using System;
using AdvEFCoreMigrations.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvEFCoreMigrations.Migrations
{
    [DbContext(typeof(MyCompanyDBContext))]
    [Migration("20190108235755_AddHireDateToEmployee")]
    partial class AddHireDateToEmployee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvEFCoreMigrations.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AuditEndDate");

                    b.Property<DateTime>("AuditModDate");

                    b.Property<string>("Department");

                    b.Property<DateTime>("Hired");

                    b.Property<bool>("IsActive");

                    b.Property<string>("JobTitle");

                    b.Property<string>("Name");

                    b.Property<int>("Salary");

                    b.Property<string>("duties");

                    b.Property<string>("duties2");

                    b.Property<string>("tasks");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
