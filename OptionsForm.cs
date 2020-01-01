using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLess
{
    public partial class OptionsForm : Form
    {
        string csvFilePath;
        public static decimal AvailableHours = 2;

        public OptionsForm(string filePath)
        {
            InitializeComponent();
            csvFilePath = filePath;
            DataFileLocationTextBox.Text = filePath;
            TotalHoursAvailableValue.Value = AvailableHours;
        }

        private void CloseOptionsButton_Click(object sender, EventArgs e)
        {
            MainForm.CsvFilePath = csvFilePath;
            this.Close();
        }

        private void DataFileLocationBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = string.IsNullOrWhiteSpace(csvFilePath) ? "C:\\" : csvFilePath;
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    csvFilePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                }
                else
                {
                    csvFilePath = DataFileLocationTextBox.Text;
                }
            }
            DataFileLocationTextBox.Text = csvFilePath;
            File.WriteAllText(MainForm.tempFilePath, csvFilePath);
        }

        private void TotalHoursAvailableValue_ValueChanged(object sender, EventArgs e)
        {
            AvailableHours = TotalHoursAvailableValue.Value;
        }
    }
}
