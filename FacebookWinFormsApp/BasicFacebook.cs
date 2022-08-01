using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class BasicFacebook : Form
    {
        //private readonly GameEngine r_GameEngine = null;

        private User m_LoggedInUser;

        public BasicFacebook(User i_LogingIn)
        {
            InitializeComponent();
            m_LoggedInUser = i_LogingIn;
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            loadAlbums();
        }

        private void loadAlbums()
        {
            AlbumListView.Items.Clear();

            foreach(Album album in m_LoggedInUser.Albums)
            {
                AlbumListView.Items.Add(album);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void profilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
