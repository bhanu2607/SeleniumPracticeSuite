using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Tests.Page_Objects;
using UI_Tests.Test_Data;

namespace UI_Tests.Common_Modules
{
    public class TimesheetClass
    {
        public void Add_Timesheet(IWebDriver driver, Timesheet_Detail timesheet_detail)
        {
            TimesheetPage timesheetpage = new TimesheetPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            //driver.FindElement(timesheetpage.Elipsis_Btn).Click();
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(timesheetpage.Timesheet_Menu));
          //  driver.FindElement(timesheetpage.Timesheet_Menu).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(timesheetpage.Add_Timesheet)); 
            driver.FindElement(timesheetpage.Add_Timesheet).Click();
            driver.FindElement(timesheetpage.Search_Emp).SendKeys(timesheet_detail.Emp_name);
            driver.FindElement(timesheetpage.Search_Emp).SendKeys(Keys.Enter);
            driver.FindElement(timesheetpage.Select_Datefrom).Clear();
            driver.FindElement(timesheetpage.Select_Datefrom).SendKeys(timesheet_detail.Date_from);
            driver.FindElement(timesheetpage.Select_Dateto).Clear();
            driver.FindElement(timesheetpage.Select_Dateto).SendKeys(timesheet_detail.Date_to);
            driver.FindElement(timesheetpage.Select_Dateto).SendKeys(Keys.Enter);
            driver.FindElement(timesheetpage.Enter_Hrs).SendKeys(timesheet_detail.Enter_hrs);
            driver.FindElement(timesheetpage.Submitapp_TS).Click();



        }
    }
    public class Timesheet_Detail
    {
        public string Emp_name { get; set; }
        public string Date_from { get; set; }
        public string Date_to { get; set; }
        public string Enter_hrs { get; set; }
     public Timesheet_Detail(string emp_name, string date_from, string date_to, string enter_hrs)
        {
            Emp_name = emp_name;
            Date_from = date_from;
            Date_to = date_to;
            Enter_hrs = enter_hrs;
        }
    }
}
