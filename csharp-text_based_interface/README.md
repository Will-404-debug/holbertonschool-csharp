# 📦 C# - Text-based Interface

This project is a **text-based inventory management console application** built in C#. It allows users to manage data for items, users, and their inventory records using JSON storage.

## 🛠️ Features

- Create, read, update, and delete (`CRUD`) objects
- Supports 3 object types: `Item`, `User`, and `Inventory`
- Stores data as JSON using `.NET System.Text.Json`
- Object structure supports extensibility
- Console interface for interaction

## 📂 Project Structure

```
csharp-text_based_interface/
├── InventoryManagement.sln            # Solution file
├── InventoryLibrary/                  # Class library project
│   ├── BaseClass.cs                   # Base class with common fields
│   ├── Item.cs                        # Item model
│   ├── User.cs                        # User model
│   ├── Inventory.cs                   # Inventory model
│   └── JSONStorage.cs                 # Storage manager
├── InventoryManager/                  # Console application
│   └── InventoryManager.cs            # Entry point and user interface
├── InventoryManagement.Tests/         # Unit tests (optional)
│   └── ...                            # Test files
└── storage/
    └── inventory_manager.json         # Data storage file (auto-created)
```

## 🚀 Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/will-404-debug/holbertonschool-csharp.git
cd holbertonschool-csharp/csharp-text_based_interface
```

### 2. Build the project

```bash
dotnet build
```

### 3. Run the console app

```bash
cd InventoryManager
dotnet run
```

## 🧪 Testing

You can run all unit tests (if created) from the solution directory:

```bash
dotnet test
```

## ✅ Commands in Console

```
Inventory Manager
-------------------------
ClassNames              show all ClassNames of objects
All                    show all objects
All [ClassName]        show all objects of a ClassName
Create [ClassName]     create a new object
Show [ClassName id]    show an object by ID
Delete [ClassName id]  delete an object
Exit                   quit the application
```

## 📌 Notes

- Ensure the `storage/` directory exists or will be created automatically.
- The app uses one single instance of `JSONStorage` during its runtime.
- Case-insensitive command input.

## 📄 License

This project is part of Holberton School curriculum – for learning and educational use.
