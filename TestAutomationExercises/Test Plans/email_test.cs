using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI_Tests
{
    [TestFixture]
    public class Email_Test
    {
        private IWebDriver driver;
        [Test]
        public void LoginTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();
            
            EmailCheck email_check = new EmailCheck();
            OnboardClass onboardClass = new OnboardClass();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);


            email_check.Emailvalid(driver, Email_TestData.Email);
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
