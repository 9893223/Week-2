using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello" + " " + name);

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your gender?");
            string gender = Console.ReadLine();

            Console.WriteLine("What is your address?");
            string address = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine("Your age is:" + " " + age);
            Console.WriteLine("Your gender is:" + " " + gender);
            Console.WriteLine("Your address is:" + " " + address);

            Console.ReadLine();
        }
    }
}
