namespace SeleniumFramework.Amazon
{
    internal class Locators
    {
        internal class ProductSearch
        {
            internal static string SearchInput = "//input[@id='twotabsearchtextbox']";
            internal static string AutocompleteResult = "//div[@class='s-suggestion-container']";
            internal static string FirstAutocompleteResult = "//*[@id='nav-flyout-searchAjax']/div[2]/div/div[1]/div[1]/div/div";
            internal static string SearchResultItem = "//div[@data-component-type='s-search-result']";
            internal static string SearchButton = "//input[@value='Go']";
        }

        internal class ProductDetails
        {
            internal static string AllLinkLocator = "//a[@id='nav-hamburger-menu']";
            internal static string ComputersCategoryLocator = "//*[@id='hmenu-content']/ul[1]/li[8]/a";
            internal static string MonitorsCategoryLocator = "//*[@id='hmenu-content']/ul[6]/li[9]";
            internal static string FirstSearchProductLocator = "//*[@id='search']/div[1]/div[1]/div/span[1]/div[1]/div[3]";
            internal static string ProductTitleLocator = "//span[@id='productTitle']";
            internal static string AddToCartButton = "//*[@id='submit.add-to-cart']/span";
            internal static string CartConfirmation = "//*[@id='NATC_SMART_WAGON_CONF_MSG_SUCCESS']";
            internal static string FirstProductLocator = "(//*[@data-component-type='s-search-result']//h2/a)[1]";
        }

        internal class UserLogin
        {
            internal static string SignInButton = "//*[@id='nav-signin-tooltip']/a/span";
            internal static string EmailInput = "//input[@id='ap_email']";
            internal static string ContinueButton = "//input[@id='continue']";
            internal static string PasswordInput = "//input[@id='ap_password']";
            internal static string SignInSubmitButton = "//input[@id='signInSubmit']";
            internal static string LoggedInText = "//span[contains(text(),'Hello, Gediminas')]"; // Not a good practice to have the username hardcoded inside of a locator
        }

        internal class FilterResultsPage
        {
            internal static string DontChangeButton = "//*[@id='nav-main']/div[1]/div/div/div[3]/span[1]/span";
            internal static string GiftCardsLink = "//a[contains(text(),'Gift Cards')]";
            internal static string AmazonGiftCardsFilter = "//*[@id='s-refinements']/div[3]/ul/li[1]/span/a/div/label/i";
            internal static string ResultsText = "//div[@data-component-type='s-search-result']";
        }

        internal class HomePage
        {
            internal static string GiftCardsLink = "//a[@aria-label='Gift Cards']";
            internal static string ThankYouLink = "//a[text()='Thank You']";
            internal static string SeeAllResultsButton = "//a[text()='See all results']";
            internal static string ResultsText = "//h1[text()='Results']";
        }
    }
}
