using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab2
{
    internal class OverloadExample
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
    }
}
