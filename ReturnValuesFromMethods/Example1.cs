using System;

namespace ReturnValuesFromMethods
{
    public class Example1
    {
        public Example1()
        {
            Run();
        }

        private void Run()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         EXAMPLE 1         ");
            Console.WriteLine("***************************");

            int sum = Sum(1, 2); // "Magic numbers" -> bad method
            
            Console.WriteLine("Sum of 1 and 2 is " + sum);
        }

        private int Sum(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;
            return sum;
        }
    }
}
