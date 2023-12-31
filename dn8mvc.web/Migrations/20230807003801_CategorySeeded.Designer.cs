﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dn8mvc.web.Data;

#nullable disable

namespace dn8mvc.web.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230807003801_CategorySeeded")]
    partial class CategorySeeded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("blk")
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dn8mvc.web.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", "blk");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = "1",
                            Name = "Acton"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = "2",
                            Name = "Scify"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = "3",
                            Name = "History"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
