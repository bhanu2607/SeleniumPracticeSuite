using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class OnBoardPage
    {
        IWebDriver driver;
        public OnBoardPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }



        public By onBoardBtn = By.XPath("//a[@href='/app/onboard-candidates/']");
        public By singleDiv = By.XPath("//div[@class='big-btn big-btn--single']");

        public By firstNameInput = By.XPath("//label[contains(text(),'First Name')]/following-sibling::div/input[@type='text']");
        public By lastNameInput = By.XPath("//label[contains(text(),'Last Name')]/following-sibling::div/input[@type='text']");

        public By designationInput = By.XPath("//label[contains(.,'Designation')]/following-sibling::div/input[@type='text']");
        public By emailIdInput = By.XPath("//label[contains(.,'Email ID*')]/following-sibling::div/input[@type='text']");
        public By phoneNumberInput = By.XPath("//label[contains(.,'Phone Number')]/following-sibling::div/input[@type]");
        public By genderInput = By.XPath("//label[contains(.,'Male')]");
        public By employmentTypeInput = By.XPath("//label[contains(.,'Employment Type')]/following-sibling::div/select");
        public By taxTermsInput = By.XPath("//label[contains(.,'Tax Terms')]/following-sibling::div/select");
        public By contractStartDateInput = By.XPath("//label[contains(., 'Contract Start')]/following-sibling::div/input");



        public By onBoardButton = By.XPath("//button[normalize-space()='Onboard']");
        public By finalEle = By.XPath("//h3[.='Candidate successfully Onboarded']");

        public By radioMale = By.XPath("//label[contains(.,'Male')]");
        public By radioFemale = By.XPath("//label[contains(.,'Female')]");

        public By signoutBtn = By.XPath("//label[normalize-space()='Sign Out']");

    }
}

