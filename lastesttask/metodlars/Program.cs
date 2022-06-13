using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlars
{
    internal class Program
    {
        private static int c;
        private static long b;

        static void Main(string[] args)
        {
            Azer(5);
            Samir(4);
            Tahir("8");
            Akif(10, 15);
            Arif("6", 12);
            Natiq(7, 13);
            Rafik(9, 11);
            Ramil("4", 5, 6);
            Console.WriteLine(Sum(11));
            Console.WriteLine(tap1(55));
            Console.WriteLine(Tap2("70"));   
            Console.WriteLine(tap3(78,"43"));
            Console.WriteLine(tap4(45,67));
            Console.WriteLine(tap5("85", 97));
            Console.WriteLine(tap6("55",88));
            Console.WriteLine(tap7(80,35));
            Console.WriteLine(tap8(89,34));
            Console.WriteLine(tap9(47,40));
            Console.WriteLine(tap10(69, 28));
            tap11(4, "8", 7);

        }

        private static int tap7(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static void Azer(int a)

        {
            a = 5;
            Console.WriteLine(a);
        }



        static void Samir(long b)

        {
            b = 4;
            Console.WriteLine(b);
        }

        static void Tahir(string c)

        {
            c = "8";

            Console.WriteLine(c);
        }

        public static void Akif(int f, long j)
        {
            f = 10;
            j = 15;

            Console.WriteLine(f + "," + j);
        }

        public static void Arif(string q, long p)

        {
            q = "6";
            p = 12;
            Console.WriteLine(q + "," + p);
        }

        public static void Natiq(sbyte w, long e)
        {
            w = 7;
            e = 13;
            Console.WriteLine(w + "," + e);
        }

        public static void Rafik(byte y, long u)
        {
            y = 9;
            u = 11;
            Console.WriteLine(y + "," + u);
        }

        public static void Ramil(string k, long l, byte g)
        {
            k = "4";
            l = 5;
            g = 6;

            Console.WriteLine(k + "," + l + "," + g);
        }

        static int Sum(int q1)

        {
            int result = q1;
            return result;

        }


        public static byte tap1(long w1)
        {
            long result1 = w1;
            return (byte)result1;
        }

        public static string Tap2(string e1)

        {
            string name = e1;
            return name;
        }

        public static int tap3(long r1, string r2)
        {
            long result3 = r1;
            string result4 = r2;
            int.Parse(result4);
            return (int)result3;
        }
        
         public static char tap4(int t1,long t2)
        {
            int result5 = t1;
            long result6 = t2;
            Convert.ToInt32(result6);
            return (char)result5;
        }
       public static sbyte tap5(string y1,long y2)
        {
            string result7 = y1;
            long result8 = y2;

            Convert.ToInt32(result8);
            return Convert.ToSByte(result7);
        }
        public static bool tap6(string u1,long u2)
        {
        string result9=u1;
        long result10 = u2;
            
            Convert.ToInt32(result10);
            return Convert.ToBoolean(result9);
        }
        public static sbyte tap7(char o1,long o2) 
        {
        char result11 = o1;
        long result12 = o2;

        Convert.ToInt32(result11);
        return Convert.ToSByte(result12);
        }
        public static int tap8(sbyte p1,long p2)
        {
            sbyte result13 = p1;
            long result14 = p2;

            Convert.ToInt32(result13);
            return Convert.ToInt32(result14);

        }
        public static bool tap9(sbyte a1,long a2)
        {
            sbyte result15=a1;
            long result16=a2;

            Convert.ToInt32(result15);
            return Convert.ToBoolean(result16);
        }
        
        public static string tap10(byte s1,long s2)
        {
            byte result17=s1;
            long result18=s2;

            Convert.ToInt32(result17);
            return Convert.ToString(result18);
        }
        public static void tap11(byte f1,string f2,long f3)
        {
            f1 = 4;
            f2 = "8";
            f3 = 7;

            Console.WriteLine(f1 + "," + f2 + "," + f3);

        }
        
        

    }
} 
