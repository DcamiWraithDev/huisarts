using HuisartsDB.Data;
using HuisartsDB.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HuisArtsApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var patientsData = new patients();
            var allPatients = patientsData.GetAllPatients();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("FullName", "Naam");
            dataGridView1.Columns.Add("DateOfBirth", "Geboortedatum");
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;


            // Zorg dat de hele rij geselecteerd wordt
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false; // Optioneel: alleen één rij tegelijk selecteren

            // Populate the DataGridView with patient names
            // Populate the DataGridView with patient names
            foreach (var patient in allPatients)
            {
                var fullName = string.IsNullOrWhiteSpace(patient.NamePrefix)
                    ? $"{patient.FirstName} {patient.LastName}"
                    : $"{patient.FirstName} {patient.NamePrefix} {patient.LastName}";

                var dateString = patient.DateOfBirth == DateTime.MinValue
                    ? ""
                    : patient.DateOfBirth.ToString("dd-MM-yyyy");

                int rowIndex = dataGridView1.Rows.Add(fullName, dateString);

                // Zet het volledige Patient object in de Tag van de rij
                dataGridView1.Rows[rowIndex].Tag = patient;
            }

            // Selecteer de eerste rij en update de labels handmatig
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection(); // Zorg dat alles eerst niet geselecteerd is
                dataGridView1.Rows[0].Selected = true;

                // Handmatig de labels updaten
                var patient = dataGridView1.Rows[0].Tag as Patient;
                if (patient != null)
                {
                    NameLbl.Text = $"Naam: {patient.FirstName} {patient.NamePrefix} {patient.LastName}";
                    birthdateLbl.Text = $"Geboortedatum: {patient.DateOfBirth:dd-MM-yyyy}";
                    streetLbl.Text = $"Straat: {patient.StreetName} {patient.HouseNumber}";
                    string formattedZip = $"{patient.ZipCode.Substring(0, 4)} {patient.ZipCode.Substring(4)}";
                    cityLbl.Text = $"Woonplaats: {formattedZip}, {patient.City}";
                    phoneLbl.Text = $"Eerste telefoon nummer: {FormatPhoneNumber(patient.PhoneNumber.ToString())}";
                    secondaryPhoneLbl.Text = $"Tweede telefoon nummer: {FormatPhoneNumber(patient.SecondaryPhoneNumber.ToString())}";
                }
            }


        }

        private string FormatPhoneNumber(string number, bool useDashes = false)
        {
            if (string.IsNullOrWhiteSpace(number))
                return number;

            // Alleen cijfers houden
            number = new string(number.Where(char.IsDigit).ToArray());

            // Leading zero opnieuw toevoegen indien nodig
            if (number.Length == 9 && !number.StartsWith("0"))
                number = "0" + number;

            string sep = useDashes ? "-" : " ";

            // Mobiel: 06-12345678
            if (number.Length == 10 && number.StartsWith("06"))
            {
                return $"{number.Substring(0, 2)}{sep}{number.Substring(2, 2)}{sep}{number.Substring(4, 3)}{sep}{number.Substring(7, 3)}";
            }

            // Vast nummer: 0318-123456
            if (number.Length == 10)
            {
                return $"{number.Substring(0, 4)}{sep}{number.Substring(4, 2)}{sep}{number.Substring(6, 2)}{sep}{number.Substring(8, 2)}";
            }

            // fallback
            return number;
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var patient = dataGridView1.SelectedRows[0].Tag as Patient;
                if (patient != null)
                {
                    NameLbl.Text = $"Naam: {patient.FirstName} {patient.NamePrefix} {patient.LastName}";
                    birthdateLbl.Text = $"Geboortedatum: {patient.DateOfBirth.ToString("dd-MM-yyyy")}";
                    streetLbl.Text = $"Straat: {patient.StreetName} {patient.HouseNumber}";
                    string formattedZip = $"{patient.ZipCode.Substring(0, 4)} {patient.ZipCode.Substring(4)}";
                    cityLbl.Text = $"Woonplaats: {formattedZip}, {patient.City}";
                    phoneLbl.Text = $"Eerste telefoon nummer: {FormatPhoneNumber(patient.PhoneNumber.ToString())}";
                    secondaryPhoneLbl.Text = $"Tweede telefoon nummer: {FormatPhoneNumber(patient.SecondaryPhoneNumber.ToString())}";
                }
            }
        }



        // Searches patients using the entered keyword and updates the ListBox.
        // Handles name prefixes correctly when displaying full names.
        private void SearchPatients()
        {
            var patientsData = new patients();
            var keyword = SearchTB.Text.Trim();
            var results = patientsData.SearchPatients(keyword);

            dataGridView1.Rows.Clear();

            if (results.Count == 0)
            {
                dataGridView1.Rows.Add("No results found.", "");
                return;
            }

            foreach (var patient in results)
            {
                var fullName = string.IsNullOrWhiteSpace(patient.NamePrefix)
                    ? $"{patient.FirstName} {patient.LastName}"
                    : $"{patient.FirstName} {patient.NamePrefix} {patient.LastName}";

                var dateString = patient.DateOfBirth == DateTime.MinValue
                    ? ""
                    : patient.DateOfBirth.ToString("dd-MM-yyyy");

                int rowIndex = dataGridView1.Rows.Add(fullName, dateString);
                dataGridView1.Rows[rowIndex].Tag = patient; // ⚡ vergeet dit niet
            }

        }

        private void SearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchPatients();
                e.SuppressKeyPress = true;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchPatients();
        }
    }
}
