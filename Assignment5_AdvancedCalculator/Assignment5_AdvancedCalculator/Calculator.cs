using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Facade Pattern
namespace Assignment5_AdvancedCalculator
{
    class Calculator
    {
        public UserInput userInput;
        string calculation;
        public EquationFactory equationToCalculate;
        public CalculatorMathLogic mathLogic;


        public Calculator()
        {
            userInput = new UserInput();
            calculation = userInput.GetUserInput();
            equationToCalculate = new EquationFactory(calculation);
            mathLogic = new CalculatorMathLogic(equationToCalculate);
            mathLogic.DetermineCalculation();
            PrintTotal(); 
        }

        public void PrintTotal()
        {
            Console.WriteLine("Total: {0}", mathLogic.total);
        }
    }
}
