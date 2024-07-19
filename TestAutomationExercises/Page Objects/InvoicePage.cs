using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests.Page_Objects
{
    public class InvoicePage
    {
        IWebDriver driver;
        public InvoicePage(IWebDriver driver)
            {
            this.driver = driver;
            }
        public By Invoice_Menu = By.XPath("//span[@class='nav-icon ob__Img ob-invoice__Img']");
        public By Sync_Data = By.XPath("//span[contains(text(),'Sync Data')]");
        public By Search_Invoice = By.XPath("//input[@placeholder='Search...']");
        public By ClickOn_Search = By.XPath("//span[normalize-space()='Search']");
        public By SelectallInvoices = By.XPath("");
        public By Batch_Actions = By.XPath("//span[normalize-space()='Batch actions']");
        public By Filters_Button = By.XPath("//div[@class='col-md-3 pTop10']//img[@alt='image']");
        public By Invoice_Status = By.XPath("//span[@id='select2-039r-container']");
        public By Bulk_SendInvoice = By.XPath("(//div[@class='dropdown-list-item'][normalize-space()='Send Invoice'])[1]");
        public By Bulk_PrintInvoice = By.XPath("(//div[@class='dropdown-list-item'][normalize-space()='Print Invoice'])[1]");
        public By Bulk_ReminderInvoice = By.XPath("(//div[@class='dropdown-list-item'][normalize-space()='Send Reminder'])[1]");
        public By Apply_Filter = By.XPath("//div[@class='row training-filter__footer']//span[@class='text'][normalize-space()='Apply']");
        public By Cancel_filter = By.XPath("//div[@class='row training-filter__footer']//span[@class='text'][normalize-space()='Cancel']");
        public By Actionsbtn_Click = By.XPath("//body[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[2]/table[1]/tbody[1]/tr[1]/td[10]/span[1]/button[1]");
        public By View_Invoice = By.XPath("(//div[contains(text(),'View Invoice')])[21]");
        public By Send_Invoice = By.XPath("(//div[contains(text(),'Send Invoice')])[22]");
        public By Delete_Invoice = By.XPath("(//div[contains(text(),'Delete Invoice')])[21]");
        public By Void_Invoice = By.XPath("(//div[contains(text(),'Void Invoice')])[21]");
        public By Download_Invoice = By.XPath("(//div[contains(text(),'Download Invoice')])[21]");

    }

}
