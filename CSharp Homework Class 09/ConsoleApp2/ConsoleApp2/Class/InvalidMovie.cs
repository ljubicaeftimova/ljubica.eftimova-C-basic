using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public class InvalidMovieSelectedException : Exception
    {
        public string Message { get; set; } = "Invalid movie selection";
    }
}
