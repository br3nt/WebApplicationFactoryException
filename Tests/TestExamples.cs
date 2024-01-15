using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests;

public class TestExamplesProgram : Program { }

public class TestExamples : IClassFixture<WebApplicationFactory<TestExamplesProgram>>
{
    private WebApplicationFactory<TestExamplesProgram> Factory { get; }

    public TestExamples(WebApplicationFactory<TestExamplesProgram> factory)
    {
        Factory = factory;
    }

    [Fact]
    public async Task ExampleTestWithException()
    {

        try
        {
            var client = Factory.CreateClient(); // exception raised here
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}