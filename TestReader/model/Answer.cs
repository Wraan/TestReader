using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public class Answer
    {
        private string content { get; set; }
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
        private bool isCorrect { get; set; }
        public bool Correct
        {
            get
            {
                return isCorrect;
            }
            set
            {
                isCorrect = value;
            }
        }       

        public Answer(string content, bool isCorrect)
        {
            this.Content = content;
            this.Correct = isCorrect;
        }
    }
}
