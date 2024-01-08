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
        public void searchtest_automation()
        {
            AuthHelper authHelper = new AuthHelper();
            searchclass searchcls = new searchclass();
            mailsearch m = new mailsearch(emaildup: "dsjdj@gmail");

        authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            searchcls.search(driver, m);


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
