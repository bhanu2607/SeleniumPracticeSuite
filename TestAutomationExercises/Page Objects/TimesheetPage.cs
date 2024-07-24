using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests.Page_Objects
{
     public class TimesheetPage
    {
        IWebDriver driver;
     public TimesheetPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public By Elipsis_Btn = By.XPath("//span[@class='nav-icon ob__Img ob-more__Img']");
        public By Timesheet_Menu = By.XPath("//a[@href='/app/employer-timesheets']");
        public By Onblick_logo = By.XPath("//img[@alt='OnBlick Logo']");
        public By Add_Timesheet = By.XPath("//button[contains(.,'Add Timesheet')]");
        public By Select_Emp = By.XPath("//span[@id='select2-x8hq-container']");
        public By Search_Emp = By.XPath("//input[@role='searchbox']");
        public By Select_Datefrom = By.XPath("//input[@id='dateFrom']");
        public By Select_Dateto = By.XPath("//input[@id='dateTo']");
        public By Enter_Hrs = By.XPath("//input[@placeholder='hrs']");
        public By Submitapp_TS = By.XPath("(//button[@type='button'])[6]");







    }
}
