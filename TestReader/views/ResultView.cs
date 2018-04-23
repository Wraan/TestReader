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
    public partial class ResultView : Form, IResultView
    {
        public Action<object, EventArgs> CloseApplicationEvent;
        public ResultView(Action<object, EventArgs> CloseApplicationEvent)
        {
            this.CloseApplicationEvent += CloseApplicationEvent;
            InitializeComponent();
        }
        public void showResult(int userPoints, int maxPoints, int minutesRemaining, int secondsRemaining)
        {
            pointsLabel.Text = userPoints.ToString() + "/" + maxPoints.ToString();
            timeLabel.Text = minutesRemaining.ToString() + ":" + secondsRemaining.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            CloseApplicationEvent(sender, e);
        }
    }
}
