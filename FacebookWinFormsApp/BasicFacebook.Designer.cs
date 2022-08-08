
using System;
using System.Windows.Forms;

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
            this.PagesListBox = new System.Windows.Forms.ListBox();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.PostTextArea = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.Posts = new System.Windows.Forms.ListBox();
            this.basic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AlbumsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(13, 16);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(149, 120);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogOut_Btn.Location = new System.Drawing.Point(13, 146);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(95, 25);
            this.LogOut_Btn.TabIndex = 1;
            this.LogOut_Btn.Text = "LogOut";
            this.LogOut_Btn.UseVisualStyleBackColor = false;
            this.LogOut_Btn.Click += new System.EventHandler(this.onClickLogOutBtn);
            // 
            // PagesListBox
            // 
            this.PagesListBox.FormattingEnabled = true;
            this.PagesListBox.Location = new System.Drawing.Point(191, 543);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(464, 69);
            this.PagesListBox.TabIndex = 3;
            this.PagesListBox.Tag = "";
            this.PagesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(191, 134);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(521, 20);
            this.EventTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Location = new System.Drawing.Point(191, 216);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(521, 63);
            this.PostTextArea.TabIndex = 6;
            this.PostTextArea.TextChanged += new System.EventHandler(this.PostTextArea_TextChanged);
            // 
            // PostBtn
            // 
            this.PostBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostBtn.Location = new System.Drawing.Point(720, 257);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(75, 23);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.Location = new System.Drawing.Point(191, 305);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(521, 212);
            this.Posts.TabIndex = 8;
            this.Posts.SelectedIndexChanged += new System.EventHandler(this.Posts_SelectedIndexChanged);
            // 
            // basic
            // 
            this.basic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basic.Controls.Add(this.tabPage1);
            this.basic.Controls.Add(this.tabPage2);
            this.basic.Location = new System.Drawing.Point(1, 10);
            this.basic.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.basic.Name = "basic";
            this.basic.SelectedIndex = 0;
            this.basic.Size = new System.Drawing.Size(843, 672);
            this.basic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.basic.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.AlbumsPanel);
            this.tabPage1.Controls.Add(this.listViewGroups);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.profilePicture);
            this.tabPage1.Controls.Add(this.PagesListBox);
            this.tabPage1.Controls.Add(this.Posts);
            this.tabPage1.Controls.Add(this.PostBtn);
            this.tabPage1.Controls.Add(this.LogOut_Btn);
            this.tabPage1.Controls.Add(this.PostTextArea);
            this.tabPage1.Controls.Add(this.EventTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(835, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // listViewGroups
            // 
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(190, 16);
            this.listViewGroups.Margin = new System.Windows.Forms.Padding(2);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(464, 55);
            this.listViewGroups.TabIndex = 12;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.SelectedIndexChanged += new System.EventHandler(this.listViewPages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, -82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upcoming Event:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(835, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // AlbumsPanel
            // 
            this.AlbumsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AlbumsPanel.AutoScroll = true;
            this.AlbumsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.AlbumsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AlbumsPanel.Location = new System.Drawing.Point(13, 216);
            this.AlbumsPanel.Name = "AlbumsPanel";
            this.AlbumsPanel.Size = new System.Drawing.Size(149, 396);
            this.AlbumsPanel.TabIndex = 13;
            this.AlbumsPanel.WrapContents = false;
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(844, 681);
            this.Controls.Add(this.basic);
            this.Name = "BasicFacebook";
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.basic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void listViewPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button LogOut_Btn;
        private System.Windows.Forms.ListBox PagesListBox;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.TextBox PostTextArea;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.ListBox Posts;
        private System.Windows.Forms.TabControl basic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label label2;
        private Label label1;
        private ListView listViewGroups;
        private FlowLayoutPanel AlbumsPanel;
    }
}