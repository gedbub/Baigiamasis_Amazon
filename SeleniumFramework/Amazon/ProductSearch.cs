using SeleniumFramework.Amazon;

namespace SeleniumFramework.Pages
{
    public class ProductSearch
    {
        public void EnterSearchTerm(string searchTerm)
        {
            Common.SendKeys(Locators.ProductSearch.SearchInput, searchTerm);
        }

        public bool IsAutocompleteResultVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductSearch.AutocompleteResult);
        }

        public void SelectFirstAutocompleteResult()
        {
            Common.Click(Locators.ProductSearch.FirstAutocompleteResult);
        }

        public bool IsSearchResultVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductSearch.SearchResultItem);
        }
    }
}
