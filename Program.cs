// See https://aka.ms/new-console-template for more information
using System;
using ConsoleApp3;

class Program
{
    static void Main()
    {
        FoodManager manager = new FoodManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Enter the name of the food item: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter the category (e.g., Canned Goods, Dairy, Produce): ");
                        string category = Console.ReadLine();

                        Console.Write("Enter the quantity: ");
                        if (!int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            Console.WriteLine("Invalid quantity. Item not added.");
                            break;
                        }

                        Console.Write("Enter the expiration date (MM/DD/YY): ");
                        if (!DateTime.TryParse(Console.ReadLine(), out DateTime expirationDate))
                        {
                            Console.WriteLine("Invalid expiration date. Item not added.");
                            break;
                        }

                        manager.AddItem(name, category, quantity, expirationDate);
                        break;

                    case 2:
                        Console.Write("Enter the name of the food item to delete: ");
                        string nameToDelete = Console.ReadLine();
                        manager.DeleteItem(nameToDelete);
                        break;

                    case 3:
                        manager.PrintList();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Exiting the program. Goodbye!");
                        running = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid Option.");
            }

            Console.WriteLine(); // Add a blank line for better readability
        }
    }
}
    
