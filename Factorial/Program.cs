using System;

namespace Factorial
{
    class CalculateFactor
    {
        public static int getFactorial(int x)
        {
            if (x == 0)
                return 1;

            return x * getFactorial(x - 1);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFactor cal = new CalculateFactor();
            Console.WriteLine(cal.getFactorial(25));
        }
    }
}
