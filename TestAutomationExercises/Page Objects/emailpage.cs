using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class EmailPage
    {
        IWebDriver driver;
        public EmailPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        

        public By Work_Force = By.XPath("//a[contains(.,'Workforce')]");
        public By SearchBar = By.XPath("//input[@placeholder='Search...']");
        public By SearchBtn = By.XPath("//button[contains(.,'Search')]");
        public By actionsBtn = By.XPath("//button[normalize-space()='Actions']");
        public By deleteBtn = By.XPath("//span[not(@style='display: none;')]/div[@class='popper']//p[normalize-space()='Delete Record']");
        public By deletepopup = By.XPath("//h2[normalize-space()='Are you sure you want to delete this employee?']");
        public By delete_yes_btn = By.XPath("//div[@class='modal in']//button[normalize-space()='Yes']");
        public By no_result = By.XPath("//h2[normalize-space()='No results found']");


    }
}
