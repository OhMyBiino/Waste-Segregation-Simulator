using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Predefined waste categories
        List<string> biodegradable = new List<string> { "food scraps", "banana peel", "vegetable scraps", "paper towels", "garden waste" };
        List<string> recyclable = new List<string> { "plastic bottle", "glass bottle", "aluminum can", "cardboard", "newspaper", "paper" };
        List<string> nonRecyclable = new List<string> { "plastic bag", "broken glass", "styrofoam", "used tissue", "dirty packaging" };

        // Initialize waste lists
        List<string> biodegradableList = new List<string>();
        List<string> recyclableList = new List<string>();
        List<string> nonRecyclableList = new List<string>();

        Console.WriteLine("Welcome to the Waste Segregation Simulator!");
        Console.WriteLine("Enter your waste items separated by commas (e.g., food scraps, plastic bottle):");

        // User input
        string input = Console.ReadLine();
        string[] wasteItems = input.Split(',');

        foreach (string item in wasteItems)
        {
            string trimmedItem = item.Trim().ToLower();

            if (biodegradable.Contains(trimmedItem))
            {
                biodegradableList.Add(trimmedItem);
                Console.WriteLine($"[INFO] '{trimmedItem}' is Biodegradable and placed in the Biodegradable bin.");
            }
            else if (recyclable.Contains(trimmedItem))
            {
                recyclableList.Add(trimmedItem);
                Console.WriteLine($"[INFO] '{trimmedItem}' is Recyclable and placed in the Recycling bin.");
            }
            else if (nonRecyclable.Contains(trimmedItem))
            {
                nonRecyclableList.Add(trimmedItem);
                Console.WriteLine($"[INFO] '{trimmedItem}' is Non-Recyclable and placed in the Non-Recyclable bin.");
            }
            else
            {
                nonRecyclableList.Add(trimmedItem); // Default to non-recyclable
                Console.WriteLine($"[WARNING] '{trimmedItem}' is Unrecognized and placed in the Non-Recyclable bin by default.");
            }
        }

        // Summary of segregated waste
        Console.WriteLine("\n--- Waste Segregation Summary ---");
        Console.WriteLine($"Biodegradable Waste: {string.Join(", ", biodegradableList)}");
        Console.WriteLine($"Recyclable Waste: {string.Join(", ", recyclableList)}");
        Console.WriteLine($"Non-Recyclable Waste: {string.Join(", ", nonRecyclableList)}");

        Console.WriteLine("\nThank you for segregating your waste properly!");
    }
}
