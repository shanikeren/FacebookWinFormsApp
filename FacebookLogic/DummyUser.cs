using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class DummyUser
    {
        private string m_name { get; set; }
        private List<string> m_checkins { get; set; }

        public DummyUser(string name)
        {
            m_name = name;
        }

        public void AddCheckin(string checkin)
        {
            m_checkins.Add(checkin);
        }
    }
}
