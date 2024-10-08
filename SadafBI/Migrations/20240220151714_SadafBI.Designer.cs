﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SadafBI.Data;

#nullable disable

namespace SadafBI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240220151714_SadafBI")]
    partial class SadafBI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlCustomergroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("customerGroupId")
                        .HasColumnType("int");

                    b.Property<string>("customerGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customergroups");
                });

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlCustomersListModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    b.Property<int>("customerGroup_Id")
                        .HasColumnType("int");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("customerIdentity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dlNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("domain_Id")
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

                    b.HasKey("Id");

                    b.HasIndex("customerGroup_Id");

                    b.HasIndex("domain_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("domainId")
                        .HasColumnType("int");

                    b.Property<string>("domainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Domains");
                });

            modelBuilder.Entity("SadafBI.CustomerStockStatus.Models.SqlCustomerStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("actualProfit")
                        .HasColumnType("bigint");

                    b.Property<int>("bDps")
                        .HasColumnType("int");

                    b.Property<int>("bFee")
                        .HasColumnType("int");

                    b.Property<long>("bProfit")
                        .HasColumnType("bigint");

                    b.Property<int>("bQty")
                        .HasColumnType("int");

                    b.Property<long>("bcBasis")
                        .HasColumnType("bigint");

                    b.Property<string>("bourseAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bourseAccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("convertFromRight")
                        .HasColumnType("int");

                    b.Property<int>("convertToStock")
                        .HasColumnType("int");

                    b.Property<long>("currentValue")
                        .HasColumnType("bigint");

                    b.Property<string>("insMaxLCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pDps")
                        .HasColumnType("int");

                    b.Property<int>("pFee")
                        .HasColumnType("int");

                    b.Property<int>("pQty")
                        .HasColumnType("int");

                    b.Property<long>("pcBasis")
                        .HasColumnType("bigint");

                    b.Property<long>("potentialProfitWe")
                        .HasColumnType("bigint");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("rQty")
                        .HasColumnType("int");

                    b.Property<int>("sQty")
                        .HasColumnType("int");

                    b.Property<int>("sumCancelIpoQty")
                        .HasColumnType("int");

                    b.Property<int>("sumIpoQty")
                        .HasColumnType("int");

                    b.Property<int>("sumRecapQty")
                        .HasColumnType("int");

                    b.Property<int>("sumSalable")
                        .HasColumnType("int");

                    b.Property<long>("totalProfit")
                        .HasColumnType("bigint");

                    b.Property<int>("twrReturn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CustomerStock");
                });

            modelBuilder.Entity("SadafBI.SeperateTransactionInformation.Models.SqlSeparateTransactionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("bourseAccountText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("bourseCo")
                        .HasColumnType("int");

                    b.Property<int?>("bourseOrg")
                        .HasColumnType("int");

                    b.Property<string>("bourseReference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("branchId")
                        .HasColumnType("int");

                    b.Property<string>("branchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("cbranchId")
                        .HasColumnType("int");

                    b.Property<string>("cbranchName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customerFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<string>("dbsAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("depositCo")
                        .HasColumnType("int");

                    b.Property<int?>("development")
                        .HasColumnType("int");

                    b.Property<string>("dlNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("facility")
                        .HasColumnType("int");

                    b.Property<string>("insMaxLcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instrumentBourseAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("interest")
                        .HasColumnType("int");

                    b.Property<int?>("isAPurchase")
                        .HasColumnType("int");

                    b.Property<int?>("isOtc")
                        .HasColumnType("int");

                    b.Property<int>("isRight")
                        .HasColumnType("int");

                    b.Property<int?>("itManagement")
                        .HasColumnType("int");

                    b.Property<string>("parentCustomerFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("parentCustomerId")
                        .HasColumnType("int");

                    b.Property<string>("postTradeTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("price")
                        .HasColumnType("int");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.Property<long?>("tax")
                        .HasColumnType("bigint");

                    b.Property<string>("transactionDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SeparateTransaction");
                });

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlCustomersListModel", b =>
                {
                    b.HasOne("SadafBI.CustomersList.Models.SqlCustomergroup", "SqlCustomergroup")
                        .WithMany("Customers")
                        .HasForeignKey("customerGroup_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SadafBI.CustomersList.Models.SqlDomain", "SqlDomain")
                        .WithMany("Customers")
                        .HasForeignKey("domain_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SqlCustomergroup");

                    b.Navigation("SqlDomain");
                });

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlCustomergroup", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("SadafBI.CustomersList.Models.SqlDomain", b =>
                {
                    b.Navigation("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
