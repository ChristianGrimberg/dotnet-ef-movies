# My first .NET Core Entity Framework Application
This app is development with .NET Core 3.1 Entity Framework
## Steps to install this proyect
* Go to the [.NET Core 3.1 Download page](http://aka.ms/dotnet-download) to download and install the SDK to your system.
* Go to the [.NET Core Entity Framework page](https://www.nuget.org/packages/dotnet-ef) to download and install the NuGet Package to your system.
* Clone this repo with this command:
    ```bash
    git clone https://github.com/ChristianGrimberg/dotnet-movies.git
    ```
* _Optional_: Follow this steps to add packages references preloaded in this proyect under `Movies/` directory:
    ```bash
    # .NET Core Entity Framework package
    dotnet add package Microsoft.EntityFrameworkCore
    # .NET Core Entity Framework SQL Server package
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    # .NET Core Entity Framework SDK Design package
    dotnet add package Microsoft.EntityFrameworkCore.Design
    ```