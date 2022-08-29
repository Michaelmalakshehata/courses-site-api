﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using courses_site_api.models;

namespace courses_site_api.Migrations
{
    [DbContext(typeof(courses_entitiy))]
    [Migration("20220828160502_intiat")]
    partial class intiat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("courses_site_api.Extensions.models.reservedcourse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("finalprice")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Reservedcourses");
                });

            modelBuilder.Entity("courses_site_api.models.Course_detailes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("discount")
                        .HasColumnType("int");

                    b.Property<string>("imgpath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberofhours")
                        .HasColumnType("int");

                    b.Property<int>("numberofvideos")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("course_Detailes");
                });

            modelBuilder.Entity("courses_site_api.models.Courses_category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Course_Detailesid")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Course_Detailesid");

                    b.ToTable("courses_Categories");
                });

            modelBuilder.Entity("courses_site_api.models.Courses_videos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Courses_Categoryid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videopath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Courses_Categoryid");

                    b.ToTable("courses_Videos");
                });

            modelBuilder.Entity("courses_site_api.models.chat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registrationid")
                        .HasColumnType("int");

                    b.Property<string>("Sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Registrationid");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("courses_site_api.models.comments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("registrationid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("registrationid");

                    b.ToTable("comments");
                });

            modelBuilder.Entity("courses_site_api.models.purchasedcourses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("courseid")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("purchasedcourses");
                });

            modelBuilder.Entity("courses_site_api.models.registration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("avatarpath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("registrations");
                });

            modelBuilder.Entity("courses_site_api.models.Courses_category", b =>
                {
                    b.HasOne("courses_site_api.models.Course_detailes", "Course_Detailes")
                        .WithMany("Courses_Categories")
                        .HasForeignKey("Course_Detailesid")
                        .HasConstraintName("ForeignKey-Courses_category-Course_Detailes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course_Detailes");
                });

            modelBuilder.Entity("courses_site_api.models.Courses_videos", b =>
                {
                    b.HasOne("courses_site_api.models.Courses_category", "Courses_Category")
                        .WithMany("Courses_Videos")
                        .HasForeignKey("Courses_Categoryid")
                        .HasConstraintName("ForeignKey-Courses_videos-Courses_category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses_Category");
                });

            modelBuilder.Entity("courses_site_api.models.chat", b =>
                {
                    b.HasOne("courses_site_api.models.registration", "Registration")
                        .WithMany("chats")
                        .HasForeignKey("Registrationid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("courses_site_api.models.comments", b =>
                {
                    b.HasOne("courses_site_api.models.registration", "registration")
                        .WithMany("comments")
                        .HasForeignKey("registrationid")
                        .HasConstraintName("ForeignKey-comments-registration")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("registration");
                });

            modelBuilder.Entity("courses_site_api.models.Course_detailes", b =>
                {
                    b.Navigation("Courses_Categories");
                });

            modelBuilder.Entity("courses_site_api.models.Courses_category", b =>
                {
                    b.Navigation("Courses_Videos");
                });

            modelBuilder.Entity("courses_site_api.models.registration", b =>
                {
                    b.Navigation("chats");

                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}
