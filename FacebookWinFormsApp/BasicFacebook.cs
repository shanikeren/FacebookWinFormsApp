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
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace BasicFacebookFeatures
{
    public partial class BasicFacebook : Form
    {
        private User m_LoggedInUser;
        public LoginResult res;
        
        // TODO: I think we need to make "UIUser" object, and have the original "USER" as a member in the engine.

        public BasicFacebook(LoginResult i_loginResult)
        {
            InitializeComponent();
            m_LoggedInUser = i_loginResult.LoggedInUser;
            profilePicture.LoadAsync(m_LoggedInUser.PictureNormalURL);
            fetchPosts();
            fetchEvents();
            fetchGroups();
            fetchMusic();
            //Tomer added
            fetchAlbums();
        }

        private void fetchPosts()
        {
            Posts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    Posts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    Posts.Items.Add(post.Caption);
                }
                else
                {
                    Posts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (Posts.Items.Count == 0)
            {
                MessageBox.Show("No Posts yet");
            }
        }

        private void fetchEvents()
        {
            EventsList.Items.Clear();
            EventsList.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                EventsList.Items.Add(fbEvent);
            }

            if (EventsList.Items.Count == 0)
            {
                MessageBox.Show("No Events yet");
            }
        }

        private void fetchGroups()
        {
            GroupsListBox.Items.Clear();
            GroupsListBox.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    GroupsListBox.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (GroupsListBox.Items.Count == 0)
            {
                MessageBox.Show("No groups yet");
            }
        }
     
        private void onClickLogOutBtn(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Text = "Loging Out...";
        }

        //example with videos - should be music couldnt find it 
        private void fetchMusic()
        {
            GroupsListBox.Items.Clear();
            GroupsListBox.DisplayMember = "Name";
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Video video in m_LoggedInUser.Videos)
                {
                   sb.Append(video.Name);
                   sb.Append(" * ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (GroupsListBox.Items.Count == 0)
            {
                MessageBox.Show("No videos yet");
            }
        }

        // need to fake post? 
        private void PostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(PostTextArea.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            foreach (Album album in m_LoggedInUser.Albums) // initialize listView items display
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
    }
}
