using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework.CSharp.Class08.Class
{
    public class Song
    {
        public Song(string title, int length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }

        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }
    }
}
