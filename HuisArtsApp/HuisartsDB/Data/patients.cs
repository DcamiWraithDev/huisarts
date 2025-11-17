using HuisartsDB.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuisartsDB.Data
{
    public class patients
    {

        // Create a method to get all patients from the database
        public List<Patient> GetAllPatients()
        {
            var list = new List<Patient>();

            using (var conn = DatabaseConnection.GetConnection()) // Use the DatabaseConnection class to get the connection
            {
                conn.Open();

                string query = "SELECT first_name, name_prefix, last_name, date_of_birth FROM patients";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Patient
                        {
                            FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                            NamePrefix = reader.IsDBNull(reader.GetOrdinal("name_prefix")) ? null : reader.GetString(reader.GetOrdinal("name_prefix")), // Handle possible NULL value
                            LastName = reader.GetString(reader.GetOrdinal("last_name")),
                            DateOfBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth"))
                        });
                    }

                }
            }

            return list;
        }

        public List<Patient> SearchPatients(string keyword)
        {
            var list = new List<Patient>();

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"SELECT first_name, name_prefix, last_name, date_of_birth
                                 FROM patients
                                 WHERE CONCAT_WS(' ', name_prefix, last_name) LIKE @search";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Patient
                            {
                                FirstName = reader.GetString("first_name"),
                                NamePrefix = reader.IsDBNull(reader.GetOrdinal("name_prefix")) ? null : reader.GetString("name_prefix"),
                                LastName = reader.GetString("last_name"), 
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("date_of_birth"))

                            });
                        }
                    }
                }
            }

            return list;

        }
    }
}
