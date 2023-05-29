using NUnit.Framework;
using SeleniumFramework.Amazon;

namespace SeleniumTests
{
    public class UserLoginTests : BaseTest
    {
        [Test]
        public void LoginToUserAccount()
        {
            UserLogin.ClickSignInButton();
            UserLogin.EnterEmail("amazontestgediminas@gmail.com");
            UserLogin.ClickContinue();
            UserLogin.EnterPassword("VilniusCodingSchool!951");
            UserLogin.ClickSignIn();
            Assert.IsTrue(UserLogin.IsLoggedIn());
        }
    }
}
