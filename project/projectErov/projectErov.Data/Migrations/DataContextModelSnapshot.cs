﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projectErov.Data;

#nullable disable

namespace projectErov.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("projectErov.Core.Entities.ContributionsEntity", b =>
                {
                    b.Property<int>("IdInTable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInTable"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Donor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameForPraying")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumInvoice")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("IdInTable");

                    b.ToTable("Contribute");
                });

            modelBuilder.Entity("projectErov.Core.Entities.ErovEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BorderErov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCity")
                        .HasColumnType("int");

                    b.Property<int>("IdInTable")
                        .HasColumnType("int");

                    b.Property<int>("IdRav")
                        .HasColumnType("int");

                    b.Property<int>("IdTypePlace")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("YardErov")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Erov");
                });

            modelBuilder.Entity("projectErov.Core.Entities.PlaceEntity", b =>
                {
                    b.Property<int>("IdInTable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInTable"), 1L, 1);

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdInTable");

                    b.ToTable("Place");
                });

            modelBuilder.Entity("projectErov.Core.Entities.QuestionAnswerEntity", b =>
                {
                    b.Property<int>("IdInTable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInTable"), 1L, 1);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdRav")
                        .HasColumnType("int");

                    b.Property<string>("NameAsker")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInTable");

                    b.ToTable("QuestionAnswer");
                });

            modelBuilder.Entity("projectErov.Core.Entities.UserEntity", b =>
                {
                    b.Property<int>("IdInTable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInTable"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Permission")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tz")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdInTable");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}