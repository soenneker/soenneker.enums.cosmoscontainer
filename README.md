[![](https://img.shields.io/nuget/v/Soenneker.Enums.CosmosContainer.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.CosmosContainer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.cosmoscontainer/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.cosmoscontainer/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Enums.CosmosContainer.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Enums.CosmosContainer/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.cosmoscontainer/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.cosmoscontainer/actions/workflows/codeql.yml)

# Soenneker.Enums.CosmosContainer

A SmartEnum base for defining an application's Azure Cosmos DB container names in one strongly typed place.

## Install

```bash
dotnet add package Soenneker.Enums.CosmosContainer
```

## Define containers

```csharp
using Soenneker.Enums.CosmosContainer;

public sealed class AppContainer : CosmosContainer<AppContainer>
{
    public static readonly AppContainer Users = new("users", 1);
    public static readonly AppContainer Orders = new("orders", 2);

    private AppContainer(string name, int value) : base(name, value)
    {
    }
}
```

The self-referential generic argument is required: `AppContainer` derives from `CosmosContainer<AppContainer>`. This allows the underlying SmartEnum implementation to discover the concrete type's static values.

## Usage

```csharp
string containerName = AppContainer.Users; // implicit conversion returns "users"

AppContainer parsed = AppContainer.FromName("orders");

foreach (AppContainer container in AppContainer.List)
    Console.WriteLine($"{container.Value}: {container.Name}");
```

Use unique integer values. Lowercase plural names such as `users` and `orders` are the repository convention because `Name` is typically passed to Cosmos DB as the physical container name; the base class does not enforce that convention or create containers.

`FromName` and `FromValue` throw when no match exists. Use the corresponding `TryFromName` or `TryFromValue` APIs when parsing configuration or other external input.
