
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.AlbumListView = new System.Windows.Forms.ListView();
            this.MusicTextBox = new System.Windows.Forms.TextBox();
            this.PostTextArea = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.Posts = new System.Windows.Forms.ListBox();
            this.EventsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "ProfilePicture";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AccessibleName = "LogOut_Btn";
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.Location = new System.Drawing.Point(208, 546);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(600, 95);
            this.GroupsListBox.TabIndex = 3;
            this.GroupsListBox.Tag = "";
            this.GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // AlbumListView
            // 
            this.AlbumListView.HideSelection = false;
            this.AlbumListView.Location = new System.Drawing.Point(12, 197);
            this.AlbumListView.Name = "AlbumListView";
            this.AlbumListView.Size = new System.Drawing.Size(141, 456);
            this.AlbumListView.TabIndex = 4;
            this.AlbumListView.UseCompatibleStateImageBehavior = false;
            this.AlbumListView.View = System.Windows.Forms.View.Tile;
            // 
            // MusicTextBox
            // 
            this.MusicTextBox.Location = new System.Drawing.Point(198, 107);
            this.MusicTextBox.Name = "MusicTextBox";
            this.MusicTextBox.Size = new System.Drawing.Size(624, 20);
            this.MusicTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Location = new System.Drawing.Point(208, 182);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(521, 63);
            this.PostTextArea.TabIndex = 6;
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(747, 222);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(75, 23);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = true;
            // 
            // Posts
            // 
            this.Posts.FormattingEnabled = true;
            this.Posts.Location = new System.Drawing.Point(208, 294);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(521, 212);
            this.Posts.TabIndex = 8;
            // 
            // EventsList
            // 
            this.EventsList.FormattingEnabled = true;
            this.EventsList.Location = new System.Drawing.Point(198, 12);
            this.EventsList.Name = "EventsList";
            this.EventsList.Size = new System.Drawing.Size(624, 69);
            this.EventsList.TabIndex = 9;
            // 
            // BasicFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 665);
            this.Controls.Add(this.EventsList);
            this.Controls.Add(this.Posts);
            this.Controls.Add(this.PostBtn);
            this.Controls.Add(this.PostTextArea);
            this.Controls.Add(this.MusicTextBox);
            this.Controls.Add(this.AlbumListView);
            this.Controls.Add(this.GroupsListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BasicFacebook";
            this.Text = "BasicFacebook";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.ListView AlbumListView;
        private System.Windows.Forms.TextBox MusicTextBox;
        private System.Windows.Forms.TextBox PostTextArea;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.ListBox Posts;
        private System.Windows.Forms.ListBox EventsList;
    }
}