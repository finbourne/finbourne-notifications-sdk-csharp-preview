using Finbourne.Notifications.Sdk.Extensions;
using NUnit.Framework;

namespace Finbourne.Notifications.Sdk.Tests
{
    [TestFixture]
    public class MissingConfigExceptionTest
    {
        [Test]
        public void Construct_Check_Message()
        {
            var cfgEx = new MissingConfigException("missing-config-exception");
            Assert.AreEqual("missing-config-exception", cfgEx.Message);
        }
    }
}
