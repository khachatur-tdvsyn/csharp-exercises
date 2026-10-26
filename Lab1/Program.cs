using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, a, b;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            Matrix m = new Matrix(n, a, b);
            m.ShowMatrix();
        }
    }
}
