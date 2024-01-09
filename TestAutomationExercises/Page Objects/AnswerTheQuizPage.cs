using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace UI_Tests
{
    public class AnswerTheQuizPage { 
        IWebDriver driver;
        public AnswerTheQuizPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }
        public class Answer
        {
            public string question { get; set; }
            public string selectedAnswer { get; set; }
            public string correctAnswer { get; set; }
            public bool isCorrect { get; set; }
        }
        public string[] GetRecordedAnswers()
        {

            var currentDirectory = Directory.GetCurrentDirectory();
            var filePath = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Page Objects", "data.json"));

            string json = File.ReadAllText(filePath);

            // Deserialize the JSON data into a dictionary
            var data = JsonConvert.DeserializeObject<Dictionary<string, List<object>>>(json);

            var recorderAnswersArray = JArray.FromObject(data["recordedAnswers"]);
            RecordedAnswers = recorderAnswersArray.ToObject<List<Answer>>();

            return new string[]
            {
        "Selenium is a web browser automation tool.",
        "To launch and interact with web browsers",
        "IWebDriver driver = new ChromeDriver();",
        ""
            };
        }






    }
}

