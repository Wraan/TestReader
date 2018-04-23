using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public class Question
    {
        private string content { set; get; }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        private Answer[] answers { get; set; }
        public Answer[] Answers
        {
            get
            {
                return answers;
            }
            set
            {
                answers = value;
            }
        }
        public Question(string content, Answer[] answers)
        {
            this.Content = content;
            this.Answers = answers;
        }

    }
}
