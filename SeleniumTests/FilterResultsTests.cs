using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class FilterResultsTests : BaseTest
    {
        private FilterResultsPage filterResultsPage;

        [SetUp]
        public void Setup()
        {
            filterResultsPage = new FilterResultsPage();
        }

        [Test]
        public void VerifyFilterResults()
        {
            filterResultsPage.ClickDontChangeButton();
            filterResultsPage.ClickGiftCardsLink();
            filterResultsPage.ClickAmazonGiftCardsFilter();
            Assert.IsTrue(filterResultsPage.VerifyResultsDisplayed());
        }
    }
}
