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
    public class CheckWorkForceTest
    {
        private IWebDriver driver;
        [Test]
        public void LoginTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();

            CheckWorkForceHelper checkWorkForceHelper = new CheckWorkForceHelper();

            CandidateDetails detailsObj = new CandidateDetails(firstName: "Rajesh", lastName: "Sudaveni", designation: "Developer Intern", email: "rajesh@example1.com", phoneNumber: "8332839112", employmentType: "Intern", taxTerm: "C2C", contractDate: "07/01/2001");

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password  );

            checkWorkForceHelper.CheckWorkForce(driver, detailsObj.Email);


            
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

