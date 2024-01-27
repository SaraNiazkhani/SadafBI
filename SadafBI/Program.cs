using SadafBI.Data;
using SadafBI.Models;
using System.Net.Http.Json;
using System;
using RestSharp;
using System.Net;
using System.Text.Json;
using Newtonsoft.Json;

namespace SadafBI
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "b2d0470a-39a2-4310-a0b7-3a9f00309deb");
            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");
            responseTask.Wait();
            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                
                result.EnsureSuccessStatusCode();

                var responseContent = result.Content.ReadAsStringAsync().Result;
                var apiResponse = JsonConvert.DeserializeObject<CustomerListResponse>(responseContent);

                // حالا می‌توانید از داده‌های دیسریالایز شده استفاده کنید
                var customerList = apiResponse?.CustomerList;

                if (customerList != null && customerList.Count > 0)
                {
                    foreach (var customer in customerList)
                    {
                        Console.WriteLine($"Customer ID: {customer.customerId}, National Code: {customer.nationalCode}");
                    }
                }
                else
                {
                    Console.WriteLine("No valid data to process.");
                }

                Console.ReadLine();
            }
        }
    }
}


           

   


              

                // استفاده از Json.NET برای دیسریالایز کردن
                

                // حالا می‌توانید از داده‌های دیسریالایز شده استفاده کنید
             
    


//using SadafBI.Data;
//using SadafBI.Models;
//using System;
//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Linq;

//namespace SadafBI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // ایجاد یک نمونه از HttpClient
//            using (var client = new HttpClient())
//            {
//                // افزودن توکن به هدر درخواست
//                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "b2d0470a-39a2-4310-a0b7-3a9f00309deb");

//                Console.WriteLine("Calling Web API...");

//                // ارسال درخواست به API
//                var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=10&page=1");
//                responseTask.Wait();

//                // بررسی وضعیت درخواست
//                if (responseTask.IsCompleted)
//                {
//                    var result = responseTask.Result;
//                    result.EnsureSuccessStatusCode(); // بررسی وضعیت درخواست و ایجاد استثناء در صورت خطا

//                    // خواندن اطلاعات از پاسخ
//                    var customerListTask = result.Content.ReadFromJsonAsync<CustomerListResponse>();
//                    customerListTask.Wait();

//                    // بررسی وضعیت خواندن اطلاعات
//                    if (customerListTask.IsCompletedSuccessfully)
//                    {
//                        var customerListResponse = customerListTask.Result;
//                        var customerList = customerListResponse.CustomerList;

//                        // اتصال به دیتابیس و ذخیره اطلاعات
//                        using (var context = new DataContext())
//                        {
//                            if (customerList != null && customerList.Any())
//                            {
//                                context.Customers.AddRange(customerList);
//                                context.SaveChanges();
//                                Console.WriteLine("Data added to the database successfully.");
//                            }
//                            else
//                            {
//                                Console.WriteLine("No valid data to add to the database.");
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("Failed to read data from the API response.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Failed to make a request to the API.");
//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}


//using System;
//using System.Net.Http;
//using System.Net.Http.Json;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using SadafBI.Models;
//using SadafBI.Data;

//namespace SadafBI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            using (var context = new DataContext())
//            {
//                HttpClient client = new HttpClient();
//                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "b2d0470a-39a2-4310-a0b7-3a9f00309deb");

//                Console.WriteLine("Calling Web API...");
//                var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1").Result;
//                //responseTask.Wait();

//                //if (responseTask.IsCompleted)
//                //{
//                //    var result = responseTask.Result;
//                //    if (result.IsSuccessStatusCode)
//                //    {
//                //        var customerListTask = result.Content.ReadFromJsonAsync<CustomerListResponse>();
//                //        customerListTask.Wait();

//                //        if (customerListTask.IsCompleted)
//                //        {
//                //            var customerListResponse = customerListTask.Result;
//                //            var customerList = customerListResponse.CustomerList;

//                //            if (customerList != null)
//                //            {
//                //                // افزودن به دیتابیس
//                //                context.Customers.AddRange(customerList);
//                //                context.SaveChanges();
//                //                Console.WriteLine("Data added to the database successfully.");
//                //            }


//                //            Console.ReadLine();
//                //        }
//                //    }
//                //}
//            }
//        }
//    }
//}






//using SadafBI.Data;
//using SadafBI.Models;
//using System.Net.Http.Json;
//using System;
//using RestSharp;
//using System.Net;

//namespace SadafBI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            HttpClient client = new HttpClient();
//            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "b2d0470a-39a2-4310-a0b7-3a9f00309deb");
//            Console.WriteLine("CallingWebAPI...");
//            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");
//            responseTask.Wait();
//            if (responseTask.IsCompleted)
//            {
//                var result = responseTask.Result;
//                if (result.IsSuccessStatusCode)
//                {
//                    var messageTask = result.Content.ReadAsStringAsync();
//                    messageTask.Wait();
//                    Console.WriteLine("Message from WbbAPI=" + messageTask.Result);
//                    Console.ReadLine();
//                }
//            }
//        }
//    }
//}





///********////*****************************************
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//class Program
//{
//    static async Task Main()
//    {
//        await MainAsync();
//    }

//    static async Task MainAsync()
//    {
//        string apiEndpoint = "https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1389/01/01&creationDateFrom=1389/01/01&size=1&page=1";

//        using (HttpClient client = new HttpClient())
//        {
//            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "b2d0470a-39a2-4310-a0b7-3a9f00309deb");

//            try
//            {
//                var response = await client.GetAsync(apiEndpoint);

