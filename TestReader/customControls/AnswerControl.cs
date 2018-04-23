using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReader
{
    public partial class AnswerControl : UserControl
    {
        private int answerNumber = 0;
        public event Action<object, EventArgs> VChangeAnswerEvent;
        public int AnswerNumber
        {
            get
            {
                return answerNumber;
            }
            set
            {
                answerNumber = value;
            }
        }
        public AnswerControl()
        {
            InitializeComponent();
        }
        public bool isChecked()
        {
            return choosenCheckbox.Checked;
        }

        public void setAnswer(Answer answer, bool userAnswer)
        {
            answerTextF.Text = answer.Content;
            choosenCheckbox.Checked = userAnswer;
        }
        public void addEvent(Action<object, EventArgs> VChangeAnswerEvent)
        {
            this.VChangeAnswerEvent += VChangeAnswerEvent;
        }

        private void choosenCheckbox_Click(object sender, EventArgs e)
        {
            VChangeAnswerEvent(sender, e);
        }
    }
}
