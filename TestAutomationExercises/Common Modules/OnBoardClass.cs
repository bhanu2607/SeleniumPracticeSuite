using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;

namespace UI_Tests
{
    public class OnboardClass
    {
        public void Onboard(IWebDriver driver, EmployeeDetail employeeDetail)
        {
            OnboardPage onboardPage = new OnboardPage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            driver.FindElement(onboardPage.firstname).SendKeys(employeeDetail.FirstName);
            driver.FindElement(onboardPage.lastname).SendKeys(employeeDetail.LastName);
            driver.FindElement(onboardPage.email).SendKeys(employeeDetail.Email);
            driver.FindElement(onboardPage.designation).SendKeys(employeeDetail.Designation);
            driver.FindElement(onboardPage.phonenum).SendKeys(employeeDetail.PhoneNumber);
            SelectElement selectEmpType = new SelectElement(driver.FindElement(onboardPage.employeetype));
            selectEmpType.SelectByText(employeeDetail.EmploymentType);
            SelectElement selecttax = new SelectElement(driver.FindElement(onboardPage.taxterm));
            selecttax.SelectByText(employeeDetail.TaxTerm);
            driver.FindElement(By.XPath("//label[contains(normalize-space(),'Contract Start Date')]/following-sibling::div/input")).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(By.XPath("//label[contains(normalize-space(),'Contract Start Date')]/following-sibling::div/input")).SendKeys(employeeDetail.ConDate);

            driver.FindElement(By.XPath("//button[normalize-space()='Onboard']")).Click();

        }
    }
    public class EmployeeDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string EmploymentType { get; set; }
        public string TaxTerm { get; set; }
         public string ConDate { get; set; }
        //  public string Gender { get; set; }
        //public string Address1 { get; set; }
        //public string Address2 { get; set; }
        //public string City { get; set; }
        //public string Zipcode { get; set; }

        //public string Empdate { get; set; }
        //public string EmpID { get; set; }
        //public string CurrWorktype { get; set; }
        //public string Billstatus { get; set; }
        //public string Wagerate { get; set; }
        //public string Wagecycle { get; set; }
        //public string Department { get; set; }
        //public string Reportingto { get; set; }


    public EmployeeDetail(string fn, string ln, string job, string mail_id,  string pn, string employmentType, string taxTerm,string condate="19/01/2020")
        {
            FirstName = fn;
            LastName = ln;
            Email = mail_id;
            Designation = job;
            PhoneNumber = pn;
         EmploymentType = employmentType;
            TaxTerm = taxTerm;
            ConDate = condate;
         //   DateOfBirth = BirthDate;
         //   Address2 = address2;
            //City = city;
            //Zipcode = zipcode;
            //Empdate = empdate;
            //EmpID = empID;
            //CurrWorktype = currWorktype;
            //Billstatus = billstatus;
            //Wagerate = wagerate;
            //Wagecycle = wagecycle;
            //Department = department;
            //Reportingto = reportingto;
        }
    }
}

