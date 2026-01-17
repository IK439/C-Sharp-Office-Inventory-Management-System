using System;
using System.Collections.Generic;
using System.Text;

public class InventoryManagement
{
    public static void Main(string[] args)
    {
        // Initialize the inventory list with some items
        List<string> inventoryList = new List<string> { "Printer", "Laptop", "Desk Chair", "Monitor", "Keyboard" };

        // Display the current inventory
        DisplayInventory(inventoryList);

        // Print total number of items
        Console.WriteLine($"\nTotal number of items in Inventory List: {inventoryList.Count}");

        // Check if "Desk Chair" exists in inventory
        bool hasDeskChair = inventoryList.Contains("Desk Chair");
        Console.WriteLine($"\nInventory List has Desk Chair: {hasDeskChair}");

        // Remove "Printer" from inventory
        bool removed = inventoryList.Remove("Printer");
        Console.WriteLine($"\nPrinter was removed from Inventory List: {removed}");

        Console.WriteLine();
        DisplayInventory(inventoryList);

        // Add new items to the inventory
        List<string> newItems = new List<string> { "Mouse", "Desk Lamp" };
        inventoryList.AddRange(newItems);

        Console.WriteLine();
        DisplayInventory(inventoryList);

        // Safely remove the last two items if the list has enough items
        int removeStart = 4;
        int removeCount = Math.Min(2, inventoryList.Count - removeStart);
        if (removeCount > 0) inventoryList.RemoveRange(removeStart, removeCount);

        // Get top 3 items from inventory safely
        int topCount = Math.Min(3, inventoryList.Count);
        List<string> topInventory = inventoryList.GetRange(0, topCount);

        // Display top inventory items
        DisplayTopInventory(topInventory);
    }

    // Display all items in the inventory
    private static void DisplayInventory(List<string> inventory)
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine("Inventory List:");
        foreach (string item in inventory)
        {
            output.AppendLine("- " + item);
        }
        Console.Write(output.ToString());
    }

    // Display the top items from the inventory
    private static void DisplayTopInventory(List<string> topInventory)
    {
        StringBuilder output = new StringBuilder();
        output.AppendLine("\nTop Inventory:");
        foreach (string item in topInventory)
        {
            output.AppendLine("- " + item);
        }
        Console.Write(output.ToString());
    }
}