using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4_5_Csharp_BarryEarls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> scoreList = new List<int>();
            scoreList.Add(4400);
            scoreList.Add(8900);
            scoreList.Add(1200);
            scoreList.Add(3700);
            scoreList.Add(7200);

            scoreList.Sort();

            System.Console.WriteLine("\n" + "Scores Lowest to Highest" + "\n");

            foreach (int num in scoreList)
            {
                System.Console.WriteLine(num);
            }

            Console.ReadLine();


            scoreList.Reverse();

            System.Console.WriteLine("\n" + "Scores Highest to Lowest" + "\n");

            foreach (int num in scoreList)
            {
                System.Console.WriteLine(num);
            }

            Console.ReadLine();



            scoreList.Add(2400);

            System.Console.WriteLine("\n" + "New Number Added" + "\n");

            foreach (int num in scoreList)
            {
                System.Console.WriteLine(num);
            }

            Console.ReadLine();



            scoreList.Remove(4400);

            System.Console.WriteLine("\n" + "Terminated Score 4400" + "\n");

            foreach (int num in scoreList)
            {
                System.Console.WriteLine(num);
            }

            Console.ReadLine();











        }
    }
}
