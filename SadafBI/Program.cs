
using Newtonsoft.Json;
using SadafBI.Data;
using SadafBI.Models;

namespace SadafBI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "9cf56baa-d8a6-4334-b95b-250353e39c16");

            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1390/01/01&creationDateFrom=1390/01/01&size=100&page=741");
            responseTask.Wait();

            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                result.EnsureSuccessStatusCode();



                var responseContent = result.Content.ReadAsStringAsync().Result;


                var settings = new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Populate
                };

                var apiResponse = JsonConvert.DeserializeObject<APIResponseModel>(responseContent, settings);

                
                using (var context = new DataContext())
                {
                    foreach (var resultItem in apiResponse.result)
                    {
                        var existingCustomer = context.Customers.FirstOrDefault(c => c.customerId == resultItem.customerId);
                        if (existingCustomer != null)
                        {
                            // Update the existing record
                            existingCustomer.nationalCode = resultItem.nationalCode ?? existingCustomer.nationalCode;
                            existingCustomer.companyName = resultItem.companyName ?? existingCustomer.companyName;
                            existingCustomer.firstName = resultItem.firstName ?? existingCustomer.firstName;
                            existingCustomer.lastName = resultItem.lastName ?? existingCustomer.lastName;
                            existingCustomer.fatherName = resultItem.fatherName ?? existingCustomer.fatherName;
                            existingCustomer.phoneNumber = resultItem.phoneNumber ?? existingCustomer.phoneNumber;
                            existingCustomer.mobileNumber = resultItem.mobileNumber ?? existingCustomer.mobileNumber;
                            existingCustomer.emailAddress = resultItem.emailAddress ?? existingCustomer.emailAddress;
                            existingCustomer.dlNumber = resultItem.dlNumber ?? existingCustomer.dlNumber;
                            existingCustomer.status = resultItem.status ?? existingCustomer.status;
                            existingCustomer.credit = resultItem.credit ?? existingCustomer.credit;
                            existingCustomer.comexCredit =(int?) resultItem.comexCredit ?? existingCustomer.comexCredit;
                            existingCustomer.sfCredit = (int?)resultItem.sfCredit ?? existingCustomer.sfCredit;
                            existingCustomer.telegramUsername = (string)(resultItem.telegramUsername ?? existingCustomer.telegramUsername);
                            existingCustomer.telegramStatusId = (string)(resultItem.telegramStatusId ?? existingCustomer.telegramStatusId);
                            existingCustomer.creationDate = resultItem.creationDate ?? existingCustomer.creationDate;
                            existingCustomer.branchId = resultItem.branchId;
                            existingCustomer.branchName = resultItem.branchName ?? existingCustomer.branchName;
                            existingCustomer.isCompany = resultItem.isCompany;
                            existingCustomer.customerIdentity = resultItem.customerIdentity ?? existingCustomer.customerIdentity;
                            existingCustomer.birthDate = resultItem.birthDate ?? existingCustomer.birthDate;
                            existingCustomer.birthCertificationNumber = resultItem.birthCertificationNumber ?? existingCustomer.birthCertificationNumber;
                            existingCustomer.address = resultItem.address ?? existingCustomer.address;
                            existingCustomer.postalCode = resultItem.postalCode ?? existingCustomer.postalCode;
                            existingCustomer.registerationNumber = resultItem.registerationNumber ?? existingCustomer.registerationNumber;
                            existingCustomer.bourseAccountName = resultItem.bourseAccountName ?? existingCustomer.bourseAccountName;
                            existingCustomer.accountNumber = resultItem.accountNumber ?? existingCustomer.accountNumber;
                            existingCustomer.onlineUsername = resultItem.onlineUsername ?? existingCustomer.onlineUsername;
                            existingCustomer.hasOnlineAccount = resultItem.hasOnlineAccount;
                            existingCustomer.modificationDate = resultItem.modificationDate ?? existingCustomer.modificationDate;
                            existingCustomer.isMmtpUser = resultItem.isMmtpUser;
                            existingCustomer.mmtpUserStatusId = resultItem.mmtpUserStatusId ?? existingCustomer.mmtpUserStatusId;
                            existingCustomer.isSiteUser = resultItem.isSiteUser;
                            existingCustomer.eorderStatusId = resultItem.eorderStatusId;
                            existingCustomer.sexTypeId = resultItem.sexTypeId;
                            existingCustomer.sexTypeName = resultItem.sexTypeName ?? existingCustomer.sexTypeName;
                            existingCustomer.referredBy = resultItem.referredBy ?? existingCustomer.referredBy;
                            existingCustomer.hasSignSample = resultItem.hasSignSample;
                            existingCustomer.hasCustomerPhoto = resultItem.hasCustomerPhoto;
                            existingCustomer.hasBirthCertificate = resultItem.hasBirthCertificate;
                            existingCustomer.hasCertificateComments = resultItem.hasCertificateComments;
                            existingCustomer.hasZipFile = resultItem.hasZipFile;
                            existingCustomer.hasOfficialGazette = resultItem.hasOfficialGazette;
                            existingCustomer.hasOfficialAds = resultItem.hasOfficialAds;
                            existingCustomer.comexVisitorId = (string)(resultItem.comexVisitorId ?? existingCustomer.comexVisitorId);
                            existingCustomer.mmtpUserId = resultItem.mmtpUserId ?? existingCustomer.mmtpUserId;
                            existingCustomer.comexEconomyAccount = resultItem.comexEconomyAccount ?? existingCustomer.comexEconomyAccount;
                            existingCustomer.isPortfo = resultItem.isPortfo;
                            existingCustomer.traderCredit = (int?)(resultItem.traderCredit ?? existingCustomer.traderCredit);
                            existingCustomer.provinceCode = resultItem.provinceCode ?? existingCustomer.provinceCode;
                            existingCustomer.provinceName = resultItem.provinceName ?? existingCustomer.provinceName;
                            existingCustomer.cityId = resultItem.cityId;
                            existingCustomer.cityCode = resultItem.cityCode ?? existingCustomer.cityCode;
                            existingCustomer.cityName = resultItem.cityName ?? existingCustomer.cityName;
                            existingCustomer.bankAccountId = resultItem.bankAccountId ?? existingCustomer.bankAccountId;
                            existingCustomer.bankAccountNumber = resultItem.bankAccountNumber ?? existingCustomer.bankAccountNumber;
                            existingCustomer.shabaNumber = resultItem.shabaNumber ?? existingCustomer.shabaNumber;
                            existingCustomer.baTypeName = resultItem.baTypeName ?? existingCustomer.baTypeName;
                            existingCustomer.bankName = resultItem.bankName ?? existingCustomer.bankName;
                            existingCustomer.isStockCreditPurchase = resultItem.isStockCreditPurchase;
                            existingCustomer.isCollateralStocksCustomer = resultItem.isCollateralStocksCustomer;
                            existingCustomer.isProfessionalTrader = resultItem.isProfessionalTrader;
                            existingCustomer.isOtcProfessionalTrader = resultItem.isOtcProfessionalTrader;
                            existingCustomer.comments = resultItem.comments ?? existingCustomer.comments;

                            // Update the associated domain and customer group if necessary
                            if (resultItem.domains != null && resultItem.domains.Length > 0)
                            {
                                existingCustomer.SqlDomain = new SqlDomain
                                {
                                    domainId = resultItem.domains[0].domainId,
                                    domainName = resultItem.domains[0].domainName
                                };
                            }

                            if (resultItem.customerGroups != null && resultItem.customerGroups.Length > 0)
                            {
                                existingCustomer.SqlCustomergroup = new SqlCustomergroup
                                {
                                    customerGroupId = resultItem.customerGroups[0].customerGroupId,
                                    customerGroupName = resultItem.customerGroups[0].customerGroupName
                                };
                            }
                        }
                        else
                        {
                            // Create a new record
                            var mappedData = MappingHelper.MapResultToSqlModel(resultItem);
                            context.Customers.Add(mappedData);
                        }
                    }

                    context.SaveChanges();

                    //foreach (var resultItem in apiResponse.result)
                    //{
                    //    // دریافت مدل مپ شده
                    //    var mappedData = MappingHelper.MapResultToSqlModel(resultItem);

                    //    // اضافه کردن به دیتابیس
                    //    context.Customers.Add(mappedData);
                    //}

                    //// ذخیره تغییرات در دیتابیس
                    //context.SaveChanges();
                }

            }
        }
    }

}


                //using (var context = new DataContext())
                //{


                //    // دریافت مدل مپ شده
                //    var mappedData = MappingHelper.MapResultToSqlModel(apiResponse.result[0]);

                //    // اضافه کردن به دیتابیس
                //    context.Customers.Add(mappedData);


                //    // ذخیره تغییرات در دیتابیس
                //    context.SaveChanges();
                //}



