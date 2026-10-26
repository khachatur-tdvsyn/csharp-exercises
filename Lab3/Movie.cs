using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises.Lab3
{
    internal enum Genre
    {
        Tragedy,
        Comedy,
        Drama,
        Adventuruous,
        Fantasy
    }
    internal class Movie
    {
        public int id;
        public string name;
        public int year;
        public Genre genre;
        public int views, likes;

        public Movie(int id, string name, int year, Genre genre, int views, int likes)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.genre = genre;
            this.views = views;
            this.likes = likes;
        }

        public double Rating()
        {
            return Math.Sqrt(likes * likes / views);
        }

        public override string ToString()
        {
            string yearString = string.Format("({0})", year);
            return string.Format("{0,-4} {1,15} {2,8} {3,12} {4:#.000,8}", id, name, yearString, genre.ToString(), Rating());
        }
    }
}
