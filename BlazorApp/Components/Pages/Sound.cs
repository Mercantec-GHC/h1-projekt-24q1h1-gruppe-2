namespace classical
{
    public class Sound
    {
        public string Condition { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public string Brand { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public bool Favorite { get; set; }


    }

    public class Kassettebånd
    {
        public string kind { get; set; }

    }

    public class Vinyl
    {
        public int size { get; set; }
        public string kind { set; get; }

    }

}
