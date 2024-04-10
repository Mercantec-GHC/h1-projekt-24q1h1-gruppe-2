using Npgsql;
using System.Reflection.Metadata.Ecma335;

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
   
        public void InsertDummyDataIntoDB2(List<Soundablegadget> AllSoundablegadgets)
        {
            string connectionString = "";
            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;

                foreach (var soundablegadget in AllSoundablegadgets)
                {
                    if (soundablegadget is Bombox bombox)
                    {


                        string insertCommand = $@"INSERT INTO Soundablegadgets";
                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }

                    else if (soundablegadget is Radio radio)
                    {
                        string insertCommand = $@"INSERT INTO Soundablegadgets";
                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }

                    else if (soundablegadget is Vinylplayer vinylplayer)
                    {
                        string insertCommand = $@"INSERT INTO Soundablegadgets";
                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
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
