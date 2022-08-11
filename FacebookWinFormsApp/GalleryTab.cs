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
    public partial class GalleryTab : UserControl
    {
        private string[] m_PicturesUrls;
        private string[] m_TopRatedPicturesUrls;

        int index = 0;

        public GalleryTab(List<string> i_picturesUrl/*, List<string> i_TopRatedPictures*/)
        {
            InitializeComponent();
            m_PicturesUrls = i_picturesUrl.ToArray();
      //      m_TopRatedPicturesUrls = i_TopRatedPictures.ToArray();
            CurrentImage.Load(m_PicturesUrls[index]);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            TabControl parent = this.Parent.Parent as TabControl;
            parent.TabPages.Remove((TabPage)this.Parent);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            index++;
            if (index == m_PicturesUrls.Length)
            {
                index = 0;
            }

            CurrentImage.Load(m_PicturesUrls[index]);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                index = m_PicturesUrls.Length - 1;
            }

            CurrentImage.Load(m_PicturesUrls[index]);

        }

        private void topRatedPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox selctedTopPicture = sender as PictureBox;
            //index = m_PicturesUrls.
            
            //Array.FindIndex<String>(m_PicturesUrls, selctedTopPicture.);
        }
    }
}
