using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number and i'll tell you if it's odd or even:");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            Console.WriteLine("That is an even number...i'm smart aye!");
            else
            Console.WriteLine("That is an odd number...i'm smart aye!");

            Console.ReadLine();


        }
    }
}
