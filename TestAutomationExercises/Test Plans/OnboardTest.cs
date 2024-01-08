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

            EmployeeDetail e = new EmployeeDetail(fn: "Div", ln: "y ", job: "developer", mail_id: "dh@gil.com", pn: "9674325232", employmentType: "Full-Time", taxTerm: "C2C");

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            onboardclass.Onboard(driver, e);


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
