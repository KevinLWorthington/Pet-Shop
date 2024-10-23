﻿// See https://aka.ms/new-console-template for more information
using Pet_Shop;
using System;
using System.Text.Json;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome to the Pet Shop Inventory System\nPress 1 to add a product\nType 'exit' to quit");
Console.ForegroundColor = ConsoleColor.Gray;
string userInput = Console.ReadLine();

    if (userInput.ToLower() == "1")
    {


        if (userInput == "1")
        {
            Console.WriteLine("Add a new product by typing the corresponding number");
            Console.WriteLine("Available types:\n1. Cat Food\n2. Dog Leash\n3. Dog Food\n4. Dog Toy\n5. Cat Toy");
            string productType = Console.ReadLine();

            if (productType.ToLower() == "1")
            {
                CatFood catFood = new CatFood();
                Console.Write("New cat food\nEnter Name: ");
                catFood.Name = Console.ReadLine();
            string priceInput;
            decimal price;
            do
            {
                Console.Write("Enter Price: ");
                priceInput = Console.ReadLine();
            } 
            while (!decimal.TryParse(priceInput.Replace("$", "").Trim(), out price));
                catFood.Price = price;

            string quantityInput;
            int quantity;
            do
            {
                Console.Write("Enter Quantity: ");
                quantityInput = Console.ReadLine();
            }
            while (!int.TryParse(quantityInput, out quantity));
            catFood.Quantity = quantity;
                Console.Write("Enter Description: ");
                catFood.Description = Console.ReadLine();

            string weightInput;
            double weight;
            do
            {
                Console.Write("Enter Weight (in pounds): ");
                weightInput = Console.ReadLine();
            }
            while (!double.TryParse(weightInput, out weight));
            catFood.WeightPounds = weight;

            string kittenInput;
            bool kittenfood;
            do
            {
                Console.Write("Is it Kitten Food (please type true or false): ");
                kittenInput = Console.ReadLine();
            }
            while (!bool.TryParse(kittenInput, out kittenfood));
                catFood.KittenFood = kittenfood;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(JsonSerializer.Serialize(catFood));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine("Type '1' to enter another product");
        }
            else if (productType.ToLower() == "2")
            {
                DogLeash dogLeash = new DogLeash();
                Console.Write("New dog leash\nEnter Name: ");
                dogLeash.Name = Console.ReadLine();
            string priceInput;
            decimal price;
            do
            {
                Console.Write("Enter Price: ");
                priceInput = Console.ReadLine();
            }
            while (!decimal.TryParse(priceInput.Replace("$", "").Trim(), out price));
            dogLeash.Price = price;

            string quantityInput;
            int quantity;
            do
            {
                Console.Write("Enter Quantity: ");
                quantityInput = Console.ReadLine();
            }
            while (!int.TryParse(quantityInput, out quantity));
            dogLeash.Quantity = quantity;

            Console.Write("Enter Description: ");
                dogLeash.Description = Console.ReadLine();

            string lengthInput;
            int length;
            do
            {
                Console.Write("Enter Length (in inches): ");
                lengthInput = Console.ReadLine();
            }
            while (!int.TryParse(lengthInput, out length));
            dogLeash.LengthInches = length;

                Console.Write("Enter Material: ");
                dogLeash.Material = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine("Type '1' to enter another product");
            }
            else if (productType.ToLower() == "3")
            {
                DogFood dogFood = new DogFood();
                Console.Write("New dog food\nEnter Name: ");
                dogFood.Name = Console.ReadLine();

            string priceInput;
            decimal price;
            do
            {
                Console.Write("Enter Price: ");
                priceInput = Console.ReadLine();
            }
            while (!decimal.TryParse(priceInput.Replace("$", "").Trim(), out price));
            dogFood.Price = price;

            dogFood.Price = decimal.Parse(Console.ReadLine());
            string quantityInput;
            int quantity;
            do
            {
                Console.Write("Enter Quantity: ");
                quantityInput = Console.ReadLine();
            }
            while (!int.TryParse(quantityInput, out quantity));
            dogFood.Quantity = quantity;
            Console.Write("Enter Description: ");
                dogFood.Description = Console.ReadLine();

            string weightInput;
            double weight;
            do
            {
                Console.Write("Enter Weight (in pounds): ");
                weightInput = Console.ReadLine();
            }
            while (!double.TryParse(weightInput, out weight));
            dogFood.WeightPounds = weight;

            string puppyInput;
            bool puppyfood;
            do
            {
                Console.Write("Is it Kitten Food (please type true or false): ");
                puppyInput = Console.ReadLine();
            }
            while (!bool.TryParse(puppyInput, out puppyfood));
            dogFood.PuppyFood = puppyfood;

            Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(JsonSerializer.Serialize(dogFood));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine("Type '1' to enter another product");
            }
            else if (productType.ToLower() == "4")
            {
                DogToy dogToy = new DogToy();
                Console.WriteLine("New dog toy\nEnter Name: ");
                dogToy.Name = Console.ReadLine();
            string priceInput;
            decimal price;
            do
            {
                Console.Write("Enter Price: ");
                priceInput = Console.ReadLine();
            }
            while (!decimal.TryParse(priceInput.Replace("$", "").Trim(), out price));
            dogToy.Price = price;
            string quantityInput;
            int quantity;
            do
            {
                Console.Write("Enter Quantity: ");
                quantityInput = Console.ReadLine();
            }
            while (!int.TryParse(quantityInput, out quantity));
            dogToy.Quantity = quantity;

            Console.WriteLine("Enter Description: ");
                dogToy.Description = Console.ReadLine();
                Console.WriteLine("Enter Material: ");
                dogToy.Material = Console.ReadLine();
                Console.WriteLine("Enter Color: ");
                dogToy.Color = Console.ReadLine();
            string lengthInput;
            int length;
            do
            {
                Console.Write("Enter size (in inches): ");
                lengthInput = Console.ReadLine();
            }
            while (!int.TryParse(lengthInput, out length));
            dogToy.Size = length;

            Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(JsonSerializer.Serialize(dogToy));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Type 'exit' to quit");
                Console.WriteLine("Type '1' to enter another product");
            }
            else if (productType.ToLower() == "5")
            {
            CatToy catToy = new CatToy();
            Console.WriteLine("New cat toy\nEnter Name: ");
            catToy.Name = Console.ReadLine();
            string priceInput;
            decimal price;
            do
            {
                Console.Write("Enter Price: ");
                priceInput = Console.ReadLine();
            }
            while (!decimal.TryParse(priceInput.Replace("$", "").Trim(), out price));
            catToy.Price = price;
            string quantityInput;
            int quantity;
            do
            {
                Console.Write("Enter Quantity: ");
                quantityInput = Console.ReadLine();
            }
            while (!int.TryParse(quantityInput, out quantity));
            catToy.Quantity = quantity;

            Console.WriteLine("Enter Description: ");
            catToy.Description = Console.ReadLine();
            Console.WriteLine("Enter Material: ");
            catToy.Material = Console.ReadLine();
            Console.WriteLine("Enter Color: ");
            catToy.Color = Console.ReadLine();
            string lengthInput;
            int length;
            do
            {
                Console.Write("Enter size (in inches): ");
                lengthInput = Console.ReadLine();
            }
            while (!int.TryParse(lengthInput, out length));
            catToy.Size = length;

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
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadLine();
            }
        }

        userInput = Console.ReadLine();

        if (userInput.ToLower() == "exit")
        {
            Environment.Exit(0);
        }
}
    else
    {
    Console.WriteLine(Console.ReadLine() + " is not a valid input. App will now quit.");
    Environment.Exit(0);
    }

