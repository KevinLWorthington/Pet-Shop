using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product>? GetAllProducts();

        public List<string?> GetOnlyInStockProducts();
    }
}
