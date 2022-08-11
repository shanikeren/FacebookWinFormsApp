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
            this.AlbumsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewGroups = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.buttonPlaces = new System.Windows.Forms.Button();
            this.checkinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(14, 16);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(159, 118);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogOut_Btn.Location = new System.Drawing.Point(31, 141);
            this.LogOut_Btn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(102, 25);
            this.LogOut_Btn.TabIndex = 1;
            this.LogOut_Btn.Text = "LogOut";
            this.LogOut_Btn.UseVisualStyleBackColor = false;
            this.LogOut_Btn.Click += new System.EventHandler(this.onClickLogOutBtn);
            // 
            // PagesListBox
            // 
            this.PagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PagesListBox.FormattingEnabled = true;
            this.PagesListBox.ItemHeight = 16;
            this.PagesListBox.Location = new System.Drawing.Point(319, 835);
            this.PagesListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(1033, 100);
            this.PagesListBox.TabIndex = 3;
            this.PagesListBox.Tag = "";
            this.PagesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // EventTextBox
            // 
            this.EventTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTextBox.Location = new System.Drawing.Point(253, 147);
            this.EventTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(833, 22);
            this.EventTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostTextArea.Location = new System.Drawing.Point(256, 266);
            this.PostTextArea.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(826, 77);
            this.PostTextArea.TabIndex = 6;
            this.PostTextArea.TextChanged += new System.EventHandler(this.PostTextArea_TextChanged);
            // 
            // PostBtn
            // 
            this.PostBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostBtn.Location = new System.Drawing.Point(1104, 316);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(13, 4, 5, 4);
            this.PostBtn.MaximumSize = new System.Drawing.Size(190, 28);
            this.PostBtn.MinimumSize = new System.Drawing.Size(47, 28);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PostBtn.Size = new System.Drawing.Size(90, 28);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // Posts
            // 
            this.Posts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Posts.FormattingEnabled = true;
            this.Posts.ItemHeight = 16;
            this.Posts.Location = new System.Drawing.Point(319, 469);
            this.Posts.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(1029, 324);
            this.Posts.TabIndex = 8;
            this.Posts.SelectedIndexChanged += new System.EventHandler(this.Posts_SelectedIndexChanged);
            // 
            // basic
            // 
            this.basic.Controls.Add(this.tabPage1);
            this.basic.Controls.Add(this.tabPage2);
            this.basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basic.Location = new System.Drawing.Point(4, 4);
            this.basic.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.basic.Name = "basic";
            this.basic.SelectedIndex = 0;
            this.basic.Size = new System.Drawing.Size(1204, 789);
            this.basic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.basic.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMargin = new System.Drawing.Size(5, 5);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(13, 1, 3, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Size = new System.Drawing.Size(1196, 760);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // AlbumsPanel
            // 
            this.AlbumsPanel.AutoScroll = true;
            this.AlbumsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.AlbumsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AlbumsPanel.Location = new System.Drawing.Point(14, 213);
            this.AlbumsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlbumsPanel.Name = "AlbumsPanel";
            this.AlbumsPanel.Size = new System.Drawing.Size(159, 390);
            this.AlbumsPanel.TabIndex = 13;
            this.AlbumsPanel.WrapContents = false;
            // 
            // listViewGroups
            // 
            this.listViewGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(253, 20);
            this.listViewGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(827, 67);
            this.listViewGroups.TabIndex = 12;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, -227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upcoming Event:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.listBoxCheckins);
            this.tabPage2.Controls.Add(this.buttonPlaces);
            this.tabPage2.Controls.Add(this.checkinLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Size = new System.Drawing.Size(1196, 760);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 16;
            this.listBoxCheckins.Location = new System.Drawing.Point(27, 160);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(291, 468);
            this.listBoxCheckins.TabIndex = 2;
            // 
            // buttonPlaces
            // 
            this.buttonPlaces.Location = new System.Drawing.Point(27, 69);
            this.buttonPlaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlaces.Name = "buttonPlaces";
            this.buttonPlaces.Size = new System.Drawing.Size(292, 60);
            this.buttonPlaces.TabIndex = 1;
            this.buttonPlaces.Text = "click me to find places to visit";
            this.buttonPlaces.UseVisualStyleBackColor = true;
            this.buttonPlaces.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkinLabel.Location = new System.Drawing.Point(21, 27);
            this.checkinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(123, 22);
            this.checkinLabel.TabIndex = 0;
            this.checkinLabel.Text = "places to visit!";
            this.checkinLabel.Click += new System.EventHandler(this.checkinLabel_Click);
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1212, 797);
            this.Controls.Add(this.basic);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BasicFacebook";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.basic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private Button buttonPlaces;
        private Label checkinLabel;
        private ListBox listBoxCheckins;
        private FlowLayoutPanel AlbumsPanel;
    }
}