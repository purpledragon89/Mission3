using System;
using System.Collections.Generic;
using ConsoleApp3; // Importing the namespace where FoodItem is defined

namespace ConsoleApp3
{
    public class FoodManager
    {
        private List<FoodItem> foodItems = new List<FoodItem>(); // Corrected to a List

        // Add a food item
        public void AddItem(string name, string category, int quantity, DateTime expirationDate)
        {
            // Create a new FoodItem using the constructor from FoodItem class
            FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);

            // Add the new item to the foodItems list
            foodItems.Add(newItem);

            Console.WriteLine("Food item added successfully.");
        }

        // Delete a food item by name
        public void DeleteItem(string name)
        {
            // Find the item in the list by name
            FoodItem itemToRemove = foodItems.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            
            if (itemToRemove != null)
            {
                // Remove the item if found
                foodItems.Remove(itemToRemove);
                Console.WriteLine("Food item deleted successfully.");
            }
            else
            {
                Console.WriteLine("Food item not found.");
            }
        }

        // Print the list of food items
        public void PrintList()
        {
            if (foodItems.Count == 0)
            {
                Console.WriteLine("No food items available.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Current Food Items:");
                foreach (var item in foodItems)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}