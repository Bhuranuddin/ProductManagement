// Full Implementation Summary + README

// ----------------------------
// ✅ What We Did: Full Summary
// ----------------------------

// 🎯 Objective: Build a scalable RESTful API using ASP.NET Core to manage Products with:
// - Unique 6-digit Product Numbers (generated server-side)
// - Stock increment/decrement operations
// - Entity Framework Core (Code-First)
// - 7 endpoints
// - Scalability and uniqueness of Product ID ensured

// ----------------------------
// 1. Created ASP.NET Core Web API Project (ProductApi)
// Command (CLI): dotnet new webapi -n ProductApi

// ----------------------------
// 2. Installed Required NuGet Packages:
// - Microsoft.EntityFrameworkCore.SqlServer
// - Microsoft.EntityFrameworkCore.Tools

// ----------------------------
// 3. Created Models:
// - Product.cs: Core product model with ProductNumber, Name, Price, StockAvailable, etc.
// - ProductCreateDto.cs: DTO to prevent client from sending ProductNumber
// - ProductNumberSequence.cs: Used to track the last product number for uniqueness

// ----------------------------
// 4. Created AppDbContext (DbContext class)
// - Registered with DI in Program.cs
// - Configured with connection string from appsettings.json
// - Seeded ProductNumberSequence with a default value of 99999

// ----------------------------
// 5. Created ProductIdGenerator
// - Fetches and increments the LastNumber field in ProductNumberSequence
// - Ensures unique 6-digit number generation

// ----------------------------
// 6. Created ProductsController
// - Injected AppDbContext and ProductIdGenerator
// - Implemented 7 endpoints:
//   - POST /api/products: Creates product with generated ProductNumber
//   - GET /api/products: Returns all products
//   - GET /api/products/{id}: Get by Id
//   - PUT /api/products/{id}: Update
//   - DELETE /api/products/{id}: Delete
//   - PUT /api/products/decrement-stock/{id}/{quantity}: Decrease stock and return updated stock
//   - PUT /api/products/add-to-stock/{id}/{quantity}: Add to stock and return updated stock

// ----------------------------
// 7. Added Swagger support (default in ASP.NET Core template)

// ----------------------------
// 8. Ran EF Core Migrations
// Command:
// > Add-Migration InitialCreate
// > Update-Database

// ----------------------------
// ✅ README.md

/*
# Product API (.NET Core Web API)

A scalable RESTful API built with ASP.NET Core for managing products with unique 6-digit product numbers.

## ✅ Features
- CRUD operations for products
- Unique 6-digit ProductNumber generated on the server
- Increment/Decrement stock APIs (return updated stock in response)
- EF Core Code-First migrations
- Swagger UI for API testing
- Uses SQL Server LocalDB by default

## 📁 Tech Stack
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server LocalDB
- Swagger (Swashbuckle)

## 📦 Product Fields
| Field            | Description                     |
|------------------|----------------------------------|
| ProductNumber     | Unique 6-digit server-generated |
| Name              | Required                         |
| Description       | Optional                         |
| Category          | Optional                         |
| Price             | Decimal                          |
| StockAvailable    | Integer                          |
| CreatedAt         | UTC Timestamp                    |

## 🔗 API Endpoints
| Method | Route                                             | Description                            |
|--------|---------------------------------------------------|----------------------------------------|
| GET    | /api/products                                     | List all products                      |
| GET    | /api/products/{id}                                | Get product by ID                      |
| POST   | /api/products                                     | Create new product                     |
| PUT    | /api/products/{id}                                | Update product                         |
| DELETE | /api/products/{id}                                | Delete product                         |
| PUT    | /api/products/decrement-stock/{id}/{quantity}     | Decrement stock, returns updated stock |
| PUT    | /api/products/add-to-stock/{id}/{quantity}        | Add to stock, returns updated stock    |

## 🛠️ Setup Instructions

### 🔧 Prerequisites
- .NET 8 SDK
- Visual Studio 2022+
- SQL Server LocalDB (or update the connection string)

### 🚀 Getting Started
1. Clone the repo
2. Open the solution in Visual Studio
3. In Package Manager Console:
    ```
    Add-Migration InitialCreate
    Update-Database
    ```
4. Press F5 to launch Swagger UI

### 📦 Sample Request
#### Create Product (POST /api/products)
```
{
  "name": "Monitor",
  "description": "27-inch 4K UHD",
  "category": "Electronics",
  "price": 249.99,
  "stockAvailable": 50
}
```

### 🔁 Sample Response for Stock Update
#### PUT /api/products/add-to-stock/1/100
```
{
  "id": 1,
  "productNumber": "100001",
  "name": "Monitor",
  "stockAvailable": 150,
  ...
}
```

## ✅ Self Checklist
- [x] REST endpoints implemented
- [x] Unique 6-digit ID generation
- [x] Code-First migrations
- [x] DTO used for clean validation
- [x] Scalable ID logic (DB-seeded)
- [x] Swagger testing enabled
- [x] Clean code with separation of concerns
- [x] Validated using Swagger and Postman

## 🧪 To Do (Optional Enhancements)
- Add unit tests using xUnit
- Add pagination to product list
- Add Redis-based ID generation for distributed scaling
- Add Docker support
*/
