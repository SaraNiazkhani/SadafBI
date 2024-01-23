// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SadafBI.Data;
using SadafBI.Models;

namespace SadafBI
{
    class Program
    {
        static void Main()
        {
            // تنظیمات اتصال به دیتابیس را بخوانید
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json") // فایل تنظیمات شما
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // ایجاد خدمات
            var serviceProvider = new ServiceCollection()
                .AddDbContext<DataContext>(options => options.UseSqlServer(connectionString))
                .BuildServiceProvider();

            // دریافت یک instance از DbContext
            using (var dbContext = serviceProvider.GetService<DataContext>())
            {
                // اطلاعات از API گرفته می‌شوند
                var customerList = GetCustomerListFromApi();

                // اطلاعات در دیتابیس ذخیره می‌شوند
                if (customerList != null && customerList.result != null)
                {
                    dbContext.Customers.AddRange(customerList.result);
                    dbContext.SaveChanges();
                    Console.WriteLine("اطلاعات با موفقیت به دیتابیس افزوده شد.");
                }
                else
                {
                    Console.WriteLine("API response is empty or does not contain the expected structure.");
                }
            }
        }

        static CustomerListResponse GetCustomerListFromApi()
        {
            // اتصال به API و دریافت اطلاعات
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");

                var response = httpClient.GetFromJsonAsync<CustomerListResponse>("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1").Result;

                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadFromJsonAsync<CustomerListResponse>().Result;
                }

                Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                return null;
            }
        }
    }
}




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
