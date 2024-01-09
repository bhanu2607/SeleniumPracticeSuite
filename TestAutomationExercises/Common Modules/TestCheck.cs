using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace UI_Tests
{
    public class TestCheck
    {
        public void TestPage(IWebDriver driver)
        {
            
            Actions actions = new Actions(driver);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));

            var current_Directory = Directory.GetCurrentDirectory();
            var file_Path = Path.GetFullPath(Path.Combine(current_Directory, "..", "..", "..", "Test Data", "RandomNameGenerator", "bhanuresult.json"));

            string json1 = File.ReadAllText(file_Path);

            // Deserialize the JSON data into a dictionary
            var data1 = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(json1);
            var correctAnswersArray = JArray.FromObject(data1["recordedAnswers"]);
            CorrectAnswers = firstNamesArray.ToObject<List<Name>>();
















            driver.Navigate().GoToUrl(URLs.Exam_link);
            
            wait.Until(ExpectedConditions.AlertIsPresent());
            var test_alert = driver.SwitchTo().Alert();
            test_alert.SendKeys("bhhajjooii");
            test_alert.Accept();

            
            {
                driver.FindElement(By.XPath($"//button[contains(text(),'{}')]")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.FindElement(By.XPath("//button[contains(text(),'Next')]")).Click();
            }

        }

    }
}
