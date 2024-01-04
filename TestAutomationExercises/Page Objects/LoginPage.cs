using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
         
        }
        public By signinBtn = By.XPath("//button[contains(text(),'Sign In')]");
        public By hrImmigrationBtn = By.XPath("//a[@href='/account/login']");
        public By inputEmail = By.XPath("//input[contains(@placeholder,'Email')]");
        public By inputPassword = By.XPath("//input[contains(@placeholder,'Password')]");
        public By submitBtn = By.XPath("//button[normalize-space()='Sign in']");
        public By signoutBtn = By.XPath("//label[normalize-space()='Sign Out']");

    }
}
