using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "y";
            while (input == "y")
            {
                Console.WriteLine("Enter a number between 1 and 100: ");
                int i = int.Parse(Console.ReadLine());

                while (i < 0 || i > 100)
                {
                    Console.WriteLine("Please try again with a number between 1 and 100.");
                    i = int.Parse(Console.ReadLine());
                }
                int e = i % 2;
                if (e == 1)
                {
                    Console.WriteLine(i + " and Odd");
                }
                else if (e != 1 && i <= 25)
                {
                    Console.WriteLine(i + ", Even and less than 25.");
                }
                else if (e != 1 && i >= 26 && i <= 60)
                {
                    Console.WriteLine("Even.");
                }
                else if (e != 1 && i > 60)
                {
                    Console.WriteLine(i + " and Even.");
                }
                Console.WriteLine("Continue? (y/n)");
                input = Console.ReadLine();
            }
            if(input == "n")
            {
                Console.WriteLine("Bye!");
            }
        }
    }
}
