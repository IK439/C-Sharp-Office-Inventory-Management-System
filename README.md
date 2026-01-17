# C-Sharp-Office-Inventory-Management-System

## Overview
This program manages a simple inventory list. It demonstrates adding, removing, and checking items in a list. The program also displays the full inventory and the top items in the inventory. It is designed to handle potential issues safely when removing or selecting items from the list.

## Coding Techniques
- **Lists (`List<T>`)**: Adding, removing, and checking items in a dynamic collection.
- **StringBuilder**: Efficiently building output for large inventories.
- **Methods**: Encapsulation of repeated functionality (`DisplayInventory`, `DisplayTopInventory`) for better readability.
- **Safe Operations**: Using `Math.Min` to avoid exceptions when getting ranges from the list.
- **String Interpolation**: Cleaner, readable output formatting.

## Example Output
```text
Inventory List:
- Printer
- Laptop
- Desk Chair
- Monitor
- Keyboard

Total number of items in Inventory List: 5

Inventory List has Desk Chair: True

Printer was removed from Inventory List: True

Inventory List:
- Laptop
- Desk Chair
- Monitor
- Keyboard

Inventory List:
- Laptop
- Desk Chair
- Monitor
- Keyboard
- Mouse
- Desk Lamp

Top Inventory:
- Laptop
- Desk Chair
- Monitor
