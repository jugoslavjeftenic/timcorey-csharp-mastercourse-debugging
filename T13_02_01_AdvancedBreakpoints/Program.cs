﻿namespace T13_02_01_AdvancedBreakpoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunsALot();
        }

        private static void RunsALot()
        {
            long total = 0;
            int test = 0;

            for (int i = -1000; i <= 1000; i++)
            {
                total += i;
                try
                {
                    test = 5 / i;
                }
                catch (Exception)
                {
                    Console.WriteLine("There was an exception.");
                }
            }

            Console.WriteLine($"The total is: {total}.");
        }
    }
}