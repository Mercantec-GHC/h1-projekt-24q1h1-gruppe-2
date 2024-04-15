using System.Formats.Asn1;
using System.Net;

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

    }
}

