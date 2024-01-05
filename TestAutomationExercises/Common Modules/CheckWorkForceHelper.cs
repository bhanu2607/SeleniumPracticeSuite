using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Cryptography.X509Certificates;

namespace UI_Tests
{
    public class CheckWorkForceHelper
    {

        public void CheckWorkForce(IWebDriver driver, string email)
        {
            WorkForcePage workForcePage = new WorkForcePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            driver.FindElement(workForcePage.workForceBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.firstNameEle));

            driver.FindElement(workForcePage.searchInputEle).SendKeys(email);
            driver.FindElement(workForcePage.searchBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.nameEle));


            SelectElement selectDeleteRecord = new SelectElement(driver.FindElement(workForcePage.actionBtn));
            selectDeleteRecord.SelectByText("Delete Record");


            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.finalEle));

        }


    }
}

