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

        public void EnterDetails(IWebDriver driver , CandidateDetails detailsObj )
        {
          

            
            

            //obj instantiation
            OnBoardPage onBoardPage = new OnBoardPage(driver);
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));


            wait.Until(ExpectedConditions.ElementIsVisible(onBoardPage.onBoardBtn));
            driver.FindElement(onBoardPage.onBoardBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(onBoardPage.singleDiv));
            driver.FindElement(onBoardPage.singleDiv).Click();

            driver.FindElement(onBoardPage.firstNameInput).SendKeys(detailsObj.FirstName);
            driver.FindElement(onBoardPage.lastNameInput).SendKeys(detailsObj.LastName);


            wait.Until(ExpectedConditions.ElementIsVisible(onBoardPage.signoutBtn));

            //wait for an element to be visible
          
            //enter details in onboard form
            
            //click on submit btn
            //wait for success msg to be visible
        }


    }
}
