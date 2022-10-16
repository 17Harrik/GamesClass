using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClass
{
    class OpenWorld : Games
    {
        public OpenWorld(string name, string rating, string releaseDate, string downloads)
        {
            this.name = name;
            this.rating = rating;
            this.releaseDate = releaseDate;
            this.downloads = downloads;
        }

        public void BlockNum()
        {
            Console.WriteLine($"There are {BLOCKNUM} blocks in {name}");
        }

        public string BLOCKNUM = "820";
    }
}
