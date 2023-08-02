using System;
using System.Collections.Generic;
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

            //int[] myArr = { 2111111111, 222222222, 333333333, 444444444, 555555555 };
            //List<int> intList = new List<int>();
            //intList.AddRange(myArr);

            //method.miniMaxSum(intList);

            //method.timeConversion("12:01:00AM");

            //string[] stringArr = { "ab", "ab", "abc" };
            //string[] queriesArr = { "ab", "abc", "bc" };
            //List<string> strings = new List<string>();
            //List<string> queries = new List<string>();
            //strings.AddRange(stringArr);
            //queries.AddRange(queriesArr);

            //method.matchingStrings(strings, queries);

            //int[] arr = { 3, 4, 2, 3, 5, 4, 3, 2, 1, 2, 4, 4, 2, 5, 2 };
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            // sorted is 1 1 2 2 3 3 4

            List<int> intList = new List<int>();
            intList.AddRange(arr);


            List<int> listA = new List<int> { 112, 42, 83, 119 };
            List<int> listB = new List<int> { 56, 125, 56, 49 };
            List<int> listC = new List<int> { 15, 78, 101, 43 };
            List<int> listD = new List<int> { 62, 98, 114, 108 };

            //sum = 414
            //List<List<int>> theMatrix = new List<List<int>> { listA, listB, listC, listD };

            method.TwoSum(arr, 6);

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
