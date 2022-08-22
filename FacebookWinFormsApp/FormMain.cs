﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                   /// (This is Desig Patter's App ID. replace it with your own)
                   // "1450160541956417", 
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
            buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
            BasicFacebook basicFacebook = new BasicFacebook(loginResult);
            this.Visible = false;
            basicFacebook.ShowDialog();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Text = "Bye...";
            this.Close();
        }
    }
}
