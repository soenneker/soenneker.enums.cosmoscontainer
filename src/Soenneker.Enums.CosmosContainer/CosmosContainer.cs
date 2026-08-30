using Soenneker.SmartEnum.Named;

namespace Soenneker.Enums.CosmosContainer;

/// <summary>
/// Base class for application-defined Azure Cosmos DB container names.
/// </summary>
/// <typeparam name="TContainer">The concrete container type.</typeparam>
public abstract class CosmosContainer<TContainer> : NamedSmartEnum<TContainer> where TContainer : CosmosContainer<TContainer>
{
    protected CosmosContainer(string name, int value) : base(name, value)
    {
    }
}
