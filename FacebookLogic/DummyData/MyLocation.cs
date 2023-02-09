using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLogic
{
    public class MyLocation
    {
        public string m_Name { get; set; }

        public int m_AmountVisit { get; set; }

        public MyLocation(string name)
        {
            m_Name = name;
            m_AmountVisit = 0;
        }
    }
}
