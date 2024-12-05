using Pet_Shop.Classes.Products;

namespace Pet_Shop.Classes
{
    internal static class ListExtensions
    {
        //Generates list of instock products
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();
        }
    }
}
