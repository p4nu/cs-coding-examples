using System;

namespace ReturnValuesFromMethods
{
    public class Example2
    {
        public Example2()
        {
            Run();
        }

        private void Run()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         EXAMPLE 2         ");
            Console.WriteLine("***************************");

            int numberOne = 1;
            int numberTwo = 2;

            int sum = Sum(numberOne, numberTwo);
            
            Console.WriteLine("Sum of " + numberOne + " and " + numberTwo + " is " + sum);
        }

        private int Sum(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }
    }
}
