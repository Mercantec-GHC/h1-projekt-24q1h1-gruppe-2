using Npgsql;


namespace Domain_Models
{
    public class Itemdata
    {
        public void InsertDummyDataIntoDB(List<Sound> AllItemdata)
        {
            string connectionString = "";
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                foreach (var sound in AllItemdata) 
                {
                    string insertCommand = $@"INSERT INTO Sounds";
                    cmd.CommandText = insertCommand;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Sound> GenerateItemDataItems()
        {
            List<Sound> AllItemdata = new List<Sound>();
            AllItemdata.Add(new Sound
            {
                id = 0,
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
                id = 1,
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
                id = 2,
                name = "Blood on the Tracks",
                artist = "Bob Dylan",
                condition = "Very Good",
                speed = "33 RPM",
                size = "12''",
                year = 1975,
                price = 180,
                genre = "Folk Rock",
                album = "Blood on the Tracks",
                brand = "Columbia Records",
                tracks = "Tangled Up in Blue, Simple Twist of Fate, You're a Big Girl Now, Idiot Wind, You're Gonna Make Me Lonesome When You Go, Meet Me in the Morning, Lily, Rosemary and the Jack of Hearts, If You See Her, Say Hello, Shelter from the Storm, Buckets of Rain",
                favorite = false,
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

            AllItemdata.Add(new Sound
            {
                id = 11,
                name = "Back in Black",
                artist = "AC/DC",
                condition = "Good",
                speed = "33 RPM",
                size = "12''",
                year = 1980,
                price = 100,
                genre = "Hard Rock",
                album = "Back in Black",
                brand = "Atlantic Records",
                tracks = "Hells Bells, Shoot to Thrill, What Do You Do for Money Honey, Given the Dog a Bone, Let Me Put My Love into You, Back in Black, You Shook Me All Night Long, Have a Drink on Me, Shake a Leg, Rock and Roll Ain't Noise Pollution",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 12,
                name = "The Wall",
                artist = "Pink Floyd",
                condition = "Very Good",
                speed = "33 RPM",
                size = "12''",
                year = 1979,
                price = 180,
                genre = "Progressive Rock",
                album = "The Wall",
                brand = "Harvest Records",
                tracks = "In the Flesh?, The Thin Ice, Another Brick in the Wall Part 1, The Happiest Days of Our Lives, Another Brick in the Wall Part 2, Mother, Goodbye Blue Sky, Empty Spaces, Young Lust, One of My Turns, Don't Leave Me Now, Another Brick in the Wall Part 3, Goodbye Cruel World",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 13,
                name = "The Chronic",
                artist = "Dr. Dre",
                condition = "Near Mint",
                speed = "33 RPM",
                size = "12''",
                year = 1992,
                price = 250,
                genre = "Hip Hop, G-Funk",
                album = "The Chronic",
                brand = "Death Row Records",
                tracks = "The Chronic (Intro), Fuck wit Dre Day (And Everybody's Celebratin'), Let Me Ride, The Day the Niggaz Took Over, Nuthin' but a 'G' Thang, Deeez Nuuuts, Lil' Ghetto Boy, A Nigga Witta Gun, Rat-Tat-Tat-Tat, The $20 Sack Pyramid, Lyrical Gangbang, High Powered, The Doctor's Office, Stranded on Death Row, The Roach (The Chronic Outro), Bitches Ain't Shit",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 14,
                name = "Nevermind",
                artist = "Nirvana",
                condition = "Excellent",
                speed = "33 RPM",
                size = "12''",
                year = 1991,
                price = 180,
                genre = "Grunge, Alternative Rock",
                album = "Nevermind",
                brand = "DGC Records",
                tracks = "Smells Like Teen Spirit, In Bloom, Come as You Are, Breed, Lithium, Polly, Territorial Pissings, Drain You, Lounge Act, Stay Away, On a Plain, Something in the Way",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 15,
                name = "Purple Rain",
                artist = "Prince and The Revolution",
                condition = "Very Good",
                speed = "33 RPM",
                size = "12''",
                year = 1984,
                price = 160,
                genre = "Pop, Rock, Funk",
                album = "Purple Rain",
                brand = "Warner Bros. Records",
                tracks = "Let's Go Crazy, Take Me with U, The Beautiful Ones, Computer Blue, Darling Nikki, When Doves Cry, I Would Die 4 U, Baby I'm a Star, Purple Rain",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 16,
                name = "Hotel California",
                artist = "Eagles",
                condition = "Good",
                speed = "33 RPM",
                size = "12''",
                year = 1976,
                price = 120,
                genre = "Rock, Soft Rock",
                album = "Hotel California",
                brand = "Asylum Records",
                tracks = "Hotel California, New Kid in Town, Life in the Fast Lane, Wasted Time, Wasted Time (Reprise), Victim of Love, Pretty Maids All in a Row, Try and Love Again, The Last Resort",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 17,
                name = "Born to Run",
                artist = "Bruce Springsteen",
                condition = "Near Mint",
                speed = "33 RPM",
                size = "12''",
                year = 1975,
                price = 180,
                genre = "Rock",
                album = "Born to Run",
                brand = "Columbia Records",
                tracks = "Thunder Road, Tenth Avenue Freeze-Out, Night, Backstreets, Born to Run, She's the One, Meeting Across the River, Jungleland",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 18,
                name = "Darkness on the Edge of Town",
                artist = "Bruce Springsteen",
                condition = "Excellent",
                speed = "33 RPM",
                size = "12''",
                year = 1978,
                price = 200,
                genre = "Rock",
                album = "Darkness on the Edge of Town",
                brand = "Columbia Records",
                tracks = "Badlands, Adam Raised a Cain, Something in the Night, Candy's Room, Racing in the Street, The Promised Land",
                favorite = false,

            });

            AllItemdata.Add(new Sound
            {
                id = 19,
                name = "Thriller",
                artist = "Michael Jackson",
                condition = "Very Good",
                speed = "33 RPM",
                size = "12''",
                year = 1982,
                price = 220,
                genre = "Pop, R&B",
                album = "Thriller",
                brand = "Epic Records",
                tracks = "Wanna Be Startin' Somethin', Baby Be Mine, The Girl Is Mine, Thriller, Beat It, Billie Jean, Human Nature, P.Y.T. (Pretty Young Thing), The Lady in My Life",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 20,
                name = "What's Going On",
                artist = "Marvin Gaye",
                condition = "Excellent",
                speed = "33 RPM",
                size = "12''",
                year = 1971,
                price = 190,
                genre = "Soul, R&B",
                album = "What's Going On",
                brand = "Tamla Records",
                tracks = "What's Going On, What's Happening Brother, Flyin' High (In the Friendly Sky), Save the Children, God Is Love, Mercy Mercy Me (The Ecology), Right On, Wholy Holy, Inner City Blues (Make Me Wanna Holler)",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 21,
                name = "The Queen Is Dead",
                artist = "The Smiths",
                condition = "Good",
                speed = "33 RPM",
                size = "12''",
                year = 1986,
                price = 150,
                genre = "Alternative Rock, Indie Rock",
                album = "The Queen Is Dead",
                brand = "Rough Trade Records",
                tracks = "The Queen Is Dead, Frankly, Mr. Shankly, I Know It's Over, Never Had No One Ever, Cemetry Gates, Bigmouth Strikes Again, The Boy with the Thorn in His Side, Vicar in a Tutu, There Is a Light That Never Goes Out, Some Girls Are Bigger Than Others",
                favorite = false,
            });

            AllItemdata.Add(new Sound
            {
                id = 22,
                name = "Sgt. Pepper's Lonely Hearts Club Band",
                artist = "The Beatles",
                condition = "Near Mint",
                speed = "33 RPM",
                size = "12''",
                year = 1967,
                price = 300,
                genre = "Rock",
                album = "Sgt. Pepper's Lonely Hearts Club Band",
                brand = "Parlophone",
                tracks = "Sgt. Pepper's Lonely Hearts Club Band, With a Little Help from My Friends, Lucy in the Sky with Diamonds, Getting Better, Fixing a Hole, She's Leaving Home, Being for the Benefit of Mr. Kite!, Within You Without You, When I'm Sixty-Four, Lovely Rita, Good Morning Good Morning, Sgt. Pepper's Lonely Hearts Club Band (Reprise), A Day in the Life",
                favorite = true,
            });

            AllItemdata.Add(new Sound
            {
                id = 23,
                name = "The Velvet Underground & Nico",
                artist = "The Velvet Underground",
                condition = "Good",
                speed = "33 RPM",
                size = "12''",
                year = 1967,
                price = 150,
                genre = "Experimental Rock, Art Rock",
                album = "The Velvet Underground & Nico",
                brand = "Verve Records",
                tracks = "Sunday Morning, I'm Waiting for the Man, Femme Fatale, Venus in Furs, Run Run Run, All Tomorrow's Parties, Heroin, There She Goes Again, I'll Be Your Mirror, The Black Angel's Death Song, European Son",
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
