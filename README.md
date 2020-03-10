# My first .NET Core Entity Framework Application
This app is development with .NET Core 3.1 Entity Framework
## Steps to install this proyect
* Go to the [.NET Core 3.1 Download page](http://aka.ms/dotnet-download) to download and install the SDK to your system.
* Go to the [.NET Core Entity Framework page](https://www.nuget.org/packages/dotnet-ef) to download and install the NuGet Package to your system.
* Clone this repo with this command:
    ```bash
    git clone https://github.com/ChristianGrimberg/dotnet-movies.git
    ```
## Build this project yourself
* Create a .NetCore Console App like `Movies`:
    ```bash
    dotnet new console -n Movies
    ```
* Follow this steps to add packages references preloaded in this proyect under `Movies/` directory:
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