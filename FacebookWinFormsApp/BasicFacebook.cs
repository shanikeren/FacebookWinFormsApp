using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookLogic;

////// user name: 
///// design.patterns
///// password:
///// design.patterns.22aa

namespace BasicFacebookFeatures
{
    public partial class BasicFacebook : Form
    {
        private InitProfile m_LoggedInUser;
        public LoginResult res;
        
        public BasicFacebook(LoginResult i_loginResult)
        {
            InitializeComponent();
            initAlbumListView();
            m_LoggedInUser = new InitProfile(i_loginResult);
            res = i_loginResult;
            profilePicture.LoadAsync(m_LoggedInUser.FetchProfilePicture());
            fetchPosts();
            fetchUpcomingEvent();
            fetchPages();
            fetchAlbums();
     
        }

        private void initAlbumListView()
        {
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(25, 25);
            //AlbumListView.LargeImageList = iList;
        }

        private void fetchUpcomingEvent()
        {
            EventTextBox.Text = m_LoggedInUser.getUpcomingEvent();
        }

        private void fetchPosts()
        {
            Posts.Items.Clear();

            List<string> postsList = m_LoggedInUser.LoadPosts();
            foreach(string post in postsList)
            {
                Posts.Items.Add(post);
            }

            if (Posts.Items.Count == 0)
            {
                MessageBox.Show("No Posts yet");
            }
        }

        private void fetchPages()
        {
            PagesListBox.Items.Clear();
            List<string> pagesList; 

            try
            {
                pagesList = m_LoggedInUser.LoadPages();
                foreach(string pageName in pagesList)
                {
                    PagesListBox.Items.Add(pageName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (PagesListBox.Items.Count == 0)
            {
                MessageBox.Show("No pages yet");
            }
        }
     
        private void onClickLogOutBtn(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Text = "Loging Out...";
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            if(PostTextArea.Text != String.Empty)
            {
                try
                {
                    m_LoggedInUser.PostStatus(PostTextArea.Text);
                    Posts.Items.Clear();
                    fetchPosts();
                    PostTextArea.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Text = "Loging Out...";
        
        }

        // ALBUMS //
        private void fetchAlbums()
        {
            AlbumsPanel.Controls.Clear();
            List<(string, Image)> userAlbums = m_LoggedInUser.LoadAlbums();

            foreach((string, Image) album in userAlbums)
            {
                PictureBox albumPic = new PictureBox();
                albumPic.Name = album.Item1;
                albumPic.Image = album.Item2;
                AlbumsPanel.Controls.Add(albumPic);
            }

            fitImageBox();
          
        }

        private void fitImageBox()
        {
            IEnumerable<PictureBox> pnls = AlbumsPanel.Controls.OfType<PictureBox>();
            foreach(PictureBox PB in pnls)
            {
                PB.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                PB.Margin = new Padding(9, 3, 3, 3);
                PB.Size = new Size(126, 96);
                PB.SizeMode = PictureBoxSizeMode.StretchImage;
                PB.MouseHover += PB_MouseHover;
                PB.MouseDoubleClick += PB_MouseDoubleClick;
            }
        }

        private void PB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox selectedAlbum = sender as PictureBox;
            List<string> picturesUrls = m_LoggedInUser.FetchAlbum(selectedAlbum.Name);
            List<string> topRatedPictures = m_LoggedInUser.FetchTopRatedPictures(selectedAlbum.Name);
            GalleryTab galleryTab = new GalleryTab(picturesUrls, topRatedPictures, profilePicture);

            TabPage newTab = new TabPage();
            newTab.Text = selectedAlbum.Name;
            basic.Controls.Add(newTab);
            galleryTab.Parent = newTab;
            galleryTab.Visible = true;
            galleryTab.Dock = DockStyle.Fill;
            basic.SelectedTab = newTab;
           // MessageBox.Show("Chosen Album is: " + PB.Name +". Make a new galleryTab");

        }

        private void PB_MouseHover(object sender, EventArgs e)
        {
            PictureBox PB = sender as PictureBox;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(PB, PB.Name);
           
        }

        private void AlbumListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.ToolTipText = e.Item.Text;
        }
  
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            List<string> checkins = m_LoggedInUser.FetchTopVisitPlaces();
            foreach (string check in checkins) {
                listBoxCheckins.Items.Add(check);
            }
        }

     
    }
}
