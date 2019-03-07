using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_Is_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a 4-digit pin number:");
            int pin = int.Parse(Console.ReadLine());

            if (pin >= 1000 && pin <= 9999)
            {
                Console.WriteLine("Thank you, please re-enter your 4-digit pin number:");
                int pin2 = int.Parse(Console.ReadLine());
                if (pin == pin2)
                    Console.WriteLine("Pin accepted");
                if (pin == pin2)

                    Console.WriteLine("Thank you, your pin has been set");

                else

                    Console.WriteLine("“Error! Your PIN numbers did not match. Your PIN was not set”.");

            }

            else

                Console.WriteLine("Your pin did not not meet the requirments.");

            Console.ReadLine();




        




        }
    }
}
