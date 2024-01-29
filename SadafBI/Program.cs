using System;
using System.Net.Http;
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
            client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", "2ba20fdc-b987-479f-8c0c-643ed7fdcc78");

            Console.WriteLine("Calling Web API...");
            var responseTask = client.GetAsync("https://api.irbroker.com/api/v1/listCustomers?dsCode=765&modificationDateFrom=1390/01/01&creationDateFrom=1390/01/01&size=100&page=1");
            responseTask.Wait();

            if (responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                result.EnsureSuccessStatusCode();
           


                var responseContent = result.Content.ReadAsStringAsync().Result;


                var apiResponse = JsonConvert.DeserializeObject<APIResponseModel>(responseContent);

                

                using (var dbContext = new DataContext())
                {
                    var newCus = new SqlCustomerList();
                    newCus.accountNumber = "5645";
                    dbContext.Customers.Add(newCus);
                    dbContext.SaveChanges();
                }

            }

            Console.ReadLine();
        }
    }
}




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

