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

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (!sessionLaunched)
            {
                sessionLaunched = true;
                startTime = DateTime.UtcNow;
                GameButton.Text = "End Session!";

                FormTimer.Start();
            } 
            else
            {
                sessionLaunched = false;
                GameButton.Text = "Play!";

                finishTime = DateTime.UtcNow;

                FormTimer.Stop();
            }
        }

        // TODO - uzyskać wartość totalną tj. czas sesji, tak aby móc go w jakiś sensowny sposób zapisać


        private void OnUpdateTimerTick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Parse((DateTime.UtcNow - startTime).ToString());
            CurrentSessionTimer.Text = dt.Hour.ToString() + " hours " + dt.Minute.ToString() + " minutes " + dt.Second.ToString() + " seconds";
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
