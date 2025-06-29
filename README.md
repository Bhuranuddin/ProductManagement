//README.md

# Product Management project

A scalable RESTful API built with ASP.NET Core for managing products with unique 6-digit product numbers.

# Features
- CRUD operations for products
- Unique 6-digit ProductNumber generated on the server
- Increment/Decrement stock APIs (return updated stock in response)
- EF Core Code-First migrations
- Uses SQL Server LocalDB by default
- Unit tests using xUnit and EF InMemory
- 
# Tech Stack
- ASP.NET Core Web API (.NET 8)
- Entity Framework Core
- SQL Server LocalDB
- xUnit for Unit Testing

# Product Fields
| Field            | Description                     |
|------------------|----------------------------------|
| ProductNumber     | Unique 6-digit server-generated |
| Name              | Required                         |
| Description       | Optional                         |
| Category          | Optional                         |
| Price             | Decimal                          |
| StockAvailable    | Integer                          |

# API Endpoints
| Method | Route                                             | Description                            |
|--------|---------------------------------------------------|----------------------------------------|
| GET    | /api/products                                     | List all products                      |
| GET    | /api/products/{id}                                | Get product by ID                      |
| POST   | /api/products                                     | Create new product                     |
| PUT    | /api/products/{id}                                | Update product                         |
| DELETE | /api/products/{id}                                | Delete product                         |
| PUT    | /api/products/decrement-stock/{id}/{quantity}     | Decrement stock, returns updated stock |
| PUT    | /api/products/add-to-stock/{id}/{quantity}        | Add to stock, returns updated stock    |

# Setup Instructions

# Prerequisites
- .NET 8 SDK
- Visual Studio 2022+
- SQL Server LocalDB (or update the connection string)

# Getting Started
1. Clone the repo
2. Open the solution in Visual Studio
3. In Package Manager Console:
    
    --Add-Migration InitialCreate
    --Update-Database
    
4. Press F5 to launch and see the localhost port

# Note if needed
Please run EF Core Migrations
// Command:
// > Add-Migration InitialCreate
// > Update-Database

# Sample Request
# Create Product (POST /api/products)
# http://localhost:<port_number_>/api/products

{
  "name": "Monitor",
  "description": "27-inch 4K UHD",
  "price": 249.99,
  "stockAvailable": 50
}


# Sample Response for Stock Update
# PUT http://localhost:<port_number_>/api/products/add-to-stock/1/100
Response
150


# Global Error Handling
- Unhandled exceptions are caught and returned as JSON:
{
  "status": 500,
  "message": "An unexpected error occurred. Please try again later."
}


# Unit Testing

# Framework: xUnit
- Project: ProductManagementUnitTest.Tests
- Uses Microsoft.EntityFrameworkCore.InMemory

# Sample Tests
| Test Class                | Description                              |
|--------------------------|------------------------------------------|
| ProductIdGeneratorTests  | Validates unique 6-digit generation logic|
| ProductsControllerTests  | Ensures product creation logic works     |

# Run Tests
- Open Test Explorer in Visual Studio
- Click Run All Tests