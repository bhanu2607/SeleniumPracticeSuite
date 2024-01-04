using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class OnboardPage
    {
        IWebDriver driver;
        public OnboardPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }
        public By signinBtn = By.XPath("//button[contains(text(),'Sign In')]");
        public By hrImmigrationBtn = By.XPath("//a[@href='/account/login']");
        public By inputEmail = By.XPath("//input[contains(@placeholder,'Email')]");
        public By inputPassword = By.XPath("//input[contains(@placeholder,'Password')]");
        public By submitBtn = By.XPath("//button[normalize-space()='Sign in']");
        public By signoutBtn = By.XPath("//label[normalize-space()='Sign Out']");
        public By onBoardBtn = By.XPath("//a[@href='/app/onboard-candidates/']");

        public By firstname = By.XPath("//label[contains(text(),'First Name')]/following-sibling::div/input[@type='text']");
        public By lastname = By.XPath("//label[contains(text(),'Last Name')]/following-sibling::div/input[@type='text']");
        public By designation = By.XPath("//label[contains(text(),'Designation')]/following-sibling::div/input[@type='text']");

        public By email = By.XPath("//label[contains(.,'Email ID*')]/following-sibling::div/input[@type='text']");
        public By phonenum = By.XPath("//label[contains(.,'Phone Number*')]/following-sibling::div/input[@type]");
        public By DOB = By.XPath("//label[contains(.,'Date Of Birth')]/following-sibling::div/input[@type]");
        public By male = By.XPath("//label[contains(.,'Male')]");
        public By city = By.XPath("//label[contains(.,'City, State')]/following-sibling::div/select");
        public By available = By.XPath("//label[contains(.,'Not Available')]");
        public By employeetype = By.XPath("//label[contains(.,'Employment Type*')]/following-sibling::div/span");


    }
}

