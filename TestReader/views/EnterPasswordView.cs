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
    
    public partial class EnterPasswordView : Form, IEnterPasswordView
    {
        public event Action<object, EventArgs> VCheckPasswordEvent;
        private string password;
        public string Password
        {
            get
            {
                password = passwordTextF.Text;
                return password;
            }
            set
            {
                password = passwordTextF.Text;
            }
        }
        public EnterPasswordView(Action<object, EventArgs> VCheckPasswordEvent)
        {
            InitializeComponent();
            this.VCheckPasswordEvent += VCheckPasswordEvent;
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            VCheckPasswordEvent(sender, e);
        }

        public void clearPassword()
        {
            passwordTextF.Clear();
        }

        private void passwordTextF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //If Enter is pressed
            if (e.KeyChar == (char)Keys.Return)
                startButton_Click(sender, e);
        }
    }
}
