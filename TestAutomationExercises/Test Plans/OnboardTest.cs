using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI_Tests
{
    [TestFixture]
    public class OnboardTest
    {
        private IWebDriver driver;
        [Test]
        public void OnboardTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();
            OnboardClass onboardClass = new OnboardClass( );

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            onboardClass.Onboard(driver, OnboardTest_TestData.employeeDetail);
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
