using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pet_Shop.Classes;
using Pet_Shop.Classes.Products;

namespace Pet_Shop
{
    public class ProductPrinter
    {
        // Method to print all product details
        public void PrintProductDetails(List<Product> allProducts)
        {
            try             //Throw exception if no products have been entered when trying to view all products
            {
                if (allProducts == null || allProducts.Count == 0)
                {
                    throw new Exception("No product information available.\nPress any button to continue");
                }
                foreach (var product in allProducts)
                {
                    // Display common product details
                    Console.WriteLine("Product name:\t" + product.Name);
                    Console.WriteLine("Description:\t" + product.Description);
                    // Console.WriteLine("Price:\t\t$" + product.Price);
                    Console.WriteLine($"Price:\t\t${ product.Price }\nDiscount Price:\t${ product.Price.DiscountThisPrice() }");
                    Console.WriteLine("Quantity:\t" + product.Quantity);

                    //Display specific product details
                    if (product is DogLeash dogLeash)
                    {
                        Console.WriteLine("Length(in):\t" + dogLeash.LengthInches + "\"");
                        Console.WriteLine("Material:\t" + dogLeash.Material);
                    }
                    else if (product is CatFood catFood)
                    {
                        Console.WriteLine("Weight(lbs):\t" + catFood.WeightPounds);
                        Console.WriteLine("For kittens:\t" + catFood.KittenFood);
                    }
                    else if (product is DogFood dogFood)
                    {
                        Console.WriteLine("Weight(lbs):\t" + dogFood.WeightPounds);
                        Console.WriteLine("For puppies:\t" + dogFood.PuppyFood);
                    }
                    else if (product is DogToy dogToy)
                    {
                        Console.WriteLine("Material:\t" + dogToy.Material);
                        Console.WriteLine("Color:\t\t" + dogToy.Color);
                        Console.WriteLine("Size(in):\t" + dogToy.Size + "\"");
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
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }

        }
    }
}

