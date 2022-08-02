using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Exercise2
{
    class Movie
    {
        public string strTitle;
        public string strGenre;
        public int intYear;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie objMovie1;          // part(b) Declare an object objMovie1 of type Movie
            objMovie1 = new Movie();  // Instantiate the object objMovie1
            //Movie objectMovie1 = new Movie();

            Console.Write("What is a title of the movie:");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("What is the genre of the movie:");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("What is the year of the movie:");
            objMovie1.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Movie Title is {ar1 strTitle0}, Genre is {1}, Year is{2}", objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear);
        }
    }
}
