using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    public class ProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, DogLeash> _dogLeashes;
        private Dictionary<string, CatFood> _catFoods;
        private Dictionary<string, DogFood> _dogFoods;
        private Dictionary<string, DogToy> _dogToys;
        private Dictionary<string, CatToy> _catToys;

        public ProductLogic()
        {
            _products = new List<Product>();
            _dogFoods = new Dictionary<string, DogFood>();
            _catFoods = new Dictionary<string, CatFood>();
            _dogLeashes = new Dictionary<string, DogLeash>();
            _dogToys = new Dictionary<string, DogToy>();
            _catToys = new Dictionary<string, CatToy>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);

            if (product is DogLeash dogLeash)
            {
                _dogLeashes[dogLeash.Name] = dogLeash;
            }
        }
    }
}
