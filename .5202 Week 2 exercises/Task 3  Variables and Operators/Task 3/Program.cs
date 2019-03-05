using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string fname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lname = Console.ReadLine();

            Console.WriteLine("Hello" + " " + fname + " " + lname);

            Console.ReadLine();
        }
    }
}
