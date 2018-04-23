using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public class Test
    {
        private string title { get; set; }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        private string description { get; set; }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        private string password { get; set; }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        private string author { get; set; }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        private int time { get; set; }
        public int Time
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        private int sumOfPoints { get; set; }
        public int SumOfPoints
        {
            get
            {
                return sumOfPoints;
            }
            set
            {
                sumOfPoints = value;
            }
        }
        private List<Question> questions { get; set; }
        public List<Question> Questions
        {
            get
            {
                return questions;
            }
            set
            {
                questions = value;
            }
        }
        public Test(string title, string description, string password, string author, int time, int sumOfPoints, List<Question> questions)
        {
            this.Title = title;
            this.Description = description;
            this.Password = password;
            this.Author = author;
            this.Time = time;
            this.SumOfPoints = sumOfPoints;
            this.Questions = questions;            
        }
        public Test() { }

        public Test(string json)
        {
            Test test;
            try
            {
                test = JsonConvert.DeserializeObject<Test>(json);
                Title = test.Title;
                Description = test.Description;
                Password = test.Password;
                Author = test.Author;
                Time = test.Time;
                SumOfPoints = test.SumOfPoints;
                Questions = test.Questions;
            }
            catch(Exception ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("Exception source: ", ex.Source);
            }            
        }
        public bool Good()
        {
            return !(Title == null || Description == null || Password == null || 
                Author == null || Time <= 0 || SumOfPoints <= 0 || Questions == null);
        }
    }
}
