﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Practice.DataModels;

namespace WebAPI_Practice.Migrations
{
    [DbContext(typeof(StudentAdminContext))]
    partial class StudentAdminContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI_Practice.DataModels.Address", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhysicalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("WebAPI_Practice.DataModels.Gender", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("WebAPI_Practice.DataModels.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenderID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GenderID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("WebAPI_Practice.DataModels.Address", b =>
                {
                    b.HasOne("WebAPI_Practice.DataModels.Student", null)
                        .WithOne("address")
                        .HasForeignKey("WebAPI_Practice.DataModels.Address", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebAPI_Practice.DataModels.Student", b =>
                {
                    b.HasOne("WebAPI_Practice.DataModels.Gender", "gender")
                        .WithMany()
                        .HasForeignKey("GenderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gender");
                });

            modelBuilder.Entity("WebAPI_Practice.DataModels.Student", b =>
                {
                    b.Navigation("address");
                });
#pragma warning restore 612, 618
        }
    }
}
