﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SadafBI.CustomersList.Models

{
    public class SqlCustomersListModel
    {
        [Key]
        public int Id { get; set; }
        public int customerId { get; set; }
        public string nationalCode { get; set; } = "";
        public string companyName { get; set; } = "";
        public string firstName { get; set; } = "";
        public string lastName { get; set; } = "";
        public string fatherName { get; set; } = "";
        public string phoneNumber { get; set; } = "";
        public string mobileNumber { get; set; } = "";
        public string emailAddress { get; set; } = "";
        public string dlNumber { get; set; } = "";
        public string status { get; set; } = "";

        public long credit { get; set; }
        public int? comexCredit { get; set; }
        public int? sfCredit { get; set; }
        public string telegramUsername { get; set; } = "";
        public string telegramStatusId { get; set; } = "";
        public string creationDate { get; set; } = "";
        public int branchId { get; set; }
        public string branchName { get; set; } = "";
        public int isCompany { get; set; }
        public string customerIdentity { get; set; } = "";
        public string birthDate { get; set; } = "";
        public string birthCertificationNumber { get; set; } = "";
        public string address { get; set; } = "";
        public string postalCode { get; set; } = "";
        public string registerationNumber { get; set; } = "";
        public string bourseAccountName { get; set; } = "";
        public string accountNumber { get; set; } = "";
        public string onlineUsername { get; set; } = "";
        public int hasOnlineAccount { get; set; }
        public string modificationDate { get; set; } = "";
        public int isMmtpUser { get; set; }
        public int? mmtpUserStatusId { get; set; }
        public int isSiteUser { get; set; }
        public int eorderStatusId { get; set; }
        public int sexTypeId { get; set; }
        public string sexTypeName { get; set; } = "";
        public string referredBy { get; set; } = "";
        public bool hasSignSample { get; set; }
        public bool hasCustomerPhoto { get; set; }
        public bool hasBirthCertificate { get; set; }
        public bool hasCertificateComments { get; set; }
        public bool hasZipFile { get; set; }
        public bool hasOfficialGazette { get; set; }
        public bool hasOfficialAds { get; set; }
        public string comexVisitorId { get; set; } = "";
        public int? mmtpUserId { get; set; }
        public string comexEconomyAccount { get; set; } = "";
        public int isPortfo { get; set; }
        public int? traderCredit { get; set; }
        public string provinceCode { get; set; } = "";
        public string provinceName { get; set; } = "";
        public int cityId { get; set; }
        public string cityCode { get; set; } = "";
        public string cityName { get; set; } = "";
        public int? bankAccountId { get; set; }
        public string bankAccountNumber { get; set; } = "";
        public string shabaNumber { get; set; } = "";
        public string baTypeName { get; set; } = "";
        public string bankName { get; set; } = "";
        public int isStockCreditPurchase { get; set; }
        public int? isCollateralStocksCustomer { get; set; }
        public int isProfessionalTrader { get; set; }
        public int isOtcProfessionalTrader { get; set; }
        public string comments { get; set; } = "";


        public int domain_Id { get; set; }


        public int customerGroup_Id { get; set; }

        public SqlDomain SqlDomain { get; set; }
        public SqlCustomergroup SqlCustomergroup { get; set; }
    }

    public class SqlDomain
    {
        [Key]
        public int Id { get; set; }
        public int domainId { get; set; }
        public string domainName { get; set; } = "";
        public ICollection<SqlCustomersListModel> Customers { get; set; }

    }

    public class SqlCustomergroup
    {
        [Key]
        public int Id { get; set; }
        public int customerGroupId { get; set; }
        public string customerGroupName { get; set; } = "";
        public ICollection<SqlCustomersListModel> Customers { get; set; }


    }
}