using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab2
{
    internal class Program
    {
        public static int ToMultiplicate(int x, int n)
        {
            return x * n;
        }

        public static double ToMultiplicate(double x, int n)
        {
            return x * n;
        }

        public static string ToMultiplicate(string x, int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
                s += x;
            return s;
        }

        public static void Main(string[] args)
        {
            Console.Write("Write x = ");
            string x = Console.ReadLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("int: " + ToMultiplicate(int.Parse(x), n));
            }
            catch { }
            try
            {
                Console.WriteLine("double: " + ToMultiplicate(double.Parse(x), n));
            }
            catch { }

            Console.WriteLine("string: " + ToMultiplicate(x, n));
        }
    }
}
