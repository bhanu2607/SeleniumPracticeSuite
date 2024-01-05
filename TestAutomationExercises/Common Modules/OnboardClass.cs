using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Runtime.InteropServices;

namespace UI_Tests
{
    public class OnboardClass
    {
        public void Onboard(IWebDriver driver, EmployeeDetail employeeDetail)
        {
            OnboardPage onboardPage = new OnboardPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.On_Board));
            driver.FindElement(onboardPage.On_Board).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.Single));
            driver.FindElement(onboardPage.Single).Click();
            //wait
            driver.FindElement(onboardPage.First_Name).SendKeys(employeeDetail.FirstName);
            driver.FindElement(onboardPage.Last_Name).SendKeys(employeeDetail.LastName);
            driver.FindElement(onboardPage.DesignationType).SendKeys(employeeDetail.Designationtype);
            driver.FindElement(onboardPage.Email_id).SendKeys(employeeDetail.Email);
            driver.FindElement(onboardPage.Phone_Number).SendKeys(employeeDetail.PhoneNumber);
            driver.FindElement(onboardPage.Date_of_birth).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(onboardPage.Date_of_birth).SendKeys(employeeDetail.DateOfBirth);
            SelectElement selectEmpType = new SelectElement(driver.FindElement(onboardPage.Employment_type));
            selectEmpType.SelectByText(employeeDetail.EmploymentType);
            SelectElement selecttaxType = new SelectElement(driver.FindElement(onboardPage.Tax_Terms));
            selecttaxType.SelectByText(employeeDetail.TaxTerm);
            driver.FindElement(onboardPage.ContractStartDate).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(onboardPage.ContractStartDate).SendKeys(employeeDetail.StartDate);

            driver.FindElement(onboardPage.OnBoard).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.Lastpage));

            //xpaths and wait for pop up messages.


            //fill all details
            //click on submit
            //wait until success popup
        }
    }
    public class EmployeeDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Designationtype { get; set; }
        public string PhoneNumber { get; set; }
        public string EmploymentType { get; set; }
        public string TaxTerm { get; set; }
        public string DateOfBirth { get; set; }
        public string StartDate { get; set; }
        public string e { get; set; }
        public EmployeeDetail(string fn, string ln,  string mail_id, string pn , string Dob, string Designation,string employ_type,string tax_term ,string start_date)
        {
            FirstName = fn;
            LastName = ln;
            Email = mail_id;
            
            PhoneNumber = pn;
            DateOfBirth = Dob;
            Designationtype = Designation;
            EmploymentType = employ_type;
            TaxTerm= tax_term;
            StartDate = start_date;
        }
    }
}