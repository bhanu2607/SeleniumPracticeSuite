using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI_Tests
{
    [TestFixture]
    public class searchtest
    {
        private IWebDriver driver;
        [Test]
        public void Searchtest_automation()
        {
            AuthHelper authHelper = new AuthHelper();

            SearchClass searchcls = new SearchClass();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            searchcls.Search(driver, "dhkk@gil.com");


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
