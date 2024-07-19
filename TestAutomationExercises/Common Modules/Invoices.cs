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
    public class InvoicesClass
    {
        public void Invoices(IWebDriver driver, Invoicedata invoicedata)
        {
            InvoicePage invoicepage = new InvoicePage(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            wait.Until(ExpectedConditions.ElementIsVisible(invoicepage.Invoice_Menu));
            driver.FindElement(invoicepage.Invoice_Menu).Click();  
            wait.Until(ExpectedConditions.ElementIsVisible(invoicepage.Sync_Data));
            driver.FindElement(invoicepage.Sync_Data).Click();
            wait.Until(ExpectedConditions.ElementIsVisible(invoicepage.Filters_Button));
            driver.FindElement(invoicepage.Search_Invoice).SendKeys(Invoicedata.Invoice_Number);
            driver.FindElement(invoicepage.ClickOn_Search);





        }
    }
}
