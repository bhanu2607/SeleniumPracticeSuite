using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Tests.Common_Modules;
using UI_Tests.Test_Data;

namespace UI_Tests.Test_Plans
{

    [TestFixture]
    public class InvoiceTest
    {
        private IWebDriver driver;
        [Test]
        public void InvoiceTest_Automation()
        {
            AuthHelper authHelper = new AuthHelper();
            authHelper.ValidLogin(driver, LoginTest_TestData.Username, LoginTest_TestData.Password);
            InvoicesClass invoicesClass = new InvoicesClass();
            invoicesClass.invoicetab(driver, Invoicedata.Invoice_Number);




           




