namespace SadafBI.Models
{
    public class MappingHelper
    {
        public static SqlCustomersListModel MapResultToSqlModel(Result result)   
        {
            var sqlCustomer = new SqlCustomersListModel
            {
                // Map کردن داده‌ها از مدل API به مدل SQL
                customerId = result.customerId,
                nationalCode = result.nationalCode ?? "",
                companyName = result.companyName ?? "",
                firstName = result.firstName ?? "",
                lastName = result.lastName ?? "",
                fatherName = result.fatherName ?? "",
                phoneNumber = result.phoneNumber ?? "",
                mobileNumber = result.mobileNumber ?? "",
                emailAddress = result.emailAddress ?? "",
                dlNumber = result.dlNumber ?? "",
                status = result.status ?? "",
                credit = result.credit,
                comexCredit = result.comexCredit,
                sfCredit = result.sfCredit,
                telegramUsername = result.telegramUsername?.ToString() ?? "",
                telegramStatusId = result.telegramStatusId?.ToString() ?? "",
                creationDate = result.creationDate ?? "",
                branchId = result.branchId,
                branchName = result.branchName ?? "",
                isCompany = result.isCompany,
                customerIdentity = result.customerIdentity ?? "",
                birthDate = result.birthDate ?? "",
                birthCertificationNumber = result.birthCertificationNumber ?? "",
                address = result.address ?? "",
                postalCode = result.postalCode ?? "",
                registerationNumber = result.registerationNumber ?? "",
                bourseAccountName = result.bourseAccountName ?? "",
                accountNumber = result.accountNumber ?? "",
                onlineUsername = result.onlineUsername ?? "",
                hasOnlineAccount = result.hasOnlineAccount,
                modificationDate = result.modificationDate ?? "",
                isMmtpUser = result.isMmtpUser,
                mmtpUserStatusId = result.mmtpUserStatusId,
                isSiteUser = result.isSiteUser,
                eorderStatusId = result.eorderStatusId,
                sexTypeId = result.sexTypeId,
                sexTypeName = result.sexTypeName ?? "",
                referredBy = result.referredBy ?? "",
                hasSignSample = result.hasSignSample,
                hasCustomerPhoto = result.hasCustomerPhoto,
                hasBirthCertificate = result.hasBirthCertificate,
                hasCertificateComments = result.hasCertificateComments,
                hasZipFile = result.hasZipFile,
                hasOfficialGazette = result.hasOfficialGazette,
                hasOfficialAds = result.hasOfficialAds,
                comexVisitorId = result.comexVisitorId?.ToString() ?? "",
                mmtpUserId = result.mmtpUserId,
                comexEconomyAccount = result.comexEconomyAccount ?? "",
                isPortfo = result.isPortfo,
                traderCredit = result.traderCredit,
                provinceCode = result.provinceCode ?? "",
                provinceName = result.provinceName ?? "",
                cityId = result.cityId,
                cityCode = result.cityCode ?? "",
                cityName = result.cityName ?? "",
                bankAccountId = result.bankAccountId,
                bankAccountNumber = result.bankAccountNumber ?? "",
                shabaNumber = result.shabaNumber ?? "",
                baTypeName = result.baTypeName ?? "",
                bankName = result.bankName ?? "",
                isStockCreditPurchase = result.isStockCreditPurchase,
                isCollateralStocksCustomer = result.isCollateralStocksCustomer,
                isProfessionalTrader = result.isProfessionalTrader,
                isOtcProfessionalTrader = result.isOtcProfessionalTrader,
                comments = result.comments ?? "",

            };
            if (result.customerGroups != null && result.customerGroups.Length > 0)
            {
                sqlCustomer.SqlCustomergroup = new SqlCustomergroup
                {
                    customerGroupId = result.customerGroups[0].customerGroupId,
                    customerGroupName = result.customerGroups[0].customerGroupName
                };
            }
            if (result.domains != null && result.domains.Length > 0)
            {
                sqlCustomer.SqlDomain = new SqlDomain
                {
                    domainId = result.domains[0].domainId,
                    domainName = result.domains[0].domainName
                };
            }
            return sqlCustomer;
        }

    }
}
