using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    [TestFixture]
    public class email_test
    {
        private IWebDriver driver;
        [Test]
        public void LoginTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();
            OnboardClass onboardClass = new OnboardClass();

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);

            authHelper.emailcheck(driver, OnboardTest_TestData.employeeDetail.Email);

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
