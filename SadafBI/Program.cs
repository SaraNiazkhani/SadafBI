// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http;
using Newtonsoft.Json;
using SadafBI.Data;
using SadafBI.Models;
using System.Threading.Tasks;

namespace SadafBI
{
    public class Program
    {
        public static async Task Main()
        {
            await MainAsync();
        }

        static async Task MainAsync()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");

                // اطلاعات را به صورت غیرهمزمان دریافت کنید
                var response = await httpClient.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");

                if (response.IsSuccessStatusCode)
                {
                    // اطلاعات را از رشته به مدل مناسب تبدیل کنید
                    var responseString = await response.Content.ReadAsStringAsync();
                    var customerListResponse = JsonConvert.DeserializeObject<CustomerListResponse>(responseString);

                    if (customerListResponse != null)
                    {
                        using (var dbContext = new DataContext())
                        {
                            dbContext.Customers.AddRange(customerListResponse.Result);
                            var result = await dbContext.SaveChangesAsync();
                            Console.WriteLine("اطلاعات با موفقیت به دیتابیس افزوده شد.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("خطا در دیسریالایز اطلاعات.");
                    }
                }
                else
                {
                    Console.WriteLine($"خطا: {response.StatusCode}");
                }
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
