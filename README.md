# My first .NET Core Entity Framework Application

[![.NET Entity Framework Core Build, Test, Publish and Run application](https://github.com/ChristianGrimberg/dotnet-ef-movies/actions/workflows/dotnet-ef-core-actions.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/dotnet-ef-movies/actions/workflows/dotnet-ef-core-actions.yml)

This app is development with .NET Entity Framework Core 5

## Work with this proyect in a Docker Container

* Pull this image directly from DockerHub:
    ```bash
    docker pull csgrimberg/dotnet-ef-movies:latest
    ```

* Run the container with this example:
    ```bash
    docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=_YourStrongPassword1234' -e 'MSSQL_PID=Express' -p 0.0.0.0:1433:1433 -e 'TIMEOUT=60' --name dotnet-ef-movies csgrimberg/dotnet-ef-movies:latest
    ```

* Run the application with this command in a new terminal after SQL Server started:
    ```bash
    docker exec -it dotnet-ef-movies dotnet /movies/movies.dll
    ```

## Steps to install this proyect

* Go to the [.NET 5 download page](http://aka.ms/dotnet-download) to download and install the SDK to your system.
* Go to the [.NET Entity Framework Core page](https://www.nuget.org/packages/dotnet-ef) to download and install the NuGet Package to your system with this command:
    ```bash
    dotnet tool install --global dotnet-ef --version 5.0.4
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

* Follow this steps to add Entity Framework Core packages references preloaded in this proyect under `movies/` directory:
    ```bash
    # Add the .NET Core Entity Framework package
    dotnet add movies package Microsoft.EntityFrameworkCore
    # Add the .NET Core Entity Framework SQL Server Provider
    dotnet add movies package Microsoft.EntityFrameworkCore.SqlServer
    # Add the .NET Core Entity Framework SDK Design references
    dotnet add movies package Microsoft.EntityFrameworkCore.Design
    # Add the .NET Core Entity Framework Powershell Tools
    dotnet add movies package Microsoft.EntityFrameworkCore.Tools
    ```

* Optional, you can add support to Configuration Files with Nuget:
    ```bash
    dotnet add movies package Microsoft.Extensions.Configuration
    dotnet add movies package Microsoft.Extensions.Configuration.FileExtensions
    dotnet add movies package Microsoft.Extensions.Configuration.Json
    ```

* Know about the DbContext implementation:
    ```bash
    dotnet ef --project movies dbcontext info
    ```

* Migrate the CodeFirst Model to implement the database context
    ```bash
    # Create a snapshot Migration model for the Database
    dotnet ef --project movies migrations add Initial
    # Optional to check the migrations snapshots created
    dotnet ef --project movies migrations list
    # To migrate the model to the database
    dotnet ef --project movies database update -v
    # If you need to re-create this model, remove the snapshot first
    dotnet ef --project movies migrations remove -f
    ```
