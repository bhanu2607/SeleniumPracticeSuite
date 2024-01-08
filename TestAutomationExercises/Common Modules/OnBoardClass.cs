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
            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.dashboardbtn));
            driver.FindElement(onboardPage.dashboardbtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.onBoardBtn));
            driver.FindElement(onboardPage.onBoardBtn).Click();

            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.single));
            driver.FindElement(onboardPage.single).Click();


            driver.FindElement(onboardPage.firstname).SendKeys(employeeDetail.FirstName);
            driver.FindElement(onboardPage.lastname).SendKeys(employeeDetail.LastName);
            driver.FindElement(onboardPage.email).SendKeys(employeeDetail.Email);
            driver.FindElement(onboardPage.designation).SendKeys(employeeDetail.Designation);
            driver.FindElement(onboardPage.phonenum).SendKeys(employeeDetail.PhoneNumber);
            SelectElement selectEmpType = new SelectElement(driver.FindElement(onboardPage.employeetype));
            selectEmpType.SelectByText(employeeDetail.EmploymentType);
            SelectElement selecttax = new SelectElement(driver.FindElement(onboardPage.taxterm));
            selecttax.SelectByText(employeeDetail.TaxTerm);
            driver.FindElement(onboardPage.consdate).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(onboardPage.consdate).SendKeys(employeeDetail.ConDate);

            driver.FindElement(onboardPage.onboardbtn).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(onboardPage.successpage));



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
         
        }
    }
}

