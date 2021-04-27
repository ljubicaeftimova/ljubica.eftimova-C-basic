using ConsoleApp2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharp.Homework.Class09.Class
{
    public class Cinema
    {
        public Cinema()
        {

        }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = movies;
        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> ListOfMovies { get; set; }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"You are watching {movie.Title}, enjoy :)");
        }

        public void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine("Choose a movie by entering the number");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title},   Genre: {movies[i].Genre}");
            }
        }

        public List<Movie> SearchMoviesByGenre(string userInput)
        {
            List<Movie> filteredMovies = ListOfMovies.Where(movie => movie.Genre.ToString().ToLower() == userInput.ToLower()).ToList(); ;
            if (filteredMovies.Count == 0)
            {
                throw new InvalidGenreException();
            }
            try
            {
                filteredMovies = ListOfMovies.Where(movie => movie.Genre.ToString().ToLower() == userInput.ToLower()).ToList(); ;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch
            {
                throw new InvalidGenreException();
            }

            return filteredMovies;
        }

        public Movie IsValidMovieSelection(List<Movie> movies, string userInput)
        {
            Movie selectedMovie = new Movie();
            bool IsValidUserInput = int.TryParse(userInput, out int validUserInput);
            if (!IsValidUserInput)
            {
                throw new InvalidMovieSelectedException();
            }
            try
            {
                selectedMovie = movies[validUserInput - 1];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + " please enter a valid number");
            }
            catch
            {
                throw new InvalidMovieSelectedException();
            }

            return selectedMovie;
        }

        internal ConsoleApp2.Movie IsValidMovieSelection(List<ConsoleApp2.Movie> userMovies, string v)
        {
            throw new NotImplementedException();
        }

        internal void PrintMovies(List<ConsoleApp2.Movie> userMovies)
        {
            throw new NotImplementedException();
        }
    }
}
