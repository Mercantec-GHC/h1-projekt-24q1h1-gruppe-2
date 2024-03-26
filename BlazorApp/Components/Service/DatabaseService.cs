using Domain_Models;
using Npgsql;
using System.Buffers;
using System;
using Domain_Models;

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

                string sql = "SELECT Name, Artist, Condition, Speed, Size, Year, Price, Genre, Album, Brand, Tracks FROM ";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var type = reader["type"].ToString();

                            allSounds.Add(new Sound()
                            {
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
                                    tracks = reader["Tracks"].ToString()
                            });

                        };
                                    
                        return allSounds;

                        }
                    }
                }
            }
        }
    }