//foreach (var customer in apiResponse.result)
//{
//    var sqlCustomer = new SqlCustomersListModel
//    {
//        // Map کردن داده‌ها از مدل API به مدل SQL
//        customerId = customer.customerId,
//        nationalCode = customer.nationalCode,
//        companyName = customer.companyName,
//        firstName = customer.firstName,
//        lastName = customer.lastName,
//        fatherName = customer.fatherName,
//        phoneNumber = customer.phoneNumber,
//        mobileNumber = customer.mobileNumber,
//        emailAddress = customer.emailAddress,
//        dlNumber = customer.dlNumber,
//        status = customer.status,
//        credit = customer.credit,
//        comexCredit = customer.comexCredit,
//        sfCredit = customer.sfCredit,
//        telegramUsername = customer.telegramUsername,
//        telegramStatusId = customer.telegramStatusId,
//        creationDate = customer.creationDate,
//        branchId = customer.branchId,
//        branchName = customer.branchName,
//        isCompany = customer.isCompany,
//        customerIdentity = customer.customerIdentity,
//        birthDate = customer.birthDate,
//        birthCertificationNumber = customer.birthCertificationNumber,
//        address = customer.address,
//        postalCode = customer.postalCode,
//        registerationNumber = customer.registerationNumber,
//        bourseAccountName = customer.bourseAccountName,
//        accountNumber = customer.accountNumber,
//        onlineUsername = customer.onlineUsername,
//        hasOnlineAccount = customer.hasOnlineAccount,
//        modificationDate = customer.modificationDate,
//        isMmtpUser = customer.isMmtpUser,
//        mmtpUserStatusId = customer.mmtpUserStatusId,
//        isSiteUser = customer.isSiteUser,
//        eorderStatusId = customer.eorderStatusId,
//        sexTypeId = customer.sexTypeId,
//        sexTypeName = customer.sexTypeName,
//        referredBy = customer.referredBy,
//        hasSignSample = customer.hasSignSample,
//        hasCustomerPhoto = customer.hasCustomerPhoto,
//        hasBirthCertificate = customer.hasBirthCertificate,
//        hasCertificateComments = customer.hasCertificateComments,
//        hasZipFile = customer.hasZipFile,
//        hasOfficialGazette = customer.hasOfficialGazette,
//        hasOfficialAds = customer.hasOfficialAds,
//        comexVisitorId = customer.comexVisitorId,
//        mmtpUserId = customer.mmtpUserId,
//        comexEconomyAccount = customer.comexEconomyAccount,
//        isPortfo = customer.isPortfo,
//        traderCredit = customer.traderCredit,
//        provinceCode = customer.provinceCode,
//        provinceName = customer.provinceName,
//        cityId = customer.cityId,
//        cityCode = customer.cityCode,
//        cityName = customer.cityName,
//        bankAccountId = customer.bankAccountId,
//        bankAccountNumber = customer.bankAccountNumber,
//        shabaNumber = customer.shabaNumber,
//        baTypeName = customer.baTypeName,
//        bankName = customer.bankName,
//        isStockCreditPurchase = customer.isStockCreditPurchase,
//        isCollateralStocksCustomer = customer.isCollateralStocksCustomer,
//        isProfessionalTrader = customer.isProfessionalTrader,
//        isOtcProfessionalTrader = customer.isOtcProfessionalTrader,
//        comments = customer.comments,

