using Soenneker.Tests.HostedUnit;

namespace Soenneker.Enums.CosmosContainer.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CosmosContainerTests : HostedUnitTest
{
    public CosmosContainerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
