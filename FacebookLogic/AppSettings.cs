using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;

namespace FacebookLogic
{
    public sealed class AppSettings
    {
        private static readonly string sr_AppSettingsXMLFileName = "appSettings.xml";
        private static readonly object sr_InstanceLock = new object();
        private static AppSettings m_Instance = null;

        public static AppSettings Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = LoadFromFile();
                        }
                    }
                }

                return m_Instance;
            }
        }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public Point LastWindowLocation { get; set; }

        private AppSettings()
        {
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings loadedThis = null;

            if (File.Exists(sr_AppSettingsXMLFileName))
            {
                using (FileStream stream = new FileStream(sr_AppSettingsXMLFileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedThis = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new AppSettings()
                {
                    RememberUser = false,
                    LastWindowLocation = new Point(260, 0),
                };
            }

            return loadedThis;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(sr_AppSettingsXMLFileName, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
