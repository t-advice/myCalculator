using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCalculator
{
    internal class Multiplication: myCalculate
    {
        public new double FirstNumber { get; set; }
        public new double SecondNumber { get; set; }

        public double Calculate()
        {
            return FirstNumber * SecondNumber;
        
        }
    }
}
