using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Command
{
    public class CommandsMenu : List<CommandsMenu.MenuItem>
    {
        public class MenuItem
        {
            public Action ItemAction { get; set; }
            public string Text { get; set; }

            public virtual void Selected()
            {
                ItemAction?.Invoke();
            }
        }
    }
}
