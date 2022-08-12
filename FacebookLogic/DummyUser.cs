using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class DummyUser   
    {
        User m_user;
        public string m_Name;
        public List<string> m_checkins { get; set; }

        public DummyUser(string name)
        {
            this.m_Name = name;
            m_checkins = new List<string>();    
        }

        public void AddCheckin(string checkin)
        {
            m_checkins.Add(checkin);
        }
    }
}
