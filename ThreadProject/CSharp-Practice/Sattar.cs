using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Sattar
    {
        
        public delegate string EnterHandler(string text);

        public event EnterHandler Enter;

        public void TriggerEnter(string a)
        {
            if (Enter != null)
            {
                Enter(a);
            }
        }

    }
}
