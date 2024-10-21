// See https://aka.ms/new-console-template for more information
using Pet_Shop;
using System;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");

    if (userInput == "1")
    {
        Console.WriteLine("Enter product type (CatFood/DogLeash):");
        string productType = Console.ReadLine();

        if (productType.ToLower() == "catfood")
        {
            CatFood catFood = new CatFood();
            Console.Write("Enter Name: ");
            catFood.Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            catFood.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            catFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Description: ");
            catFood.Description = Console.ReadLine();
            Console.Write("Enter Weight (in pounds): ");
            catFood.WeightPounds = double.Parse(Console.ReadLine());
            Console.Write("Is it Kitten Food (true/false): ");
            catFood.KittenFood = bool.Parse(Console.ReadLine());

            Console.WriteLine(JsonSerializer.Serialize(catFood));
        }
        else if (productType.ToLower() == "dogleash")
        {
            DogLeash dogLeash = new DogLeash();
            Console.Write("Enter Name: ");
            dogLeash.Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            dogLeash.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            dogLeash.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Description: ");
            dogLeash.Description = Console.ReadLine();
            Console.Write("Enter Length (in inches): ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());
            Console.Write("Enter Material: ");
            dogLeash.Material = Console.ReadLine();

            Console.WriteLine(JsonSerializer.Serialize(dogLeash));
        }
    }

    userInput = Console.ReadLine();
}
