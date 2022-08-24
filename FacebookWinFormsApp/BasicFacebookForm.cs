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
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class BasicFacebookForm : Form
    {
        private InitProfile m_LoggedInUser;
        public LoginResult m_Res;
        private string m_AccessToken;
        
        // DELETE?
        public BasicFacebookForm(LoginResult i_loginResult)
        {
            InitializeComponent();
            initAlbumListView();
            m_AccessToken = i_loginResult.AccessToken;
            m_LoggedInUser = new InitProfile(i_loginResult);
            m_Res = i_loginResult;
            profilePicture.LoadAsync(m_LoggedInUser.FetchProfilePicture());
            fetchPosts();
            fetchUpcomingEvent();
            fetchPages();
            fetchAlbums();
        }

        //public BasicFacebookForm(InitProfile i_InitProfile)
        //{
        //    m_LoggedInUser = i_InitProfile;
        //    this.Text = $"Logged in as {m_LoggedInUser.Name}";
        //    InitializeComponent();
        //    initAlbumListView(null, null);
        //    fetchUserData(null, null);
        //}

        public BasicFacebookForm(InitProfile i_InitProfile)
        {
            InitializeComponent();
            this.Size = new Size(1002, 729);
            m_LoggedInUser = i_InitProfile;
            this.Text = $"Logged in as {m_LoggedInUser.Name}";
            this.Shown += loadInfo;
        }

        private void loadInfo(object sender, EventArgs e)
        {
            new Thread(this.initAlbumListView).Start();
            new Thread(this.fetchUserData).Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if(AppSettings.Instance.RememberUser)
            {
                this.Location = AppSettings.Instance.LastWindowLocation;
            }
        }

        private void fetchUserData()
        {
            profilePicture.LoadAsync(m_LoggedInUser.FetchProfilePicture());
            new Thread(this.fetchPosts).Start();
            new Thread(this.fetchUpcomingEvent).Start();
            new Thread(this.fetchPages).Start();
            new Thread(this.fetchAlbums).Start();
        }

        private void initAlbumListView()
        {
            ImageList iList = new ImageList();
            iList.ImageSize = new Size(25, 25);
        }

        private void fetchUpcomingEvent()
        {
            string upComingEvent = m_LoggedInUser.GetUpcomingEvent();
            EventTextBox.Invoke(new Action(()=>EventTextBox.Text = upComingEvent));
        }

        private void fetchPosts()
        {
            Posts.Invoke(new Action(()=>Posts.Items.Clear()));

            List<string> postsList = m_LoggedInUser.LoadPosts();
            foreach(string post in postsList)
            {
                Posts.Invoke(new Action(()=>Posts.Items.Add(post)));
            }

        }

        private void fetchPages()
        {
            PagesListBox.Invoke(new Action(()=>PagesListBox.Items.Clear()));
            List<string> pagesList; 

            try
            {
                pagesList = m_LoggedInUser.LoadPages();
                foreach(string pageName in pagesList)
                {
                    PagesListBox.Invoke(new Action(()=>PagesListBox.Items.Add(pageName)));
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
            FacebookService.Logout();
            this.Text = "Loging Out...";
            this.Visible = false;
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            //m_LoggedInUser.UpdateAppSettingsBeforeClose(RememberMeCheckBox.Checked);
        }

        private void postBtn_Click(object sender, EventArgs e)
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


        // ALBUMS //
        private void fetchAlbums()
        {
            AlbumsPanel.Invoke(new Action(()=>AlbumsPanel.Controls.Clear()));
            List<(string, Image)> userAlbums = m_LoggedInUser.LoadAlbums();

            foreach((string, Image) album in userAlbums)
            {
                PictureBox albumPic = new PictureBox();
                albumPic.Name = album.Item1;
                albumPic.Image = album.Item2;
                AlbumsPanel.Invoke(new Action(()=>AlbumsPanel.Controls.Add(albumPic)));
            }

            AlbumsPanel.Invoke(new Action(()=>fitImageBox()));
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
                PB.MouseHover += pictureBox_MouseHover;
                PB.MouseDoubleClick += album_MouseDoubleClick;
            }
        }

        private void album_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox selectedAlbum = sender as PictureBox;
            List<string> picturesUrls = m_LoggedInUser.FetchAlbum(selectedAlbum.Name);
            List<string> topRatedPictures = m_LoggedInUser.FetchTopRatedPictures(selectedAlbum.Name);
            GalleryTab galleryTab = new GalleryTab(picturesUrls, topRatedPictures, profilePicture);
            galleryTab.profilePictureChangedEvent += m_LoggedInUser.OnProfilePictureChange;

            TabPage newTab = new TabPage();
            newTab.Text = selectedAlbum.Name;
            newTab.AutoScroll = true;
            basic.Controls.Add(newTab);
            galleryTab.Parent = newTab;
            galleryTab.Visible = true;
            galleryTab.Dock = DockStyle.Fill;
            basic.SelectedTab = newTab;

        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox PB = sender as PictureBox;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(PB, PB.Name);
           
        }
  
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            listBoxCheckins.Items.Clear();

            List<(string, int)> checkins = m_LoggedInUser.FetchTopVisitPlaces();
            foreach ((string, int) check in checkins) {
                listBoxCheckins.Items.Add(check.Item1);
            }

            fillChart(checkins);
        }

        private void fillChart(List<(string, int)> i_checkins)
        {
            foreach (Series series in visitsChart.Series)
            {
                series.Points.Clear();
            }

            foreach((string,int) visit in i_checkins)
            {
                visitsChart.Series["Visits"].Points.AddXY(visit.Item1, visit.Item2);
            }
            visitsChart.Visible = true;
        }

        private void basic_TabIndexChanged(object sender, EventArgs e)
        {
            listBoxCheckins.Items.Clear();
            foreach(Series series in visitsChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void basicFacebook_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Text = "Loging Out...";
            //FacebookService.Logout();
            //this.Close();
        }

        private void BasicFacebookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //base.OnFormClosing(e);

            AppSettings.Instance.RememberUser = this.RememberMeCheckBox.Checked;
            AppSettings.Instance.LastWindowLocation = this.Location;

            if(AppSettings.Instance.RememberUser)
            {
                AppSettings.Instance.LastAccessToken = m_LoggedInUser.AccessToken;
            }
            else
            {
                AppSettings.Instance.LastAccessToken = null;
            }

            AppSettings.Instance.SaveToFile();
        }

        private void checkinLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
