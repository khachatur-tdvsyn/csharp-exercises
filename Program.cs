using CSharpExercises.Lab1;
using CSharpExercises.Lab2;
using CSharpExercises.Lab3;
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
            /*Console.Write("Write x = ");
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

            Console.WriteLine("string: " + OverloadExample.ToMultiplicate(x, n));*/

            //Lab3
            Console.Write("Insert count of movies: ");
            int n = int.Parse(Console.ReadLine());

            Movie[] movies = new Movie[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Write down parameters of movie: [id] [name] [date] [genre(1-5)] [views] [likes]");
                string[] movieValues = Console.ReadLine().Split(' ');

                movies[i] = new Movie(
                    int.Parse(movieValues[0]),
                    movieValues[1],
                    int.Parse(movieValues[2]),
                    (Genre)(int.Parse(movieValues[3]) - 1),
                    int.Parse(movieValues[4]),
                    int.Parse(movieValues[5])
                );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }
    }
}
