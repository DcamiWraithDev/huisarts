using HuisartsDB.Data;
using HuisartsDB.Models;
using System;
using System.Windows.Forms;

namespace HuisArtsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var patientsData = new patients();
            var allPatients = patientsData.GetAllPatients();

            listBox1.Items.Clear();

            // Populate the ListBox with patient names
            foreach (var patient in allPatients)
            {
                var dateString = patient.DateOfBirth.ToString("dd-MM-yyyy"); // Alleen dag-maand-jaar
                var display = string.IsNullOrWhiteSpace(patient.NamePrefix)
                    ? $"{patient.FirstName} {patient.LastName} {dateString}" // No prefix
                    : $"{patient.FirstName} {patient.NamePrefix} {patient.LastName} {dateString}"; // With prefix

                listBox1.Items.Add(display); // Add the formatted name to the ListBox
            }

        }

        // Searches patients using the entered keyword and updates the ListBox.
        // Handles name prefixes correctly when displaying full names.
        private void SearchPatients()
        {
            var patientsData = new patients();
            var keyword = SearchTB.Text.Trim();
            var results = patientsData.SearchPatients(keyword);

            listBox1.Items.Clear();

            if (results.Count == 0)
            {
                listBox1.Items.Add("No results found.");
                return;
            }

            foreach (var patient in results)
            {
                var dateString = patient.DateOfBirth.ToString("dd-MM-yyyy"); // Alleen dag-maand-jaar
                var display = string.IsNullOrWhiteSpace(patient.NamePrefix)
                    ? $"{patient.FirstName} {patient.LastName} {dateString}" // No prefix
                    : $"{patient.FirstName} {patient.NamePrefix} {patient.LastName} {dateString}"; // With prefix


                listBox1.Items.Add(display);
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
