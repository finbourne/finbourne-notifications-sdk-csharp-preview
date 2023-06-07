using System.IO;
using Finbourne.Notifications.Sdk.Extensions;

namespace Finbourne.Notifications.Sdk.IntegrationTests
{
    public class IntegrationTestApiFactoryBuilder
    {
        public static IApiFactory CreateApiFactory(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiFactoryBuilder.Build(secretsFile)
                : ApiFactoryBuilder.Build(null);
        }

        public static ApiConfiguration CreateApiConfiguration(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiConfigurationBuilder.Build(secretsFile)
                : ApiConfigurationBuilder.Build(null);
        }
    }
}
