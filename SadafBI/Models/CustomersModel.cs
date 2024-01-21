using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.Models
{
    public class CustomersModel
    {
      
            public int customerId { get; set; }
            public string nationalCode { get; set; }
            public string? companyName { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string fatherName { get; set; }
            public string? phoneNumber { get; set; }
            public string mobileNumber { get; set; }
            public string? emailAddress { get; set; }
            public string dlNumber { get; set; }
            public string Status { get; set; }
            public int Credit { get; set; }
            public string? comexCredit { get; set; }
            public string? sfCredit { get; set; }
            public string? telegramUsername { get; set; }
            public string? telegramStatusId { get; set; }
            public string creationDate { get; set; }
            public int Branched { get; set; }
            public string branchName { get; set; }
            public int isCompany { get; set; }
            public string customerIdentity { get; set; }
            public string birthdate { get; set; }
            public string birthCertificationNumber { get; set; }
            public string? Address { get; set; }
            public string? postalCode { get; set; }
            public string? registerationNumber { get; set; }
            public List<DomainModel> domains { get; set; }
            public List<CustomerGroupModel> customerGroups { get; set; }
            public string bourseAccountName { get; set; }
            public string accountNumber { get; set; }
            public string onlineUsername { get; set; }
            public int hasOnlineAccount { get; set; }
            public string modificationDate { get; set; }
            public int isMmtpUser { get; set; }
            public int mmtpUserStatusId { get; set; }
            public int isSiteUser { get; set; }
            public int eorderStatusId { get; set; }
            public int SexTypeId { get; set; }
            public string sexTypeName { get; set; }
            public string? referredBy { get; set; }
            public bool hasSignSample { get; set; }
            public bool hasCustomerPhoto { get; set; }
            public bool hasBirthCertificate { get; set; }
            public bool hasCertificateComments { get; set; }
            public bool hasZipFile { get; set; }
            public bool hasOfficialGazette { get; set; }
            public bool hasOfficialAds { get; set; }
            public string? comexEconomyAccount { get; set; }
            public int comexVisitorId { get; set; }
            public int isPortfo { get; set; }
            public string? traderCredit { get; set; }
            public string provinceCode { get; set; }
            public string provinceName { get; set; }
            public int cityId { get; set; }
            public string cityCode { get; set; }
            public string cityName { get; set; }
            public int? bankAccountId { get; set; }
            public string? bankAccountNumber { get; set; }
            public string? shabaNumber { get; set; }
            public string? baTypeName { get; set; }
            public string? bankName { get; set; }
            public int isStockCreditPurchase { get; set; }
            public string? isCollateralStocksCustomer { get; set; }
            public int pageSize { get; set; }
            public int pageNumber { get; set; }
            public int Total { get; set; }
            public string comment { get; set; }
            public int id_user_mmtp { get; set; }
            public int isProfessionalTrader { get; set; }
            public string isOtcProfessionalTrader { get; set; }


        }

        public class DomainModel
        {
            public int domainId { get; set; }
            public string domainName { get; set; }
        }
        public class CustomerGroupModel
        {
            public int CustomerGroupId { get; set; }
            public string customerGroupName { get; set; }
        }
        public class CustomerListResponse
        {
            public List<CustomersModel> Result { get; set; }
            public int PageSize { get; set; }
            public int PageNumber { get; set; }
            public int Offset { get; set; }
            public int Total { get; set; }
        }
    }



