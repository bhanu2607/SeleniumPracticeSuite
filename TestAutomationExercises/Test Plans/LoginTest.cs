using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI_Tests
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver driver;
        [Test]
        public void LoginTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();
            OnboardClass onboardclass = new OnboardClass();

            EmployeeDetail e = new EmployeeDetail(fn: "Divya", ln: "y ", job: "developer", mail_id: "duh@gmail.com", pn: "9674325212", employmentType: "fulltime", taxTerm: "w2");

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
