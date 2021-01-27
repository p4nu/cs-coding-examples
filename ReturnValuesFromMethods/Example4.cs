using System;

namespace ReturnValuesFromMethods
{
    public class Example4
    {
        public Example4()
        {
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         EXAMPLE 4         ");
            Console.WriteLine("***************************");

            const int numberOne = 1;
            const int numberTwo = 2;
            
            Console.WriteLine("Sum of " + numberOne + " and " + numberTwo + " is " + Sum(numberOne, numberTwo));
        }

        private static int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
