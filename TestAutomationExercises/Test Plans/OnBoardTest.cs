using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            OnBoardHelper onBoardHelper = new OnBoardHelper();

            CheckWorkForceHelper checkWorkForceHelper = new CheckWorkForceHelper();


            CandidateDetails detailsObj = new CandidateDetails(firstName: "Rajesh", lastName: "Sudhaveni", designation: "Developer Intern", email: "rajesh@example1.com", phoneNumber: "8332839112", employmentType: "Intern", taxTerm: "C2C" , contractDate: "01/12/2023");

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);

            checkWorkForceHelper.CheckWorkForce(driver, detailsObj.Email);

            onBoardHelper.EnterDetails(driver, detailsObj);
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
