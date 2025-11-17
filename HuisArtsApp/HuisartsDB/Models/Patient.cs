using System;
using System.Collections.Generic;

namespace HuisartsDB.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string NamePrefix { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public int SecondaryPhoneNumber { get; set; }
        public ICollection<Note> Notes { get; set; }

    }
}
