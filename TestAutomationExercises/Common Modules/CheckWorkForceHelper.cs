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
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            driver.FindElement(workForcePage.workForceBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.firstNameEle));

            driver.FindElement(workForcePage.searchInputEle).SendKeys(email);
            driver.FindElement(workForcePage.searchBtn).Click();

            try
            {
                wait1.Until(ExpectedConditions.ElementIsVisible(workForcePage.nameEle));


                driver.FindElement(workForcePage.actionBtn).Click();
                driver.FindElement(workForcePage.deleteRecordEle).Click();

                wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.finalEle));

                driver.FindElement(workForcePage.deleteBtn).Click();


            }
            catch (NoSuchElementException)
            {
                driver.FindElement(workForcePage.notFoundEle);
            }            

        }


    }
}

