using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UI_Tests

{
    public class EmailCheck
    {
        public void EmailValid(IWebDriver driver, string email)
        {
            EmailPage emailPage = new EmailPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));

            driver.Navigate().GoToUrl(URLs.Work_Force_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(emailPage.SearchBtn));
        
            driver.FindElement(emailPage.SearchBar).SendKeys(Email_TestData.Email);
            driver.FindElement(emailPage.SearchBtn).Click();
            try
            {
                driver.FindElement(emailPage.no_result);
            }
            catch (Exception)
            {

                
                wait.Until(ExpectedConditions.ElementIsVisible(emailPage.actionsBtn));
                driver.FindElement(emailPage.actionsBtn).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(emailPage.deleteBtn));
                driver.FindElement(emailPage.deleteBtn).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(emailPage.deletepopup));
                driver.FindElement(emailPage.delete_yes_btn).Click();
            }






        }
    }
}
