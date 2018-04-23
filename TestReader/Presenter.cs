using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReader
{
    public class Presenter
    {
        IInformationsView informationsView;
        IEnterPasswordView enterPasswordView;
        ITestView testView;
        IResultView resultView;
        Model model;

        public Presenter(Model model, IInformationsView informationsView)
        {
            this.model = model;
            this.informationsView = informationsView;
            informationsView.VEnterPasswordEvent += InformationsView_EnterPasswordViewEvent;
            informationsView.VReadFileEvent += InformationsView_ReadFileEvent;
        }

        private void InformationsView_EnterPasswordViewEvent(object arg1, EventArgs arg2)
        {
            if (model.LoadedTest != null && model.LoadedTest.Good())
            {
                enterPasswordView = new EnterPasswordView(EnterPasswordView_CheckPasswordEvent);
                enterPasswordView.Show();
            }
            else
            {
                MessageBox.Show("Pick a proper file first.");
            }
        }

        private void CloseApplicationEvent(object arg1, EventArgs arg2)
        {
            informationsView.Close();
        }

        private void TestView_LoadQuestionEvent(object arg1, EventArgs arg2)
        {
            Question question = model.LoadedTest.Questions[testView.CurrentQuestion - 1];
            UserAnswer userAnswer = model.UserAnswers[testView.CurrentQuestion - 1];
            testView.loadQuestion(question, userAnswer);
        }
        private void TestView_ChangeAnswerEvent(object arg1, EventArgs arg2)
        {
            CheckBox cb = (CheckBox)arg1;
            AnswerControl ac = (AnswerControl) cb.GetContainerControl();
            model.UserAnswers[testView.CurrentQuestion - 1].Answers[ac.AnswerNumber - 1] =
                !model.UserAnswers[testView.CurrentQuestion - 1].Answers[ac.AnswerNumber - 1];
        }

        private void TestView_ShowResultEvent(object arg1, EventArgs arg2)
        {
            model.calculateResult();
            int minutes = model.LoadedTest.Time - testView.Minute - 1;
            int seconds = 60 - testView.Second;
            testView.Hide();

            resultView = new ResultView(CloseApplicationEvent);
            resultView.showResult(model.UserPoints, model.LoadedTest.SumOfPoints, minutes, seconds);
            resultView.Show();            
        }

        private void InformationsView_ReadFileEvent(object arg1, EventArgs arg2)
        {
            OpenFileDialog openFileDialog = createOpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    informationsView.Path = openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    if (ex.Source != null)
                        Console.WriteLine("Exception source: ", ex.Source);
                    MessageBox.Show("Error: Could not read file from disk.");
                }
            }

            model.loadTest(informationsView.Path);

            if (model.LoadedTest != null && model.LoadedTest.Good())
            {
                informationsView.showTestInfo(model.LoadedTest);
            }
            else
            {
                MessageBox.Show("Pick a proper file first.");
            }
        }
        private void EnterPasswordView_CheckPasswordEvent(object arg1, EventArgs arg2)
        {
            if(enterPasswordView.Password == model.LoadedTest.Password)
            {
                enterPasswordView.Close();
                testView = new TestView(CloseApplicationEvent, TestView_LoadQuestionEvent, TestView_ChangeAnswerEvent, TestView_ShowResultEvent);

                model.UserAnswers = new List<UserAnswer>();
                for (int i = 0; i < model.LoadedTest.Questions.Count; i++)
                {
                    model.UserAnswers.Add(new UserAnswer());
                }

                testView.QuestionsNumber = model.LoadedTest.Questions.Count;
                testView.loadQuestion(model.LoadedTest.Questions[0], model.UserAnswers[0]);
                testView.Minute = model.LoadedTest.Time;                

                informationsView.Hide();
                testView.Start();
            }
            else
            {
                MessageBox.Show("Wrong password");
                enterPasswordView.clearPassword();
            }
        }
        private OpenFileDialog createOpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            return openFileDialog;

        }
    }
}
