﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathLibrary;

namespace LibraryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Writeline
            System.Console.WriteLine("Calling methods from MathLibrary.DLL:");

            if (args.Length != 2)
            {
                System.Console.WriteLine("Usage: TestCode <num1> <num2>");
                return;
            }

            long num1 = long.Parse(args[0]);
            long num2 = long.Parse(args[1]);

            long sum = AddClass.Add(num1, num2);
            long product = MultiplyClass.Multiply(num1, num2);

            System.Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
            System.Console.WriteLine("{0} * {1} = {2}", num1, num2, product);

        }
    }
}
