using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_AdvancedCalculator
{
    class SubtractOperator :IOperator
    {
        public double number { get; set; }
        public char operatorType { get; set; }

        public SubtractOperator()
        {
            operatorType = '-';
            number = 0;
        }
    }
}
