using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public class searchclass
    {
        public void search(IWebDriver driver, mailsearch mail_s)
        {
            searchpage spage = new searchpage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            wait.Until(ExpectedConditions.ElementIsVisible(spage.workForce));
            driver.FindElement(spage.workForce).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(spage.searchbox));

            driver.FindElement(spage.workForce).SendKeys(mail_s.mail);

        }
    }
    public class mailsearch
    {
        public string mail { get; set; }
        public mailsearch(string emaildup)
        {
            mail = emaildup;
        }
    }
}