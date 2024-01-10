using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Newtonsoft.Json;
namespace UI_Tests
{
    public class Data
    {
        public string Playername { get; set; }
        public int Score { get; set; }
        public string Timetaken { get; set; }
        public Options[] RecordedAnswers { get; set; }
    }
    public class  Options
    {
        public string question {  get; set; }
        public string selectedAnswer { get; set; }
        public string correctAnswer { get; set; }
        public bool isCorrect { get; set; }
    }


    public class MarksPage
    {
        IWebDriver driver;
        public MarksPage(IWebDriver driver)
        {
            this.driver = driver;
            #region InitElements: Open to Read
            //PageFactory.InitElements(driver, this);
            //use this for elements with [FindsBy()] method which would not require "driver.FindElement" to be written for each element instead the elements will be initialized when the constructor is called
            #endregion
        }
      public Options[] GetRecordedanswers() 
        {
            var currentDirectory=Directory.GetCurrentDirectory();
            var filePath = Path.GetFullPath(Path.Combine(currentDirectory, "..", "..", "..", "Page Objects", "Marks.json"));
            string json =File.ReadAllText(filePath);
            var data = JsonConvert.DeserializeObject<Data>(json);
            return data.RecordedAnswers;
        }

    }

}
