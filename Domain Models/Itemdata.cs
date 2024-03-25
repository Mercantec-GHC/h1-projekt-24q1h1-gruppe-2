
namespace Domain_Models
{
    public class Itemdata
    {
        public List<Sound> GenerateItemDataItems()
        {
            List<Sound> AllItemdata = new List<Sound>();
            AllItemdata.Add(new Sound
            {
                id = 1,
                name = "My Man",
                artist = "Ben Webster",
                condition = "MINT",
                speed = "33 RPM",
                size = "12''",
                year = 1973,
                price = 327,
                genre = "Jazz, Post Bop",
                album = "Live at Montmarte 1973",
                brand = "Steeplechase",
                tracks = "Sunday, Old Folks, Willow Weep For Me, I Got Rhythm, Exactly Like You, Sett Call",
                favorite = false,
            });

      
            return AllItemdata;
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

            return allSellersUsers;

        }

    }
}
