using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Models
{
    public abstract class Soundablegadget
    {
        public int gadgetId { get; set;}
        public string url { get; set;}
        public string name { get; set;}
        public string brand {  get; set;}
        public string color { get; set;}
        public string type { get; set;}

    }

    public class Bombox : Soundablegadget
    {
        
    }

    public class Radio : Soundablegadget
    {

    }

    public class Vinylplayer : Soundablegadget
    {

    }
}
