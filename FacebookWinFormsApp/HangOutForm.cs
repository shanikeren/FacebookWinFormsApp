using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class HangOutForm : Form
    {
        private InitProfile i_LoggedInUser;

        public HangOutForm()
        {
            InitializeComponent();
        }

        public HangOutForm(InitProfile i_LoggedInUser)
        {
            this.i_LoggedInUser = i_LoggedInUser;
        }
    }
}
