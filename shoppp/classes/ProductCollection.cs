using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppp.classes
{
    class ProductCollection : ObservableCollection<Product>
    {
        public ProductCollection() 
        {
            Add(new Product { Title = "Новый продукт", Description = "test descr", Category = "test cat", Price = "1000", Discount = "0" });
            Add(new Product { Title = "Новый продукт1", Description = "test descr1", Category = "test cat1", Price = "1001", Discount = "00" });
        }
    }
}
