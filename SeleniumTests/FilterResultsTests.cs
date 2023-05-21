using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class FilterResultsTests : BaseTest
    {
        private SeleniumFramework.Pages.FilterResultsPage filterResultsPage;

        [SetUp]
        public void Setup()
        {
            filterResultsPage = new SeleniumFramework.Pages.FilterResultsPage();
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
