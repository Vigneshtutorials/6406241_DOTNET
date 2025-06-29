using System;

namespace CalcLibrary
{
    interface IMathLibrary
    {
        double Addition(double a, double b);
        double Subtraction(double a, double b);
        double Multiplication(double a, double b);
        double Division(double a, double b);
    }

    public class SimpleCalculator : IMathLibrary
    {
        double result = 0;

        // Addition
        public double Addition(double a, double b)
        {
            result = a + b;
            return result;
        }

        // Subtraction
        public double Subtraction(double a, double b)
        {
            result = a - b;
            return result;
        }

        // Multiplication
        public double Multiplication(double a, double b)
        {
            result = a * b;
            return result;
        }

        // Division
        public double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Second Parameter Can't be Zero");
            result = a / b;
            return result;
        }

        // Method to clear the result
        public void AllClear()
        {
            result = 0;
        }

        // Method to get the result
        public double GetResult
        {
            get { return result; }
        }
    }
}
