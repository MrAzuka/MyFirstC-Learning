/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstC_Learning
{
    internal class SumOfNum
    {
        *//*
        * Create and initalize int array of numbers
        * Create a function SumOfNumbers with int return type
        * int array param
        * function should return total of all numbers
        * call in main and output total
        * extra: check array size length
            * return -1 if array is empty
            * check return in main and output message
        *//*

        static int SumOfNumbers(int[] x)
        {
            if (x.Length == 0)
            {
                return -1;
            };
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
                sum += x[i];
            }
            return sum;

        }

        static void PrintResult(int x)
        {
            if (x == -1)
            {
                Console.WriteLine("Cannot sum an empty array");
            }
            else
            {
                Console.WriteLine($"The sum of the numbers is {x}");
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            *//*call the function*//*
            PrintResult(SumOfNumbers(numbers));
            Console.ReadLine();
        }
    }
}
*/