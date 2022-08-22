using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class TopRatedPictureBox : UserControl
    {
        public string Url { get; set; }
        public int IndexOf { get; set; }

        public delegate void StarBoxHandler(object sender, MouseEventArgs e);
        StarBoxHandler changeProfilePicture;
        public TopRatedPictureBox(string i_Url, int i_index, GalleryTab i_ListenerTab)
        {
            InitializeComponent();
            Url = i_Url;
            IndexOf = i_index;
            pictureBox.LoadAsync(Url);
            changeBtn.MouseClick += new MouseEventHandler(onChangeBtn_MouseClick);
            pictureBox.MouseDoubleClick += new MouseEventHandler(this.onGotChosen) ;
            changeProfilePicture = new StarBoxHandler(i_ListenerTab.ChangeBtn_MouseClick);
            this.MouseDoubleClick +=  new MouseEventHandler(i_ListenerTab.TopRatedPictureBox_MouseDoubleClick);
        }

        private void onGotChosen(Object sendr, EventArgs e)
        {
            this.OnMouseDoubleClick(null);
        }

        private void onChangeBtn_MouseClick(object sender, EventArgs e)
        {
            changeProfilePicture?.Invoke(this, null);
        }

        private void changeBtn_MouseHover(object sender, EventArgs e)
        {
            PictureBox starBox = sender as PictureBox;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(starBox,"set as profile picture");
        }
    }
}
