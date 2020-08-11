using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCalculator
{
    [Serializable]
    public class Class1
    {
        
        public int Num1
        {
            get;
            set;
        }
        public int Num2
        {
            get;
            set;
        }
        public int Add()
        {
            return Num1 + Num2;
        }
        public int Sub()
        {
            return Num1 - Num2;

        }
        public int Mul()
        {
            return Num1 * Num2;
        }
        public int Div()
        {
            return Num1 / Num2;
        }
    }
}
