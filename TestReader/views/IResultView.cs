using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    interface IResultView
    {
        void showResult(int userPoints, int maxPoints, int minutes, int seconds);
        void Show();
    }
}
