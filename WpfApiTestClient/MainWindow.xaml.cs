using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystematicWebApi.Models.Products;
using WpfApiTestClient.Model;

namespace WpfApiTestClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private HttpClient client;
        private ProductsCollection _products;

        public MainWindow()
        {
            InitializeComponent();

            client = new HttpClient()
            {
                BaseAddress = new Uri(ConfigurationManager.AppSettings["BaseApiUrl"]),
            };
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            _products = new ProductsCollection();
            this.ProductsList.ItemsSource = _products;
        }

        private async void GetProducts(object sender, RoutedEventArgs e)
        {
            try
            {
                BtnGetProducts.IsEnabled = false;

                var response = await client.GetAsync("api/products");
                response.EnsureSuccessStatusCode();

                var products = await response.Content.ReadAsAsync<IList<ProductModel>>();
                _products.CopyFrom(products);
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                BtnGetProducts.IsEnabled = true;
            }
        }

        private async void PostProduct(object sender, RoutedEventArgs e)
        {
            BtnPostProduct.IsEnabled = false;

            try
            {
                var product = new ProductModel()
                {
                    Category = this.TextCategory.Text,
                    Name = this.TextName.Text,
                    Price = decimal.Parse(this.TextPrice.Text)
                };

                var response = await client.PostAsJsonAsync("api/Products", product);
                response.EnsureSuccessStatusCode();

                _products.Add(product);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Price must be a number");
            }
            finally
            {
                BtnPostProduct.IsEnabled = true;
            }
        }
    }
}
