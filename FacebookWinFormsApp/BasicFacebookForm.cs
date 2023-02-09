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
using BasicFacebookFeatures.Command;
using FacebookLogic.Interfaces;

namespace BasicFacebookFeatures
{
    public partial class BasicFacebookForm : Form
    {
        private InitProfile m_LoggedInUser;
        private HangOutFacade m_HangOutFacade;
        private IClickedObserver m_Logger;

        public BasicFacebookForm(InitProfile i_InitProfile)
        {
            //initCommandMenu();
            InitializeComponent();
            this.Size = new Size(1506, 1117);
            m_LoggedInUser = i_InitProfile;
            userBindingSource.DataSource = m_LoggedInUser.LoggedUser;
            this.Text = $"Logged in as {m_LoggedInUser.Name}";
            this.Shown += loadInfo;
            this.m_HangOutFacade = HangOutFacade.GetHangOutFacade(m_LoggedInUser);
            initLogger();
        }

        private void initLogger()
        {
            m_Logger = new LogObserver();
            //m_Logger.AddNotifier(LogOut_Btn);
            //m_Logger.AddNotifier(PostBtn);
            //m_Logger.AddNotifier(JoinBtn);
            //m_Logger.AddNotifier(CreateOfferBtn);
            //m_Logger.AddNotifier(ShowBtn);
            //m_Logger.AddNotifier(buttonPlaces);
            //m_Logger.AddNotifier(timeFilterButton);

            //timeFilterButton.Click += m_Logger.ReportClicked;

            attachButtonsToLogger();


            //(m_Logger as LogObserver).AssignNotifiersEvent();
        }

