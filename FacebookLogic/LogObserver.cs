using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic.Interfaces;

namespace FacebookLogic
{
    public class LogObserver : IClickedObserver
    {
        private static readonly string sr_FileName = "Logger.txt";
        private string m_Path = string.Empty;
        private List<Button> m_Notifiers;

        public LogObserver()
        {
            m_Path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (StreamWriter sw = File.AppendText(m_Path + "\\" + sr_FileName))
            {
                log("Log Starts", sw);
            }

            m_Notifiers = new List<Button>();
        }

        public void AssignNotifiersEvent()
        {
            m_Notifiers.ForEach((notifier) => { notifier.Click += new System.EventHandler(this.ReportClicked); });
        }

        public void AddNotifier(Button i_Notifier)
        {
            m_Notifiers.Add(i_Notifier);
        }

        public void ReportClicked(object sender, EventArgs args)
        {
            if (sender is Button)
            {
                using (StreamWriter sw = File.AppendText(m_Path + "\\" + sr_FileName))
                {
                    log((sender as Button).Name, sw);
                }
            }
        }

        private void log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }
    }
}
