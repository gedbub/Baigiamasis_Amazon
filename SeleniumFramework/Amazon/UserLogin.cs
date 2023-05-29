namespace SeleniumFramework.Amazon
{
    public class UserLogin
    {
        public void ClickSignInButton()
        {
            Common.Click(Locators.UserLogin.SignInButton);
        }

        public void EnterEmail(string email)
        {
            Common.SendKeys(Locators.UserLogin.EmailInput, email);
        }

        public void ClickContinue()
        {
            Common.Click(Locators.UserLogin.ContinueButton);
        }

        public void EnterPassword(string password)
        {
            Common.SendKeys(Locators.UserLogin.PasswordInput, password);
        }

        public void ClickSignIn()
        {
            Common.Click(Locators.UserLogin.SignInSubmitButton);
        }

        public bool IsLoggedIn()
        {
            return Common.WaitForElementToBeVisible(Locators.UserLogin.LoggedInText);
        }
    }
}
