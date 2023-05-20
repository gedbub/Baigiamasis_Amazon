namespace SeleniumFramework.Amazon
{
    public static class Locators
    {
        public static class ProductSearch
        {
            public static readonly string SearchInput = "//input[@id='twotabsearchtextbox']";
            public static readonly string AutocompleteResult = "//div[@class='s-suggestion-container']";
            public static readonly string FirstAutocompleteResult = "//*[@id='nav-flyout-searchAjax']/div[2]/div/div[1]/div[1]/div/div";
            public static readonly string SearchResultItem = "//div[@data-component-type='s-search-result']";
        }
    }
}
