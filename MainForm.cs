using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GameLess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CsvFilePath = GetCurrentDataFilePath();
            StartupPromptForDataFileLocation();
        }

        public static string tempFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Temp\GameLessData.tmp");

        bool sessionLaunched = false;
        public static string CsvFilePath { get; set; }

        DateTime startTime;
        DateTime finishTime;
        DateTime dt;
        double sessionTotal;

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (!sessionLaunched)
            {
                sessionLaunched = true;
                startTime = DateTime.UtcNow;
                GameButton.Text = "End Session!";
                CurrentSessionTimer.ForeColor = Color.Black;

                FormTimer.Start();
            } 
            else
            {
                sessionLaunched = false;
                GameButton.Text = "Play!";

                finishTime = DateTime.UtcNow;

                sessionTotal = Math.Round((finishTime - startTime).TotalSeconds);

                FormTimer.Stop();
            }
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            dt = DateTime.Parse((DateTime.UtcNow - startTime).ToString());

            CurrentSessionTimer.Text = dt.Hour.ToString() + " hours " + dt.Minute.ToString() + " minutes " + dt.Second.ToString() + " seconds";
            
            sessionTotal = Math.Round((DateTime.UtcNow - startTime).TotalSeconds);

            if (Convert.ToInt32(sessionTotal / 7200 * 100) < 100)
            {
                CurrentSessionProgressBar.Value = Convert.ToInt32(sessionTotal / 7200 * 100);
            }
            else
            {
                CurrentSessionProgressBar.Value = 100;
                CurrentSessionTimer.ForeColor = Color.Red;
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(CsvFilePath);
            optionsForm.Show();
        }

        private string GetCurrentDataFilePath()
        {
            string csvPathToCheck;

            if (File.Exists(tempFilePath))
            {
                csvPathToCheck = File.ReadAllText(tempFilePath);

                if (!File.Exists(csvPathToCheck)) {

                    return string.Empty;

                } 
                else
                {
                    return File.ReadAllText(tempFilePath);
                }
            }
            else
            {
                File.WriteAllText(tempFilePath, string.Empty);
                return string.Empty;
            }
        }

        private void StartupPromptForDataFileLocation()
        {
            if (CsvFilePath == string.Empty)
            {
                MessageBox.Show(@"Data file not found! Please select the folder, in which the data file will be stored. This can be later changed in the options menu.");
                
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        CsvFilePath = Path.Combine(fbd.SelectedPath, "GameLessData.csv");
                        File.WriteAllText(tempFilePath, CsvFilePath);
                        File.WriteAllText(CsvFilePath, string.Empty);
                        MessageBox.Show("Data file path successfully set to: " + CsvFilePath + "!");
                    }
                    else
                    {
                        CsvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Temp\GameLessData.csv");
                        File.WriteAllText(tempFilePath, CsvFilePath);
                        File.WriteAllText(CsvFilePath, string.Empty);
                        MessageBox.Show("No data file location has been selected. Defaulting to: " + CsvFilePath + ". This can be later changed in the options menu (all progress will be reset).");
                    }
                }
            }
        }
    }
}
