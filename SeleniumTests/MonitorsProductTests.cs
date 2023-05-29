using NUnit.Framework;
using SeleniumFramework.Amazon;

namespace SeleniumTests
{
    public class ProductMonitorsTest : BaseTest
    {
        [Test]
        public void VerifyMonitorsProductDetailsPage()
        {
            MonitorsProduct.OpenMenuAll();
            MonitorsProduct.ExpandMenuComputers();
            MonitorsProduct.ExpandMenuMonitors();
            MonitorsProduct.SelectFirstProduct();

            Assert.IsTrue(MonitorsProduct.IsPageElementVisible());
        }
    }
}