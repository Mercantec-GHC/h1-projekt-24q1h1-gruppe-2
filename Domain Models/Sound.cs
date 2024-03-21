﻿using System.Formats.Asn1;

namespace Domain_Models
{
    public abstract class Sound
    {
        public int soundId { get; set; }
        public string url { get; set; }
        public string Name {  get; set; }
        public string Condition { get; set; }
        public string Speed { get; set; }
        public string Tracks { get; set; }
        public string Size { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public string Brand { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public bool Favorite { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Sound(string Name, string Condition, string Speed, string Tracks, int Price )
        {
            this.Name = Name ;
            this.Condition = Condition ;
            this.Speed = Speed ;
            this.Tracks = Tracks ;
            this.Price = Price ;

        }
        public virtual void DisplaySound()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"This classical is called ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($);
        }

    }

    public abstract class Sound : 

    public abstract class Kassettebånd
    {
        public string kind { get; set; }

    }

    public class CDs
    {
        public string Length { get; set; }

    }


    public class Vinyl
    {
        public int size { get; set; }
        public string kind { set; get; }

    }

}
