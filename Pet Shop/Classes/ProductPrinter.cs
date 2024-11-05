using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    public class ProductPrinter
    {
        public void PrintProductDetails(List<Product> allProducts)
        {
            foreach (var product in allProducts)
            {
                // Display common product details
                Console.WriteLine("Product name:\t" + product.Name);
                Console.WriteLine("Description:\t" + product.Description);
                Console.WriteLine("Price:\t\t$" + product.Price);
                Console.WriteLine("Quantity:\t" + product.Quantity);

                // Check product type and display additional details
                if (product is DogLeash dogLeash)
                {
                    Console.WriteLine("Length(in):\t" + dogLeash.LengthInches + "\"");
                    Console.WriteLine("Material:\t" + dogLeash.Material);
                }
                else if (product is CatFood catFood)
                {
                    Console.WriteLine("Weight(lbs):\t" + catFood.WeightPounds);
                    Console.WriteLine("Kitten Food:\t" + catFood.KittenFood);
                }
                else if (product is DogFood dogFood)
                {
                    Console.WriteLine("Weight(lbs):\t" + dogFood.WeightPounds);
                    Console.WriteLine("Puppy Food:\t" + dogFood.PuppyFood);
                }
                else if (product is DogToy dogToy)
                {
                    Console.WriteLine("Material:\t" + dogToy.Material);
                    Console.WriteLine("Color:\t\t" + dogToy.Color);
                    Console.WriteLine("Size(in):\t\t" + dogToy.Size + "\"");
                }
                else if (product is CatToy catToy)
                {
                    Console.WriteLine("Material:\t" + catToy.Material);
                    Console.WriteLine("Color:\t\t" + catToy.Color);
                    Console.WriteLine("Size(in):\t\t" + catToy.Size + "\"");
                }

                Console.WriteLine("-------------------------------------------------------");
            }
        }
    }
}
