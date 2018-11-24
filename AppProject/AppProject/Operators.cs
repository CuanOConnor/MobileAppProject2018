using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject
{
    // Class made to help with operators logic and calculation
    class Operators
    {
        public static double Calculate(double value1, double value2, string myOperator)
        {
            double result = 0;
            switch (myOperator) //switching on the operator chosens string value
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;

            }
            return result;

        }
    }
}
