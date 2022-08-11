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

        public TopRatedPictureBox(string i_Url, int i_index, GalleryTab i_ListenerTab)
        {
            InitializeComponent();
            Url = i_Url;
            IndexOf = i_index;
            pictureBox.LoadAsync(Url);
            changeBtn.MouseClick += new MouseEventHandler(i_ListenerTab.ChangeBtn_MouseClick);
            pictureBox.MouseDoubleClick += new MouseEventHandler(this.OnGotChosen) ;
            //pictureBox.MouseDoubleClick += new MouseEventHandler(this.MouseDoubleClick);

            this.MouseDoubleClick +=  new MouseEventHandler(i_ListenerTab.topRatedPictureBox_MouseDoubleClick);
        }

        private void OnGotChosen(Object sendr, EventArgs e)
        {
            
            this.OnMouseDoubleClick(null);
        }

    }
}
