﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SadafBI.Data;

#nullable disable

namespace SadafBI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SadafBI.Models.SqlCustomergroup", b =>
                {
                    b.Property<int>("customerGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerGroupId"), 1L, 1);

                    b.Property<string>("customerGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("customerGroupId");

                    b.ToTable("Customergroups");
                });

            modelBuilder.Entity("SadafBI.Models.SqlCustomersListModel", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("customerId"), 1L, 1);

                    b.Property<string>("accountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("baTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("bankAccountId")
                        .HasColumnType("int");

                    b.Property<string>("bankAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthCertificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bourseAccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("branchId")
                        .HasColumnType("int");

                    b.Property<string>("branchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.Property<string>("cityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("comexCredit")
                        .HasColumnType("int");

                    b.Property<string>("comexEconomyAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comexVisitorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("creationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("credit")
                        .HasColumnType("bigint");

                    b.Property<int>("customerGroupId")
                        .HasColumnType("int");

                    b.Property<string>("customerIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("domainId")
                        .HasColumnType("int");

                    b.Property<string>("emailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("eorderStatusId")
                        .HasColumnType("int");

                    b.Property<string>("fatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasBirthCertificate")
                        .HasColumnType("bit");

                    b.Property<bool>("hasCertificateComments")
                        .HasColumnType("bit");

                    b.Property<bool>("hasCustomerPhoto")
                        .HasColumnType("bit");

                    b.Property<bool>("hasOfficialAds")
                        .HasColumnType("bit");

                    b.Property<bool>("hasOfficialGazette")
                        .HasColumnType("bit");

                    b.Property<int>("hasOnlineAccount")
                        .HasColumnType("int");

                    b.Property<bool>("hasSignSample")
                        .HasColumnType("bit");

                    b.Property<bool>("hasZipFile")
                        .HasColumnType("bit");

                    b.Property<int?>("isCollateralStocksCustomer")
                        .HasColumnType("int");

                    b.Property<int>("isCompany")
                        .HasColumnType("int");

                    b.Property<int>("isMmtpUser")
                        .HasColumnType("int");

                    b.Property<int>("isOtcProfessionalTrader")
                        .HasColumnType("int");

                    b.Property<int>("isPortfo")
                        .HasColumnType("int");

                    b.Property<int>("isProfessionalTrader")
                        .HasColumnType("int");

                    b.Property<int>("isSiteUser")
                        .HasColumnType("int");

                    b.Property<int>("isStockCreditPurchase")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("mmtpUserId")
                        .HasColumnType("int");

                    b.Property<int?>("mmtpUserStatusId")
                        .HasColumnType("int");

                    b.Property<string>("mobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modificationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("onlineUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("postalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provinceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provinceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("referredBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("registerationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sexTypeId")
                        .HasColumnType("int");

                    b.Property<string>("sexTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("sfCredit")
                        .HasColumnType("int");

                    b.Property<string>("shabaNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telegramStatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telegramUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("traderCredit")
                        .HasColumnType("int");

                    b.HasKey("customerId");

                    b.HasIndex("customerGroupId");

                    b.HasIndex("domainId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SadafBI.Models.SqlDomain", b =>
                {
                    b.Property<int>("domainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("domainId"), 1L, 1);

                    b.Property<string>("domainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("domainId");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("SadafBI.Models.SqlCustomersListModel", b =>
                {
                    b.HasOne("SadafBI.Models.SqlCustomergroup", "SqlCustomergroup")
                        .WithMany("Customers")
                        .HasForeignKey("customerGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SadafBI.Models.SqlDomain", "SqlDomain")
                        .WithMany("Customers")
                        .HasForeignKey("domainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SqlCustomergroup");

                    b.Navigation("SqlDomain");
                });

            modelBuilder.Entity("SadafBI.Models.SqlCustomergroup", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("SadafBI.Models.SqlDomain", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
