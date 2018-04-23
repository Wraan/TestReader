using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReader
{
    public partial class TestView : Form, ITestView
    {
        private int minute;
        private int second = 0;
        private int questionsNumber = 0;
        private int currentQuestion = 1;
        public int QuestionsNumber
        {
            get
            {
                return questionsNumber;
            }
            set
            {
                questionsNumber = value;
            }
        }
        public int CurrentQuestion
        {
            get
            {
                return currentQuestion;
            }
            set
            {
                currentQuestion = value;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public int Second {
            get
            {
                return second;
            }
        }
        public event Action<object, EventArgs> VTestViewClosedEvent;
        public event Action<object, EventArgs> VLoadQuestionEvent;
        public event Action<object, EventArgs> TestView_ShowResultEvent;
        public TestView(Action<object, EventArgs> VTestViewClosedEvent, Action<object, EventArgs> VLoadQuestionEvent, 
            Action<object, EventArgs> TestView_ChangeAnswerEvent, Action<object, EventArgs> TestView_ShowResultEvent)
        {
            InitializeComponent();

            this.VTestViewClosedEvent += VTestViewClosedEvent;
            this.VLoadQuestionEvent = VLoadQuestionEvent;
            addEventToAnswersControls(TestView_ChangeAnswerEvent);
            this.TestView_ShowResultEvent += TestView_ShowResultEvent;

            answer1Control.AnswerNumber = 1;
            answer2Control.AnswerNumber = 2;
            answer3Control.AnswerNumber = 3;
            answer4Control.AnswerNumber = 4;
        }
        private void addEventToAnswersControls(Action<object, EventArgs> VChangeAnswerEvent)
        {
            answer1Control.addEvent(VChangeAnswerEvent);
            answer2Control.addEvent(VChangeAnswerEvent);
            answer3Control.addEvent(VChangeAnswerEvent);
            answer4Control.addEvent(VChangeAnswerEvent);
        }

        private void TestView_FormClosed(object sender, FormClosedEventArgs e)
        {
            VTestViewClosedEvent(sender, e);            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            second--;
            if(minute <= 0 && second <=0)
            {
                TestView_ShowResultEvent(sender, e);
            }
            if(second <= 0)
            {
                minute--;
                second = 59;                
            }
            timerLabel.Text = minute + ":" + second;
        }
        public void Start()
        {
            questionsNumbersLabel.Text = currentQuestion.ToString() + "/" + questionsNumber.ToString();
            timerLabel.Text = minute.ToString() + ":" + second.ToString();
            timer.Enabled = true;
            Show();
        }
        public void loadQuestion(Question question, UserAnswer userAnswer)
        {
            questionTextF.Text = question.Content;
            answer1Control.setAnswer(question.Answers[0], userAnswer.Answers[0]);            
            answer2Control.setAnswer(question.Answers[1], userAnswer.Answers[1]);
            answer3Control.setAnswer(question.Answers[2], userAnswer.Answers[2]);
            answer4Control.setAnswer(question.Answers[3], userAnswer.Answers[3]);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(currentQuestion >= questionsNumber)
            {
                return;
            }
            currentQuestion++;
            questionsNumbersLabel.Text = currentQuestion.ToString() + "/" + questionsNumber.ToString();
            VLoadQuestionEvent(sender, e);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if(currentQuestion <= 1)
            {
                return;
            }
            currentQuestion--;
            questionsNumbersLabel.Text = currentQuestion.ToString() + "/" + questionsNumber.ToString();
            VLoadQuestionEvent(sender, e);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TestView_ShowResultEvent(sender, e);
        }
    }
}
