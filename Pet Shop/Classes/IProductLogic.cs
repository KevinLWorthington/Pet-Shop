using Pet_Shop.Classes.Products;


namespace Pet_Shop.Classes
{
    internal interface IProductLogic
    {
        public void AddProduct(Product product);

        public List<Product>? GetAllProducts();

        public List<string?> GetOnlyInStockProducts();

        public decimal GetTotalPriceOfInventory();
    }
}
