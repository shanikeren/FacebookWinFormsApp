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

namespace BasicFacebookFeatures
{
    public partial class BasicFacebook : Form
    {
        User m_LoggedInUser;
        public BasicFacebook(User i_loggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_loggedInUser;
            fetchPosts();
            fetchEvents();
            fetchGroups();
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

        private void Posts_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

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

        private void PostTextArea_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
