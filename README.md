# Employee Management System

This project is an Employee Management System web application built using ASP.NET Core and Entity Framework Core. It allows users to perform CRUD (Create, Read, Update, Delete) operations on employee records stored in a SQL Server database.

## Features

- **Create Employee**: Add new employees with details such as full name, position, salary, appraisal, birthdate, join date, and department.
- **Read Employee**: View a list of all employees with their basic details and options to view more details, edit, or delete each employee.
- **Update Employee**: Modify existing employee details including position, salary, appraisal, and department.
- **Delete Employee**: Remove employees from the system.
- **Department Management**: Maintain a list of departments and associate employees with specific departments.

## Technologies Used

- **ASP.NET Core MVC**: Framework for building web applications in C#.
- **Entity Framework Core**: Object-Relational Mapping (ORM) framework for database operations.
- **SQL Server**: Database management system used for data storage.
- **Bootstrap**: Front-end framework for responsive and mobile-first design.

## Getting Started

### Prerequisites

- .NET 5 SDK or later
- Visual Studio 2019 or Visual Studio Code

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/your-repository.git
   ## Setup Instructions

### 1. Open the solution in Visual Studio

### 2. Restore NuGet packages and build the solution

Open a terminal or command prompt and run:

```bash
dotnet restore
dotnet build
```
3. **Update the database connection string**

Update the `ConnectionStrings` section in `appsettings.json` to point to your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your-server;Database=your-database;User=your-user;Password=your-password;"
  }
}
```
4. Apply EF Core migrations to create the database schema
Open a terminal or command prompt and run:

bash
نسخ الكود
dotnet ef database update
5. Run the application
Press F5 in Visual Studio or run:

```bash
نسخ الكود
dotnet run
Project Structure
```
# Project Overview

The project follows the MVC (Model-View-Controller) pattern:

- **Controllers:** Handle incoming requests and manage application flow.
- **Models:** Define data entities such as Employee and Department.
- **Views:** Display UI and collect user input using Razor syntax.
- **Migrations:** Database schema changes using EF Core migrations.
- **wwwroot:** Static assets (CSS, JavaScript) and client-side libraries.

## Usage

- Navigate to the Employees section to view, add, edit, or delete employees.
- Use the Departments section to manage department details and associations with employees.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your improvements.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments

- Hat tip to anyone whose code was used.
- Inspiration, etc.

## Setup Instructions

Ensure to replace placeholders like `your-server`, `your-database`, `your-user`, `your-password` with your actual database connection details.
