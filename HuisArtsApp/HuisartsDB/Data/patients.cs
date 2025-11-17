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

                string query = @"SELECT patient_id, first_name, name_prefix, last_name, date_of_birth, street_name, house_number, zip_code, city, mobile_number, secondary_phone
                                FROM patients";


                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Patient
                        {
                            PatientId = reader.GetInt32("patient_id"),
                            FirstName = reader.GetString("first_name"),
                            NamePrefix = reader.IsDBNull(reader.GetOrdinal("name_prefix")) ? null : reader.GetString("name_prefix"),
                            LastName = reader.GetString("last_name"),
                            DateOfBirth = reader.GetDateTime("date_of_birth"),
                            StreetName = reader.GetString("street_name"),
                            HouseNumber = reader.GetInt32("house_number"),
                            ZipCode = reader.GetString("zip_code"),
                            City = reader.GetString("city"),
                            PhoneNumber = reader.GetString("mobile_number"),
                            SecondaryPhoneNumber = reader.GetString("secondary_phone")
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

                string query = @"SELECT patient_id, first_name, name_prefix, last_name, date_of_birth,
                                street_name, house_number, zip_code, city, mobile_number, secondary_phone
                         FROM patients
                         WHERE CONCAT_WS(' ', first_name, name_prefix, last_name) LIKE @search";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Patient
                            {
                                PatientId = reader.GetInt32("patient_id"),
                                FirstName = reader.GetString("first_name"),
                                NamePrefix = reader.IsDBNull(reader.GetOrdinal("name_prefix")) ? null : reader.GetString("name_prefix"),
                                LastName = reader.GetString("last_name"),
                                DateOfBirth = reader.GetDateTime("date_of_birth"),
                                StreetName = reader.GetString("street_name"),
                                HouseNumber = reader.GetInt32("house_number"),
                                ZipCode = reader.GetString("zip_code"),
                                City = reader.GetString("city"),
                                PhoneNumber = reader.GetString("mobile_number"),
                                SecondaryPhoneNumber = reader.GetString("secondary_phone")
                            });
                        }
                    }
                }
            }

            return list;
        }

    }
}
