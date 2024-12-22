using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Enums.CosmosContainer.Tests;

[Collection("Collection")]
public class CosmosContainerTests : FixturedUnitTest
{
    public CosmosContainerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
