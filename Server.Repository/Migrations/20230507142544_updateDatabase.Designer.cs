﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Repository;

#nullable disable

namespace _3Server.Repository.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230507142544_updateDatabase")]
    partial class updateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Server.Repository.Entities.CoronaInformation", b =>
                {
                    b.Property<int>("CoronaInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoronaInformationId"));

                    b.Property<DateTime>("ReceivingCoronaVaccineDate1")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivingCoronaVaccineDate2")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivingCoronaVaccineDate3")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivingCoronaVaccineDate4")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivingPositiveResultDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RecoveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VaccineManufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoronaInformationId");

                    b.ToTable("CoronaInformation");
                });

            modelBuilder.Entity("Server.Repository.Entities.PersonalInformation", b =>
                {
                    b.Property<int>("PersonalInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalInformationId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("IDNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalInformationId");

                    b.ToTable("PersonalInformation");
                });

            modelBuilder.Entity("Server.Repository.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int>("CoronaInformationId")
                        .HasColumnType("int");

                    b.Property<int>("PersonalInformationId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("CoronaInformationId");

                    b.HasIndex("PersonalInformationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Server.Repository.Entities.User", b =>
                {
                    b.HasOne("Server.Repository.Entities.CoronaInformation", "CoronaInformation")
                        .WithMany()
                        .HasForeignKey("CoronaInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Server.Repository.Entities.PersonalInformation", "PersonalInformation")
                        .WithMany()
                        .HasForeignKey("PersonalInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoronaInformation");

                    b.Navigation("PersonalInformation");
                });
#pragma warning restore 612, 618
        }
    }
}