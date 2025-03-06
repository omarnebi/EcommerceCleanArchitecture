# EcommerceCleanArchitecture

A clean architecture-based e-commerce web API built with .NET 8, Entity Framework Core, and SQL Server.

## Features

- Manage products (CRUD operations).
- Built with Clean Architecture principles.
- Uses Entity Framework Core for database management.
- Swagger for API documentation and testing.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

1. Clone the repository:

   ```bash
   git clone https://github.com/ton-utilisateur/EcommerceCleanArchitecture.git

2.Configure the database:

 .Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=TON_SERVEUR_SQL;Database=EcommerceCleanArchitectureDb;User Id=TON_UTILISATEUR;Password=TON_MOT_DE_PASSE;TrustServerCertificate=True;"
}

3.Apply migrations:



dotnet ef database update --project EcommerceCleanArchitecture.Infrastructure --startup-project EcommerceCleanArchitecture.Presentation

## Project Structure
-Domain: Contains the core entities and business rules.

-Application: Contains the business logic and use cases.

-Infrastructure: Manages database and external services.

-Presentation: Contains the Web API.