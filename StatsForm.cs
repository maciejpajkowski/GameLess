using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLess
{
    public partial class StatsForm : Form
    {
        public StatsForm(List<SessionModel> s)
        {
            InitializeComponent();
            sessions = s;
            BuildStatistics();
        }

        List<SessionModel> sessions;

        private void CloseOptionsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuildStatistics()
        {
            int hoursToday = 0;
            int hoursWeek = 0;
            int hoursMonth = 0;
            int hoursYear = 0;

            foreach (SessionModel session in sessions)
            {
                CultureInfo myCI = new CultureInfo("pl-PL");
                Calendar myCalendar = myCI.Calendar;

                if (session.SessionDate.Day == DateTime.Now.Day)
                {
                    hoursToday += session.SessionLength.Hour;
                }

                if (myCalendar.GetWeekOfYear(session.SessionDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday) == myCalendar.GetWeekOfYear(
                    DateTime.Now, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                {
                    hoursWeek += session.SessionLength.Hour;
                }

                if (session.SessionDate.Month == DateTime.Now.Month)
                {
                    hoursMonth += session.SessionLength.Hour;
                }

                if (session.SessionDate.Year == DateTime.Now.Year)
                {
                    hoursYear += session.SessionLength.Hour;
                }
            }

            TotalHoursTodayValue.Text = hoursToday + " hours";
            TotalHoursWeekValue.Text = hoursWeek + " hours";
            TotalHoursMonthValue.Text = hoursMonth + " hours";
            TotalHoursYearValue.Text = hoursYear + " hours";

        }
    }
}
