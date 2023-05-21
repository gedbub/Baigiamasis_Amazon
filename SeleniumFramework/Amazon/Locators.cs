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
            public static readonly string SearchButton = "//input[@value='Go']";
        }

        public static class ProductDetails
        {
            public static readonly string AllLinkLocator = "//a[@id='nav-hamburger-menu']";
            public static readonly string ComputersCategoryLocator = "//*[@id='hmenu-content']/ul[1]/li[8]/a";
            public static readonly string MonitorsCategoryLocator = "//*[@id='hmenu-content']/ul[6]/li[9]";
            public static readonly string FirstSearchProductLocator = "//*[@id='search']/div[1]/div[1]/div/span[1]/div[1]/div[3]";
            public static readonly string ProductTitleLocator = "//span[@id='productTitle']";
            public static readonly string AddToCartButton = "//*[@id='submit.add-to-cart']/span";
            public static readonly string CartConfirmation = "//*[@id='attachDisplayAddBaseAlert']";
            public static readonly string FirstProductLocator = "//*[@id='search']/div[1]/div[1]/div/span[1]/div[1]/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/h2/a";
        }
        public static class UserLogin
        {
            public static readonly string SignInButton = "//*[@id='nav-signin-tooltip']/a/span";
            public static readonly string EmailInput = "//input[@id='ap_email']";
            public static readonly string ContinueButton = "//input[@id='continue']";
            public static readonly string PasswordInput = "//input[@id='ap_password']";
            public static readonly string SignInSubmitButton = "//input[@id='signInSubmit']";
            public static readonly string LoggedInText = "//span[contains(text(),'Hello, Gediminas')]";
            }
        }
}
