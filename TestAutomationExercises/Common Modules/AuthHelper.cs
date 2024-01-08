using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UI_Tests
{
    public class AuthHelper
    {
        public void ValidLogin(IWebDriver driver, string username, string password)
        {
            OnboardPage onbp = new OnboardPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));

            driver.Navigate().GoToUrl(URLs.Login_URL);
            actions.MoveToElement(driver.FindElement(onbp.signinBtn)).Perform();
            driver.FindElement(onbp.hrImmigrationBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(onbp.inputEmail));
            driver.FindElement(onbp.inputEmail).SendKeys(username);
            driver.FindElement(onbp.inputPassword).SendKeys(password);
            driver.FindElement(onbp.submitBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(onbp.signoutBtn));


            wait.Until(ExpectedConditions.ElementIsVisible(onbp.onBoardBtn));
            driver.FindElement(onbp.onBoardBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[normalize-space()='Single']")));
            driver.FindElement(By.XPath("//span[normalize-space()='Single']")).Click();



        }
        

    }
}

