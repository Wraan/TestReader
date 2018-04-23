using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestReader
{
    public class UserAnswer
    {
        private bool[] answers = { false, false, false, false };
        public bool[] Answers
        {
            get
            {
                return answers;
            }
            set
            {
                answers = value;
            }
        }


    }
}
