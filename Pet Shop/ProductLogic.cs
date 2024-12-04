using Pet_Shop.Classes;
using Pet_Shop.Classes.Products;

namespace Pet_Shop
{
    //Dictionary for each type of product
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
                //Add each product to the appropriate dictionary
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
        //Get products by name
        public T GetProductByName<T>(string name) where T : Product
        {
            try
            {
                if (typeof(T) == typeof(DogLeash))
                {
                    return _dogLeash[name] as T;
                }
                else if (typeof(T) == typeof(CatFood))
                {
                    return _catFood[name] as T;
                }
                else if (typeof(T) == typeof(DogFood))
                {
                    return _dogFood[name] as T;
                }
                else if (typeof(T) == typeof(DogToy))
                {
                    return _dogToy[name] as T;
                }
                else if (typeof(T) == typeof(CatToy))
                {
                    return _catToy[name] as T;
                }                
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        //Get all products that have been entered
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
        //Get all products that are in stock
        public List<string?> GetOnlyInStockProducts()
        {
            return _products.Where(static x => x.Quantity > 0).Select(static x => x.Name).ToList();
        }
        //Get the total value of the instock products
        public decimal GetTotalPriceOfInventory()
        {
            return _products.InStock().Select(x => x.Price).Sum();
        }
    }

}

