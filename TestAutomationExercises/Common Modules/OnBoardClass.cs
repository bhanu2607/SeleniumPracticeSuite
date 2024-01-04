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
        public string DateOfBirth { get; set; }
        public EmployeeDetail(string fn, string ln, string job, string mail_id, string pn, string employmentType, string taxTerm, [Optional] string BirthDate)
        {
            FirstName = fn;
            LastName = ln;
            Email = mail_id;
            Designation = job;
            PhoneNumber = pn;
            EmploymentType = employmentType;
            TaxTerm = taxTerm;
            DateOfBirth = BirthDate;
        }
    }
}

