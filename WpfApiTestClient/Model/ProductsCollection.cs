using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystematicWebApi.Models.Products;

namespace WpfApiTestClient.Model
{
    class ProductsCollection : ObservableCollection<ProductModel>
    {
        public void CopyFrom(IEnumerable<ProductModel> products)
        {
            this.Clear();
            foreach (var productModel in products)
            {
                this.Items.Add(productModel);
            }

            this.OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}
