using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5_AdvancedCalculator
{
    class EquationFactory
    {

        public readonly List<IEquation> calculationList = new List<IEquation>();
        char[] calculationArray;

        public EquationFactory(string calculation)
        {
            this.calculationArray = SplitCalulation(calculation);
            CreateCalculationObjects(calculationArray);
        }

        public char[] SplitCalulation(string calculation)
        {
            return calculation.ToCharArray();
        }

        public void CreateCalculationObjects(char[] calculation)
        {
            foreach (char x in calculation)
            {
                int num = 0;

                if (int.TryParse(x.ToString(), out num) == true)
                { 
                    calculationList.Add(new Number(num));
                }
                else if (x.Equals('+'))
                {
                    calculationList.Add(new AdditionOperator());
                }
                else if (x.Equals('-'))
                {
                    calculationList.Add(new SubtractOperator());
                }
                else if (x.Equals('*'))
                {
                    calculationList.Add(new MultiplicationOperator());
                }
                else if (x.Equals('/'))
                {
                    calculationList.Add(new DivideOperator());
                }
                else if (x.Equals('^'))
                {
                    calculationList.Add(new ExponentialOperator());
                }
            }
        }


        public int MoreThanOneDigit(char x)
        {
            int num = 0;
            int moreThanOneInt = 1;
            string currentInt = "";
            string current;


            int.TryParse(x.ToString(), out num);
            current = x.ToString();

            if (moreThanOneInt == 1)
            {
                moreThanOneInt = 2;
                currentInt += current;
            }
            else if (moreThanOneInt == 2)
            {
                num = int.Parse(currentInt + current);
            }

            return num;
        }

    }
}
