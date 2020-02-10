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
        string csvFilePath = Properties.Settings.Default.PathToCSVFile;

        public OptionsForm(string filePath)
        {
            InitializeComponent();
            DataFileLocationTextBox.Text = Properties.Settings.Default.PathToCSVFile;
            TotalHoursAvailableValue.Value = Properties.Settings.Default.MaxPlayHours;
            DesktopNotificationCheckbox.Checked = Properties.Settings.Default.DesktopNotifications;
        }

        private void CloseOptionsButton_Click(object sender, EventArgs e)
        {
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
            Properties.Settings.Default.Save();
        }

        private void TotalHoursAvailableValue_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.MaxPlayHours = (int)TotalHoursAvailableValue.Value;
            Properties.Settings.Default.Save();
        }

        private void DesktopNotificationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (DesktopNotificationCheckbox.Checked)
            {
                Properties.Settings.Default.DesktopNotifications = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.DesktopNotifications = false;
                Properties.Settings.Default.Save();
            }

        }
    }
}
