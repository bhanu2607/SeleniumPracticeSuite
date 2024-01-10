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

            string currentDirectory = Directory.GetCurrentDirectory();
            string downloadPath = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Downloads"));
            AnswerTheQuizHelper answerHelper = new AnswerTheQuizHelper();

            AnswerTheQuizPage obj = new AnswerTheQuizPage(driver);

            Answer[] recordedAnswers = obj.GetRecordedAnswers();

            var initialFileCount = Directory.GetFiles(downloadPath).Length;

            answerHelper.AnswerTheQuiz(driver, recordedAnswers);

            var currentFileCount = initialFileCount;
            while (currentFileCount <= initialFileCount)
            {
                currentFileCount = Directory.GetFiles(downloadPath).Length;
            }
            var downloadedFiles = new DirectoryInfo(downloadPath).GetFiles();
            var firstFile = downloadedFiles.OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            while (!firstFile.Name.EndsWith(".json"))
            {
                downloadedFiles = new DirectoryInfo(downloadPath).GetFiles();
                firstFile = downloadedFiles.OrderByDescending(x => x.LastWriteTime).FirstOrDefault();
            }





        }

        [SetUp]
        public void Setup()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string downloadPath = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Downloads"));
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", downloadPath);
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Directory.CreateDirectory(downloadPath);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

