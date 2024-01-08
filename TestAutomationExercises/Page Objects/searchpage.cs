using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public class SearchPage
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;

        }
        public By workForce = By.XPath("//a[contains(.,'Workforce')]");
        public By searchbox = By.XPath("//input[@placeholder='Search...']");
        public By searchBtn = By.XPath("//button[normalize-space()='Search']");
        public By actionbtn = By.XPath("//button[contains(.,'Actions')]");
        public By deleterecord = By.XPath("//span[not(@style='display: none;')]/div[@class='popper']//p[normalize-space()='Delete Record']");
        public By deleteyes = By.XPath("//div[@class='modal in']//button[normalize-space()='Yes']");
        public By noresult = By.XPath("//h2[normalize-space()='No results found']");


    }
}
