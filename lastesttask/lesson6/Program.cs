using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int[] x = { 1, 2, 3, 6, 4, 8 };
            //Total(x);
            //TotalParametrMulti(x, 100);
            TotalParamsileMultiParametr(5,6,3,9,23);
            //TotalParamsile(5, 4, 7, 8, 2);
            



            //for (int i = 0; i < x.Length; i++)
            //{ 
            //Console.WriteLine(x[i]);
            // }
            //foreach(var item in x)
            //{
            //Console.WriteLine(item);
            //}
            //Total(x);
            //int[] dynamicArr = new int[5];

            //for (int i = 0; i < dynamicArr.Length; i++)
            // {
            //Console.WriteLine(i+1"elementi daxil edin");
            //int eded = Convert.ToInt32(Console.ReadLine());
            // dynamicArr[i] = eded;
            // }

            //Total(dynamicArr);
        }



        public static void TotalParamsile(params int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result + "cavab");
        }

        public static void TotalParamsileMultiParametr(int y,params int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result +y+ "cavab paramsilemulti");
        }
        public static void TotalParametrMulti( int[] array,int y)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            Console.WriteLine(result + y + "cavab multi");
        }


        public static void Total(int[] array)
        {
            int result=0;
            foreach(var item in array)
            {
                result += item;
            }
            Console.WriteLine(result);
        }


      
    }

}
