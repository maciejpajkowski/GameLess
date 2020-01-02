using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLess
{
    public partial class StatsForm : Form
    {
        public StatsForm(List<SessionModel> sessions)
        {
            InitializeComponent();
            sessionsList = sessions;
        }

        List<SessionModel> sessionsList;

        private void CloseOptionsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
