namespace SeleniumFramework.Amazon
{
    public class ProductSearch
    {
        public static void EnterSearchTerm(string searchTerm)
        {
            Common.SendKeys(Locators.ProductSearch.SearchInput, searchTerm);
        }

        public static bool IsAutocompleteResultVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductSearch.AutocompleteResult);
        }

        public static void SelectFirstAutocompleteResult()
        {
            Common.Click(Locators.ProductSearch.FirstAutocompleteResult);
        }

        public static bool IsSearchResultVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.ProductSearch.SearchResultItem);
        }
    }
}
