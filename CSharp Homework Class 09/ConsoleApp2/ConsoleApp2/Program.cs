using ConsoleApp2.Class;
using SEDC.CSharp.Homework.Class09.Class;
using SEDC.CSharp.Homework.Class09.Movies;
using System;
using System.Collections.Generic;

namespace SEDC.CSharp.Homework.Class09
{
    class Program
    {
           static void Main(string[] args)
            {

                Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4);
                Movie movie2 = new Movie("American Pie", Genre.Comedy, 4);
                Movie movie3 = new Movie("Saw", Genre.Horror, 4);
                Movie movie4 = new Movie("The Shining", Genre.Horror, 4);
                Movie movie5 = new Movie("Rambo", Genre.Action, 4);
                Movie movie6 = new Movie("The Terminator", Genre.Action, 4);
                Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4);
                Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4);
                Movie movie9 = new Movie("Passengers", Genre.SciFi, 4);
                Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4);

                List<Movie> MovieList1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };

                Movie movie11 = new Movie("Airplane", Genre.Comedy, 4);
                Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4);
                Movie movie13 = new Movie("The Ring", Genre.Horror, 4);
                Movie movie14 = new Movie("Sinister", Genre.Horror, 4);
                Movie movie15 = new Movie("RoboCop", Genre.Action, 4);
                Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4);
                Movie movie17 = new Movie("The Social Network", Genre.Drama, 4);
                Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4);
                Movie movie19 = new Movie("Inception", Genre.SciFi, 4);
                Movie movie20 = new Movie("Avatar", Genre.SciFi, 4);

                List<Movie> MovieList2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };

                TotheMovies();

                Console.ReadLine();



            }
            public static void TotheMovies()
            {
                MovieService movieService = new MovieService();

                Cinema cinema1 = new Cinema("Cinema1", new List<int>() { 1, 2, 3, 4 }, movieService.MovieList1);

                Cinema cinema2 = new Cinema("Cinema2", new List<int>() { 1, 2 }, movieService.MovieList2);

                Console.WriteLine("Please choose a cinema");
                Console.WriteLine($"1.{cinema1.Name} \n2.{cinema2.Name}");

                Cinema userCinema = new Cinema();

                string userInput = Console.ReadLine();

                bool isValid = Int32.TryParse(userInput, out int userCinemaChoice);
                if (isValid)
                {
                    while (userCinemaChoice == 0)
                    {
                        Console.WriteLine($"1.{cinema1.Name} \n2.{cinema2.Name}");

                    }
                    switch (userCinemaChoice)
                    {
                        case 1:
                            userCinema = cinema1;
                            break;
                        case 2:
                            userCinema = cinema2;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine("Do you want to see \n1.All movies \n2.By Genre");

                string userInputt = Console.ReadLine();

                bool isValidMovies = Int32.TryParse(userInputt, out int userFilterMovies);
                if (isValidMovies)
                {
                    while (userFilterMovies == 0)
                    {
                        Console.WriteLine("Do you want to see \n1.All movies \n2.By Genre");
                    }

                    if (userFilterMovies == 1)
                    {
                        userCinema.PrintMovies(userCinema.ListOfMovies);
                    }
                }

                List<Movie> userChoiceOfMovies = null;
                if (userFilterMovies == 2)
                {
                    while (userFilterMovies == null)
                    {
                        try
                        {
                            Console.WriteLine($"Enter your favorite genre");
                            userChoiceOfMovies = userCinema.SearchMoviesByGenre(Console.ReadLine());
                            userCinema.PrintMovies(userChoiceOfMovies);
                        }
                        catch (InvalidGenreException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                    }
                }

                Movie selectedMovie = null;
                Console.WriteLine("Enter the movie number to watch the movie");
                if (userFilterMovies == 1)
                {
                    while (selectedMovie == null)
                    {
                        try
                        {
                            selectedMovie = userCinema.IsValidMovieSelection(userCinema.ListOfMovies, Console.ReadLine());
                        }
                        catch (InvalidMovieSelectedException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                    }
                }

                if (userFilterMovies == 2)
                {
                    while (selectedMovie == null)
                    {
                        try
                        {
                            selectedMovie = userCinema.IsValidMovieSelection(userChoiceOfMovies, Console.ReadLine());
                        }
                        catch (InvalidMovieSelectedException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                    }
                }
                userCinema.MoviePlaying(selectedMovie);
            }
    }
}
