using System;

namespace ReturnValuesFromMethods
{
    public class Example3
    {
        public Example3()
        {
            Run();
        }

        private void Run()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("         EXAMPLE 3         ");
            Console.WriteLine("***************************");

            var numberOne = 1;
            var numberTwo = 2;
            
            Console.WriteLine("Sum of " + numberOne + " and " + numberTwo + " is " + Sum(numberOne, numberTwo));
        }

        private int Sum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }
    }
}
