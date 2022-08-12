using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace FacebookLogic
{
    public class AppSettings
    {
        private Point m_LastWindowLocation;
        private Size m_LastWindowSize;
        private bool m_RememberUser;
        private string m_LastAccessToken;

        public AppSettings()
        {
            m_RememberUser = false;
            m_LastAccessToken = string.Empty;
        }
    }
}
