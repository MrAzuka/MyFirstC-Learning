﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstC_Learning
{
    class Program
    {
        /*
        * Create an int and try convert any string to an int
        * Notice the error, write a try.....catch handler around it
        * catch the error and output the error message
        * without changing the current code
        * call in main and output total
        * 
        * Why is this a bad situation and how can we know it has converted?
        * 
        * Create a custome try parse function
        * Find the real function and return type/params
        * Read the tooltip it gives you, to give you ideas on what to do
        */
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            if (TryParse(Console.ReadLine(), out int result)) {
                Console.WriteLine($"converted, {result}");
            }
            else
            {
                Console.WriteLine("not converted");
            }


            Console.ReadLine();
        }

        static bool TryParse(string input, out int result) {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
