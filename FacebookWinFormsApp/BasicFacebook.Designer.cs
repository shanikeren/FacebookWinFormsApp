﻿
namespace BasicFacebookFeatures
{
    partial class BasicFacebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.LogOut_Btn = new System.Windows.Forms.Button();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.AlbumListView = new System.Windows.Forms.ListView();
            this.MusicTextBox = new System.Windows.Forms.TextBox();
            this.PostTextArea = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.Posts = new System.Windows.Forms.ListBox();
            this.EventsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(18, 18);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(212, 177);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.Location = new System.Drawing.Point(18, 218);
            this.LogOut_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(148, 37);
            this.LogOut_Btn.TabIndex = 1;
            this.LogOut_Btn.Text = "LogOut";
            this.LogOut_Btn.UseVisualStyleBackColor = true;
            this.LogOut_Btn.Click += new System.EventHandler(this.onClickLogOutBtn);
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 20;
            this.GroupsListBox.Location = new System.Drawing.Point(312, 840);
            this.GroupsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(898, 144);
            this.GroupsListBox.TabIndex = 3;
            this.GroupsListBox.Tag = "";
            this.GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // AlbumListView
            // 
            this.AlbumListView.HideSelection = false;
            this.AlbumListView.Location = new System.Drawing.Point(18, 303);
            this.AlbumListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumListView.Name = "AlbumListView";
            this.AlbumListView.Size = new System.Drawing.Size(210, 699);
            this.AlbumListView.TabIndex = 4;
            this.AlbumListView.UseCompatibleStateImageBehavior = false;
            this.AlbumListView.View = System.Windows.Forms.View.Tile;
            // 
            // MusicTextBox
            // 
            this.MusicTextBox.Location = new System.Drawing.Point(297, 165);
            this.MusicTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MusicTextBox.Name = "MusicTextBox";
            this.MusicTextBox.Size = new System.Drawing.Size(934, 26);
            this.MusicTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Location = new System.Drawing.Point(312, 280);
            this.PostTextArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(780, 95);
            this.PostTextArea.TabIndex = 6;
            this.PostTextArea.TextChanged += new System.EventHandler(this.PostTextArea_TextChanged);
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(1120, 342);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(112, 35);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = true;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.ItemHeight = 20;
            this.Posts.Location = new System.Drawing.Point(312, 452);
            this.Posts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(780, 324);
            this.Posts.TabIndex = 8;
            this.Posts.SelectedIndexChanged += new System.EventHandler(this.Posts_SelectedIndexChanged);
            // 
            // EventsList
            // 
            this.EventsList.FormattingEnabled = true;
            this.EventsList.ItemHeight = 20;
            this.EventsList.Location = new System.Drawing.Point(297, 18);
            this.EventsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventsList.Name = "EventsList";
            this.EventsList.Size = new System.Drawing.Size(934, 104);
            this.EventsList.TabIndex = 9;
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 1023);
            this.Controls.Add(this.EventsList);
            this.Controls.Add(this.Posts);
            this.Controls.Add(this.PostBtn);
            this.Controls.Add(this.PostTextArea);
            this.Controls.Add(this.MusicTextBox);
            this.Controls.Add(this.AlbumListView);
            this.Controls.Add(this.GroupsListBox);
            this.Controls.Add(this.LogOut_Btn);
            this.Controls.Add(this.profilePicture);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasicFacebook";
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button LogOut_Btn;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.ListView AlbumListView;
        private System.Windows.Forms.TextBox MusicTextBox;
        private System.Windows.Forms.TextBox PostTextArea;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.ListBox Posts;
        private System.Windows.Forms.ListBox EventsList;
    }
}