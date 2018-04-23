using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    interface IEnterPasswordView
    {
        event Action<object, EventArgs> VCheckPasswordEvent;
        void Show();
        void Close();
        string Password { get; set; }
        void clearPassword();
    }
}
