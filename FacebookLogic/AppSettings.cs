using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Serialization;



namespace FacebookLogic
{
    public sealed class AppSettings
    {
        public static readonly string sr_AppSettingsXMLFileName = "appSettings.xml";
 
        private static AppSettings m_Instance = null;
        private static readonly object sr_InstanceLock = new Object();

        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }


        public static AppSettings Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    lock(sr_InstanceLock)
                    {
                        if(m_Instance == null)
                        {
                            m_Instance = new AppSettings();
                        }
                    }
                }

                return m_Instance;
            }
        }

        private AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(sr_AppSettingsXMLFileName, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public void LoadFromFile()
        {
            using (Stream stream = new FileStream(sr_AppSettingsXMLFileName, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                AppSettings lodedAppSettings = serializer.Deserialize(stream) as AppSettings;

                foreach (PropertyInfo currProperty in typeof(AppSettings).GetProperties())
                {
                    if (!currProperty.GetMethod.IsStatic)
                    {
                        object currValue = currProperty.GetValue(lodedAppSettings);

                        currProperty.SetValue(this, currValue);
                    }
                }
            }
        }
    }
}
