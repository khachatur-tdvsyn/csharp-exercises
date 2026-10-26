using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab1
{
    internal class Matrix
    {
        private int[,] matrix;
        private Random r;
        private int n = 1, a, b;

        public void SetN(int n)
        {
            if (n > 0)
                this.n = n;
            else
                throw new Exception("n should be a positive number");
        }

        public int GetN() { return n; }

        public void SetA(int a) { this.a = a; }
        public int GetA() { return a; }

        public void SetB(int b) { this.b = b; } 
        public int GetB() { return b; }

        private void FillMatrix()
        {
            matrix = new int[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = r.Next(a, b + 1);
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        public Matrix(int n, int a, int b)
        {
            SetN(n);
            SetA(a);
            SetB(b);

            r = new Random();
            FillMatrix();
        }
    }
}
