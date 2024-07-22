using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UI_Tests.Common_Modules;
using UI_Tests.Test_Data;

namespace UI_Tests.Test_Plans
{
    public class InvoiceTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            
            driver = new ChromeDriver();
        }

        [Test]
        public void InvoiceTest_Automation()
        {
            
            AuthHelper authHelper = new AuthHelper();
            InvoicesClass invoicesClass = new InvoicesClass();

            
            
           

            // Perform login

            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);

            // Navigate to invoice tab and perform actions
            invoicesClass.invoicetab(driver,InvoiceTest_data.Invoice_Number);

            
        }

        [TearDown]
        public void Cleanup()
        {
           
            driver.Quit();
        }
    }
}
