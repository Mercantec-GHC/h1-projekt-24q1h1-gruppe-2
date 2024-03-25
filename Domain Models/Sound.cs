using System.Formats.Asn1;

namespace Domain_Models
{
    public class Sound
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name {  get; set; }
        public string condition { get; set; }
        public string speed { get; set; }
        public string tracks { get; set; }
        public string size { get; set; }
        public int year { get; set; }
        public int price { get; set; }
        public string genre { get; set; }
        public string brand { get; set; }
        public string album { get; set; }
        public string artist { get; set; }
        public bool favorite { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public List<string> image { get; set; }


        //removed constructor from code
        //public Sound(string name, string condition, string speed, string tracks, int price)
        //{
        //    this.name = name ;
        //    this.condition = condition ;
        //    this.speed = speed ;
        //    this.tracks = tracks ;
        //    this.price = price ;
        //}
        public virtual void DisplaySound()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"This classical is called ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.name}");
            Console.ResetColor();
            Console.WriteLine($"It is in this condition:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.condition}");
            Console.ResetColor();
            Console.WriteLine($"The speed of the track is:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.speed}");
            Console.ResetColor();
            Console.WriteLine($"Here is a list of the tracks that are includede:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.tracks}");
            Console.WriteLine($"The price of the item:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{this.price}");
        }
    }
}
