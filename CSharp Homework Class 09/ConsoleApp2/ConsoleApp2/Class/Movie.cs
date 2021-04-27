using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharp.Homework.Class09.Class
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string title, Genre genre, int rating)
        {
            if (rating >= 1 && rating <= 5)
            {
                this.Rating = rating;
            }
            else
            {
                throw new Exception();
            }
            Title = title;
            Genre = genre;
            TicketPrice = 5 * rating;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }
    }
}
