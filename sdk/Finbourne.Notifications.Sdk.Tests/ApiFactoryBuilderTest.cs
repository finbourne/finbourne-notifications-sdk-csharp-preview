using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Finbourne.Notifications.Sdk.Extensions;
using Moq;
using NUnit.Framework;

namespace Finbourne.Notifications.Sdk.Tests
{
    [TestFixture]
    public class ApiFactoryBuilderTest
    {
        private string _secretsFile;
        [OneTimeSetUp]
        public void CreateDummySecretsFile()
        {
            _secretsFile = Path.GetTempFileName();
            var secrets = new Dictionary<string, object>
            {
                ["api"] = new Dictionary<string, string>()
                {
                    {"baseUrl", "https://sub-domain.lusid.com/api"},
                    {"tokenUrl", "https://sub-domain.okta.com/oauth2/abcd123/v1/token"},
                    {"clientId", "<clientId>"},
                    {"clientSecret", "<clientSecret>"},
                    {"applicationName", "<applicationName>"},                    
                    {"username", "<username>"},
                    {"password", "<password>"},                    
                }
            };
            var json = JsonSerializer.Serialize(secrets);
            File.WriteAllText(_secretsFile, json);
        }

        [Test]
        public void Build_From_Secrets_Returns_NonNull_ApiFactory()
        {
            var apiConfig = ApiConfigurationBuilder.Build(_secretsFile);
            
            // Empty out ApiFactory.ApiTypes to avoid request being made to bogus tokenUrl
            var apiFactory = new ApiFactory(apiConfig, apiTypes: Enumerable.Empty<Type>());
            
            Assert.IsNotNull(apiFactory);
        }

        //Test requires [assembly: InternalsVisibleTo("Finbourne.Notifications.Sdk.Tests")] in ClientCredentialsFlowTokenProvider
        [Test]
        public void Build_From_Configuration_Returns_NonNull_ApiFactory()
        {
            // Mock token provider to avoid request being made to bogus tokenUrl
            var tokenProvider = new Mock<ClientCredentialsFlowTokenProvider>(ApiConfigurationBuilder.Build(_secretsFile));
            tokenProvider
                .As<ITokenProvider>()
                .Setup(x => x.GetAuthenticationTokenAsync())
                .ReturnsAsync("{{ \"access_token\", \"token\"},{ \"expires_in\", \"30\"}}");
            
            var config = new TokenProviderConfiguration(tokenProvider.Object)
            {
                BasePath = "base path"
            };
            var apiFactory = new ApiFactory(config);
            Assert.IsNotNull(apiFactory);
        }
    }
}
