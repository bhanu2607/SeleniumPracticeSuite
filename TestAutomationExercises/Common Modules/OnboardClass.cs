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
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[normalize-space()='Single']")));
            driver.FindElement(By.XPath("//span[normalize-space()='Single']")).Click();
            //wait
            driver.FindElement(onboardPage.First_Name).SendKeys(employeeDetail.FirstName);
            driver.FindElement(onboardPage.Last_Name).SendKeys(employeeDetail.LastName);
            driver.FindElement(onboardPage.Email_id).SendKeys(employeeDetail.Email);
            driver.FindElement(onboardPage.Phone_Number).SendKeys(employeeDetail.PhoneNumber);
            driver.FindElement(By.XPath("")).SendKeys(Keys.Control + "A" + Keys.Backspace);
            driver.FindElement(By.XPath("")).SendKeys(employeeDetail.DateOfBirth);

            driver.FindElement(By.XPath("(//button[@type='button'])[3]")).Click();

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
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
        public string EmploymentType { get; set; }
        public string TaxTerm { get; set; }
        public string DateOfBirth { get; set; }
        public EmployeeDetail(string fn, string ln,  string mail_id, string pn)
        {
            FirstName = fn;
            LastName = ln;
            Email = mail_id;
            
            PhoneNumber = pn;
           
        }
    }
}