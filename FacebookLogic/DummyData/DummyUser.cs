using System.Threading.Tasks;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookLogic
{
    public class DummyUser
    {
        private User m_user;
        private string m_Name;

        public List<string> m_checkins { get; set; }

        public DummyUser(string name)
        {
            this.m_Name = name;
            this.m_checkins = new List<string>();
        }

        public void AddCheckin(string checkin)
        {
            m_checkins.Add(checkin);
        }
    }
}
