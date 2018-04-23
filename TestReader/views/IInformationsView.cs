using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public interface IInformationsView
    {
        string Path { get; set; }
        event Action<object, EventArgs> VEnterPasswordEvent;
        event Action<object, EventArgs> VReadFileEvent;
        void showTestInfo(Test test);
        void Hide();
        void Close();

    }
}
