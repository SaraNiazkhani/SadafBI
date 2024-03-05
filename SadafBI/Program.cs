
using Newtonsoft.Json;
using SadafBI.CustomersList.Models;
using SadafBI.Data;
using SadafBI;
using SadafBI.SeperateTransactionInformation.Models;
using System;
using SadafBI.CustomerStockStatus.Models;
using Microsoft.EntityFrameworkCore;

namespace SadafBI
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "bd4bdb61-6ebd-4f3a-aa8d-6dffcfb31fbf");

            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1390/01/01&creationDateFrom=1390/01/01&size=10000&page=8");
            responseTask.Wait();
            //لیست مشتریان
            //if (responseTask.IsCompleted)
            //{
            //    var result = responseTask.Result;
            //    result.EnsureSuccessStatusCode();



            //    var responseContent = result.Content.ReadAsStringAsync().Result;


            //    var settings = new JsonSerializerSettings
            //    {

            //        DefaultValueHandling = DefaultValueHandling.Populate
            //    };

            //    var apiResponse = JsonConvert.DeserializeObject<APIResponseCustomersModel>(responseContent, settings);


            //    using (var context = new DataContext())
            //    {
            //        var customerUpdater = new CustomerUpdater();
            //        foreach (var resultItem in apiResponse.result)
            //        {
            //            var existingCustomer = context.Customers.FirstOrDefault(c => c.customerId == resultItem.customerId);
            //            if (existingCustomer != null)
            //            {
            //                CustomerUpdater.UpdateCustomer(existingCustomer, resultItem);
            //            }
            //            else
            //            {
            //                var mappedData = CustomersMappingHelper.MapResultToSqlModel(resultItem);
            //                context.Customers.Add(mappedData);
            //            }
            //        }
            //        context.SaveChanges();
            //    }

            //}





            //اطلاعات معاملات به صورت تکفیفی
            //var startDate = new DateTime(1402, 01, 30); // تاریخ شروع مورد نظر

            //var endDate = new DateTime(1402, 01, 30); // تاریخ پایان مورد نظر (یک روز بعد از شروع)
            //var endDateMonth = new DateTime(1402, 01, 01); // تاریخ شروع از 1 ژانویه 1402
            //                                               // تاریخ شروع ماه برای اولین بار
            //while (startDate >= endDateMonth)
            //{
            var responseTransactionTask = client.GetAsync($"https://api.irbroker.com/api/v1/transactions/separated?dsCode=765&startDate=1402/12/09&endDate=1402/12/09&size=20000&page=1");
            responseTransactionTask.Wait();
            if (responseTransactionTask.IsCompleted)
            {
                var Result = responseTransactionTask.Result;
                Result.EnsureSuccessStatusCode();

                var ResponseContent = Result.Content.ReadAsStringAsync().Result;

                var settings = new JsonSerializerSettings
                {
                    DefaultValueHandling = DefaultValueHandling.Populate
                };

                var apiResponse = JsonConvert.DeserializeObject<APIResponseTransactionModel>(ResponseContent, settings);
                using (var context = new DataContext())
                {
                    foreach (var resultItem in apiResponse.result)
                    {
                        // دریافت مدل مپ شده
                        var mappedData2 = TransactionMappingHelper.MapResultsToSqlModel(resultItem);

                        // اضافه کردن به دیتابیس
                        context.SeparateTransaction.Add(mappedData2);
                    }

                    // ذخیره تغییرات در دیتابیس
                    context.SaveChanges();
                }

                //startDate = startDate.AddDays(-1);
                //endDate = endDate.AddDays(-1);
            }
            //}




            //وضغیت سهام مشتری

            //using (var context = new DataContext())
            //{
            //    var startDate = new DateTime(1402, 12, 09); // تاریخ شروع مورد نظر
            //    var endDate = new DateTime(1402, 12, 09);
            //    // دریافت CustomerId ها از دیتابیس
            //    var customerIds = context.Customers.Select(c => c.customerId).ToList();

            //    foreach (var customerId in customerIds)
            //    {
            //        var responseCustomerStoukTask = client.GetAsync($"https://api.irbroker.com/api/v1/customers/stockDetail?startDate={startDate:yyyy/MM/dd}&endDate={endDate:yyyy/MM/dd}&withRemain=false&dsCode=765&customerId={customerId}&size=30000&page=1");
            //        responseCustomerStoukTask.Wait();
            //        if (responseCustomerStoukTask.IsCompleted)
            //        {
            //            var Result = responseCustomerStoukTask.Result;
            //            Result.EnsureSuccessStatusCode();

            //            var ResponseContent = Result.Content.ReadAsStringAsync().Result;

            //            var settings = new JsonSerializerSettings
            //            {
            //                DefaultValueHandling = DefaultValueHandling.Populate
            //            };

            //            var apiResponseCustomerStock = JsonConvert.DeserializeObject<APIResponseCustomerStock>(ResponseContent, settings);
            //            foreach (var resultItem in apiResponseCustomerStock.result)
            //            {
            //                // دریافت مدل مپ شده
            //                var mappedData3 = CustomerStockMappingHelper.MapResultToSQLModel(resultItem);

            //                // اضافه کردن به دیتابیس
            //                context.CustomerStock.Add(mappedData3);
            //            }
            //            // ذخیره تغییرات در دیتابیس
            //            // کد ذخیره تغییرات در دیتابیس
            //            context.SaveChanges();

            //        }
            //    }







        }
    }
}





















            //            var startDate = new DateTime(1402, 12, 07); // تاریخ شروع مورد نظر
            //            var endDate = new DateTime(1402, 12, 07);
            //            var CustomerId = 202927657
            //                ;
            //            var responseCustomerStoukTask = client.GetAsync($"https://api.irbroker.com/api/v1/customers/stockDetail?startDate={startDate:yyyy/MM/dd}&endDate={endDate:yyyy/MM/dd}&withRemain=false&dsCode=765&customerId={CustomerId}&size=20000&page=1");
            //            responseCustomerStoukTask.Wait();
            //            if (responseCustomerStoukTask.IsCompleted)
            //            {
            //                var Result = responseCustomerStoukTask.Result;
            //                Result.EnsureSuccessStatusCode();

            //                var ResponseContent = Result.Content.ReadAsStringAsync().Result;

            //                var settings = new JsonSerializerSettings
            //                {
            //                    DefaultValueHandling = DefaultValueHandling.Populate
            //                };

            //                var apiResponseCustomerStock = JsonConvert.DeserializeObject<APIResponseCustomerStock>(ResponseContent, settings);
            //                using (var context = new DataContext())
            //                {
            //                    foreach (var resultItem in apiResponseCustomerStock.result)
            //                    {
            //                        // دریافت مدل مپ شده
            //                        var mappedData3 = CustomerStockMappingHelper.MapResultToSQLModel(resultItem);

            //                        // اضافه کردن به دیتابیس
            //                        context.CustomerStock.Add(mappedData3);
            //                    }

            //                    // ذخیره تغییرات در دیتابیس
            //                    context.SaveChanges();
            //                }

            //            }
            //        }
            //    }
            //}










            //using (var context = new DataContext())
            //{
            //    var startDate = new DateTime(1402, 12, 07); // تاریخ شروع مورد نظر
            //    var endDate = new DateTime(1402, 12, 07);

            //    var pageSize = 50; // اندازه هر صفحه
            //    var totalCustomers = context.SeparateTransaction.Count(); // تعداد کل کاستومرها
            //    var totalPages = (int)Math.Ceiling((double)totalCustomers / pageSize); // تعداد کل صفحات

            //    for (int page = 1; page <= totalPages; page++)
            //    {
            //        var customerIds = context.SeparateTransaction
            //                                .OrderBy(c => c.customerId) // یا هر فیلدی که برای صفحه‌بندی استفاده می‌شود
            //                                .Skip((page - 1) * pageSize)
            //                                .Take(pageSize)
            //                                .Select(c => c.customerId)
            //                                .ToList();

            //        foreach (var customerId in customerIds)
            //        {
            //            var responseCustomerStockTask = client.GetAsync($"https://api.irbroker.com/api/v1/customers/stockDetail?startDate={startDate:yyyy/MM/dd}&endDate={endDate:yyyy/MM/dd}&withRemain=false&dsCode=765&customerId={customerId}&size=20000&page=1");
            //            responseCustomerStockTask.Wait();

            //            if (responseCustomerStockTask.IsCompleted)
            //            {
            //                var result = responseCustomerStockTask.Result;
            //                result.EnsureSuccessStatusCode();

            //                var responseContent = result.Content.ReadAsStringAsync().Result;

            //                var settings = new JsonSerializerSettings
            //                {
            //                    DefaultValueHandling = DefaultValueHandling.Populate
            //                };

            //                var apiResponseCustomerStock = JsonConvert.DeserializeObject<APIResponseCustomerStock>(responseContent, settings);

            //                foreach (var resultItem in apiResponseCustomerStock.result)
            //                {
            //                    var mappedData = CustomerStockMappingHelper.MapResultToSQLModel(resultItem);
            //                    context.CustomerStock.Add(mappedData);
            //                }

            //                context.SaveChanges();
            //            }
            //        }
            //    }









