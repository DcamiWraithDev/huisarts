using System;
using System.Windows.Forms;
using HuisartsDB.Data;

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
                var display = string.IsNullOrWhiteSpace(patient.NamePrefix)
                    ? $"{patient.FirstName} {patient.LastName}" // No prefix
                    : $"{patient.FirstName} {patient.NamePrefix} {patient.LastName}"; // With prefix

                listBox1.Items.Add(display); // Add the formatted name to the ListBox
            }

        }
    }
}
