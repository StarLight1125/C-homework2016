using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello C#  " + args.Length);
            foreach (string x in args)
            {
                Console.WriteLine("Test {0}",x);
            }
            Console.WriteLine("{0 :G}", System.DateTime.Now);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
