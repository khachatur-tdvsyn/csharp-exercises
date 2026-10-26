using CSharpExercises.Lab1;
using CSharpExercises.Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab 1
            /*int n, a, b;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Matrix m = new Matrix(n, a, b);
            m.ShowMatrix();*/

            //Lab2
            Console.Write("Write x = ");
            string x = Console.ReadLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("int: " + OverloadExample.ToMultiplicate(int.Parse(x), n));
            }
            catch { }
            try
            {
                Console.WriteLine("double: " + OverloadExample.ToMultiplicate(double.Parse(x), n));
            }
            catch { }

            Console.WriteLine("string: " + OverloadExample.ToMultiplicate(x, n));
        }
    }
}
