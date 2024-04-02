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
        private static uint lastId = 0;
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string ItemCondition { get; set; }
        public int Year { get; set; }

        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }



        public Soundablegadget(string brand, string model, string color, int year, string condition, int price, string imageUrl, string description)
        {
            this.Url = $"headset/{lastId}";
            GadgetId = lastId++;
            this.Brand = brand;
            this.Year = year;
            this.Model = model;
            this.Color = color;
            this.ItemCondition = condition;
            this.Price = price;
            this.ImageUrl = imageUrl;
            this.Description = description;
        }

        public virtual void DisplayHeadset()
        {
            Console.WriteLine($"{this.Brand}");
            Console.WriteLine($"{this.Model}");
            Console.WriteLine($"{this.Color}");
            Console.WriteLine($"{this.Year}");
            Console.WriteLine($"{this.ItemCondition}");
            Console.WriteLine($"{this.Description}");
            Console.WriteLine($"{this.Price}");
        }

    }

    public class Bombox : Soundablegadget
    {
        public bool Bluetooth  { get; set; }
        public bool Cd { get; set; }
        public bool Kassette { get; set; }


        public Bombox(string brand, string model, string color, int year, string condition, int price, string imageUrl, string description, bool bluetooth, bool cd, bool kassette) 
            : base(brand, model, color, year, condition, price, imageUrl, description)
        {

        }

        public override void DisplayHeadset()
        {
            base.DisplayHeadset();
            Console.WriteLine($"Bluetooth mood:{this.Bluetooth}");
            Console.WriteLine($"Cd mood:{this.Cd}");
            Console.WriteLine($"Kassette mood:{this.Kassette}");
        }
    }

    public class Radio : Soundablegadget
{
    public bool Wireless { get; set; }


    public Radio(string brand, string model, string color, int year, string condition, int price, string imageUrl, string description, bool wireless)
        : base(brand, model, color, year, condition, price, imageUrl, description)
    {

    }

    public override void DisplayHeadset()
    {
        base.DisplayHeadset();
        Console.WriteLine($"This radio is:{this.Wireless}");
    }

}

    public class Vinylplayer : Soundablegadget
    {
        public string Type { get; set; }


        public Vinylplayer(string brand, string model, string color, int year, string condition, int price, string imageUrl, string description, string type)
            : base(brand, model, color, year, condition, price, imageUrl, description)
        {

        }

        public override void DisplayHeadset()
        {
            base.DisplayHeadset();
            Console.WriteLine($"The type of vinyl is:{this.Type}");
        }
    }
}
