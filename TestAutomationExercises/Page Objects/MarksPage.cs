using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class MarksPage
    {
        IWebDriver driver;
        public MarksPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }
        public By nextbtn = By.XPath("//button[contains(text(),'Next')]");
        public By onebtn = By.XPath("//button[contains(text(),'Selenium is a web browser automation tool.')]");
        public By twobtn = By.XPath("//button[contains(text(),'To launch and interact with web browsers')]");
        public By threebtn = By.XPath("//button[contains(text(),'IWebDriver driver = new ChromeDriver();')]");
        public By fourbtn = By.XPath("//button[contains(text(),'To wait for specific expected conditions')]");
        public By fivebtn = By.XPath("//button[contains(text(),'driver.Manage().Window.Maximize();')]");
        public By sixbtn = By.XPath("//button[contains(text(),'Explicit wait is dynamic and is applied to specific elements, while implicit wait is static and is applied globally to the entire script.')]");
        public By sevenbtn = By.XPath("//button[contains(text(),'WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));')]");
        public By eightbtn = By.XPath("//button[contains(text(),'To locate web elements')]");
        public By ninebtn = By.XPath("//button[contains(text(),'driver.FindElement(By.Id(\"submitBtn\")).Click();')]");
        public By tenbtn = By.XPath("//button[contains(text(),'Using SelectElement class')]");
        public By elevenbtn = By.XPath("//button[contains(text(),'`driver.Close()` closes the current browser window, while `driver.Quit()` closes all browser windows and ends the WebDriver session.')]");
        public By twelvebtn = By.XPath("//button[contains(text(),'`ExpectedConditions.ElementIsVisible` checks if the element is present in the DOM and visible, while `ExpectedConditions.ElementToBeClickable` additionally checks if the element is enabled.')]");
        public By thirteenbtn = By.XPath("//button[contains(text(),'driver.Navigate().GoToUrl(\"https://www.google.com\')]");
        public By fourteenbtn = By.XPath("//button[contains(text(),\"<input type='file'>\")]");
        public By fifteenbtn = By.XPath("//button[contains(text(),\"//label[normalize-space()='Email Id']/following-sibling::input\")]");
        public By sixteenbtn = By.XPath("//button[contains(text(),'To improve code reusability by representing web pages as classes')]");
        public By seventeenbtn = By.XPath("//button[contains(text(),'A class that contains locators and methods for a web page')]");
        public By eighteenbtn = By.XPath("//button[contains(text(),'driver.FindElement() returns a single element, while driver.FindElements() returns a list of elements.')]");
        public By nineteenbtn = By.XPath("//button[contains(text(),'NUnit')]");
        public By twentybtn = By.XPath("//button[contains(text(),'[Test]')]");
        public By twentyonebtn = By.XPath("//button[contains(text(),'[TestFixture]')]");

        public By twentytwobtn = By.XPath("//button[contains(text(),'driver.Url')]");
        public By twentythreebtn = By.XPath("//button[contains(text(),'To represent a web element')]");
        public By twentyfourbtn = By.XPath("//button[contains(text(),'element.Text')]");
        public By twentyfivebtn = By.XPath("//button[contains(text(),'driver.Navigate().Refresh()')]");
        public By twentysixbtn = By.XPath("//button[contains(text(),'To set the implicit wait time')]");
        public By twentysevenbtn = By.XPath("//button[contains(text(),'All of the above')]");
        public By twentyeightbtn = By.XPath("//button[contains(text(),'driver.SwitchTo().DefaultContent();')]");
        public By twentyninebtn = By.XPath("//button[contains(text(),'All of the above')]");
        public By thirtybtn = By.XPath("//button[contains(text(),'driver.FindElement(By.Id(\"inputUsername\")).SendKeys(Keys.Tab);')]");


    }
}
