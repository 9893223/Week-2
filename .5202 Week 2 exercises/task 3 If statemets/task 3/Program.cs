using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your final mark. This should be a number between 0-100");
            float mark = float.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
                Console.WriteLine("Your grade is an A+");
            else if (mark >= 80 && mark <= 89)
                Console.WriteLine("Your grade is an A");
            else if (mark >= 70 && mark <= 79)
                Console.WriteLine("Your grade is an B+");
            else if (mark >= 60 && mark <= 69)
                Console.WriteLine("Your grade is an B");
            else if (mark >= 50 && mark <= 59)
                Console.WriteLine("Your grade is an C");
            else if (mark >= 40 && mark <= 49)
                Console.WriteLine("Your grade is an D");
            else if (mark >= 0 && mark <= 39)
                Console.WriteLine("Your grade is an F");





            Console.ReadLine();


        }
    }
}
