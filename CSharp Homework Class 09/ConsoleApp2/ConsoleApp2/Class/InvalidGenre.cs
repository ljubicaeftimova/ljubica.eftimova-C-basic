using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public class InvalidGenreException : Exception
    {
        public string Message { get; set; } = "Invalid genre exception";
    }
}
