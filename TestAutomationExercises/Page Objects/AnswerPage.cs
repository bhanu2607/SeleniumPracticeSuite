using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Tests
{

    public class Data
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public string TimeTaken { get; set; }
        public Answer[] RecordedAnswers { get; set; }
    }

    public class Answer
    {
        public string Question { get; set; }
        public string SelectedAnswer { get; set; }
        public string CorrectAnswer { get; set; }
        public bool IsCorrect { get; set; }
    }
    public class AnswerPage
    {
        public Answer[] Returning_answers()
        {
            var current_Directory = Directory.GetCurrentDirectory();
            var file_Path = Path.GetFullPath(Path.Combine(current_Directory, "..", "..", "..", "Test Data", "RandomNameGenerator", "bhanuresult.json"));

            string json1 = File.ReadAllText(file_Path);

            // Deserialize the JSON data into a dictionary
            var data1 = JsonConvert.DeserializeObject<Data>(json1);

            return data1.RecordedAnswers;
        }
    }
}
