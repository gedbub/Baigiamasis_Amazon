using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    public class BaseTest
    {
        private const string BaseUrl = "https://www.amazon.com";

        [SetUp]
        public void SetUp()
        {
            Driver.InitializeDriver();
            Driver.OpenPage(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotFilePath = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(screenshotFilePath);
            }
            Driver.ShutdownDriver();
        }
    }
}
