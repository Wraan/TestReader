using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public class Model
    {
        private Test loadedTest { get; set; }
        public Test LoadedTest
        {
            get
            {
                return loadedTest;
            }
            set
            {
                loadedTest = value;
            }
        }
        private List<UserAnswer> userAnswers { get; set; }
        public List<UserAnswer> UserAnswers
        {
            get
            {
                return userAnswers;
            }
            set
            {
                userAnswers = value;
            }
        }
        private int userPoints { get; set; }
        public int UserPoints
        {
            get
            {
                return userPoints;
            }
            set
            {
                userPoints = value;
            }
        }
        public void loadTest(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string output = sr.ReadToEnd();
                    LoadedTest = new Test(output);
                }
            }
            catch (Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Exception source: ", ex.Source);
            }
        }
        public void calculateResult()
        {
            for(int i = 0; i < LoadedTest.Questions.Count; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    //correct answer gives point
                    if(LoadedTest.Questions[i].Answers[j].Correct == true && userAnswers[i].Answers[j] == true)
                    {
                        userPoints++;
                    }
                    //incorrect answer gives minus point
                    if (LoadedTest.Questions[i].Answers[j].Correct == false && userAnswers[i].Answers[j] == true)
                    {
                        userPoints--;
                    }
                }
            }
        }
    }
}
