using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Security.Cryptography.X509Certificates;

namespace UI_Tests
{
    public class OnBoardHelper
    {
        

        public void EnterDetails(IWebDriver driver, CandidateDetails detailsObj)
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

            SelectElement selectEmpType = new SelectElement(driver.FindElement(onBoardPage.employmentTypeInput));
            selectEmpType.SelectByText(detailsObj.EmploymentType);


            SelectElement selectTaxTermType = new SelectElement(driver.FindElement(onBoardPage.taxTermsInput));
            selectTaxTermType.SelectByText(detailsObj.TaxTerm);

            driver.FindElement(onBoardPage.contractStartDateInput).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(onBoardPage.contractStartDateInput).SendKeys(detailsObj.ContractDate);


            driver.FindElement(onBoardPage.onBoardButton).Click();


            wait.Until(ExpectedConditions.ElementIsVisible(onBoardPage.finalEle));

            //wait for an element to be visible

            //enter details in onboard form

            //click on submit btn
            //wait for success msg to be visible
        }



    }
}
