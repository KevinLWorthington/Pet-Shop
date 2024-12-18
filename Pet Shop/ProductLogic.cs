﻿using Pet_Shop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    internal class ProductLogic : IProductLogic
    {
        private List<Product> _products;
        private Dictionary<string, CatFood> _catFood;
        private Dictionary<string, DogLeash> _dogLeash;
        private Dictionary<string, DogFood> _dogFood;
        private Dictionary<string, DogToy> _dogToy;
        private Dictionary<string, CatToy> _catToy;

        public ProductLogic()
        {
            _products = new List<Product>()
            {
                new DogLeash
                {
                    Name = "Dog Leash",
                    Description = "For dogs.",
                    LengthInches = 50,
                    Material = "Nylon",
                    Price = 45.00m,
                    Quantity = 0
                },
                new CatFood
                {
                    Name = "Cat Food",
                    Description = "For Cats.",
                    Quantity = 2,
                    Price = 14.00m,                    
                    WeightPounds = 10,
                    KittenFood = false
                }
            };
            _dogLeash = new Dictionary<string, DogLeash>();
            _catFood = new Dictionary<string, CatFood>();
            _dogFood = new Dictionary<string, DogFood>();
            _dogToy = new Dictionary<string, DogToy>();
            _catToy = new Dictionary<string, CatToy>();
        }

        public void AddProduct(Product product)
        {
            {
                if (product is DogLeash)
                {
                    _dogLeash.Add(product.Name, product as DogLeash);
                }
                if (product is CatFood)
                {
                    _catFood.Add(product.Name, product as CatFood);
                }
                if (product is DogFood)
                {
                    _dogFood.Add(product.Name, product as DogFood);
                }
                if (product is DogToy)
                {
                    _dogToy.Add(product.Name, product as DogToy);
                }
                if (product is CatToy)
                {
                    _catToy.Add(product.Name, product as CatToy);
                }
                _products.Add(product);

            }

            
        }
        public List<Product>? GetAllProducts()
        {
            try
            {
                return _products;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<string?> GetOnlyInStockProducts()
        {
            return _products.Where(static x => x.Quantity > 0).Select(static x => x.Name).ToList();
        }
    }
    
}

