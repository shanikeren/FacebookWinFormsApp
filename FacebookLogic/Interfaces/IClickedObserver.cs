using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookLogic.Interfaces
{
    public interface IClickedObserver
    {
        void ReportClicked(object sender, EventArgs args);

        void AddNotifier(Button i_Notifier);
    }
}
