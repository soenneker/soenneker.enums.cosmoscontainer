using Soenneker.Tests.HostedUnit;
using System.Linq;
using System.Threading.Tasks;

namespace Soenneker.Enums.CosmosContainer.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CosmosContainerTests : HostedUnitTest
{
    public CosmosContainerTests(Host host) : base(host)
    {
    }

    [Test]
    public async Task Derived_values_participate_in_lookup()
    {
        TestContainer users = TestContainer.Users;

        await Assert.That(users.Name).IsEqualTo("users");
        await Assert.That(TestContainer.List.Any(value => value.Name == "users")).IsTrue();
        await Assert.That(TestContainer.FromName("users")).IsEqualTo(TestContainer.Users);
    }

    private sealed class TestContainer : CosmosContainer<TestContainer>
    {
        public static readonly TestContainer Users = new("users", 1);

        private TestContainer(string name, int value) : base(name, value)
        {
        }
    }
}
