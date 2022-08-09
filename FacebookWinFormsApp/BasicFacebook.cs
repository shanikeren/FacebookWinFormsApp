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
            fetchGroups();
            fetchPages();
            //Tomer added
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

        private void fetchEvents()
        {
            //PagesList.Items.Clear();

            //List<string> eventsList = m_LoggedInUser.LoadPosts();
            //foreach (string fbEvent in eventsList)
            //{
            //    PagesList.Items.Add(fbEvent);
            //}

            //if (PagesList.Items.Count == 0)
            //{
            //    MessageBox.Show("No Events yet");
            //}
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

        //example with videos - should be music couldnt find it 
        private void fetchGroups()
        {
            listViewGroups.Items.Clear();
            //LogicUser.clearAlbums();

            foreach (Group group in res.LoggedInUser.Groups) // initialize listView items display
            {
                listViewGroups.LargeImageList.Images.Add(group.ImageLarge);
            }
            listViewGroups.Items.Add("1");
            listViewGroups.Items.Add("1");
            listViewGroups.Items.Add("1");
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Status postedStatus = m_LoggedInUser.PostStatus(PostTextArea.Text);
            //    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Text = "Loging Out...";
        
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Method for groups, suppose to do what?
            // Maybe we should do it as hovering a group's name?
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Posts_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
     

        private void PostTextArea_TextChanged(object sender, EventArgs e)
        {

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
            List<string> picturesUrl = m_LoggedInUser.FetchAlbum(selectedAlbum.Name);
            GalleryTab galleryTab = new GalleryTab(picturesUrl);

            TabPage newTab = new TabPage();
            newTab.Text = selectedAlbum.Name;
            basic.Controls.Add(newTab);
            galleryTab.Parent = newTab;
            galleryTab.Visible = true;
            galleryTab.Dock = DockStyle.Fill;
            basic.SelectedTab = newTab;
            //MessageBox.Show("Chosen Album is: " + PB.Name +". Make a new galleryTab");

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
  
        private void checkinLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}
