using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI_Tests
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;
        [Test]
        public void LoginTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