//    };
//using (var dbContext = new DataContext())
//{
//    var newCus = new SqlCustomersListModel();
//    newCus.accountNumber = "5645";
//    dbContext.Customers.Add(newCus);
//    dbContext.SaveChanges();
//}



//using System;
//using System.Net.Http;
//using Newtonsoft.Json;
//using SadafBI.Data;
//using SadafBI.Migrations;.
//using SadafBI.Models;

//namespace SadafBI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            HttpClient client = new HttpClient();
//            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "efd05110-822a-43a3-a990-2ec409441116");

//            Console.WriteLine("Calling Web API...");
//            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");
//            responseTask.Wait();

//            if (responseTask.IsCompleted)
//            {
//                var result = responseTask.Result;
//                result.EnsureSuccessStatusCode();

//                var responseContent = result.Content.ReadAsStringAsync().Result;
//                var apiResponse = JsonConvert.DeserializeObject<CustomerListResponse>(responseContent);

//                using (var dbContext = new DataContext())
//                {
//                    // افزودن به دیتابیس
//                    dbContext.Customers.AddRange(apiResponse.CustomerList);
//                    dbContext.SaveChanges();
//                }

//                Console.WriteLine("Data saved to the database.");
//            }

//            Console.ReadLine();
//        }
//    }
//}

