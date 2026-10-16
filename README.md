# Blazor Server DataGrid EF Core CRUD

## Overview

This sample demonstrates how to perform Create, Read, Update, and Delete (CRUD) operations in the Syncfusion [Blazor DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid) using Entity Framework Core, SQL Server, and Web API. The application retrieves data from a SQL Server database, exposes data-access operations through API endpoints, and synchronizes changes between the DataGrid and the database. The sample serves as a reference implementation for developers building data-driven Blazor applications that require persistent storage and full CRUD functionality.

## Key Features

- Integrates Syncfusion Blazor DataGrid with SQL Server using Entity Framework Core.
- Demonstrates Create, Read, Update, and Delete operations against a database table.
- Uses Entity Framework Core as the data access layer for database communication.
- Uses Web API endpoints to handle DataGrid data operations.
- Persists DataGrid changes directly to SQL Server instead of using local collections.
- Demonstrates adding new records and saving them to the database.
- Demonstrates editing existing records and updating the corresponding database entries.
- Demonstrates deleting records and removing them from the database.
- Includes SQL scripts required to create and configure the sample database.
- Provides sample implementations targeting multiple .NET versions through separate project folders.

## Prerequisites

- SQL Server
- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download the repository.
2. Create the required SQL Server database using the scripts available in the `SQL Script` folder.
3. Open the appropriate solution from:
   - `NET5/LibraryManagement`
   - `NET6/LibraryManagement`
   - `BlazorWebApp`
4. Update the database connection string in the application configuration file.
5. Restore all NuGet packages.
6. Set the appropriate startup project if required.
7. Build the solution.
8. Run the application using `Ctrl+F5`.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the desired project directory.

```bash
cd NET6/LibraryManagement
dotnet restore
dotnet run
```

4. Open the local URL displayed in the terminal after the application starts.

## Project Structure

- `NET5/LibraryManagement/` — contains the .NET 5 implementation of the DataGrid CRUD application using Entity Framework Core.
- `NET6/LibraryManagement/` — contains the .NET 6 implementation of the DataGrid CRUD application using Entity Framework Core.
- `BlazorWebApp/` — contains the Blazor application implementation used by the sample.
- `SQL Script/` — contains SQL scripts required to create and initialize the sample database.
- `Pages/` — contains the Blazor pages that host the Syncfusion DataGrid and perform CRUD operations.
- `Controllers/` — contains Web API controllers responsible for processing DataGrid requests and communicating with Entity Framework Core.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For feature documentation, see the Syncfusion Blazor DataGrid Entity Framework Core documentation: https://help.syncfusion.com/grid-sdk/blazor/data-grid/connecting-to-orm/entityframework

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
