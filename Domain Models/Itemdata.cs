
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
            AllItemdata.Add(new Sound
            {
                id = 2,
                name = "Take the 'A' Train",
                artist = "Billy Strayhorn",
                condition = "VG+",
                speed = "33 RPM",
                size = "12''",
                year = 1961,
                price = 250,
                genre = "Jazz",
                album = "Take the 'A' Train",
                brand = "Blue Note",
                tracks = "Take the 'A' Train, Cheek to Cheek, What Is This Thing Called Love?, I Can't Get Started, St. Louis Blues",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 3,
                name = "Kind of Blue",
                artist = "Miles Davis",
                condition = "MINT",
                speed = "33 RPM",
                size = "12''",
                year = 1959,
                price = 500,
                genre = "Jazz, Modal Jazz",
                album = "Kind of Blue",
                brand = "Columbia",
                tracks = "So What, Flamenco Sketches, Blue in Green, All Blues, I Love You So",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 4,
                name = "A Love Supreme",
                artist = "John Coltrane",
                condition = "VG++",
                speed = "33 RPM",
                size = "12''",
                year = 1965,
                price = 450,
                genre = "Jazz, Modal Jazz",
                album = "A Love Supreme",
                brand = "Impulse!",
                tracks = "Acknowledgement, Resolution, Pursuance, Psalm, Love Supreme",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 5,
                name = "Giant Steps",
                artist = "John Coltrane",
                condition = "MINT",
                speed = "33 RPM",
                size = "12''",
                year = 1960,
                price = 550,
                genre = "Jazz, Modal Jazz",
                album = "Giant Steps",
                brand = "Atlantic",
                tracks = "Giant Steps, Countdown, Naima, Mr. P.C., Cousin Mary",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 6,
                name = "Blue Train",
                artist = "John Coltrane",
                condition = "VG+",
                speed = "33 RPM",
                size = "12''",
                year = 1957,
                price = 300,
                genre = "Jazz",
                album = "Blue Train",
                brand = "Blue Note",
                tracks = "Blue Train, Moment's Notice, Locomotion, I Want to Talk About You, Lulu's Back in Town",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 7,
                name = "A Love Supreme",
                artist = "John Coltrane",
                condition = "Very Good",
                speed = "33 RPM",
                size = "12''",
                year = 1965,
                price = 200,
                genre = "Jazz, Avant-Garde Jazz",
                album = "A Love Supreme",
                brand = "Impulse! Records",
                tracks = "Acknowledgement, Resolution, Pursuance, Psalm",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 8,
                name = "Led Zeppelin IV",
                artist = "Led Zeppelin",
                condition = "Good",
                speed = "33 RPM",
                size = "12''",
                year = 1971,
                price = 120,
                genre = "Hard Rock, Blues Rock",
                album = "Led Zeppelin IV",
                brand = "Atlantic Records",
                tracks = "Black Dog, Rock and Roll, The Battle of Evermore, Stairway to Heaven, Misty Mountain Hop, Four Sticks, Going to California, When the Levee Breaks",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 9,
                name = "Pet Sounds",
                artist = "The Beach Boys",
                condition = "Near Mint",
                speed = "33 RPM",
                size = "12''",
                year = 1966,
                price = 180,
                genre = "Rock, Pop",
                album = "Pet Sounds",
                brand = "Capitol Records",
                tracks = "Wouldn't It Be Nice, You Still Believe in Me, That's Not Me, Don't Talk (Put Your Head on My Shoulder), I'm Waiting for the Day, Let's Go Away for Awhile, Sloop John B, God Only Knows, I Know There's an Answer, Here Today, I Just Wasn't Made for These Times, Pet Sounds, Caroline, No",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 10,
                name = "Rumours",
                artist = "Fleetwood Mac",
                condition = "Excellent",
                speed = "33 RPM",
                size = "12''",
                year = 1977,
                price = 220,
                genre = "Rock, Pop Rock",
                album = "Rumours",
                brand = "Warner Bros. Records",
                tracks = "Second Hand News, Dreams, Never Going",
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
