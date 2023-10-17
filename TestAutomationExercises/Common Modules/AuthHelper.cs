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
            By signinBtn = By.XPath("//button[contains(text(),'Sign In')]");
            By hrImmigrationBtn = By.XPath("//a[@href='/account/login']");
            By inputEmail = By.XPath("//input[contains(@placeholder,'Email')]");
            By inputPassword = By.XPath("//input[contains(@placeholder,'Password')]");
            By submitBtn = By.XPath("//button[normalize-space()='Sign in']");
            By signoutBtn = By.XPath("//label[normalize-space()='Sign Out']");

            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            driver.Navigate().GoToUrl(LoginTest_TestData.Login_URL);
            actions.MoveToElement(driver.FindElement(signinBtn)).Perform();
            driver.FindElement(hrImmigrationBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(inputEmail));
            driver.FindElement(inputEmail).SendKeys(username);
            driver.FindElement(inputPassword).SendKeys(password);
            driver.FindElement(submitBtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(signoutBtn));
        }
    }
}
