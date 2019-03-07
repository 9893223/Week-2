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
 
                Console.WriteLine("Please input the number of the program would you like to run from the following menu: \n1)Details \n2)Maths \n3)Hello");
                int input = int.Parse(Console.ReadLine());

                if(input ==1)
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

            if (input == 2)
            {

                Console.WriteLine("Please input the number of the equation you would like to do from the following menu: \n1)Multiplication \n2)Division \n3)Addition \n3)Subtraction");
                int input2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a second number");
                int num2 = int.Parse(Console.ReadLine());

               

                    int answer;
                    answer = num1 + num2;

                if (input2 == 3)
                {

                    answer = num1 + num2;

                    Console.WriteLine("{0} + {1} = {2}", num1, num2, answer);
                    answer = num1 + num2;
                }

                else if (input2 == 1)
                {
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, answer);
                    answer = num1 * num2;
                }

                else if (input2 == 2)
                {
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, answer);
                    answer = num1 / num2;
                }

                else
                {
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, answer);
                    answer = num1 - num2;
                }

                Console.ReadLine();
                }

                if (input ==3)

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
}
