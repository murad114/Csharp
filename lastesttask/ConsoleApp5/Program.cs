using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a / 1000;
            int c = b / 1000;
            int d = c / 100;

            Console.WriteLine(a + b + c + d);


        }
    }
}
