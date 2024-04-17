using Domain_Models;
using Npgsql;
using System.Buffers;
using System;

namespace Service
{
    public class DatabaseService2
    {
        public string connectionString;

        public DatabaseService2(string connectionString) { this.connectionString = connectionString; }
        public List<Soundablegadget> GetAllSoundablegadgets()
        {
            List<Soundablegadget> AllSoundablegadgets = new List<Soundablegadget>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT Brand, Model, Color, Year, Condition, Price, Size, Url, Description, Bluetooth, Cd, type, Kassette FROM soundablegagdet";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string type = reader?["type"].ToString();
                            if (type == "Bombox")

                            {
                                AllSoundablegadgets.Add(new Bombox()
                                {
                                    Brand = reader["Brand"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    Color = reader["Color"].ToString(),
                                    Year = Convert.ToInt32(reader["Year"]),
                                    Condition = reader["Condition"].ToString(),
                                    Price = Convert.ToInt32(reader["Price"]),
                                    Url= reader["Url"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Bluetooth = Convert.ToBoolean(reader["Bluetooth"]),
                                    Cd = Convert.ToBoolean(reader["Cd"]),
                                    Kassette = Convert.ToBoolean(reader["Kassette"])
                                }

                                );
                            }

                            else if (type == "Radio")

                            {
                                AllSoundablegadgets.Add(new Radio()
                                {
                                    Brand = reader["Brand"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    Color = reader["Color"].ToString(),
                                    Year = Convert.ToInt32(reader["Year"]),
                                    Condition = reader["Condition"].ToString(),
                                    Price = Convert.ToInt32(reader["Price"]),
                                    Url = reader["Url"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Wireless = Convert.ToBoolean(reader["Wireless"])

                                }

                                );
                            }

                            else if (type == "Vinylplayer")

                            {
                                AllSoundablegadgets.Add(new Vinylplayer()
                                {
                                    Brand = reader["Brand"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    Color = reader["Color"].ToString(),
                                    Year = Convert.ToInt32(reader["Year"]),
                                    Condition = reader["Condition"].ToString(),
                                    Price = Convert.ToInt32(reader["Price"]),
                                    Url = reader["Url"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Type = reader["TypeofVinyl"].ToString()       

                                }

                                );
                            }
                        }

                        return AllSoundablegadgets;

                    }
                }
            }
        }
    }
}


