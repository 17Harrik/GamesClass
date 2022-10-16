using System;

namespace GamesClass 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpenWorld Minecraft = new OpenWorld("Minecraft", "5.0", "18th November 2011", "600 million");
            FPS Valorant = new FPS("Valorant" , "4.0", "2nd June 2020", "22.5 million");

            Minecraft.Rating();
            Minecraft.ReleaseDate();
            Minecraft.Downloads();
            Minecraft.BlockNum();

            Console.WriteLine("");

            Valorant.Rating();
            Valorant.ReleaseDate();
            Valorant.Downloads();
            Valorant.GunSelect();

        }
    }
}