using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables__operators_and_decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You're about to be tested");
            Console.Write("Test 1 - Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}", name);
        
            Console.Write("Could you please enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write($"Okay {name}, could you please enter your gender: ");
            string gender = Console.ReadLine();

            Console.Write("Please enter your address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Okay, here is the information that I gathered:");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Address: {0}", address);

            Console.WriteLine("Test 1 is complete - Press enter to continue...");
            Console.ReadLine();

            Console.Clear();

        }
    }
}
