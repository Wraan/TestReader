using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReader
{
    public partial class InformationsView : Form, IInformationsView
    {
        public event Action<object, EventArgs> VEnterPasswordEvent;
        public event Action<object, EventArgs> VReadFileEvent;

        private string path;
        public string Path {
            get
            {
                return path;
            }
            set
            {
                path = value;
                pathTextF.Text = path;
            }
        }
        public InformationsView()
        {
            InitializeComponent();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {


        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            VReadFileEvent(sender, e);
        }

        public void showTestInfo(Test test)
        {
            authorTextF.Text = test.Author;
            titleTextF.Text = test.Title;
            descriptionTextF.Text = test.Description;
            maxPointsTextF.Text = test.SumOfPoints.ToString();
            questionsAmountTextF.Text = test.Questions.Count.ToString();
            timeTextF.Text = test.Time.ToString();

        }

        private void createSampleTestButton_Click(object sender, EventArgs e)
        {
            Answer[] answers1 = { new Answer("First", true), new Answer("Second", false), new Answer("Third", false), new Answer("Fourth", false) };
            Answer[] answers2 = { new Answer("First again", true), new Answer("Second again ", false), new Answer("Third again", true), new Answer("Fourth again", false) };
            Answer[] answers3 = { new Answer("First again again", true), new Answer("Second again again", false), new Answer("Third again again", true), new Answer("Fourth again again", false) };
            Question question1 = new Question("First question", answers1);
            Question question2 = new Question("Second question", answers2);
            Question question3 = new Question("Second question", answers3);
            Test test = new Test("First test", "This is description of the first test.", "pass", "Me Mario", 40, 20, new List<Question>() { question1, question2, question3 });

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"d:\json.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, test);
            }
        }

        private void startTestButton_Click(object sender, EventArgs e)
        {
            VEnterPasswordEvent(sender, e);            
        }
    }
}
