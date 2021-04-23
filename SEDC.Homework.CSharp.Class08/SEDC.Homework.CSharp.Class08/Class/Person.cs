using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.CSharp.Class08.Class
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoriteMusic)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusicType = favoriteMusic;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} hates music");
            }
            else
            {
                Console.WriteLine($"Sorry {GetFullName()} like this song");


                System.Collections.IList list = FavoriteSongs;
                for (int i = 0; i < list.Count; i++)
                {
                    Song song = (Song)list[i];
                    Console.WriteLine($"Title: {song.Title} Genre: {song.Genre} Length: {song.Length}");
                }
            }
        }

    }
}
