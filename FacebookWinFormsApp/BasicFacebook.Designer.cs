
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
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.AlbumListView = new System.Windows.Forms.ListView();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.PostTextArea = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.Posts = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewPages = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(17, 25);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(188, 142);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.Location = new System.Drawing.Point(39, 191);
            this.LogOut_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(132, 30);
            this.LogOut_Btn.TabIndex = 1;
            this.LogOut_Btn.Text = "LogOut";
            this.LogOut_Btn.UseVisualStyleBackColor = true;
            this.LogOut_Btn.Click += new System.EventHandler(this.onClickLogOutBtn);
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.ItemHeight = 16;
            this.GroupsListBox.Location = new System.Drawing.Point(254, 667);
            this.GroupsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(694, 116);
            this.GroupsListBox.TabIndex = 3;
            this.GroupsListBox.Tag = "";
            this.GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // AlbumListView
            // 
            this.AlbumListView.HideSelection = false;
            this.AlbumListView.Location = new System.Drawing.Point(17, 253);
            this.AlbumListView.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumListView.Name = "AlbumListView";
            this.AlbumListView.ShowItemToolTips = true;
            this.AlbumListView.Size = new System.Drawing.Size(187, 382);
            this.AlbumListView.TabIndex = 4;
            this.AlbumListView.UseCompatibleStateImageBehavior = false;
            this.AlbumListView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.AlbumListView_ItemMouseHover);
            this.AlbumListView.SelectedIndexChanged += new System.EventHandler(this.AlbumListView_SelectedIndexChanged);
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
            this.PostTextArea.Location = new System.Drawing.Point(254, 253);
            this.PostTextArea.Margin = new System.Windows.Forms.Padding(4);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(694, 77);
            this.PostTextArea.TabIndex = 6;
            this.PostTextArea.TextChanged += new System.EventHandler(this.PostTextArea_TextChanged);
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(985, 301);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(100, 28);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = true;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.ItemHeight = 16;
            this.Posts.Location = new System.Drawing.Point(254, 375);
            this.Posts.Margin = new System.Windows.Forms.Padding(4);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(694, 260);
            this.Posts.TabIndex = 8;
            this.Posts.SelectedIndexChanged += new System.EventHandler(this.Posts_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2323, 1504);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewPages);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.profilePicture);
            this.tabPage1.Controls.Add(this.GroupsListBox);
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
            this.tabPage1.Size = new System.Drawing.Size(2315, 1475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 225);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(2315, 1475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewPages
            // 
            this.listViewPages.HideSelection = false;
            this.listViewPages.Location = new System.Drawing.Point(254, 25);
            this.listViewPages.Name = "listViewPages";
            this.listViewPages.Size = new System.Drawing.Size(694, 82);
            this.listViewPages.TabIndex = 12;
            this.listViewPages.UseCompatibleStateImageBehavior = false;
            this.listViewPages.SelectedIndexChanged += new System.EventHandler(this.listViewPages_SelectedIndexChanged);
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 682);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BasicFacebook";
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Button LogOut_Btn;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.ListView AlbumListView;
        private System.Windows.Forms.TextBox EventTextBox;
        private System.Windows.Forms.TextBox PostTextArea;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.ListBox Posts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label label2;
        private Label label1;
        private ListView listViewPages;
    }
}