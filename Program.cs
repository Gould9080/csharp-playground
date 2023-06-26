using System;
using System.Diagnostics;

namespace cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();

            //method.HelloWorld();
            //int[] numbers = { 1234, 5678, 9012 };
            //int target = 14690;
            //method.TwoSum(numbers, target);

            //method.WriteStuff();
            //method.ReadCSV();

            //method.FibPerimeter(5);

            method.fibRecur(5);


            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
