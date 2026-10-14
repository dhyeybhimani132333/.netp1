# Inventory Management Module - ADO.NET + SQLite + ASP.NET Core MVC (.NET 8)

A complete Inventory Management CRUD application for Visual Studio 2022.

## Technology
- ASP.NET Core MVC (.NET 8)
- ADO.NET using `Microsoft.Data.Sqlite`
- SQLite local database
- Bootstrap 5
- Razor Views

## No SQL Server Required
This version does **not** require SQL Server, SQL Server Express, or LocalDB.
When the application starts, it automatically creates `inventory.db`, creates the `Products` table, and inserts sample products if the table is empty.

## Run in Visual Studio 2022
1. Extract the ZIP.
2. Open `InventoryManagement.csproj` in Visual Studio 2022.
3. Restore NuGet packages.
4. Press `Ctrl + F5` or click Run.
5. The application automatically creates `inventory.db` in the project folder.

## CRUD Operations
- Create/Add Product
- Read/View Products
- Update/Edit Product
- Delete Product
- Search Products

## Product Fields
- ProductId
- ProductName
- Category
- Price
- Quantity
- Supplier

## Important
`inventory.db` is generated automatically. You do not need to create a database manually.
