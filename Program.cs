﻿using System;
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

            string[] stringArr = { "ab", "ab", "abc" };
            string[] queriesArr = { "ab", "abc", "bc" };
            List<string> strings = new List<string>();
            List<string> queries = new List<string>();
            strings.AddRange(stringArr);
            queries.AddRange(queriesArr);

            method.matchingStrings(strings, queries);

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
