using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;


namespace cSharp
{
    public class Methods
    {
        public void HelloWorld()
        {
            Console.WriteLine("Enter any letter");
            string entry = Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Your letter was: " + entry);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            /*int[] result = new int[2];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    if (sum == target)
                    {
                        Console.WriteLine("i= " + i + ", j= " + j);
                        result[0] = i;
                        result[1] = i + 1;
                    }
                }
            }
            return result;
            */

            Dictionary<int, int> resultDictionary = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNumber = numbers[i];
                int secondNumber = target - firstNumber;
                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] {
                        index,
                        i
                    };
                }
                //resultDictionary.Add(firstNumber, i);
                resultDictionary[firstNumber] = i;
            }
            Console.WriteLine();
            return Array.Empty<int>();
        }

        public void WriteStuff()
        {
            string readFile = "alice.txt";
            string writeFile = "output.txt";
            string currentDirectory = Environment.CurrentDirectory;
            string directory = @"C:\Users\james\source\repos\cSharp\";
            // the @ tells the compiler to use the string as is (no escape needed)
            string fullReadPath = Path.Combine(directory, readFile);
            string fullWritePath = Path.Combine(directory, writeFile);
            try
            {
                using (StreamReader sr = new StreamReader(fullReadPath))
                using (StreamWriter sw = new StreamWriter(fullWritePath, false)) // false means overwrite the file (append = false)
                {
                    int lineNumber = 1;
                    while (!sr.EndOfStream)
                    {
                        string eachLine = sr.ReadLine();
                        StringBuilder sb = new StringBuilder(eachLine);
                        sb.Replace("Alice", "Skeletrex and His Bone Brigade");
                        sb.Replace("ALICE", "SKELETREX AND HIS BONE BRIGADE");
                        sb.Replace("Wonderland", "Houston, TX");
                        sb.Replace("WONDERLAND", "HOUSTON, TX");

                        if (sb.Length > 0)
                        {
                            eachLine = lineNumber + ": " + sb.ToString();

                        }


                        sw.WriteLine(eachLine);
                        lineNumber++;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ReadCSV()
        {
            List<string> allWords = new List<string>();
            string directory = @"C:\Users\james\source\repos\cSharp\";
            string readFile = "words.csv";
            string fullReadPath = Path.Combine(directory, readFile);

            try
            {
                using (StreamReader sr = new StreamReader(fullReadPath))
                {
                    string[] words = sr.ReadLine().Split(',');
                    allWords.AddRange(words);
                    foreach (string word in allWords)
                    {
                        Console.WriteLine(word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower());
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        public BigInteger FibPerimeter(BigInteger n)
        {
            BigInteger first = 1;
            BigInteger second = 1;
            BigInteger tempSum = first + second;
            List<BigInteger> fibs = new List<BigInteger>();
            fibs.Add(1);
            fibs.Add(1);
            for (BigInteger i = 2; i <= n; i++)
            {
                fibs.Add(tempSum);
                first = second;
                second = tempSum;
                tempSum = first + second;
            }

            BigInteger result = fibs.Aggregate(BigInteger.Add);
            Console.WriteLine(result);
            return result * 4;
        }

        public BigInteger fib(int n)
        {
            BigInteger a = 1, b = 1, c = a + b;
            List<BigInteger> fibs = new List<BigInteger>();
            fibs.Add(0); fibs.Add(a); fibs.Add(b);
            for (BigInteger i = 3; i < n; i++)
            {
                fibs.Add(c);
                a = b;
                b = c;
                c = a + b;
            }
            BigInteger result = fibs.Last();
            /*
            foreach (BigInteger i in fibs)
            {
                Console.WriteLine(i);

            }
            */
            Console.WriteLine(result);
            return result;
        }

        public int fibRecur(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return (fibRecur(n - 1) + fibRecur(n - 2));
            }
        }

        public void plusMinus(List<int> arr)
        {
            decimal count = arr.Count;
            decimal plus = 0;
            decimal minus = 0;
            decimal zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    plus++;
                }
                else if (arr[i] < 0)
                {
                    minus++;
                }
                else
                {
                    zero++;
                }
            }
            decimal plusRat = plus / count;
            decimal minusRat = minus / count;
            decimal zeroRat = zero / count;

            Console.WriteLine(String.Format("{0:#,0.000000}", plusRat));
            Console.WriteLine(String.Format("{0:#,0.000000}", minusRat));
            Console.WriteLine(String.Format("{0:#,0.000000}", zeroRat));

        }

        public void miniMaxSum(List<int> arr)
        {
            // print out minimum and maximum sum of 4 out of 5 numbers in a List<int>
            // allow for sum larger than int32
            arr.Sort();
            long min = arr.Min();
            long max = arr.Max();
            long sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }
            long minSum = sum - max;
            long maxSum = sum - min;
            Console.WriteLine($"{minSum} {maxSum}");
        }

        public string timeConversion(string s)
        {
            // take in AM/PM time format and return military time
            string ampm = s.Substring(s.Length - 2);
            string hours = s.Substring(0, 2);
            string remainder = s.Substring(2, 6);
            int intHours = int.Parse(hours);

            if (ampm == "AM" && hours == "12")
            {
                hours = "00";
            }

            if (ampm == "PM" && hours != "12")
            {
                intHours += 12;
                hours = intHours.ToString();
            }

            Console.WriteLine($"{hours}{remainder}");
            return $"{hours}{remainder}";
        }

        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            // return List of the number of times each query shows up in the strings list
            List<int> matches = new List<int>();
            int contains = 0;
            foreach (string q in queries)
            {
                if (strings.Contains(q))
                {
                    foreach (string s in strings)
                    {
                        if (s == q)
                        {
                            contains++;
                        }
                    }
                }
                matches.Add(contains);
                contains = 0;
            }
            Console.WriteLine($"{matches[0]} {matches[1]} {matches[2]}");
            return matches;
        }

        public int FindMostFrequent(int[] arr)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount[num] = 1;
                }
            }

            IEnumerable<int> sorted = from entry in numCount orderby entry.Key descending select entry.Value;

            int largest = sorted.FirstOrDefault();
            Console.WriteLine(numCount[largest]);
            return numCount[largest];
        }


    }
}
