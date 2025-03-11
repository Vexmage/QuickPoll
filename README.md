# QuickPoll 🗳

### A simple polling app built with ASP.NET Core MVC, Entity Framework Core, and SQLite.

### Getting Started

## Ensure you have the following installed:

-    .NET SDK 7.0+ 
-    Visual Studio (or VS Code with C# Extension)
-    Git (for cloning the repository)

## Installation & Setup
- Clone the Repository

- git clone https://github.com/Vexmage/QuickPoll.git
- cd QuickPoll

## Set Up the Project
- Create the .sln file and add the project to it:

- dotnet new sln -n QuickPoll
- dotnet sln add QuickPoll.csproj

## Install Dependencies
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet add package Microsoft.EntityFrameworkCore.Tools

## Apply Database Migrations
- dotnet ef migrations add InitialCreate
- dotnet ef database update

## Run the Application
- dotnet run

## Troubleshooting
Common Issues & Fixes

- ❌ "dotnet ef" command not found
- ✅ Install the EF Core CLI tool:

- dotnet tool install --global dotnet-ef

- ❌ "SQLite Error: Table Polls already exists"
- ✅ Delete the existing database and recreate it:

- rm polls.db
- dotnet ef database update

## License

This project is open-source and free to use.

## Contributors

Created by Joel Southall & Open-Source Contributors.
