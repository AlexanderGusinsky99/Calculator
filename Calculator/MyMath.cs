using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyMath
    {
        public static double ReturnResult(int action, double numberOne, double numberTwo)
        {
            double result = 0;
            if (action == 1)
            {
                result = Add(numberOne, numberTwo);
            }
            else if (action == 2)
            {
                result = Subtract(numberOne, numberTwo);
            }
            else if (action == 3)
            {
                result = Multiply(numberOne, numberTwo);
            }
            else if (action == 4)
            {
                result = Divide(numberOne, numberTwo);
            }
            return result;
        }
        public static double ReturnResult(int action, double numberOne)
        {
            double result = 0;
            if (action == 5)
            {
                result = Square(numberOne);
            }
            if (action == 6)
            {
                result = Negate(numberOne);
            }
            return result;
        }
        private static double Add(double numberOne, double numberTwo)
        {
            double result;
            result = numberOne + numberTwo;
            return result;
        }
        private static double Subtract(double numberOne, double numberTwo)
        {
            double result;
            result = numberOne - numberTwo;
            return result;
        }
        private static double Multiply(double numberOne, double numberTwo)
        {
            double result;
            result = numberOne * numberTwo;
            return result;
        }
        private static double Divide(double numberOne, double numberTwo)
        {
            double result;
            result = numberOne / numberTwo;
            return result;
        }
        private static double Square(double number)
        {
            double result;
            result = number * number;
            return result;
        }
        private static double Negate(double number)
        {
            double result;
            result = -number;
            return result;
        }
    }
}
