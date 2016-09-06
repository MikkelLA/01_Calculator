using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            var x = v1 + v2;
            return x;
        }

        internal static int Subtract(int v1, int v2)
        {
            var x = v1 - v2;
            return x;
        }

        internal static int Sum(int[] numbers)
        {

            int sum = 0;
            int i = 0;
            do
            {
                sum += numbers[i];
                i++;
            } while (i < numbers.Length);

            return sum;
        }

              internal static int Multiply(int v1, int v2)
        {
            var x = v1 * v2;
            return x;
        }


        internal static int Divide(int v1, int v2)
        {
            var x = v1 / v2;
            return x;
        }

        internal static double Power(int v1, int v2)
        {
            return Math.Pow(v1,v2);
        }

        internal static int Factorial(int x)
        {

            int sum = 1;
            int i = x;
            do
            {
                sum *= i;
                i--;
            } while (i > 0);

            return sum;

        }
    }
} 