
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
            this.AlbumListView = new System.Windows.Forms.ListView();
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
            this.checkinLabel = new System.Windows.Forms.Label();
            this.buttonPlaces = new System.Windows.Forms.Button();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(17, 25);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(184, 147);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogOut_Btn.Location = new System.Drawing.Point(17, 179);
            this.LogOut_Btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(127, 30);
            this.LogOut_Btn.TabIndex = 1;
            this.LogOut_Btn.Text = "LogOut";
            this.LogOut_Btn.UseVisualStyleBackColor = false;
            this.LogOut_Btn.Click += new System.EventHandler(this.onClickLogOutBtn);
            // 
            // PagesListBox
            // 
            this.PagesListBox.FormattingEnabled = true;
            this.PagesListBox.ItemHeight = 16;
            this.PagesListBox.Location = new System.Drawing.Point(254, 719);
            this.PagesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(694, 84);
            this.PagesListBox.TabIndex = 3;
            this.PagesListBox.Tag = "";
            this.PagesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // AlbumListView
            // 
            this.AlbumListView.BackColor = System.Drawing.SystemColors.Control;
            this.AlbumListView.HideSelection = false;
            this.AlbumListView.Location = new System.Drawing.Point(17, 421);
            this.AlbumListView.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumListView.MultiSelect = false;
            this.AlbumListView.Name = "AlbumListView";
            this.AlbumListView.ShowItemToolTips = true;
            this.AlbumListView.Size = new System.Drawing.Size(187, 382);
            this.AlbumListView.TabIndex = 4;
            this.AlbumListView.UseCompatibleStateImageBehavior = false;
            this.AlbumListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.AlbumListView_ItemMouseHover);
            this.AlbumListView.DoubleClick += new System.EventHandler(this.AlbumListView_DoubleClick);
            // 
            // EventTextBox
            // 
            this.EventTextBox.Location = new System.Drawing.Point(254, 146);
            this.EventTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(694, 22);
            this.EventTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Location = new System.Drawing.Point(254, 290);
            this.PostTextArea.Margin = new System.Windows.Forms.Padding(4);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(588, 77);
            this.PostTextArea.TabIndex = 6;
            this.PostTextArea.TextChanged += new System.EventHandler(this.PostTextArea_TextChanged);
            // 
            // PostBtn
            // 
            this.PostBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostBtn.Location = new System.Drawing.Point(848, 339);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(100, 28);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.ItemHeight = 16;
            this.Posts.Location = new System.Drawing.Point(254, 421);
            this.Posts.Margin = new System.Windows.Forms.Padding(4);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(694, 260);
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
            this.basic.Location = new System.Drawing.Point(1, 9);
            this.basic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basic.Name = "basic";
            this.basic.SelectedIndex = 0;
            this.basic.Size = new System.Drawing.Size(2105, 1528);
            this.basic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.basic.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.listViewGroups);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.profilePicture);
            this.tabPage1.Controls.Add(this.PagesListBox);
            this.tabPage1.Controls.Add(this.Posts);
            this.tabPage1.Controls.Add(this.PostBtn);
            this.tabPage1.Controls.Add(this.LogOut_Btn);
            this.tabPage1.Controls.Add(this.PostTextArea);
            this.tabPage1.Controls.Add(this.AlbumListView);
            this.tabPage1.Controls.Add(this.EventTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(2097, 1499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // listViewGroups
            // 
            this.listViewGroups.HideSelection = false;
            this.listViewGroups.Location = new System.Drawing.Point(254, 20);
            this.listViewGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewGroups.Name = "listViewGroups";
            this.listViewGroups.Size = new System.Drawing.Size(694, 66);
            this.listViewGroups.TabIndex = 12;
            this.listViewGroups.UseCompatibleStateImageBehavior = false;
            this.listViewGroups.SelectedIndexChanged += new System.EventHandler(this.listViewPages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upcoming Event:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.listBoxCheckins);
            this.tabPage2.Controls.Add(this.buttonPlaces);
            this.tabPage2.Controls.Add(this.checkinLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(2097, 1499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkinLabel.Location = new System.Drawing.Point(16, 22);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(123, 22);
            this.checkinLabel.TabIndex = 0;
            this.checkinLabel.Text = "places to visit!";
            this.checkinLabel.Click += new System.EventHandler(this.checkinLabel_Click);
            // 
            // buttonPlaces
            // 
            this.buttonPlaces.Location = new System.Drawing.Point(20, 56);
            this.buttonPlaces.Name = "buttonPlaces";
            this.buttonPlaces.Size = new System.Drawing.Size(219, 49);
            this.buttonPlaces.TabIndex = 1;
            this.buttonPlaces.Text = "click me to find places to visit";
            this.buttonPlaces.UseVisualStyleBackColor = true;
            this.buttonPlaces.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 16;
            this.listBoxCheckins.Location = new System.Drawing.Point(20, 130);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(219, 388);
            this.listBoxCheckins.TabIndex = 2;
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1031, 870);
            this.Controls.Add(this.basic);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BasicFacebook";
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.basic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.ListView AlbumListView;
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
    }
}