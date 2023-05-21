using NUnit.Framework;
using SeleniumFramework.Pages;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests
{
    public class UserLoginTests : BaseTest
    {
        private UserLogin userLogin;

        [SetUp]
        public void Setup()
        {
            userLogin = new UserLogin();
        }

        [Test]
        public void LoginToUserAccount()
        {
            userLogin.ClickSignInButton();
            userLogin.EnterEmail("amazontestgediminas@gmail.com");
            userLogin.ClickContinue();
            userLogin.EnterPassword("VilniusCodingSchool!951");
            userLogin.ClickSignIn();
            Assert.IsTrue(userLogin.IsLoggedIn());
        }
    }
}
