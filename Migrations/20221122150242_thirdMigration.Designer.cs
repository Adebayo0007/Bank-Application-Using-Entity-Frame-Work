﻿// <auto-generated />
using LegitBankApp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LegitBankApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221122150242_thirdMigration")]
    partial class thirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("LegitBankApp.Model.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("_address")
                        .HasColumnType("text");

                    b.Property<string>("_age")
                        .HasColumnType("text");

                    b.Property<string>("_email")
                        .HasColumnType("text");

                    b.Property<string>("_firstName")
                        .HasColumnType("text");

                    b.Property<string>("_gender")
                        .HasColumnType("text");

                    b.Property<string>("_lastName")
                        .HasColumnType("text");

                    b.Property<string>("_password")
                        .HasColumnType("text");

                    b.Property<string>("_phoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("_staffID")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("LegitBankApp.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("_accountBalance")
                        .HasColumnType("double");

                    b.Property<string>("_accountNumber")
                        .HasColumnType("text");

                    b.Property<string>("_accountType")
                        .HasColumnType("text");

                    b.Property<string>("_address")
                        .HasColumnType("text");

                    b.Property<string>("_age")
                        .HasColumnType("text");

                    b.Property<int>("_customerRegNum")
                        .HasColumnType("int");

                    b.Property<string>("_email")
                        .HasColumnType("text");

                    b.Property<string>("_firstName")
                        .HasColumnType("text");

                    b.Property<string>("_gender")
                        .HasColumnType("text");

                    b.Property<string>("_lastName")
                        .HasColumnType("text");

                    b.Property<string>("_password")
                        .HasColumnType("text");

                    b.Property<string>("_phoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("_pin")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("LegitBankApp.Model.ManagingDirector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("_age")
                        .HasColumnType("text");

                    b.Property<string>("_firstName")
                        .HasColumnType("text");

                    b.Property<string>("_lastName")
                        .HasColumnType("text");

                    b.Property<string>("_managerId")
                        .HasColumnType("text");

                    b.Property<string>("_phoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("managingDirector");
                });

            modelBuilder.Entity("LegitBankApp.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("_accountBalance")
                        .HasColumnType("double");

                    b.Property<string>("_accountNumber")
                        .HasColumnType("text");

                    b.Property<double>("_airtimeAmount")
                        .HasColumnType("double");

                    b.Property<string>("_dateTime")
                        .HasColumnType("text");

                    b.Property<double>("_depositAmount")
                        .HasColumnType("double");

                    b.Property<string>("_pin")
                        .HasColumnType("text");

                    b.Property<string>("_refNum")
                        .HasColumnType("text");

                    b.Property<double>("_transferAmount")
                        .HasColumnType("double");

                    b.Property<double>("_withdrawalAmount")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
