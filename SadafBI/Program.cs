
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
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "c4b9a837-0b64-4044-b7cd-5a9b3bfc6dca");

            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1390/01/01&creationDateFrom=1390/01/01&size=10000&page=8");
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
                            existingCustomer.comexCredit = (int?)(resultItem.comexCredit ?? existingCustomer.comexCredit);
                            existingCustomer.sfCredit = (int?)(resultItem.sfCredit ?? existingCustomer.sfCredit);
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
                            existingCustomer.comexVisitorId = (resultItem.comexVisitorId ?? existingCustomer.comexVisitorId).ToString();
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

