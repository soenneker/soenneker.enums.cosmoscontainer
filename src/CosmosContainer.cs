using Ardalis.SmartEnum;

namespace Soenneker.Enums.CosmosContainer;

/// <summary>
/// An abstract enum type for using with Azure Cosmos database utilities <para/>
/// Obviously this is meant to be derived. Values should be plural and lowercase.
/// </summary>
public abstract class CosmosContainer : SmartEnum<CosmosContainer>
{
    protected CosmosContainer(string name, int value) : base(name, value)
    {
    }
}