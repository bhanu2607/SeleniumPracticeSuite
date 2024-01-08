using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UI_Tests

{
    public class EmailCheck
    {
        public void Emailvalid(IWebDriver driver, string email)
        {
            EmailPage Emailpage = new EmailPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(70));

            driver.Navigate().GoToUrl(URLs.Work_Force_URL);
            wait.Until(ExpectedConditions.ElementToBeClickable(Emailpage.SearchBtn));
        
            driver.FindElement(Emailpage.SearchBar).SendKeys(Email_TestData.Email);
            driver.FindElement(Emailpage.SearchBtn).Click();
            try
            {
                driver.FindElement(Emailpage.no_result);
            }
            catch (Exception)
            {

                
                wait.Until(ExpectedConditions.ElementIsVisible(Emailpage.actionsBtn));
                driver.FindElement(Emailpage.actionsBtn).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(Emailpage.deleteBtn));
                driver.FindElement(Emailpage.deleteBtn).Click();
                wait.Until(ExpectedConditions.ElementIsVisible(Emailpage.deletepopup));
                driver.FindElement(Emailpage.delete_yes_btn).Click();
            }






        }
    }
}
