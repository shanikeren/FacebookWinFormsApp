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
        private int m_CurrentImageIndex = 0;
        PictureBox m_CurrProfilePicture;

        public delegate void profilePictureChangedDelegate(string url);
        public profilePictureChangedDelegate profilePictureChangedEvent;

        public GalleryTab(List<string> i_picturesUrl, List<string> i_TopRatedPictures, PictureBox i_profilePictureBox)
        {
            InitializeComponent();
            m_PicturesUrls = i_picturesUrl.ToArray();
            m_TopRatedPicturesUrls = i_TopRatedPictures.ToArray();
            CurrentImage.Load(m_PicturesUrls[m_CurrentImageIndex]);
            initializeTopRatedPicture(i_profilePictureBox);
            m_CurrProfilePicture = i_profilePictureBox;
        }

        private void initializeTopRatedPicture(PictureBox i_profilePictureBox)
        {
            int index = 0;
            
            foreach(String url in m_TopRatedPicturesUrls)
            {
                index = Array.IndexOf(m_PicturesUrls, url);
                TopRatedPictureBox topRatedPicture = new TopRatedPictureBox(url, index, this);
                topRatedPicturePanel.Controls.Add(topRatedPicture);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            TabControl parent = this.Parent.Parent as TabControl;
            parent.TabPages.Remove((TabPage)this.Parent);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex++;
            if (m_CurrentImageIndex == m_PicturesUrls.Length)
            {
                m_CurrentImageIndex = 0;
            }

            CurrentImage.Load(m_PicturesUrls[m_CurrentImageIndex]);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            m_CurrentImageIndex--;
            if (m_CurrentImageIndex == -1)
            {
                m_CurrentImageIndex = m_PicturesUrls.Length - 1;
            }

            CurrentImage.Load(m_PicturesUrls[m_CurrentImageIndex]);

        }

        public void TopRatedPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TopRatedPictureBox selctedTopPicture = sender as TopRatedPictureBox;
            CurrentImage.LoadAsync(selctedTopPicture.Url);
            m_CurrentImageIndex = selctedTopPicture.IndexOf;
        }

        public void ChangeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            TopRatedPictureBox selectedTopPicture = sender as TopRatedPictureBox;
            m_CurrProfilePicture.LoadAsync(selectedTopPicture.Url);
            m_CurrProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageBox.Show("Profile picture was changed:)");
            profilePictureChangedEvent?.Invoke(selectedTopPicture.Url);
        }

        private void galleryTab_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

    }
}
