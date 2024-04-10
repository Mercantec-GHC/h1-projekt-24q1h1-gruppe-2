using Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain_Models
{
    public abstract class Soundablegadget
    {
        public uint GadgetId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Condition { get; set; }
        public int Year { get; set; }

        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public virtual void DisplaySoundablegadgets()
        {
            Console.WriteLine($"{this.Brand}");
            Console.WriteLine($"{this.Model}");
            Console.WriteLine($"{this.Color}");
            Console.WriteLine($"{this.Year}");
            Console.WriteLine($"{this.Condition}");
            Console.WriteLine($"{this.Description}");
            Console.WriteLine($"{this.Price}");
        }

    }

    public abstract class Soundgadget : Soundablegadget
    {
        public int Itemsinstock { get; set; }
    }

        public class Bombox : Soundgadget
        {
            public bool Bluetooth { get; set; }
            public bool Cd { get; set; }
            public bool Kassette { get; set; }

            public override void DisplaySoundablegadgets()
            {
                base.DisplaySoundablegadgets();
                Console.WriteLine($"Bluetooth mood:{this.Bluetooth}");
                Console.WriteLine($"Cd mood:{this.Cd}");
                Console.WriteLine($"Kassette mood:{this.Kassette}");
            }
        }

        public class Radio : Soundgadget
        {
            public bool Wireless { get; set; }

            public override void DisplaySoundablegadgets()
            {
                base.DisplaySoundablegadgets();
                Console.WriteLine($"This radio is:{this.Wireless}");
            }

        }

        public class Vinylplayer : Soundgadget
        {
            public string TypeofVinyl { get; set; }

            public override void DisplaySoundablegadgets()
            {
                base.DisplaySoundablegadgets();
                Console.WriteLine($"The type of vinyl is:{this.TypeofVinyl}");
            }
        }
    }