        private void attachButtonsToLogger()
        {
            var buttons = GetAll(this, typeof(Button));
            foreach (Button button in buttons)
            {
                m_Logger.AddNotifier(button);
                button.Click += m_Logger.ReportClicked;
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void initCommandMenu()
        {
            
        }

        private void loadInfo(object sender, EventArgs e)
        {
            new Thread(this.initAlbumListView).Start();
            new Thread(this.fetchUserData).Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Size = new Size(1002, 729);
            base.OnLoad(e);

            if (AppSettings.Instance.RememberUser)
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
            EventTextBox.Invoke(new Action(() => EventTextBox.Text = upComingEvent));
        }

        private void fetchPosts()
        {
            Posts.Invoke(new Action(() => Posts.Items.Clear()));

            List<Post> postsList = m_LoggedInUser.LoadPosts();
            Sorter sorter = chosenStrategy();
            sortLabel.Invoke(new Action(() => sortLabel.Text = "Sort By: (sorting...)"));
            sorter.Sort(postsList);
            sortLabel.Invoke(new Action(() => sortLabel.Text = "Sort By:"));
            foreach (Post post in postsList)
            {
                Posts.Invoke(new Action(() =>

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
                }));
            }

            //check is radio button is chosen and create a sorter as asked. amount of likes - Update time - create time
            // change from List<string> to List<Post>
        }

        private Sorter chosenStrategy()
        {
            ICompareStrategy chosenComparer;
            string strategyName = null;
            var chosenStrategy = compareStrategyPanel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if(chosenStrategy != null)
            {
                strategyName = (chosenStrategy as RadioButton).Text;
            }
            chosenComparer = (ICompareStrategy)FacebookLogic.Compare_Strategies.CompareStrategyFactory.CreateStrategy(strategyName);

            return new Sorter(chosenComparer);
        }

        private void fetchPages()
        {
            PagesListBox.Invoke(new Action(() => PagesListBox.Items.Clear()));
            List<string> pagesList;

            try
            {
                pagesList = m_LoggedInUser.LoadPages();
                foreach (string pageName in pagesList)
                {
                    PagesListBox.Invoke(new Action(() => PagesListBox.Items.Add(pageName)));
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
            if (PostTextArea.Text != String.Empty)
            {
                try
                {
                    //m_LoggedInUser.PostStatus(PostTextArea.Text);
                    Posts.Items.Clear();
                    new Thread(fetchPosts).Start();
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
            AlbumsPanel.Invoke(new Action(() => AlbumsPanel.Controls.Clear()));
            List<(string, Image)> userAlbums = m_LoggedInUser.LoadAlbums();

            foreach ((string, Image) album in userAlbums)
            {
                PictureBox albumPic = new PictureBox();
                albumPic.Name = album.Item1;
                albumPic.Image = album.Item2;
                AlbumsPanel.Invoke(new Action(() => AlbumsPanel.Controls.Add(albumPic)));
            }

            AlbumsPanel.Invoke(new Action(() => fitImageBox()));
        }

        private void fitImageBox()
        {
            IEnumerable<PictureBox> pnls = AlbumsPanel.Controls.OfType<PictureBox>();
            foreach (PictureBox PB in pnls)
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
            foreach ((string, int) check in checkins)
            {
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

            foreach ((string, int) visit in i_checkins)
            {
                visitsChart.Series["Visits"].Points.AddXY(visit.Item1, visit.Item2);
            }
            visitsChart.Visible = true;
        }

        private void basic_TabIndexChanged(object sender, EventArgs e)
        {
            listBoxCheckins.Items.Clear();
            foreach (Series series in visitsChart.Series)
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

            if (AppSettings.Instance.RememberUser)
            {
                AppSettings.Instance.LastWindowLocation = this.Location;

                AppSettings.Instance.LastAccessToken = m_LoggedInUser.AccessToken;
            }
            else
            {
                AppSettings.Instance.LastAccessToken = null;
            }

            AppSettings.Instance.SaveToFile();
        }


        // Hang Outs \\

      private void listBoxCheckins_MouseClick(object sender, MouseEventArgs e)
        {
            OffersListBox.Items.Clear();

            int index = this.listBoxCheckins.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                List<HangOutOffer> offers = m_HangOutFacade.GetOffersByPlace((sender as ListBox).SelectedItem.ToString());
                foreach(HangOutOffer offer in offers)
                {
                    OffersListBox.Items.Add(offer);
                }
            }
        }

       private void OffersListBox_MouseClick(object sender, MouseEventArgs e)
        {
            HangOutOffer selectedOffer = (sender as ListBox).SelectedItem as HangOutOffer;
            if(selectedOffer != null)
            {
                m_HangOutFacade.CurrOffer = selectedOffer;

                InitInfo.Text = selectedOffer.InitiatorName;
                WhereFromInfo.Text = selectedOffer.FromWhere;
                WhereToInfo.Text = selectedOffer.WhereTo;
                PhoneInfo.Text = selectedOffer.InitiatorPhone;
                WhenInfo.Text = selectedOffer.When.ToString("dd-MM-yy H:mm");
            }
           
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            List<HangOutOffer> offers = new List<HangOutOffer>();

            OffersListBox.Items.Clear();
            if (AllRadioBtn.Checked)
            {
                offers = m_HangOutFacade.GetAllOffers();
            }
            else if(MineRadioBtn.Checked)
            {
                offers = m_LoggedInUser.m_MyHangOuts;
                
            }

            foreach (HangOutOffer offer in offers)
            {
                OffersListBox.Items.Add(offer);
            }
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            try
            {
                m_HangOutFacade.JoinHangOut();
                MessageBox.Show("You Joined, enjoy.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createOfferBtn_Click(object sender, EventArgs e)
        {
            Form hangOutForm = FormsFactory.CreateForm(eFormType.HangOutForm, m_LoggedInUser) as HangOutForm;
            hangOutForm.ShowDialog();
        }

        private void fetchPosts(object sender, EventArgs e)
        {
            new Thread(fetchPosts).Start();
        }

        private void timeFilterButton_Click(object sender, EventArgs e)
        {
            OffersListBox.Items.Clear();
            List<HangOutOffer> filteredOffers = m_HangOutFacade.GetOffersByTime(fromDateTimePicker.Value, untilDateTimePicker.Value);
            foreach (HangOutOffer offer in filteredOffers)
            {
                OffersListBox.Items.Add(offer);
            }

        }
    }
}
