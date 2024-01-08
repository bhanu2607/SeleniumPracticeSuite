using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public class SearchClass
    {
        public void Search(IWebDriver driver, string mail)

        {
            SearchPage spage = new SearchPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(spage.workForce));
            driver.FindElement(spage.workForce).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(spage.searchBtn));
            driver.FindElement(spage.searchbox).SendKeys(mail);
            driver.FindElement(spage.searchBtn).Click();

            try
            {
                driver.FindElement(spage.noresult);
            }
            catch (NoSuchElementException)
            {
                wait.Until(ExpectedConditions.ElementIsVisible(spage.actionbtn));
                driver.FindElement(spage.actionbtn).Click();
                driver.FindElement(spage.deleterecord).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(spage.deleteyes));
                driver.FindElement(spage.deleteyes).Click();

            }


        }
    }
}