using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
