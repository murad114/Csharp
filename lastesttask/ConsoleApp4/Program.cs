using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<=9; i++)

            Console.WriteLine($"{number}*{i}={number * i}");




            int number1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number1; i++)

                sum+=i*i;
            Console.WriteLine(sum);

            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum2 = 0;
            int pow = 1;
            for (int i = 1; i <= number2; i++)
            { sum2 += i;
              pow *= i;
            
            }
               
      

            Console.WriteLine(pow-sum);

        }
          

        }
    }

