﻿// <auto-generated />
using AspDotNetCoreDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspDotNetCoreDbContext.Migrations
{
    [DbContext(typeof(DbAspNetCoreCtx))]
    [Migration("20190411120402_M100")]
    partial class M100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspDotNetCoreDbContext.Table1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Num1");

                    b.Property<string>("String1")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Table1");
                });
#pragma warning restore 612, 618
        }
    }
}
