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
            EmailCheck email_check = new EmailCheck();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            onboardClass.Onboard(driver, OnboardTest_TestData.employeeDetail);
            email_check.Emailvalid(driver, "bhanukri@gmail.com");



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
