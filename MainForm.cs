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
            CsvFilePath = Properties.Settings.Default.PathToCSVFile;
            StartupPromptForDataFileLocation(); // Runs if CsvFilePath is empty

            sessions = CsvFilePath.LoadDataFromFile().BuildSessionList();

            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        bool sessionLaunched = false;
        public string CsvFilePath { get; set; }

        DateTime startTime;
        DateTime finishTime;
        DateTime dt;
        double sessionTotal;
        List<SessionModel> sessions;

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (!sessionLaunched)
            {
                sessionLaunched = true;
                GameButton.Text = "End Session!";
                startTime = DateTime.Now;
                CurrentSessionTimer.ForeColor = Color.Black;
                CurrentSessionLabel.Text = "Current session:";

                FormTimer.Start();

                if (Properties.Settings.Default.DesktopNotifications)
                {
                    SystemTrayNotification.ShowBalloonTip(3000, "Game session started!", "GameLess is now tracking the time of your game session.", ToolTipIcon.Info);
                }
            } 
            else
            {
                sessionLaunched = false;
                GameButton.Text = "Play!";

                finishTime = DateTime.Now;
                sessionTotal = Math.Round((finishTime - startTime).TotalSeconds);

                FormTimer.Stop();

                dt = DateTime.Parse((DateTime.Now - startTime).ToString());
                CurrentSessionLabel.Text = "Last session:";
                sessions.SaveNewSessionData(startTime, DateTime.Parse((DateTime.Now - startTime).ToString()));

                if (Properties.Settings.Default.DesktopNotifications)
                {
                    SystemTrayNotification.ShowBalloonTip(3000, "Game session finished!", "Game time: " + (DateTime.Now - startTime).ToString(@"hh\:mm\:ss"), ToolTipIcon.Info);
                }
            }
        }

        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            dt = DateTime.Parse((DateTime.Now - startTime).ToString());

            CurrentSessionTimer.Text = dt.Hour.ToString() + " hours " + dt.Minute.ToString() + " minutes " + dt.Second.ToString() + " seconds";
            
            sessionTotal = Math.Round((DateTime.Now - startTime).TotalSeconds);

            if (Convert.ToInt32(sessionTotal / ((double)Properties.Settings.Default.MaxPlayHours * 3600) * 100) < 100)
            {
                CurrentSessionProgressBar.Value = Convert.ToInt32(sessionTotal / ((double)Properties.Settings.Default.MaxPlayHours * 3600) * 100);
            }
            else
            {
                CurrentSessionProgressBar.Value = 100;
                CurrentSessionTimer.ForeColor = Color.Red;

                if (Properties.Settings.Default.DesktopNotifications)
                {
                    SystemTrayNotification.ShowBalloonTip(3000, "Your gaming session has exceeded the limit!", "Game time: " + (DateTime.Now - startTime).ToString(@"hh\:mm\:ss"), ToolTipIcon.Info);
                }
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            SystemTrayNotification.Dispose();
            Environment.Exit(0);
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(CsvFilePath);
            optionsForm.Show();
        }

        private void StartupPromptForDataFileLocation()
        {


            if (CsvFilePath == string.Empty)
            {
                MessageBox.Show(@"Data file not found! Please select the folder, in which the data file will be stored. This can be later changed in the options menu.", "GameLess", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        CsvFilePath = Path.Combine(fbd.SelectedPath, "GameLessData.csv");
                        Properties.Settings.Default.PathToCSVFile = CsvFilePath;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Data file path successfully set to: " + CsvFilePath + "!", "GameLess", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        CsvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Temp\GameLessData.csv");
                        Properties.Settings.Default.PathToCSVFile = CsvFilePath;
                        Properties.Settings.Default.Save();
                        MessageBox.Show("No data file location has been selected. Defaulting to: " + CsvFilePath + ". This can be later changed in the options menu (all progress will be reset).", "GameLess", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                }
            }
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm(sessions);
            statsForm.Show();
        }
    }
}
