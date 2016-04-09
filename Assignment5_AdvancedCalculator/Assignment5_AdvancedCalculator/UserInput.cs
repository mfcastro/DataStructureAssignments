using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_AdvancedCalculator
{
    class UserInput
    {
        string[] operatorList = { "+", "-", "*", "/", "^" };
        string equation;

        public string GetUserInput()
        {
            Console.WriteLine("Enter a calculation. Ex. 3+5");
            equation = Console.ReadLine();
            if (equation.Equals("c"))
            {
                ClearCalculator();
            }
            else if (CheckIfInputIsEquation(equation) == true)
            {
                return equation;
            }
            else
            {
                Console.WriteLine("Incorrect Format!");
                GetUserInput();
            }
            return equation;
        }

        public bool CheckIfInputIsEquation(string equation)
        {
            bool contains = false;

            foreach(string x in operatorList)
            {
                if (equation.Contains(x))
                {
                    contains = true;
                }
            }

            return contains;
        }

        public int ClearCalculator()
        {
            return 0;
        }

    }
}
