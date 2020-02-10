using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLess
{
    public static class DataAccess
    {
        public static List<string> LoadDataFromFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<SessionModel> BuildSessionList(this List<string> lines)
        {
            List<SessionModel> sessions = new List<SessionModel>();

            if (lines.Count > 0)
            {
                foreach (string line in lines)
                {
                    string[] cols = line.Split(',');

                    SessionModel session = new SessionModel();
                    session.Id = int.Parse(cols[0]);
                    session.SessionDate = DateTime.Parse(cols[1]);
                    session.SessionLength = DateTime.Parse(cols[2]);

                    sessions.Add(session);
                } 
            }

            return sessions;
        }

        public static void SaveDataToFile(this List<SessionModel> sessions)
        {
            List<string> lines = new List<string>();

            foreach (SessionModel s in sessions)
            {
                lines.Add($"{ s.Id },{ s.SessionDate },{ s.SessionLength }");
            }

            File.WriteAllLines(Properties.Settings.Default.PathToCSVFile, lines, Encoding.UTF8);
        }

        public static List<SessionModel> SaveNewSessionData(this List<SessionModel> currentSessions, DateTime argSessionDate, DateTime argSessionLength)
        {
            SessionModel session = new SessionModel();

            if (currentSessions.Count > 0)
            {
                session.Id = currentSessions.Max(x => x.Id) + 1;
            }
            else
            {
                session.Id = 1;
            }

            session.SessionDate = argSessionDate;
            session.SessionLength = argSessionLength;

            currentSessions.Add(session);

            currentSessions.SaveDataToFile();

            return currentSessions;
        }
    }
}
