using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SystematicWebApi.Models.Products;

namespace ApiTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseApiUrl"]);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string listUrl = "api/Products";
            var response = client.GetAsync(listUrl).Result;
            if (response.IsSuccessStatusCode)
            {
                response.Content.ReadAsAsync<IList<ProductModel>>().ContinueWith(task =>
                {
                    Console.WriteLine("Id -- Name -- Category -- Price");
                    foreach (var productModel in task.Result)
                    {
                        Console.WriteLine("{0}--{1}--{2}--{3}", productModel.Id, productModel.Name, productModel.Category, productModel.Price);
                    }
                });
                
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
