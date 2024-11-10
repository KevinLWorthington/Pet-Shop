using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.Classes
{
    public class PrintByType
    {
        public void PrintProduct(List<Product> allProducts)
        {
            try             //Throw exception if no products have been entered when trying to view all products
            {
                if (allProducts == null || allProducts.Count == 0)
                {
                    throw new Exception("No product information available.\nPress any button to continue");
                }
                foreach (Product product in allProducts)
                {
                    Console.WriteLine("Which product type would you like to view?");
                    Console.WriteLine("Available types:\n1. Cat Food\n2. Dog Leash\n3. Dog Food\n4. Dog Toy\n5. Cat Toy");
                    string? userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        if (product is CatFood catFood)
                        {
                            Console.WriteLine("Product name:\t" + catFood.Name);
                            Console.WriteLine("Description:\t" + catFood.Description);
                            // Console.WriteLine("Price:\t\t$" + product.Price);
                            Console.WriteLine($"Price:\t\t${catFood.Price}\nDiscount Price:\t${product.Price.DiscountThisPrice()}");
                            Console.WriteLine("Quantity:\t" + catFood.Quantity);
                            Console.WriteLine("Weight(lbs):\t" + catFood.WeightPounds);
                            Console.WriteLine("For kittens:\t" + catFood.KittenFood);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No cat food has been added!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    else if (userInput == "2")
                    {
                        if (product is DogLeash dogLeash)
                        {
                            Console.WriteLine("Product name:\t" + dogLeash.Name);
                            Console.WriteLine("Description:\t" + dogLeash.Description);
                            // Console.WriteLine("Price:\t\t$" + product.Price);
                            Console.WriteLine($"Price:\t\t${dogLeash.Price}\nDiscount Price:\t${product.Price.DiscountThisPrice()}");
                            Console.WriteLine("Quantity:\t" + dogLeash.Quantity);
                            Console.WriteLine("Length(in):\t" + dogLeash.LengthInches + "\"");
                            Console.WriteLine("Material:\t" + dogLeash.Material);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No dog leash has been added!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }

                    }
                    else if (userInput == "3")
                    {
                        if (product is DogFood dogFood)
                        {
                            Console.WriteLine("Product name:\t" + dogFood.Name);
                            Console.WriteLine("Description:\t" + dogFood.Description);
                            // Console.WriteLine("Price:\t\t$" + product.Price);
                            Console.WriteLine($"Price:\t\t${dogFood.Price}\nDiscount Price:\t${product.Price.DiscountThisPrice()}");
                            Console.WriteLine("Quantity:\t" + dogFood.Quantity);
                            Console.WriteLine("Weight(lbs):\t" + dogFood.WeightPounds);
                            Console.WriteLine("For puppies:\t" + dogFood.PuppyFood);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No dog food has been added!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    else if (userInput == "4")
                    {
                        if (product is DogToy dogToy)
                        {
                            Console.WriteLine("Product name:\t" + dogToy.Name);
                            Console.WriteLine("Description:\t" + dogToy.Description);
                            // Console.WriteLine("Price:\t\t$" + product.Price);
                            Console.WriteLine($"Price:\t\t${dogToy.Price}\nDiscount Price:\t${product.Price.DiscountThisPrice()}");
                            Console.WriteLine("Quantity:\t" + dogToy.Quantity);
                            Console.WriteLine("Material:\t" + dogToy.Material);
                            Console.WriteLine("Color:\t\t" + dogToy.Color);
                            Console.WriteLine("Size(in):\t" + dogToy.Size + "\"");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No dog toy has been added!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    else if (userInput == "5")
                    {
                        if (product is CatToy catToy)
                        {
                            Console.WriteLine("Product name:\t" + catToy.Name);
                            Console.WriteLine("Description:\t" + catToy.Description);
                            // Console.WriteLine("Price:\t\t$" + product.Price);
                            Console.WriteLine($"Price:\t\t${catToy.Price}\nDiscount Price:\t${product.Price.DiscountThisPrice()}");
                            Console.WriteLine("Quantity:\t" + catToy.Quantity);
                            Console.WriteLine("Material:\t" + catToy.Material);
                            Console.WriteLine("Color:\t\t" + catToy.Color);
                            Console.WriteLine("Size(in):\t\t" + catToy.Size + "\"");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No cat toy has been added!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
            }
        }
    }
}
