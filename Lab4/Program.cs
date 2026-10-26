using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab4
{
    internal class Program
    {
        public static void A(in int x)
        {
            //This expression throws exception
            //x = 7;

            int y = x + 7;
        }

        public static void B(out int x)
        {
            //Method throws exception if x isn't assigned anywhere 
            x = 6;
        }

        public static void C(ref int x)
        {
            x += 11;
        }

        public static int SumValues(params int[] values)
        {
            int s = 0;
            foreach(int i in values)
            {
                s += i;
            }
            return s;
        }

        static void Main(string[] args)
        {
            int x = 13;
            Console.WriteLine(x);
            A(x);
            A(in x);
            Console.WriteLine(x);

            B(out x);
            Console.WriteLine(x);
            C(ref x);
            Console.WriteLine(x);

            Console.WriteLine("sum: " + SumValues(6, 1, 6, 9, 31, 21, 54, 13, 17));
            Console.WriteLine("sum: " + SumValues(21, 56, 11, 3, -4, 45, -11));
        }
    }
}
