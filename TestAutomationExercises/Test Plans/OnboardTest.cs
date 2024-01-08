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
            OnboardClass onboardclass = new OnboardClass();
            SearchClass searchClass = new SearchClass();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            searchClass.Search(driver, OnboardTest_TestData.e.Email);
            onboardclass.Onboard(driver, OnboardTest_TestData.e);


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
