using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClass
{
    internal class Games
    {
        public void Rating()
        {
            Console.WriteLine($"{name} has a rating of {rating}");
        }

        public void ReleaseDate()
        {
            Console.WriteLine($"{name} was released on the {releaseDate}");
        }

        public void Downloads()
        {
            Console.WriteLine($"{name} has {downloads} total downloads");
        }

        public string name;

        public string rating;

        public string releaseDate;

        public string downloads;
    }
}
