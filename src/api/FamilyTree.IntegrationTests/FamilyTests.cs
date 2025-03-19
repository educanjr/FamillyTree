using System.Net;

namespace FamilyTree.IntegrationTests;

public class FamilyTests : BaseIntegrationTest
{
    public FamilyTests(IntegrationTestWebAppFactory factory)
        : base(factory)
    {
    }

    [Fact]
    public async Task GetFamily_ShouldReturn501()
    {
        var response = await GetAsync($"api/v1/Family/{Guid.NewGuid()}");

        Assert.Equal(HttpStatusCode.NotImplemented, response.StatusCode);
    }
}
