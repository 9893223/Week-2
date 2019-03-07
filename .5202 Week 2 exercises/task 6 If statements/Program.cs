using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a 3 letter palidrome. Input the first letter and press enter?");
            string firstletter = Console.ReadLine();

            Console.WriteLine("What is the second letter?");
            string secondletter = Console.ReadLine();

            Console.WriteLine("What is the third letter?");
            string thirdletter = Console.ReadLine();

            if (firstletter == thirdletter)
            {

                if (secondletter == "a" || secondletter == "e" || secondletter == "i" || secondletter == "o" || secondletter == "u")
                    Console.WriteLine("{0}{1}{2} is a palidrome", firstletter, secondletter, thirdletter);

                else
                    Console.WriteLine("I dont think that's a real word");
            }
            else
                Console.WriteLine("{0}{1}{2} is not a palidrome", firstletter, secondletter, thirdletter);


            Console.WriteLine("Task is finsihed. Press enter to continue");
            Console.ReadLine();
            Console.Clear();



            
        }
    }
}
