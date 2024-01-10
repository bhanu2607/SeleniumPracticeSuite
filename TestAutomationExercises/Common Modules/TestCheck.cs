using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq.Expressions;
using UI_Tests;

namespace UI_Tests

{


    public class TestCheck
    {

        public void TestCheckMethod(IWebDriver driver)
        {

            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));



            AnswerPage object1 = new AnswerPage();
            Answer[] answers = object1.Returning_answers();




















            driver.Navigate().GoToUrl(URLs.Exam_link);


           retry: try
            {
            wait.Until(ExpectedConditions.AlertIsPresent());

            }
            catch (WebDriverTimeoutException)
            {
                driver.Navigate().Refresh();
                goto retry;
            }

            var test_alert = driver.SwitchTo().Alert();
            test_alert.SendKeys("bhhhhhjooii");
            test_alert.Accept();


            foreach (Answer answer in answers)
            {
                if (!answer.CorrectAnswer.Contains('\''))
                {
                    driver.FindElement(By.XPath($"//button[normalize-space()='{answer.CorrectAnswer}']")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath($"//button[normalize-space()=\"{answer.CorrectAnswer}\"]")).Click();
                }
                driver.FindElement(By.XPath("//button[normalize-space()='Next']")).Click();
            }
        }
    }
}
            
            