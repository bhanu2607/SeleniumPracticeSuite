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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(150));

            try
            {
                string url = "https://demohr.onblick.com/app/employer-timesheets?pageNo=1";
                driver.Navigate().GoToUrl(url);

                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(timesheetpage.Onblick_logo));

                // Wait for the Add Timesheet button to be clickable
                //IWebElement addTimesheetButton = wait.Until(ExpectedConditions.ElementToBeClickable(timesheetpage.Add_Timesheet));

                // Click the Add Timesheet button
                //wait.Until(ExpectedConditions.ElementToBeClickable(timesheetpage.Add_Timesheet));
                driver.FindElement(timesheetpage.Add_Timesheet).Click();
                // Wait for the Search Employee input field to be visible and interactable
                wait.Until(ExpectedConditions.ElementIsVisible(timesheetpage.Search_Emp));

                // Enter employee name and press Enter
                IWebElement searchEmpInput = driver.FindElement(timesheetpage.Search_Emp);
                searchEmpInput.Clear();
                searchEmpInput.SendKeys(timesheet_detail.Emp_name);
                searchEmpInput.SendKeys(Keys.Enter);

                // Wait for Date From input field to be visible and interactable
                wait.Until(ExpectedConditions.ElementIsVisible(timesheetpage.Select_Datefrom));

                // Enter Date From
                IWebElement dateFromInput = driver.FindElement(timesheetpage.Select_Datefrom);
                dateFromInput.Clear();
                dateFromInput.SendKeys(timesheet_detail.Date_from);

                // Wait for Date To input field to be visible and interactable
                wait.Until(ExpectedConditions.ElementIsVisible(timesheetpage.Select_Dateto));

                // Enter Date To and press Enter
                IWebElement dateToInput = driver.FindElement(timesheetpage.Select_Dateto);
                dateToInput.Clear();
                dateToInput.SendKeys(timesheet_detail.Date_to);
                dateToInput.SendKeys(Keys.Enter);

                // Wait for Enter Hours input field to be visible and interactable
                wait.Until(ExpectedConditions.ElementIsVisible(timesheetpage.Enter_Hrs));

                // Enter Hours
                driver.FindElement(timesheetpage.Enter_Hrs).SendKeys(timesheet_detail.Enter_hrs);

                // Click the Submit button
                driver.FindElement(timesheetpage.Submitapp_TS).Click();
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine("Timeout occurred while waiting for element: " + ex.Message);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
                
            }


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
