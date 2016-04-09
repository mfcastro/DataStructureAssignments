using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_AdvancedCalculator
{
    class CalculatorMathLogic
    {
        public double total;
        public double currentNum = 0;
        public double lastNumber = 0;
        public char currentOperator;
        public Queue<double> numbers = new Queue<double>();
        List<IEquation> calculationList;
        

        public CalculatorMathLogic(EquationFactory equation)
        {
            this.calculationList = equation.calculationList; 
            DetermineCalculation();
            DoCalculation();
        }


        public void DetermineCalculation()
        {
            for (int i = 0; i < this.calculationList.Count; i++)
            {
                lastNumber = currentNum;

                if (i == 0 && this.calculationList[i] is Number && !currentOperator.Equals(' '))
                {
                    currentNum = this.calculationList[i].number;
                    numbers.Enqueue(currentNum);
                }
                else if (this.calculationList[i] is Number)
                {
                    currentNum = this.calculationList[i].number;
                    numbers.Enqueue(currentNum);
                }
                else if (this.calculationList[i] is IOperator)
                {
                    currentOperator = this.calculationList[i].operatorType;
                }

            }

            DoCalculation();
        }


        public void DoCalculation()
        {
            switch (currentOperator)
            {
                case '+':
                    Add();
                    break;
                case '-':
                    Subtract();
                    break;
                case '*':
                    Multiply();
                    break;
                case '/':
                    Divide();
                    break;
                case '^':
                    Exponent();
                    break;
                default:
                    break;
            }
        }

        private void Exponent()
        {
            total = Math.Pow(lastNumber, currentNum);
        }

        public void Add()
        {
            total = lastNumber + currentNum;
        }

        public void Subtract()
        {
            total = lastNumber - currentNum;
        }

        public void Multiply()
        {
            total = lastNumber * currentNum;
        }

        public void Divide()
        {
            total = lastNumber / currentNum;
        }

    }
}
