using Domain_Models;
using Npgsql;
using NpgsqlTypes;
using System.Buffers;
using System;


namespace Service
{
    public class DatabaseService
    {
        public string connectionString;

        public DatabaseService(string connectionString) { this.connectionString = connectionString; }
        public List<Sound> GetAllItemData()
        {
            List<Sound> allSounds = new List<Sound>();

            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT id, Name, url, Artist, Condition, Speed, Size, Year, Price, Genre, Album, Brand, Tracks, Description FROM Sounds order by id";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            allSounds.Add(new Sound()
                            {
                                    id = Convert.ToInt32(reader["Id"]),
                                    url = reader["url"].ToString(),
                                    name = reader["Name"].ToString(),
                                    artist = reader["Artist"].ToString(),
                                    condition = reader["Condition"].ToString(),
                                    speed = reader["speed"].ToString(),
                                    size = reader["size"].ToString(),
                                    year = Convert.ToInt32(reader["Year"]),
                                    price = Convert.ToInt32(reader["Price"]),
                                    genre = reader["Genre"].ToString(),
                                    album = reader["Album"].ToString(),
                                    brand = reader["Brand"].ToString(),
                                    tracks = reader["Tracks"].ToString(),
                                    description = reader["Description"].ToString()
                            });

                        };
                                    
                        return allSounds;

                    }
                }
            }
        }

        public List<Sellers> AB;
        public List<Sellers> HentBrugere()
        {
            List<Sellers> alleBrugere = new List<Sellers>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM bruger";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            alleBrugere.Add(new Sellers()
                            {
                                fullName = reader["FullName"].ToString(),
                                userID = reader["UserID"].ToString(),
                                email = reader["Email"].ToString(),
                                phoneNumber = Convert.ToInt32(reader["PhoneNumber"]),
                                password = reader["Password"].ToString()
                            });
                        }
                        return alleBrugere;
                    }
                }
            }
        }























    }
}

