﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int num2 = int.Parse(Console.ReadLine());

            int answer;

            answer = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);
            answer = num1 * num2;
            Console.WriteLine("{0} * {1} = {2}", num1, num2, answer);
            answer = num1 / num2;
            Console.WriteLine("{0} / {1} = {2}", num1, num2, answer);
            answer = num1 - num2;
            Console.WriteLine("{0} - {1} = {2}", num1, num2, answer);

            Console.ReadLine();













        }
    }
}
