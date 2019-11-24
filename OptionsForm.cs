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
        public string CsvFilePath { get; set; }

        public OptionsForm(string filePath)
        {
            InitializeComponent();
            CsvFilePath = filePath;
            DataFileLocationTextBox.Text = filePath;
        }

        private void CloseOptionsButton_Click(object sender, EventArgs e)
        {
            MainForm.CsvFilePath = CsvFilePath;
            this.Close();
        }

        private void DataFileLocationBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = string.IsNullOrWhiteSpace(CsvFilePath) ? "C:\\" : CsvFilePath;
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    CsvFilePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                }
                else
                {
                    CsvFilePath = DataFileLocationTextBox.Text;
                }
            }
            DataFileLocationTextBox.Text = CsvFilePath;
            File.WriteAllText(MainForm.tempFilePath, CsvFilePath);
        }
    }
}
