using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Cryptography.X509Certificates;

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

            driver.FindElement(onBoardPage.designationInput).SendKeys(detailsObj.Designation);
            driver.FindElement(onBoardPage.emailIdInput).SendKeys(detailsObj.Email);
            driver.FindElement(onBoardPage.phoneNumberInput).SendKeys(detailsObj.PhoneNumber);

            SelectElement selectEmpType = new SelectElement(driver.FindElement(onBoardPage.employmentTypeInput) );
            selectEmpType.SelectByText(detailsObj.EmploymentType);


            SelectElement selectTaxTermType = new SelectElement(driver.FindElement(onBoardPage.taxTermsInput));
            selectTaxTermType.SelectByText(detailsObj.TaxTerm);

            driver.FindElement(onBoardPage.contractStartDateInput).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(onBoardPage.contractStartDateInput).SendKeys(detailsObj.ContractDate);

            
            driver.FindElement(onBoardPage.onBoardButton).Click();


            wait.Until(ExpectedConditions.ElementIsVisible(onBoardPage.finalEle) );

            //wait for an element to be visible
          
            //enter details in onboard form
            
            //click on submit btn
            //wait for success msg to be visible
        }

        public void CheckWorkForce(IWebDriver driver, string email)
        {
            WorkForcePage workForcePage = new WorkForcePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40)); 

            driver.FindElement(workForcePage.workForceBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.firstNameEle));

            driver.FindElement(workForcePage.searchInputEle).SendKeys(email);
            driver.FindElement(workForcePage.searchBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.nameEle));


            SelectElement selectDeleteRecord = new SelectElement(driver.FindElement(workForcePage.actionBtn));
            selectDeleteRecord.SelectByText("Delete Record");


            wait.Until(ExpectedConditions.ElementIsVisible(workForcePage.finalEle));

        }


    }
}
