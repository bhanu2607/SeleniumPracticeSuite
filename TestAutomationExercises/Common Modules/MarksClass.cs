using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Runtime.InteropServices;

namespace UI_Tests
{
    public class MarksClass
    {
        public void MarksClsmethod(IWebDriver driver, Options[] recordedanswers)
        {
            MarksPage markspage = new MarksPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));

            driver.Navigate().GoToUrl(URLs.quiz_url);

        ReTry: try
            {
                wait.Until(ExpectedConditions.AlertIsPresent());
            }
            catch (WebDriverTimeoutException)
            {
                driver.Navigate().Refresh();
                goto ReTry;
            }


            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("Divya");
            alert_win.Accept();
            foreach (Options opt in recordedanswers)
            {
                var index = Array.IndexOf(recordedanswers, opt);
                if (!opt.correctAnswer.Contains('\''))
                {
                    driver.FindElement(By.XPath($"//span[normalize-space()='{opt.correctAnswer}']")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath($"//span[normalize-space()=\"{opt.correctAnswer}\"]")).Click();
                }
                if (index==29)
                {
                    driver.FindElement(By.XPath("//button[normalize-space()='28']")).Click();//just for checking purpose

                    driver.FindElement(By.XPath("//button[normalize-space()='Submit']")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath("//button[normalize-space()='Save & Next']")).Click();

                }

            }






        }
    }
}