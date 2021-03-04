# My first .NET Core Entity Framework Application
[![.NET Entity Framework Core Build, Test, Publish and Run application](https://github.com/ChristianGrimberg/dotnet-ef-movies/actions/workflows/dotnet-ef-core-actions.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/dotnet-ef-movies/actions/workflows/dotnet-ef-core-actions.yml)

This app is development with .NET Entity Framework Core 5
## Steps to install this proyect
* Go to the [.NET 5 download page](http://aka.ms/dotnet-download) to download and install the SDK to your system.
* Go to the [.NET Entity Framework Core page](https://www.nuget.org/packages/dotnet-ef) to download and install the NuGet Package to your system with this command:
    ```bash
    dotnet tool install --global dotnet-ef --version 5.0.3
    ```
* Clone this repo with this command:
    ```bash
    git clone git@github.com:ChristianGrimberg/dotnet-ef-movies.git
    ```
## Build this project yourself
* Create a .NetCore Console App like `movies`:
    ```bash
    dotnet new console -n movies
    dotnet new sln
    dotnet sln add movies
    ```
* Follow this steps to add packages references preloaded in this proyect under `movies/` directory:
    ```bash
    # Add the .NET Core Entity Framework package
    dotnet add package Microsoft.EntityFrameworkCore
    # Add the .NET Core Entity Framework SQL Server Provider
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    # Add the .NET Core Entity Framework SDK Design references
    dotnet add package Microsoft.EntityFrameworkCore.Design
    # Add the .NET Core Entity Framework Powershell Tools
    dotnet add package Microsoft.EntityFrameworkCore.Tools
    ```
* Know about the DbContext implementation:
    ```bash
    dotnet ef dbcontext info
    ```
* Migrate the CodeFirst Model to implement the database context
    ```bash
    # Create a snapshot Migration model for the Database
    dotnet ef migrations add Initial
    # Optional to check the migrations snapshots created
    dotnet ef migrations list
    # To migrate the model to the database
    dotnet ef database update -v
    # If you need to re-create this model, remove the snapshot first
    dotnet ef migrations remove -f
    ```
