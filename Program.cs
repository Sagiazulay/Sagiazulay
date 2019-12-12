using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);

            Console.WriteLine("please enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);

            if (a % b == 0)
            {
                // if true
                Console.WriteLine("lelo sheerit");
            }
           else
            {
                // if false
                Console.WriteLine("iesh sheerit");
            }


        }
    }
}
