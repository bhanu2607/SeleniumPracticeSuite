using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Cryptography.X509Certificates;

namespace UI_Tests
{
    public class AnswerTheQuizHelper
    {
        public void AnswerTheQuiz(IWebDriver driver, string[] recordedAnwers )
        {
            AnswerTheQuizPage answerTheQuizPage = new AnswerTheQuizPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            driver.Navigate().GoToUrl(URLs.Quiz_page_URL);

            wait.Until(ExpectedConditions.AlertIsPresent());
            // Switch to the alert
            IAlert alert = driver.SwitchTo().Alert();

            // Get text from the alert
            alert.SendKeys("Demo");

            // Accept (click OK) on the alert
            alert.Accept();

            foreach (string answer in recordedAnwers)
            {
                driver.FindElement(By.XPath($"//button[normalize-space()='{answer}']")).Click();
                driver.FindElement(By.XPath("//button[normalize-space()='Next']")).Click();
            }




        }

   

        


    }
}

