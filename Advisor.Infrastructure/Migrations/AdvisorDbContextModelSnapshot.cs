﻿// <auto-generated />
using System;
using Advisor.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Advisor.Infrastructure.Migrations
{
    [DbContext(typeof(AdvisorDbContext))]
    partial class AdvisorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Advisor.Core.Domain.Models.AdvisorClient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AdvisorID")
                        .HasColumnType("int");

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdvisorID");

                    b.HasIndex("ClientID");

                    b.ToTable("AdvisorClients");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.AdvisorRegistrationDetails", b =>
                {
                    b.Property<int>("AdvisorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvisorId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdvisorId");

                    b.ToTable("AdvisorDetails");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestmentStrategy", b =>
                {
                    b.Property<int>("InvestmentStrategyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentStrategyID"), 1L, 1);

                    b.Property<string>("AccountID")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int");

                    b.Property<decimal>("InvestmentAmount")
                        .HasColumnType("decimal(17,5)");

                    b.Property<int>("InvestmentTypeID")
                        .HasColumnType("int");

                    b.Property<int>("InvestorInfoID")
                        .HasColumnType("int");

                    b.Property<string>("ModelAPLID")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("DateTime2");

                    b.Property<string>("StrategyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("InvestmentStrategyID");

                    b.HasIndex("InvestmentTypeID");

                    b.HasIndex("InvestorInfoID");

                    b.ToTable("InvestmentStrategies");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestmentType", b =>
                {
                    b.Property<int>("InvestmentTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestmentTypeID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int");

                    b.Property<string>("InvestmentTypeName")
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("DateTime2");

                    b.HasKey("InvestmentTypeID");

                    b.ToTable("InvestmentTypes");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestorInfo", b =>
                {
                    b.Property<int>("InvestorInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestorInfoID"), 1L, 1);

                    b.Property<byte>("Active")
                        .HasColumnType("Tinyint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int");

                    b.Property<string>("InvestmentName")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("InvestorInfoID");

                    b.HasIndex("UserID");

                    b.ToTable("InvestorInfos");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<byte>("Active")
                        .HasColumnType("Tinyint");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<byte>("Active")
                        .HasColumnType("Tinyint");

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("AdvisorID")
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("AgentID")
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("ClientID")
                        .HasMaxLength(6)
                        .HasColumnType("VARCHAR(6)");

                    b.Property<string>("Company")
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR(150)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("DateTime2");

                    b.Property<int>("DeletedFlag")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR(50)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("DateTime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PasswordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("VARCHAR(40)");

                    b.Property<DateTime?>("ResetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("SortName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("State")
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("VerificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.AdvisorClient", b =>
                {
                    b.HasOne("Advisor.Core.Domain.Models.Users", "Advisor")
                        .WithMany("AdvisorsList")
                        .HasForeignKey("AdvisorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Advisor.Core.Domain.Models.Users", "Client")
                        .WithMany("ClientList")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Advisor");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestmentStrategy", b =>
                {
                    b.HasOne("Advisor.Core.Domain.Models.InvestmentType", "InvestmentTypes")
                        .WithMany("investmentStrategies")
                        .HasForeignKey("InvestmentTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Advisor.Core.Domain.Models.InvestorInfo", "InvestorInfo")
                        .WithMany("investmentStrategies")
                        .HasForeignKey("InvestorInfoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvestmentTypes");

                    b.Navigation("InvestorInfo");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestorInfo", b =>
                {
                    b.HasOne("Advisor.Core.Domain.Models.Users", "User")
                        .WithMany("investorInfos")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.Users", b =>
                {
                    b.HasOne("Advisor.Core.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestmentType", b =>
                {
                    b.Navigation("investmentStrategies");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.InvestorInfo", b =>
                {
                    b.Navigation("investmentStrategies");
                });

            modelBuilder.Entity("Advisor.Core.Domain.Models.Users", b =>
                {
                    b.Navigation("AdvisorsList");

                    b.Navigation("ClientList");

                    b.Navigation("investorInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
