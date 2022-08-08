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
        
        // TODO: I think we need to make "UIUser" object, and have the original "USER" as a member in the engine.

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
            AlbumListView.LargeImageList = iList;
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
            AlbumListView.Items.Clear();
            //LogicUser.clearAlbums();

            int index = 0;
            foreach (Album album in res.LoggedInUser.Albums) // initialize listView items display
            {
                AlbumListView.LargeImageList.Images.Add(album.ImageAlbum);
                AlbumListView.Items.Add(album.Name, index);
                
                index++;
            }

        }

        private void AlbumListView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            e.Item.ToolTipText = e.Item.Text;
        }

        private void AlbumListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Need to check if this is rellvant");
        }

        private void AlbumListView_DoubleClick(object sender, EventArgs e)
        {
                // user clicked an item of listview control

                if (AlbumListView.SelectedItems.Count == 1)
                {
                    MessageBox.Show("Chosen Album is: " + AlbumListView.SelectedItems[0].Text);
                //Logic User new AlbumDisplay( AlbumListView.SelectedItems[0].Text)
            }
            AlbumListView.SelectedItems.Clear();
        }

        private void checkinLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
