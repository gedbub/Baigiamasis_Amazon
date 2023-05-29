using NUnit.Framework;
using SeleniumFramework.Amazon;

namespace SeleniumTests
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
