using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GameLess
{
    public partial class MainContainerForm : Form
    {
        public MainContainerForm()
        {
            InitializeComponent();
        }

        bool sessionLaunched = false;

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

                // MessageBox.Show(sessionTotal.ToString()); // debug

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
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }
    }
}
