using NUnit.Framework;
using SeleniumFramework.Amazon;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
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
