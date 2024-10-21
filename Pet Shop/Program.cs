// See https://aka.ms/new-console-template for more information
using Pet_Shop;
using System;
using System.Text.Json;

Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' at any time to quit");
string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
   

    if (userInput == "1")
    {
        Console.WriteLine("Enter product type");
        Console.WriteLine("Available types: catfood, dogfood, dogleash, cattoy, dogtoy");
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

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(JsonSerializer.Serialize(catFood));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type 'exit' to quit");
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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(JsonSerializer.Serialize(dogLeash));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("Type '1' to enter another product");
        }
        else if (productType.ToLower() == "dogfood")
        {
            DogFood dogFood = new DogFood();
            Console.Write("Enter Name: ");
            dogFood.Name = Console.ReadLine();
            Console.Write("Enter Price: ");
            dogFood.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            dogFood.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Description: ");
            dogFood.Description = Console.ReadLine();
            Console.Write("Enter Weight (in pounds): ");
            dogFood.WeightPounds = double.Parse(Console.ReadLine());
            Console.Write("Is it Puppy Food (true/false): ");
            dogFood.PuppyFood = bool.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(JsonSerializer.Serialize(dogFood));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("Type '1' to enter another product");
        }
        else if (productType.ToLower() == "dogtoy")
        {
            DogToy dogToy = new DogToy();
            Console.WriteLine("Enter Name: ");
            dogToy.Name = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            dogToy.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            dogToy.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Description: ");
            dogToy.Description = Console.ReadLine();
            Console.WriteLine("Enter Material: ");
            dogToy.Material = Console.ReadLine();
            Console.WriteLine("Enter Color: ");
            dogToy.Color = Console.ReadLine();
            Console.WriteLine("Enter Size: ");
            dogToy.Size = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(JsonSerializer.Serialize(dogToy));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("Type '1' to enter another product");
        }
        else if (productType.ToLower() == "cattoy")
        {
            CatToy catToy = new CatToy();
            Console.WriteLine("Enter Name: ");
            catToy.Name = Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            catToy.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity: ");
            catToy.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Description: ");
            catToy.Description = Console.ReadLine();
            Console.WriteLine("Enter Material: ");
            catToy.Material = Console.ReadLine();
            Console.WriteLine("Enter Color: ");
            catToy.Color = Console.ReadLine();
            Console.WriteLine("Enter Size: ");
            catToy.Size = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(JsonSerializer.Serialize(catToy));
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type 'exit' to quit");
            Console.WriteLine("Type '1' to enter another product");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVALID INPUT. PLEASE TRY AGAIN.");
            Console.WriteLine("Press any key to exit");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Environment.Exit(0);
        }
    }

    userInput = Console.ReadLine();
}
