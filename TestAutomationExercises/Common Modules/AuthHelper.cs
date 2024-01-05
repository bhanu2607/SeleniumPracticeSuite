using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UI_Tests
{
    public class AuthHelper
    {
        public void ValidLogin(IWebDriver driver, string username, string password)
        {
            LoginPage loginPage = new LoginPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            driver.Navigate().GoToUrl(URLs.Login_URL);
            actions.MoveToElement(driver.FindElement(loginPage.signinBtn)).Perform();
            driver.FindElement(loginPage.hrImmigrationBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(loginPage.inputEmail));
            driver.FindElement(loginPage.inputEmail).SendKeys(username);
            driver.FindElement(loginPage.inputPassword).SendKeys(password);
            driver.FindElement(loginPage.submitBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(loginPage.signoutBtn));
        }
        public void emailcheck(IWebDriver driver, string email)
        {
            emailpage Emailpage = new emailpage(driver);
            driver.FindElement(Emailpage.Work_Force).Click();

        }
    }
}
