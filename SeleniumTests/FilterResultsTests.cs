using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class FilterResultsTests : BaseTest
    {
        [Test]
        public void VerifyFilterResults()
        {
            FilterResults.ClickDontChangeButton();
            FilterResults.ClickGiftCardsLink();
            FilterResults.ClickAmazonGiftCardsFilter();
            Assert.IsTrue(FilterResults.VerifyResultsDisplayed());
        }
    }
}
