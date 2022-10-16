using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClass
{
    class FPS : Games
    {
        
        List<string> guns = new List<string> { "Classic", "Shorty", "Frenzy", "Ghost", "Sheriff", "Stinger", "Spectre", "Bucky",
            "Judge", "Bulldog", "Guardian", "Phantom", "Vandal", "Marshal", "Operator", "Ares", "Odin" };
        Random r = new Random();
        int index = Random.Next(guns.Count);

        public FPS(string name, string rating, string releaseDate, string downloads)
        {
            this.name = name;
            this.rating = rating;
            this.releaseDate = releaseDate;
            this.downloads = downloads;
        }

        public void GunSelect()
        {
            Console.WriteLine($"The Valorant gun selected at random is the {guns[index]}");
        }


    }
}
