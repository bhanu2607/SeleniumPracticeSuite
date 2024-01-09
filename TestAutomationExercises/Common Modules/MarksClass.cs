using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Runtime.InteropServices;

namespace UI_Tests
{
    public class MarksClass
    {
        public void Marks(IWebDriver driver)
        {
            MarksPage markspage = new MarksPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));

            driver.Navigate().GoToUrl(URLs.quiz_url);
            wait.Until(ExpectedConditions.AlertIsPresent());
            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("Divya");
            alert_win.Accept();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.onebtn));
            driver.FindElement(markspage.onebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twobtn));
            driver.FindElement(markspage.twobtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.threebtn));
            driver.FindElement(markspage.threebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.fourbtn));
            driver.FindElement(markspage.fourbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.fivebtn));
            driver.FindElement(markspage.fivebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.sixbtn));
            driver.FindElement(markspage.sixbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.sevenbtn));
            driver.FindElement(markspage.sevenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.eightbtn));
            driver.FindElement(markspage.eightbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.ninebtn));
            driver.FindElement(markspage.ninebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.tenbtn));
            driver.FindElement(markspage.tenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.elevenbtn));
            driver.FindElement(markspage.elevenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twelvebtn));
            driver.FindElement(markspage.twelvebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.thirteenbtn));
            driver.FindElement(markspage.thirteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.fourteenbtn));
            driver.FindElement(markspage.fourteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.fifteenbtn));
            driver.FindElement(markspage.fifteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.sixteenbtn));
            driver.FindElement(markspage.sixteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.seventeenbtn));
            driver.FindElement(markspage.seventeenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.eighteenbtn));
            driver.FindElement(markspage.eighteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.nineteenbtn));
            driver.FindElement(markspage.nineteenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentybtn));
            driver.FindElement(markspage.twentybtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentyonebtn));
            driver.FindElement(markspage.twentyonebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentytwobtn));
            driver.FindElement(markspage.twentytwobtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentythreebtn));
            driver.FindElement(markspage.twentythreebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentyfourbtn));
            driver.FindElement(markspage.twentyfourbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentyfivebtn));
            driver.FindElement(markspage.twentyfivebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentysixbtn));
            driver.FindElement(markspage.twentysixbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentysevenbtn));
            driver.FindElement(markspage.twentysevenbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentyeightbtn));
            driver.FindElement(markspage.twentyeightbtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.twentyninebtn));
            driver.FindElement(markspage.twentyninebtn).Click();
            driver.FindElement(markspage.nextbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(markspage.thirtybtn));
            driver.FindElement(markspage.thirtybtn).Click();
            driver.FindElement(markspage.nextbtn).Click();






        }
    }
}