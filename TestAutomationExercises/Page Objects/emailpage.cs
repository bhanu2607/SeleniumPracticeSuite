using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class emailpage
    {
        IWebDriver driver;
        public emailpage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public By signinBtn = By.XPath("//button[contains(text(),'Sign In')]");
        public By hrImmigrationBtn = By.XPath("//a[@href='/account/login']");
        public By inputEmail = By.XPath("//input[contains(@placeholder,'Email')]");
        public By inputPassword = By.XPath("//input[contains(@placeholder,'Password')]");
        public By submitBtn = By.XPath("//button[normalize-space()='Sign in']");
        public By signoutBtn = By.XPath("//label[normalize-space()='Sign Out']");

        public By Work_Force = By.XPath("//a[contains(.,'Workforce')]");
        public By SearchBar = By.XPath("//input[@placeholder='Search...']");
        public By SearchBtn = By.XPath("");


    }
}
