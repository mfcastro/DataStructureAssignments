using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment5_AdvancedCalculator
{
    class Calculator
    {
        public UserInput userInput;
        string calculation;
        public EquationFactory equationToCalculate;
        public CalculatorMathLogic mathLogic;
        double total;

        public Calculator()
        {
            RunCalculator();   
        }

        public void PrintTotal()
        {
            this.total = mathLogic.total;
            Console.WriteLine("Total: {0}", mathLogic.total);
        }

        public void RunCalculator()
        {
            userInput = new UserInput();
            calculation = userInput.GetUserInput();
            equationToCalculate = new EquationFactory(calculation);
            mathLogic = new CalculatorMathLogic(equationToCalculate);
            mathLogic.DetermineCalculation();
            PrintTotal();
        }
    }
}
