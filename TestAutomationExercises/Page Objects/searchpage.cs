using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    public class searchpage
    {
        IWebDriver driver;
        public searchpage(IWebDriver driver)
        {
            this.driver = driver;
          
        }
        public By workForce = By.XPath("//a[contains(.,'Workforce')]");
        public By searchbox = By.XPath("//input[@placeholder='Search...']");
        public By searchBtn = By.XPath("//button[normalize-space()='Search']");

    }
}
