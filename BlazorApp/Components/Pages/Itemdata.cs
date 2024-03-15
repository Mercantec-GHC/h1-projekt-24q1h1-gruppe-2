using classical;
using Microsoft.AspNetCore.Components.Routing;
using Users;

namespace BlazorApp.Components.Pages
{
    public class Itemdata
    {
        public List<Sound> GenerateItemDataItems()
        {
            List<Sound> allItemdata = new List<Sound>();
            allItemdata.Add(new Sound
            {
                Name = "My Man",
                Artist = "Ben Webster",
                Condition = "MINT",
                Speed = "33 RPM",
                Size = "12''",
                Year = 1973,
                Price = 327,
                Genre = "Jazz, Post Bop",
                Album = "Live at Montmarte 1973",
                Brand = "Steeplechase",
                Tracks = "Sunday, Old Folks, Willow Weep For Me, I Got Rhythm, Exactly Like You, Sett Call",
                Favorite = false,

            });

            allItemdata.Add(new Sound
            {
                Name = "Moonlight Sonata",
                Artist = "Ludwig van Beethoven",
                Condition = "EXCELLENT",
                Speed = "33 RPM",
                Size = "12''",
                Year = 1801,
                Price = 250,
                Genre = "Classical",
                Album = "Piano Sonata No. 14 in C-sharp minor, Op. 27, No. 2",
                Brand = "Deutsche Grammophon",
                Tracks = "I. Adagio sostenuto, II. Allegretto, III. Presto agitato",
                Favorite = true,
            });

            allItemdata.Add(new Sound
            {
                Name = "The Dark Side of the Moon",
                Artist = "Pink Floyd",
                Condition = "NEAR MINT",
                Speed = "33 RPM",
                Size = "12''",
                Year = 1973,
                Price = 350,
                Genre = "Progressive Rock",
                Album = "The Dark Side of the Moon",
                Brand = "Harvest, Capitol",
                Tracks = "Speak to Me, Breathe, On the Run, Time, The Great Gig in the Sky, Money, Us and Them, Any Colour You Like, Brain Damage, Eclipse",
                Favorite = true,
            });

            allItemdata.Add(new Sound
            {
                Name = "Thriller",
                Artist = "Michael Jackson",
                Condition = "GOOD",
                Speed = "33 RPM",
                Size = "12''",
                Year = 1982,
                Price = 200,
                Genre = "Pop, R&B",
                Album = "Thriller",
                Brand = "Epic",
                Tracks = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life",
                Favorite = false,
            });

            return allItemdata;
        }
        public List<Sellers> GenerateSellersUsers()
        {
            List<Sellers> allSellersUsers = new List<Sellers>();

            allSellersUsers.Add(new Sellers
            {
                Name = "Alice",
                Surname = "Ormsen",
                UserID = "Cooldog369",
                Email = "AliceOrmsen369@sexydog.dk",
                PhoneNumber = "1234567890",
                Location = "Gilleleje Hundehavn",
                Numberofproductssold = 30,
                Description = "Sometimes i feel like music is the only one that gets me, check out my other products",
                Validatedprofil = true,
            });

            allSellersUsers.Add(new Sellers
            {
                Name = "Michael",
                Surname = "Brown",
                UserID = "MBrown1980",
                Email = "michael.brown@example.com",
                PhoneNumber = "5559876543",
                Location = "Houston",
                Numberofproductssold = 20,
                Description = "Passionate about vintage vinyl records. Explore my collection!",
                Validatedprofil = true
            });

            allSellersUsers.Add(new Sellers
            {
                Name = "Emma",
                Surname = "Garcia",
                UserID = "EmGarcia95",
                Email = "emma.garcia@example.com",
                PhoneNumber = "1235557890",
                Location = "Miami",
                Numberofproductssold = 15,
                Description = "Offering a variety of CDs and DVDs. Check them out!",
                Validatedprofil = true
            });

            allSellersUsers.Add(new Sellers
            {
                Name = "Alex",
                Surname = "Roberts",
                UserID = "ARoberts87",
                Email = "alex.roberts@example.com",
                PhoneNumber = "7891234560",
                Location = "Seattle",
                Numberofproductssold = 10,
                Description = "Specializing in rare vinyl records. Don't miss out!",
                Validatedprofil = true
            });

        }

    }
}
