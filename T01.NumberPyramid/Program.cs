﻿using System;

namespace T01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (currentNum > n)
                    {
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                Console.WriteLine();
            }
        }
    }
}
