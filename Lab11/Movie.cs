﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        #region Data Members
        private string title;
        private string category;
        #endregion



        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }


        #region Methods
        public static void PrintByGenre(List<Movie> movies, string _category)
        {
            List<string> titles = new List<string>();

            Console.WriteLine($"Movies in the {_category} category:");
            Console.WriteLine("================================");
            foreach(Movie movie in movies)
            {
                if(movie.category == _category)
                {
                    titles.Add(movie.title);
                }
            }
            titles.Sort();
            foreach (string name in titles)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
        }

        public static void ListMovies(List<Movie> movies)
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine("Here are our categories\n=======================");
            Console.WriteLine("\n\t1. Animated\n\t2. Drama\n\t3. Horror\n\t4. Scifi\n\t5. Quit");

            if (int.TryParse(Console.ReadLine(), out int selection))
            {
                switch (selection)
                {
                    case 1://Animated
                        {
                            Console.Clear();
                            PrintByGenre(movies, "Animated");
                            ListMovies(movies);
                            break;
                        }
                    case 2://Drama
                        {
                            Console.Clear();
                            PrintByGenre(movies, "Drama");
                            ListMovies(movies);
                            break;
                        }
                    case 3://Horror
                        {
                            Console.Clear();
                            PrintByGenre(movies, "Horror");
                            ListMovies(movies);
                            break;
                        }
                    case 4://Scifi
                        {
                            Console.Clear();
                            PrintByGenre(movies, "Scifi");
                            ListMovies(movies);
                            break;
                        }
                    case 5://Quit
                        {
                            break;
                        }                  
                }
            }
            else
            {
                Console.Clear();
                Console.Write("Invalid input! (Please enter a number from 1-5)");
                ListMovies(movies);
            }
        }

        

        #endregion

    }
}
