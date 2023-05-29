namespace SeleniumFramework.Amazon
{
    public class UserLogin
    {
        public static void ClickSignInButton()
        {
            Common.Click(Locators.UserLogin.SignInButton);
        }

        public static void EnterEmail(string email)
        {
            Common.SendKeys(Locators.UserLogin.EmailInput, email);
        }

        public static void ClickContinue()
        {
            Common.Click(Locators.UserLogin.ContinueButton);
        }

        public static void EnterPassword(string password)
        {
            Common.SendKeys(Locators.UserLogin.PasswordInput, password);
        }

        public static void ClickSignIn()
        {
            Common.Click(Locators.UserLogin.SignInSubmitButton);
        }

        public static bool IsLoggedIn()
        {
            return Common.WaitForElementToBeVisible(Locators.UserLogin.LoggedInText);
        }
    }
}
