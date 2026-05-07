# Getting Started with Blazor Grid

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-512BD4?style=flat-square&logo=blazor&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Syncfusion Grid](https://img.shields.io/badge/Syncfusion-Grid%20v24.1-6E3FA3?style=flat-square)](https://www.syncfusion.com/blazor-components/blazor-datagrid)
[![License](https://img.shields.io/badge/License-MIT-yellow?style=flat-square)](LICENSE)

A modern, full-stack .NET 8 Blazor application demonstrating essential data grid features using the [Syncfusion Grid component](https://www.syncfusion.com/blazor-components/blazor-datagrid). This project showcases best practices for building interactive, data-driven web applications with Blazor.

## Overview

This sample application provides a practical introduction to building rich, interactive user interfaces with Blazor and Syncfusion components. It demonstrates:

- **Interactive Data Grids**: Display and manage tabular data with pagination, sorting, and filtering
- **Full-Stack Blazor**: Server and WebAssembly interoperability for optimal performance
- **Component-Based Architecture**: Modular, reusable Razor components
- **.NET 8 Latest Features**: Leveraging the latest framework capabilities

The application includes sample order data with realistic information, making it easy to explore grid features immediately after running the project.

## Features

- **Pagination**: Browse large datasets efficiently with configurable page sizes
- **Sorting**: Sort columns in ascending or descending order
- **Filtering**: Apply filters to find specific records
- **Grouping**: Organize data by column values
- **Responsive Design**: Works seamlessly on desktop and mobile devices
- **Server + WebAssembly Integration**: Combines the benefits of both rendering modes

## Technology Stack

| Technology | Version | Purpose |
|---|---|---|
| **.NET** | 8.0 | Runtime and framework |
| **Blazor** | 8.0 | Web framework (Server + WebAssembly) |
| **Syncfusion Grid** | 24.1.45 | Data grid component |
| **C#** | 12 | Primary language |

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) (v17.0 or later) with the ASP.NET and web development workload, or
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) with your preferred code editor

> [!TIP]
> You can develop with Visual Studio Code or Rider as well. Just ensure you have the .NET 8 SDK installed.

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/yourusername/getting-started-blazor-grid.git
cd getting-started-blazor-grid
```

### Run with Visual Studio

1. Open `GettingStartedSample.sln` in Visual Studio 2022
2. The solution will automatically restore NuGet packages
3. Press `F5` or select **Debug** → **Start Debugging**
4. The application will open in your default browser at `https://localhost:7123`

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the application
dotnet run --project GettingStartedSample/GettingStartedSample.csproj
```

The application will be available at `https://localhost:7123`.

## Project Structure

```
GettingStartedSample.sln
├── GettingStartedSample/                 # Server project
│   ├── Components/
│   │   ├── Pages/
│   │   │   ├── Home.razor                # Home page
│   │   │   ├── Weather.razor             # Weather example
│   │   │   └── Error.razor               # Error handling
│   │   ├── Layout/                       # Layout components
│   │   ├── App.razor                     # Root component
│   │   └── Routes.razor                  # Route definitions
│   ├── Program.cs                        # Server configuration
│   └── appsettings.json                  # Configuration
│
└── GettingStartedSample.Client/          # WebAssembly client project
    ├── Pages/
    │   └── Counter.razor                 # Data grid example with Syncfusion
    ├── Program.cs                        # Client configuration
    └── wwwroot/                          # Static assets
```

## Key Components

### Data Grid Component (`Counter.razor`)

The main feature of this application is the interactive data grid in the Counter page:

```csharp
<SfGrid DataSource="@Orders" AllowPaging="true" AllowSorting="true" 
        AllowFiltering="true" AllowGrouping="true">
    <GridPageSettings PageSize="5"></GridPageSettings>
    <GridColumns>
        <GridColumn Field=@nameof(Order.OrderID) HeaderText="Order ID" 
                    TextAlign="TextAlign.Right" Width="120"></GridColumn>
        <GridColumn Field=@nameof(Order.CustomerID) HeaderText="Customer Name" 
                    Width="150"></GridColumn>
        <GridColumn Field=@nameof(Order.OrderDate) HeaderText="Order Date" 
                    Format="d" Type="ColumnType.Date" Width="130"></GridColumn>
        <GridColumn Field=@nameof(Order.Freight) HeaderText="Freight" 
                    Format="C2" Width="120"></GridColumn>
    </GridColumns>
</SfGrid>
```

The grid displays 75 sample orders with the following capabilities:
- **Pagination**: 5 rows per page
- **Sorting**: Click column headers to sort
- **Filtering**: Built-in filter bar
- **Grouping**: Organize by any column

## Configuration

### Application Settings

Key configuration files:

- `GettingStartedSample/appsettings.json` - Server-side settings
- `GettingStartedSample.Client/wwwroot/appsettings.json` - Client-side settings

### Syncfusion License

This project uses Syncfusion components. Ensure you have an appropriate license or are using the community license (free for companies with less than $1 million in annual gross revenue).

> [!NOTE]
> Syncfusion components are fully functional in trial mode for development purposes.

## Debugging

### With Visual Studio

1. Set breakpoints in your code
2. Press `F5` to start debugging
3. The debugger will break at set breakpoints
4. Use the Debug toolbar to step through code

### Browser DevTools

- Press `F12` in your browser to open Developer Tools
- Use the **Network** tab to inspect HTTP requests
- Use the **Console** tab for JavaScript debugging

## Performance Tips

- **Lazy Loading**: Implement data virtualization for large datasets
- **Caching**: Use browser caching for static assets
- **Code Splitting**: Leverage WebAssembly's module system for better bundle optimization
- **Compression**: Enable gzip compression on the server

## Troubleshooting

### Port Already in Use

If port 7123 is already in use:

```bash
dotnet run --project GettingStartedSample/GettingStartedSample.csproj --urls=https://localhost:5000
```

### NuGet Package Restore Issues

```bash
# Clear NuGet cache
dotnet nuget locals all --clear

# Restore packages
dotnet restore
```

### SSL Certificate Issues

If you encounter SSL errors during development:

```bash
# Trust the development certificate
dotnet dev-certs https --trust
```

## Building for Production

```bash
# Publish to a release folder
dotnet publish -c Release -o ./publish

# The published files will be in the ./publish directory
```

## Next Steps

- Explore the [Syncfusion Blazor Grid documentation](https://www.syncfusion.com/documentation/blazor/grid/getting-started/)
- Try adding [more Syncfusion components](https://www.syncfusion.com/blazor-components)
- Implement [server-side data binding](https://www.syncfusion.com/documentation/blazor/grid/data-binding/)
- Add [custom templates](https://www.syncfusion.com/documentation/blazor/grid/templates/) for specialized rendering

## Additional Resources

- [Microsoft Blazor Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [.NET 8 Release Notes](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
- [Syncfusion Blazor Components](https://www.syncfusion.com/blazor-components)
- [C# 12 Features](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)

## Common Issues Reference

| Issue | Solution |
|-------|----------|
| Port 7123 already in use | Use `--urls` parameter to specify a different port |
| SSL certificate errors | Run `dotnet dev-certs https --trust` |
| Components not rendering | Ensure JavaScript interop files are loaded in `App.razor` |
| Grid data not displaying | Verify `DataSource` property is correctly bound |
