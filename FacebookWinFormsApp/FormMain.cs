using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private InitProfile m_InitProfile;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_InitProfile = new InitProfile();
        }

        protected override void OnShown(EventArgs e)
        {
           // LoginResult loginResult = FacebookService.Connect(AppSettings.Instance.LastAccessToken);

            base.OnShown(e);

            if(AppSettings.Instance.RememberUser && !string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                LoginResult loginResult = m_InitProfile.LogInFromXml();
                openBasicFacbookForm(loginResult);
            }



            //loginResult = m_InitProfile.LogInFromXml();
            //if (loginResult != null && !string.IsNullOrEmpty(loginResult.AccessToken))
            //{
            //    openBasicFacbookForm(loginResult);
            //}

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); 

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                   "1257835301628630",
                    /// requested permissions:
					"email",
                    "public_profile",
                    "user_photos",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos"
                    /// add any relevant permissions
                    );

            openBasicFacbookForm(loginResult);

            /*BasicFacebookForm basicFacebook = new BasicFacebookForm(loginResult);
            this.Visible = false;
            basicFacebook.ShowDialog();
            this.Close();*/
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Text = "Bye...";
            this.Close();
        }

        private void openBasicFacbookForm(LoginResult i_LoginResult)
        {
            if (m_InitProfile.CheckIfLoggedIn(i_LoginResult))
            {
                buttonLogin.Text = $"Logging in as {i_LoginResult.LoggedInUser.Name}";
                BasicFacebookForm basicFacebook = new BasicFacebookForm(m_InitProfile);
                this.Visible = false;
                basicFacebook.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(i_LoginResult.ErrorMessage, "Login Failed");
            }
        }
    }
}
