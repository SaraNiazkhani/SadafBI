// See https://aka.ms/new-console-template for more information
using SadafBI.Data;
using SadafBI.Models;
using System.Net.Http.Json;
using System;

namespace SadafBI // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main()
        {
            MainSync();
        }
        static void MainSync()
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "543ae258-b863-478b-b07c-91ea1478f70f");
                using (var dbContext = new DataContext())
                {
                    var pageSize = 100;
                    var pageNumber = 1;

                    // var x = httpClient.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1").Result;

                    var responseTask = httpClient.GetFromJsonAsync<CustomerListResponse>("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1400/02/01&creationDateFrom=1400/02/20&size=100&page=1");
                    responseTask.Wait();

                    var response = responseTask.Result; // بازیابی نتیجه تسک

                    if (response != null)
                    {
                        dbContext.Customers.AddRange(response.Result);

                        var result = dbContext.SaveChanges();

                        Console.WriteLine("اطلاعات با موفقیت به دیتابیس افزوده شد.");
                    }
                    else
                    {
                        Console.WriteLine("درخواست API ناموفق بود.");
                    }
                }
            }
        }
    }
}

