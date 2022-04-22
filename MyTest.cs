using System;
using static System.Console;

namespace MyTest 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            //Declare variables
            int a, b, c, d, e, avg;

            //Enter test scores
            Write("Please enter first test score: ");
            a = Convert.ToInt32(ReadLine());

            Write("Please enter second test score: ");
            b = Convert.ToInt32(ReadLine());

            Write("Please enter third test score: ");
            c = Convert.ToInt32(ReadLine());

            Write("Please enter fourth test score: ");
            d = Convert.ToInt32(ReadLine());

            Write("Please enter fifth test score: ");
            e = Convert.ToInt32(ReadLine());

            //Calculate average score
            avg = (a + b + c + d + e)/5;

            //Display average score
            Write("The average score is {0}", avg.ToString("F2"));
        }
    }
}