//                if (response.IsSuccessStatusCode)
//                {
//                    string responseBody = await response.Content.ReadAsStringAsync();
//                    Console.WriteLine("Status Code: " + response.StatusCode);
//                    Console.WriteLine("Response Body: " + responseBody);
//                }
//                else
//                {
//                    Console.WriteLine("Error: " + response.StatusCode);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Exception: " + ex.Message);
//            }
//        }
//    }
//}







//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;
//using SadafBI.Data;
//using SadafBI.Models;

//namespace SadafBI
//{
//    public class Program
//    {
//        public static async Task Main()
//        {
//            await MainAsync();
//        }

//        static async Task MainAsync()
//        {
//            using (var httpClient = new HttpClient())
//            {
//                httpClient.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");

//                try
//                {
//                    // درخواست اطلاعات از یو ار ال
//                    var response = await httpClient.GetStringAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");

//                    // دیسریالیزیشن اطلاعات
//                    var customerListResponse = JsonConvert.DeserializeObject<CustomerListResponse>(response);

//                    if (customerListResponse != null)
//                    {
//                        using (var dbContext = new DataContext())
//                        {
//                            // تبدیل به مدل‌های اسکیوال
//                            var sqlCustomerList = customerListResponse.Result?.Select(c => new SqlCustomerList
//                            {
//                                customerId = c.customerId,
//                                nationalCode = c.nationalCode,
//                                // سایر فیلدها

//                            }).ToList();

//                            if (sqlCustomerList != null)
//                            {
//                                // ذخیره در دیتابیس
//                                dbContext.SqlCustomerLists.AddRange(sqlCustomerList);
//                                var result = await dbContext.SaveChangesAsync();
//                                Console.WriteLine("اطلاعات با موفقیت به دیتابیس افزوده شد.");
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("درخواست API ناموفق بود یا اطلاعات خالی است.");
//                    }
//                }
//                catch (HttpRequestException ex)
//                {
//                    Console.WriteLine($"خطا در برقراری ارتباط با سرور: {ex.Message}");
//                }
//            }
//        }
//    }
//}





/////////////////////////////////////////////////////////////////
//using SadafBI.Models;
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;
//using Newtonsoft.Json;

//class Program
//{
//    static async Task Main()
//    {
//        await GetCustomersAsync();
//    }

//    static async Task GetCustomersAsync()
//    {
//        using (HttpClient client = new HttpClient())
//        {
//            // اضافه کردن توکن به هدر درخواست
//            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "cf7ebfa6-357e-401a-ba90-63e9c920554a");

//            // ایجاد آدرس API
//            string apiUrl = "https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1";

//            // ارسال درخواست HTTP GET به API
//            HttpResponseMessage response = await client.GetAsync(apiUrl);

//            // بررسی موفقیت درخواست
//            if (response.IsSuccessStatusCode)
//            {
//                // دریافت محتوای JSON از پاسخ
//                string jsonContent = await response.Content.ReadAsStringAsync();

//                // تبدیل محتوای JSON به مدل مورد نظر
//                Rootobject result = JsonConvert.DeserializeObject<Rootobject>(jsonContent);

//                // نمایش اطلاعات مشتریان
//                foreach (Result customer in result.result)
//                {
//                    Console.WriteLine($"Customer ID: {customer.customerId}, Name: {customer.firstName} {customer.lastName}");
//                }
//            }
//            else
//            {
//                // نمایش پیام خطا در صورت عدم موفقیت درخواست
//                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
//            }
//            Console.ReadKey();
//        }
//    }

//*///***
//using SadafBI.Data;



//public class Program
//{ public static void Main()
//    {
//        MainSync();
//    }

//    static void MainSync()
//    {
//        var client = new RestClient("https://api.irbroker.com/");
//        RestRequest request = new RestRequest("api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1"); // تغییر در این خط


//        // افزودن هدر X-CLIENT-TOKEN به درخواست API
//        request.AddHeader("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");

//        // افزودن پارامترهای درخواست
//        request.AddQueryParameter("dsCode", "765");
//        request.AddQueryParameter("modificationDateFrom", "1400/02/01");
//        request.AddQueryParameter("creationDateFrom", "1400/02/20");
//        request.AddQueryParameter("size", "100");
//        request.AddQueryParameter("page", "1");

//        var response = client.Execute<SqlCustomerList>(request);

//        if (response.IsSuccessful)
//        {
//            using (var dbContext = new DataContext())
//            {
//                dbContext.Customers.AddRange(response.Data);
//                var result = dbContext.SaveChanges();

//                Console.WriteLine($"{result} records inserted into the database.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"API request failed with status code: {response.StatusCode}");
//        }
//    }
//}


//using SadafBI.Data;
//using SadafBI.Models;
//using System.Net.Http.Json;
//using System;
//using RestSharp;

//namespace SadafBI // Note: actual namespace depends on the project name.
//{
//    public class Program
//    {

//        public static void Main()
//        {
//            MainSync();
//        }
//        static void MainSync()
//        {
//            using (var httpClient = new HttpClient())
//            {
//                httpClient.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");
//                using (var dbContext = new DataContext())
//                {
//                    var pageSize = 100;
//                    var pageNumber = 1;

//                    // var x = httpClient.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1").Result;

//                    var responseTask = httpClient.GetFromJsonAsync<CustomerListResponse>("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");
//                    responseTask.Wait();

//                    var response = responseTask.Result; // بازیابی نتیجه تسک

//                    if (response != null)
//                    {
//                        dbContext.Customers.AddRange(response.Result);

//                        var result = dbContext.SaveChanges();

//                        Console.WriteLine("اطلاعات با موفقیت به دیتابیس افزوده شد.");
//                    }
//                    else
//                    {
//                        Console.WriteLine("درخواست API ناموفق بود.");
//                    }
//                }
//            }
//        }
//    }
//}
