using SadafBI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SadafBI.Models; // لازم است که مدل‌ها را به اینجا اضافه کنید
using System.Data.SqlClient;
namespace SadafBI
{
     class Program
    {
        static async Task Main()
        {
            try
            {
                // 1. ارسال درخواست به API برای دریافت لیست مشتریان
                List<CustomersModel> customers = await GetCustomersFromApi("YourApiUrl", "YourApiParameters");

                // 2. ذخیره لیست مشتریان در پایگاه داده
                SaveCustomersToDatabase(customers);

                Console.WriteLine("Data has been successfully retrieved from API and saved to the database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        static async Task<List<CustomersModel>> GetCustomersFromApi(string apiUrl, string apiParameters)
        {
            using (HttpClient client = new HttpClient())
            {
                // اضافه کردن پارامترهای API به URL
                string requestUrl = $"{apiUrl}?{apiParameters}";

                // ارسال درخواست GET به API
                HttpResponseMessage response = await client.GetAsync(requestUrl);

                // بررسی موفقیت درخواست
                response.EnsureSuccessStatusCode();

                // دریافت محتوای JSON از API
                string responseBody = await response.Content.ReadAsStringAsync();

                // تبدیل محتوا به لیست مشتریان
                CustomerListResponse customerListResponse = JsonConvert.DeserializeObject<CustomerListResponse>(responseBody);
                return customerListResponse.Result;
            }
        }
        static void SaveCustomersToDatabase(List<CustomersModel> customers)
        {
            string connectionString = "Data Source=DESKTOP-G1PGSB0;Initial Catalog=SadafBI;Integrated Security=True";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            foreach (var customer in customers)
            {
                // ایجاد دستور SQL برای درج اطلاعات مشتری در جدول
                string sql = "INSERT INTO Customers (customerId, nationalCode, companyName, firstName, lastName, ...)" +
                             " VALUES (@CustomerId, @NationalCode, @CompanyName, @FirstName, @LastName, ...)" +
                             " ON DUPLICATE KEY UPDATE nationalCode = @NationalCode, companyName = @CompanyName, ...";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // پارامترها را به دستور اضافه کنید
                    command.Parameters.AddWithValue("@CustomerId", customer.customerId);
                    command.Parameters.AddWithValue("@NationalCode", customer.nationalCode);
                    command.Parameters.AddWithValue("@CompanyName", customer.companyName);
                    command.Parameters.AddWithValue("@FirstName", customer.firstName);
                    command.Parameters.AddWithValue("@LastName", customer.lastName);
                    // ...

                    // اجرای دستور SQL
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }
    }
}


