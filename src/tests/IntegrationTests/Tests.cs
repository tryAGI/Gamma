namespace Gamma.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GammaClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GAMMA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GAMMA_API_KEY environment variable is not found.");

        var client = new GammaClient(apiKey);
        
        return client;
    }
}
