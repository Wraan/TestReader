using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    interface ITestView
    {
       
        event Action<object, EventArgs> VTestViewClosedEvent;
        event Action<object, EventArgs> VLoadQuestionEvent;
        void Start();
        void loadQuestion(Question question, UserAnswer userAnswer);
        int CurrentQuestion { get; set; }
        int QuestionsNumber { get; set; }
        int Minute { get; set; }
        int Second { get; }
        void Close();
        void Hide();
    }

    
}
