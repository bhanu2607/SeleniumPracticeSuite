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
    public class OnBoardTest
    {
        private IWebDriver driver;
        [Test]
        public void OnBoard_Automation()
        {
            AuthHelper authHelper = new AuthHelper();

            CandidateDetails detailsObj = new CandidateDetails(firstName: "Rajesh", lastName: "Sudhaveni", designation: "Developer Intern", email: "rajesh@example.com", phoneNumber: "8332839112", employmentType: "Intern", taxTerm: "C2C");

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);

            authHelper.EnterDetails(driver, detailsObj);
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
