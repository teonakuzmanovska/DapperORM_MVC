# DapperORM_MVC
This is an ASP.NET MVC application that demonstrates the usage of Dapper for data access without Entity Framework.

## Overview
The application showcases how to perform CRUD operations using Dapper as the data access technology. It includes examples of using Dapper in a layered architecture, with separate components for data access, services, and controllers.

## Features
- Table creations using Dapper
- Creating categories, products and orders using Dapper
- Listing products using Dapper
- Integration with Dapper for database access

## Prerequisites
- .NET Framework 7.4.2 or later
- SQL Server installed locally

## Getting Started
1. Clone the repository:

   ```shell
   git clone https://github.com/teonakuzmanovska/DapperORM_MVC.git
2. Open the solution in Visual Studio.
3. Configure the connection string in the `Web.config` file under `<connectionStrings>`:
     
   ```shell
   connectionString = "your-connection-string";
4. Create a local database on SQL Server with the database name you included in your connection string
5. Build the solution to restore NuGet packages.
6. Run the application.

## Project Structure
The project follows a standard ASP.NET MVC structure:

- `Controllers`: Contains the controllers responsible for handling user requests and invoking the appropriate service methods.
- `Models`: Contains the model classes that represent the entities and data structures used in the application.
- `Repository`: Contains the data access logic implemented using Dapper.
- `Service`: Contains the service layer that coordinates the interaction between the controllers and the repository.
- `Views`: Contains the views responsible for rendering the user interface.
  
Additionally, on application startup, the following actions are performed in the `Global.asax.cs` file:

- Database tables are created: The application automatically creates the necessary database tables if they don't exist.
- Database tables are populated: The application inserts sample data into the database tables to demonstrate the functionality.

## Usage
1. Launch the application
2. View the products on home page

## Dependencies
The project relies on the following dependencies:

- Dapper: A micro-ORM for data access that simplifies working with SQL databases.
- System.Data.SqlClient: A .NET data provider for SQL Server to interact with the database.
  
These dependencies are managed via NuGet packages and will be automatically restored when building the solution.
