﻿// <auto-generated />
using System;
using ContestManagerRepository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContestManagerRepository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContestManagerDomain.Entities.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime>("FinalContestDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FinalRegistrationDate")
                        .HasColumnType("datetime");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("InitialContestDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("InitialRegistrationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Link")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("MaximumTeamCoach")
                        .HasColumnType("int");

                    b.Property<int>("MaximumTeamContestant")
                        .HasColumnType("int");

                    b.Property<int>("MinimalTeamCoach")
                        .HasColumnType("int");

                    b.Property<int>("MinimalTeamContestant")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Contest", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A maior maratona do IFSP",
                            FinalContestDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2608),
                            FinalRegistrationDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2610),
                            InitialContestDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2598),
                            InitialRegistrationDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2609),
                            MaximumTeamCoach = 0,
                            MaximumTeamContestant = 0,
                            MinimalTeamCoach = 0,
                            MinimalTeamContestant = 0,
                            Name = "VII InterIF 2024 - Final Piracicaba"
                        },
                        new
                        {
                            Id = 2,
                            Description = "A maior maratona do IFSP",
                            FinalContestDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2612),
                            FinalRegistrationDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2613),
                            InitialContestDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2611),
                            InitialRegistrationDate = new DateTime(2024, 3, 27, 15, 14, 31, 204, DateTimeKind.Local).AddTicks(2612),
                            MaximumTeamCoach = 0,
                            MaximumTeamContestant = 0,
                            MinimalTeamCoach = 0,
                            MinimalTeamContestant = 0,
                            Name = "VI InterIF 2023 - Final Campinas"
                        });
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Contestant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Document")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TshirtSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int");

                    b.Property<string>("UniversityRegistrationNumber")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Contestant", (string)null);
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsMediumLevel")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Course", (string)null);
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContestId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.TeamContestants", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContestantId")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContestantId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamContestants", (string)null);
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UniversityAcronym")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id");

                    b.ToTable("University", (string)null);
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Contestant", b =>
                {
                    b.HasOne("ContestManagerDomain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("ContestManagerDomain.Entities.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Course");

                    b.Navigation("University");
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Course", b =>
                {
                    b.HasOne("ContestManagerDomain.Entities.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Team", b =>
                {
                    b.HasOne("ContestManagerDomain.Entities.Contest", "Contest")
                        .WithMany()
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contest");
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.TeamContestants", b =>
                {
                    b.HasOne("ContestManagerDomain.Entities.Contestant", "Contestant")
                        .WithMany()
                        .HasForeignKey("ContestantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContestManagerDomain.Entities.Team", "Team")
                        .WithMany("Contestants")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contestant");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ContestManagerDomain.Entities.Team", b =>
                {
                    b.Navigation("Contestants");
                });
#pragma warning restore 612, 618
        }
    }
}
