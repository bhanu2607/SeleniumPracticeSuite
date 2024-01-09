using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{
    [TestFixture]
    public class AnswerTheQuizTest
    {
        private IWebDriver driver;
        [Test]
        public void AnswerTheQuiz_Automation()
        {
           
            AnswerTheQuizHelper answerHelper = new AnswerTheQuizHelper();

            AnswerTheQuizPage obj = new AnswerTheQuizPage(driver);

            string[] recordedAnswers = obj.GetRecordedAnswers();

            answerHelper.AnswerTheQuiz(driver, recordedAnswers);




        }

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

