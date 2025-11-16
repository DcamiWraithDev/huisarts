using System;

namespace HuisartsDB.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public string NoteSubject { get; set; }
        public string NoteText { get; set; }
        public DateTime NoteDateCreated { get; set; } = DateTime.Now;
        public DateTime? NoteDateModified { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}

