using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_AdvancedCalculator
{
    class Number : IEquation
    {
        public double number { get; set; }
        public char operatorType { get;}

        public Number(int number)
        {
            this.number = number;
        }
    }
}
