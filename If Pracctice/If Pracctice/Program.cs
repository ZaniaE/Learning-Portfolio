using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Pracctice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Number Two... - Please enter a number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int num2 = int.Parse(Console.ReadLine());

            //this is how you add their chosen numbers together
            Console.WriteLine("{0}+{1} = {2}", num1, num2, (num1 + num2));

            //this is how you subtract their chosen numbers
            Console.WriteLine("{0}-{1} = {2}", num1, num2, (num1 - num2));

            //this is how you multiply their numbers
            Console.WriteLine("{0}x{1} = {2}", num1, num2, (num1 * num2));

            // this is how you divide their numbers
            Console.WriteLine("{0}/{1} = {2}", num1, num2, (num1 / num2));

            Console.WriteLine("Your second test is complete, congratulations. Press enter to continue...");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
