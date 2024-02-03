
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
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "f445797e-a6b8-4f64-8e54-893c5722ebbd");

            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1390/01/01&creationDateFrom=1390/01/01&size=100&page=22");
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

                //var apiResponse = JsonConvert.DeserializeObject<APIResponseModel>(responseContent);
                using (var context = new DataContext())
                {
                    foreach (var resultItem in apiResponse.result)
                    {
                        // دریافت مدل مپ شده
                        var mappedData = MappingHelper.MapResultToSqlModel(resultItem);

                        // اضافه کردن به دیتابیس
                        context.Customers.Add(mappedData);
                    }

                    // ذخیره تغییرات در دیتابیس
                    context.SaveChanges();
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

            }
        }
    }

}




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