//    var startDate = new DateTime(1402, 08, 29); // تاریخ شروع مورد نظر
//    var endDate = new DateTime(1402, 08, 29); // تاریخ پایان مورد نظر (یک روز بعد از شروع)
//    var endDateMonth = new DateTime(1402,08 , 01);
//    if(startDate >= endDateMonth)
//    {
//        var responseTransactionTask = client.GetAsync($"https://api.irbroker.com/api/v1/transactions/separated?dsCode=765&startDate={startDate:yyyy/MM/dd}&endDate={endDate:yyyy/MM/dd}&size=20000&page=1");


//        responseTransactionTask.Wait();
//        if (responseTransactionTask.IsCompleted)
//        {
//            var Result = responseTransactionTask.Result;
//            Result.EnsureSuccessStatusCode();



//            var ResponseContent = Result.Content.ReadAsStringAsync().Result;


//            var settings = new JsonSerializerSettings
//            {
//                DefaultValueHandling = DefaultValueHandling.Populate
//            };

//            var apiResponse = JsonConvert.DeserializeObject<APIResponseTransactionModel>(ResponseContent, settings);
//            using (var context = new DataContext())
//            {

//                foreach (var resultItem in apiResponse.result)
//                {
//                    // دریافت مدل مپ شده
//                    var mappedData2 = TransactionMappingHelper.MapResultsToSqlModel(resultItem);

//                    // اضافه کردن به دیتابیس
//                    context.SeparateTransaction.Add(mappedData2);
//                }

//                // ذخیره تغییرات در دیتابیس
//                context.SaveChanges();

//            }
//            startDate = startDate.AddDays(-1);
//             endDate = endDate.AddDays(-1);
//        }
//    }
//    else
//    {
//        Console.WriteLine("endDateMonth...");
//    }
//}

