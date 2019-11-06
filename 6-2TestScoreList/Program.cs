using System;
using static System.Console;

namespace _6_2TestScoreList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = new int[8];

            //Gets test scores from user
            for(int x = 0; x < tests.Length; ++x)
            {
                WriteLine("Enter test score:");
                tests[x] = Convert.ToInt32(ReadLine());
            }

            /*
             * Find the average of all the test scores
             */
            double total = 0;

            for (int x = 0; x < tests.Length; ++x)
            {
                total += tests[x]; //adds test at postion 'x' to total
            }

            double avg = total / tests.Length; //finds the average
            WriteLine("The Average is: {0}", avg);


            /*
             * Display results
             */

            double fromAvg;
            for (int x = 0; x < tests.Length; ++x)
            {
                fromAvg = tests[x] - avg;
                WriteLine("Test # {0}:    {1} From average:     {2}", x, tests[x], fromAvg);
            }



        }
    }
}
