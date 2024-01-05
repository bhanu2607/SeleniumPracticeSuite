using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class WorkForcePage
    {
        IWebDriver driver;
        public WorkForcePage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }



        public By  workForceBtn = By.XPath("//a[@href='/app/work-force-new']");
        public By firstNameEle = By.XPath("//span[normalize-space()='FIRST NAME']");

        public By searchInputEle = By.XPath("//input[@placeholder='Search...']");
        public By searchBtn = By.XPath("//button[normalize-space()='Search']");

        public By nameEle = By.XPath("//span[@title='Rajesh']");
        public By actionBtn = By.XPath("//button[normalize-space()='Search']");

        public By finalEle = By.XPath("//h2[normalize-space()='Are you sure you want to delete this employee?']");



        

    }
}


