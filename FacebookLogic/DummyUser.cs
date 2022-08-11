using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class DummyUser  : User
    {
        private List<string> m_checkins { get; set; }

        public DummyUser(string name)
        {
            this.Name = name;
        }

        public void AddCheckin(string checkin)
        {
            m_checkins.Add(checkin);
        }
    }
}
