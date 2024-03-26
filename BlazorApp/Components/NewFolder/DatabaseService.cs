using Domain_Models;
using Npgsql;
using System.Buffers;
using System;

namespace BlazorApp.Service
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

                            allSounds.Add(new Sound(
                                    reader["Name"].ToString(),
                                    reader["Artist"].ToString(),
                                    reader["Condition"].ToString(),
                                    Convert.ToInt32(reader["Speed"]),
                                    Convert.ToInt32(reader["Size"]),
                                    Convert.ToInt32(reader["Year"]),
                                    Convert.ToInt32(reader["Price"]),
                                    reader["Genre"].ToString(),
                                    reader["Album"].ToString(),
                                    reader["Brand"].ToString(),
                                    reader["Tracks"].ToString()
                                    ));

                        };
                                    
                        return allSounds;

                        }
                    }
                }
            }
        }
    }

