using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Class1
    {
        private int result;
        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public void Add(int num1, int num2)
        {
            result = num1 + num2;
        }

        public void Sub(int num1, int num2)
        {
            result = num1 - num2;
        }

        public void Mul(int num1, int num2)
        {
            result = num1 * num2;
        }

        public void Div(int num1, int num2)
        {
            result = num1 / num2;
        }
    }
}
