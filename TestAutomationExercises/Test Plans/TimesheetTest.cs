using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UI_Tests.Common_Modules;
using UI_Tests.Test_Data;

namespace UI_Tests.Test_Plans
{
    public class TimesheetTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
        }

        [Test]
        public void Timsheet_Automation()
        {

            AuthHelper authHelper = new AuthHelper();
            TimesheetClass timesheetClass = new TimesheetClass();





            // Perform login
           

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            string url = "https://demohr.onblick.com/app/employer-timesheets?pageNo=1";
            driver.Navigate().GoToUrl(url);
            // Navigate to timesheet tab and perform actions


            timesheetClass.Add_Timesheet(driver, Timesheet_Data.timesheet_Detail);


        }

        [TearDown]
        public void Cleanup()
        {

            driver.Quit();
        }
    }
}

