using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class BasicFacebookForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.LogOut_Btn = new System.Windows.Forms.Button();
            this.PagesListBox = new System.Windows.Forms.ListBox();
            this.EventTextBox = new System.Windows.Forms.TextBox();
            this.PostTextArea = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.Posts = new System.Windows.Forms.ListBox();
            this.basic = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.compareStrategyPanel = new System.Windows.Forms.Panel();
            this.sortLabel = new System.Windows.Forms.Label();
            this.createTimeRadioBtn = new System.Windows.Forms.RadioButton();
            this.likesRadionBtn = new System.Windows.Forms.RadioButton();
            this.updateTimeRadionBtn = new System.Windows.Forms.RadioButton();
            this.UserDetailsPanel = new System.Windows.Forms.Panel();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.AlbumsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UntilLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.timeFilterButton = new System.Windows.Forms.Button();
            this.untilDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeFilterLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WhenInfo = new System.Windows.Forms.Label();
            this.WhereFromInfo = new System.Windows.Forms.Label();
            this.WhereToInfo = new System.Windows.Forms.Label();
            this.PhoneInfo = new System.Windows.Forms.Label();
            this.InitInfo = new System.Windows.Forms.Label();
            this.JoinBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateOfferBtn = new System.Windows.Forms.Button();
            this.AllRadioBtn = new System.Windows.Forms.RadioButton();
            this.MineRadioBtn = new System.Windows.Forms.RadioButton();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.OffersLabels = new System.Windows.Forms.Label();
            this.OffersListBox = new System.Windows.Forms.ListBox();
            this.visitsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.buttonPlaces = new System.Windows.Forms.Button();
            this.checkinLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.compareStrategyPanel.SuspendLayout();
            this.UserDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(282, 73);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(42, 20);
            linkLabel.TabIndex = 10;
            linkLabel.Text = "Link:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(282, 12);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(71, 20);
            this.birthdayLabel.TabIndex = 2;
            this.birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(496, 12);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 18);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name:";
            // 
            // profilePicture
            // 
            this.profilePicture.AccessibleName = "ProfilePicture";
            this.profilePicture.Location = new System.Drawing.Point(19, 25);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(6);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(224, 185);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // LogOut_Btn
            // 
            this.LogOut_Btn.AccessibleName = "LogOut_Btn";
            this.LogOut_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LogOut_Btn.Location = new System.Drawing.Point(19, 221);
            this.LogOut_Btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LogOut_Btn.Name = "LogOut_Btn";
            this.LogOut_Btn.Size = new System.Drawing.Size(143, 39);
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
            this.PagesListBox.ItemHeight = 20;
            this.PagesListBox.Location = new System.Drawing.Point(287, 837);
            this.PagesListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(909, 104);
            this.PagesListBox.TabIndex = 3;
            this.PagesListBox.Tag = "";
            // 
            // EventTextBox
            // 
            this.EventTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventTextBox.Location = new System.Drawing.Point(285, 184);
            this.EventTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EventTextBox.Name = "EventTextBox";
            this.EventTextBox.Size = new System.Drawing.Size(917, 26);
            this.EventTextBox.TabIndex = 5;
            // 
            // PostTextArea
            // 
            this.PostTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostTextArea.Location = new System.Drawing.Point(287, 332);
            this.PostTextArea.Margin = new System.Windows.Forms.Padding(6, 6, 15, 6);
            this.PostTextArea.Multiline = true;
            this.PostTextArea.Name = "PostTextArea";
            this.PostTextArea.Size = new System.Drawing.Size(909, 95);
            this.PostTextArea.TabIndex = 6;
            // 
            // PostBtn
            // 
            this.PostBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostBtn.Location = new System.Drawing.Point(1223, 396);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(15, 5, 6, 5);
            this.PostBtn.MaximumSize = new System.Drawing.Size(214, 35);
            this.PostBtn.MinimumSize = new System.Drawing.Size(53, 35);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Padding = new System.Windows.Forms.Padding(3);
            this.PostBtn.Size = new System.Drawing.Size(101, 35);
            this.PostBtn.TabIndex = 7;
            this.PostBtn.Text = "POST";
            this.PostBtn.UseVisualStyleBackColor = false;
            this.PostBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // Posts
            // 
            this.Posts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Posts.FormattingEnabled = true;
            this.Posts.ItemHeight = 20;
            this.Posts.Location = new System.Drawing.Point(287, 471);
            this.Posts.Margin = new System.Windows.Forms.Padding(6);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(909, 264);
            this.Posts.TabIndex = 8;
            // 
            // basic
            // 
            this.basic.Controls.Add(this.tabPage1);
            this.basic.Controls.Add(this.tabPage2);
            this.basic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basic.Location = new System.Drawing.Point(5, 5);
            this.basic.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.basic.Name = "basic";
            this.basic.SelectedIndex = 0;
            this.basic.Size = new System.Drawing.Size(1479, 1002);
            this.basic.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.basic.TabIndex = 10;
            this.basic.SelectedIndexChanged += new System.EventHandler(this.basic_TabIndexChanged);
            this.basic.TabIndexChanged += new System.EventHandler(this.basic_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.compareStrategyPanel);
            this.tabPage1.Controls.Add(this.UserDetailsPanel);
            this.tabPage1.Controls.Add(this.RememberMeCheckBox);
            this.tabPage1.Controls.Add(this.AlbumsPanel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.profilePicture);
            this.tabPage1.Controls.Add(this.PagesListBox);
            this.tabPage1.Controls.Add(this.Posts);
            this.tabPage1.Controls.Add(this.PostBtn);
            this.tabPage1.Controls.Add(this.LogOut_Btn);
            this.tabPage1.Controls.Add(this.PostTextArea);
            this.tabPage1.Controls.Add(this.EventTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(15, 1, 3, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Size = new System.Drawing.Size(1471, 969);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            // 
            // compareStrategyPanel
            // 
            this.compareStrategyPanel.Controls.Add(this.sortLabel);
            this.compareStrategyPanel.Controls.Add(this.createTimeRadioBtn);
            this.compareStrategyPanel.Controls.Add(this.likesRadionBtn);
            this.compareStrategyPanel.Controls.Add(this.updateTimeRadionBtn);
            this.compareStrategyPanel.Location = new System.Drawing.Point(1205, 585);
            this.compareStrategyPanel.Name = "compareStrategyPanel";
            this.compareStrategyPanel.Size = new System.Drawing.Size(200, 150);
            this.compareStrategyPanel.TabIndex = 19;
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.BackColor = System.Drawing.Color.Transparent;
            this.sortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sortLabel.Location = new System.Drawing.Point(14, 9);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(82, 25);
            this.sortLabel.TabIndex = 20;
            this.sortLabel.Text = "Sort By:";
            // 
            // createTimeRadioBtn
            // 
            this.createTimeRadioBtn.AutoSize = true;
            this.createTimeRadioBtn.Location = new System.Drawing.Point(18, 46);
            this.createTimeRadioBtn.Name = "createTimeRadioBtn";
            this.createTimeRadioBtn.Size = new System.Drawing.Size(120, 24);
            this.createTimeRadioBtn.TabIndex = 16;
            this.createTimeRadioBtn.TabStop = true;
            this.createTimeRadioBtn.Text = "Create Time";
            this.createTimeRadioBtn.UseVisualStyleBackColor = true;
            this.createTimeRadioBtn.Click += new System.EventHandler(this.fetchPosts);
            // 
            // likesRadionBtn
            // 
            this.likesRadionBtn.AutoSize = true;
            this.likesRadionBtn.Location = new System.Drawing.Point(18, 106);
            this.likesRadionBtn.Name = "likesRadionBtn";
            this.likesRadionBtn.Size = new System.Drawing.Size(111, 24);
            this.likesRadionBtn.TabIndex = 18;
            this.likesRadionBtn.TabStop = true;
            this.likesRadionBtn.Text = "Comments";
            this.likesRadionBtn.UseVisualStyleBackColor = true;
            this.likesRadionBtn.Click += new System.EventHandler(this.fetchPosts);
            // 
            // updateTimeRadionBtn
            // 
            this.updateTimeRadionBtn.AutoSize = true;
            this.updateTimeRadionBtn.Location = new System.Drawing.Point(18, 76);
            this.updateTimeRadionBtn.Name = "updateTimeRadionBtn";
            this.updateTimeRadionBtn.Size = new System.Drawing.Size(125, 24);
            this.updateTimeRadionBtn.TabIndex = 17;
            this.updateTimeRadionBtn.TabStop = true;
            this.updateTimeRadionBtn.Text = "Update Time";
            this.updateTimeRadionBtn.UseVisualStyleBackColor = true;
            this.updateTimeRadionBtn.Click += new System.EventHandler(this.fetchPosts);
            // 
            // UserDetailsPanel
            // 
            this.UserDetailsPanel.Controls.Add(linkLabel);
            this.UserDetailsPanel.Controls.Add(this.linkLinkLabel);
            this.UserDetailsPanel.Controls.Add(this.firstNameLabel);
            this.UserDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.UserDetailsPanel.Controls.Add(this.lastNameLabel);
            this.UserDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.UserDetailsPanel.Controls.Add(this.emailLabel);
            this.UserDetailsPanel.Controls.Add(this.emailTextBox);
            this.UserDetailsPanel.Controls.Add(this.birthdayLabel);
            this.UserDetailsPanel.Controls.Add(this.birthdayTextBox);
            this.UserDetailsPanel.Location = new System.Drawing.Point(287, 25);
            this.UserDetailsPanel.Name = "UserDetailsPanel";
            this.UserDetailsPanel.Size = new System.Drawing.Size(1062, 127);
            this.UserDetailsPanel.TabIndex = 15;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.AutoSize = true;
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(355, 73);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(80, 20);
            this.linkLinkLabel.TabIndex = 11;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(108, 15);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(144, 26);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 67);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(144, 26);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(554, 12);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(488, 26);
            this.emailTextBox.TabIndex = 5;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayTextBox.Location = new System.Drawing.Point(359, 12);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(100, 26);
            this.birthdayTextBox.TabIndex = 3;
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(19, 278);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(140, 24);
            this.RememberMeCheckBox.TabIndex = 14;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AlbumsPanel
            // 
            this.AlbumsPanel.AutoScroll = true;
            this.AlbumsPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.AlbumsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AlbumsPanel.Location = new System.Drawing.Point(19, 332);
            this.AlbumsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlbumsPanel.Name = "AlbumsPanel";
            this.AlbumsPanel.Size = new System.Drawing.Size(224, 609);
            this.AlbumsPanel.TabIndex = 13;
            this.AlbumsPanel.WrapContents = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, -241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upcoming Event:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.CreateOfferBtn);
            this.tabPage2.Controls.Add(this.AllRadioBtn);
            this.tabPage2.Controls.Add(this.MineRadioBtn);
            this.tabPage2.Controls.Add(this.ShowBtn);
            this.tabPage2.Controls.Add(this.OffersLabels);
            this.tabPage2.Controls.Add(this.OffersListBox);
            this.tabPage2.Controls.Add(this.visitsChart);
            this.tabPage2.Controls.Add(this.listBoxCheckins);
            this.tabPage2.Controls.Add(this.buttonPlaces);
            this.tabPage2.Controls.Add(this.checkinLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Size = new System.Drawing.Size(1471, 969);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "where to visit?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UntilLabel);
            this.panel2.Controls.Add(this.FromLabel);
            this.panel2.Controls.Add(this.timeFilterButton);
            this.panel2.Controls.Add(this.untilDateTimePicker);
            this.panel2.Controls.Add(this.TimeFilterLabel);
            this.panel2.Controls.Add(this.fromDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(957, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 217);
            this.panel2.TabIndex = 16;
            // 
            // UntilLabel
            // 
            this.UntilLabel.AutoSize = true;
            this.UntilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UntilLabel.Location = new System.Drawing.Point(50, 111);
            this.UntilLabel.Name = "UntilLabel";
            this.UntilLabel.Size = new System.Drawing.Size(51, 22);
            this.UntilLabel.TabIndex = 19;
            this.UntilLabel.Text = "Until:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FromLabel.Location = new System.Drawing.Point(50, 43);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(56, 22);
            this.FromLabel.TabIndex = 18;
            this.FromLabel.Text = "From:";
            // 
            // timeFilterButton
            // 
            this.timeFilterButton.Location = new System.Drawing.Point(323, 167);
            this.timeFilterButton.Name = "timeFilterButton";
            this.timeFilterButton.Size = new System.Drawing.Size(111, 37);
            this.timeFilterButton.TabIndex = 17;
            this.timeFilterButton.Text = "Filter";
            this.timeFilterButton.UseVisualStyleBackColor = true;
            this.timeFilterButton.Click += new System.EventHandler(this.timeFilterButton_Click);
            // 
            // untilDateTimePicker
            // 
            this.untilDateTimePicker.Location = new System.Drawing.Point(234, 108);
            this.untilDateTimePicker.Name = "untilDateTimePicker";
            this.untilDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.untilDateTimePicker.TabIndex = 16;
            // 
            // TimeFilterLabel
            // 
            this.TimeFilterLabel.AutoSize = true;
            this.TimeFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TimeFilterLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeFilterLabel.Name = "TimeFilterLabel";
            this.TimeFilterLabel.Size = new System.Drawing.Size(103, 25);
            this.TimeFilterLabel.TabIndex = 14;
            this.TimeFilterLabel.Text = "Time Filter";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromDateTimePicker.Location = new System.Drawing.Point(234, 43);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fromDateTimePicker.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.WhenInfo);
            this.panel1.Controls.Add(this.WhereFromInfo);
            this.panel1.Controls.Add(this.WhereToInfo);
            this.panel1.Controls.Add(this.PhoneInfo);
            this.panel1.Controls.Add(this.InitInfo);
            this.panel1.Controls.Add(this.JoinBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(957, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 364);
            this.panel1.TabIndex = 13;
            // 
            // WhenInfo
            // 
            this.WhenInfo.AutoSize = true;
            this.WhenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhenInfo.Location = new System.Drawing.Point(241, 268);
            this.WhenInfo.Name = "WhenInfo";
            this.WhenInfo.Size = new System.Drawing.Size(0, 25);
            this.WhenInfo.TabIndex = 10;
            // 
            // WhereFromInfo
            // 
            this.WhereFromInfo.AutoSize = true;
            this.WhereFromInfo.Location = new System.Drawing.Point(292, 210);
            this.WhereFromInfo.Name = "WhereFromInfo";
            this.WhereFromInfo.Size = new System.Drawing.Size(0, 20);
            this.WhereFromInfo.TabIndex = 9;
            // 
            // WhereToInfo
            // 
            this.WhereToInfo.AutoSize = true;
            this.WhereToInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhereToInfo.Location = new System.Drawing.Point(292, 153);
            this.WhereToInfo.Name = "WhereToInfo";
            this.WhereToInfo.Size = new System.Drawing.Size(0, 25);
            this.WhereToInfo.TabIndex = 8;
            // 
            // PhoneInfo
            // 
            this.PhoneInfo.AutoSize = true;
            this.PhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneInfo.Location = new System.Drawing.Point(292, 88);
            this.PhoneInfo.Name = "PhoneInfo";
            this.PhoneInfo.Size = new System.Drawing.Size(0, 25);
            this.PhoneInfo.TabIndex = 7;
            // 
            // InitInfo
            // 
            this.InitInfo.AutoSize = true;
            this.InitInfo.Location = new System.Drawing.Point(292, 30);
            this.InitInfo.Name = "InitInfo";
            this.InitInfo.Size = new System.Drawing.Size(0, 20);
            this.InitInfo.TabIndex = 6;
            // 
            // JoinBtn
            // 
            this.JoinBtn.Location = new System.Drawing.Point(323, 306);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(111, 41);
            this.JoinBtn.TabIndex = 5;
            this.JoinBtn.Text = "Join :)";
            this.JoinBtn.UseVisualStyleBackColor = true;
            this.JoinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(49, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "When:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(49, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(49, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Where From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(49, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Where To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Initiator:";
            // 
            // CreateOfferBtn
            // 
            this.CreateOfferBtn.Location = new System.Drawing.Point(736, 745);
            this.CreateOfferBtn.Name = "CreateOfferBtn";
            this.CreateOfferBtn.Size = new System.Drawing.Size(121, 35);
            this.CreateOfferBtn.TabIndex = 12;
            this.CreateOfferBtn.Text = "Create";
            this.CreateOfferBtn.UseVisualStyleBackColor = true;
            this.CreateOfferBtn.Click += new System.EventHandler(this.createOfferBtn_Click);
            // 
            // AllRadioBtn
            // 
            this.AllRadioBtn.AutoSize = true;
            this.AllRadioBtn.Checked = true;
            this.AllRadioBtn.Location = new System.Drawing.Point(736, 556);
            this.AllRadioBtn.Name = "AllRadioBtn";
            this.AllRadioBtn.Size = new System.Drawing.Size(95, 24);
            this.AllRadioBtn.TabIndex = 11;
            this.AllRadioBtn.TabStop = true;
            this.AllRadioBtn.Text = "Show All";
            this.AllRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MineRadioBtn
            // 
            this.MineRadioBtn.AutoSize = true;
            this.MineRadioBtn.Checked = true;
            this.MineRadioBtn.Location = new System.Drawing.Point(736, 628);
            this.MineRadioBtn.Name = "MineRadioBtn";
            this.MineRadioBtn.Size = new System.Drawing.Size(112, 24);
            this.MineRadioBtn.TabIndex = 10;
            this.MineRadioBtn.TabStop = true;
            this.MineRadioBtn.Text = "Show Mine";
            this.MineRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(736, 685);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(121, 36);
            this.ShowBtn.TabIndex = 6;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // OffersLabels
            // 
            this.OffersLabels.AutoSize = true;
            this.OffersLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OffersLabels.Location = new System.Drawing.Point(424, 153);
            this.OffersLabels.Name = "OffersLabels";
            this.OffersLabels.Size = new System.Drawing.Size(150, 25);
            this.OffersLabels.TabIndex = 5;
            this.OffersLabels.Text = "HangOut offers:";
            // 
            // OffersListBox
            // 
            this.OffersListBox.FormattingEnabled = true;
            this.OffersListBox.ItemHeight = 20;
            this.OffersListBox.Location = new System.Drawing.Point(405, 202);
            this.OffersListBox.Name = "OffersListBox";
            this.OffersListBox.Size = new System.Drawing.Size(302, 584);
            this.OffersListBox.TabIndex = 4;
            this.OffersListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OffersListBox_MouseClick);
            // 
            // visitsChart
            // 
            this.visitsChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitsChart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.visitsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.visitsChart.Legends.Add(legend1);
            this.visitsChart.Location = new System.Drawing.Point(30, 812);
            this.visitsChart.MinimumSize = new System.Drawing.Size(400, 120);
            this.visitsChart.Name = "visitsChart";
            this.visitsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Visits";
            this.visitsChart.Series.Add(series1);
            this.visitsChart.Size = new System.Drawing.Size(400, 206);
            this.visitsChart.TabIndex = 3;
            this.visitsChart.Text = "chart1";
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 20;
            this.listBoxCheckins.Location = new System.Drawing.Point(30, 200);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(306, 584);
            this.listBoxCheckins.TabIndex = 2;
            this.listBoxCheckins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCheckins_MouseClick);
            // 
            // buttonPlaces
            // 
            this.buttonPlaces.Location = new System.Drawing.Point(30, 113);
            this.buttonPlaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlaces.Name = "buttonPlaces";
            this.buttonPlaces.Size = new System.Drawing.Size(253, 49);
            this.buttonPlaces.TabIndex = 1;
            this.buttonPlaces.Text = "Check Out where your friends likes to visit";
            this.buttonPlaces.UseVisualStyleBackColor = true;
            this.buttonPlaces.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkinLabel.Location = new System.Drawing.Point(44, 51);
            this.checkinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(179, 29);
            this.checkinLabel.TabIndex = 0;
            this.checkinLabel.Text = "HangOut Board";
            // 
            // BasicFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1489, 1012);
            this.Controls.Add(this.basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasicFacebookForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "BasicFacebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BasicFacebookForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.basic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.compareStrategyPanel.ResumeLayout(false);
            this.compareStrategyPanel.PerformLayout();
            this.UserDetailsPanel.ResumeLayout(false);
            this.UserDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsChart)).EndInit();
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
        private Button buttonPlaces;
        private Label checkinLabel;
        private ListBox listBoxCheckins;
        private FlowLayoutPanel AlbumsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart visitsChart;
        private CheckBox RememberMeCheckBox;
        private Button ShowBtn;
        private Label OffersLabels;
        public ListBox OffersListBox;
        private RadioButton AllRadioBtn;
        private RadioButton MineRadioBtn;
        private Panel UserDetailsPanel;
        private TextBox emailTextBox;
        private BindingSource userBindingSource;
        private TextBox birthdayTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private Label birthdayLabel;
        private Label emailLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private LinkLabel linkLinkLabel;
        private Button CreateOfferBtn;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button JoinBtn;
        private Label label7;
        private Label WhereFromInfo;
        private Label WhereToInfo;
        private Label PhoneInfo;
        private Label InitInfo;
        private Label WhenInfo;
        private RadioButton createTimeRadioBtn;
        private RadioButton likesRadionBtn;
        private RadioButton updateTimeRadionBtn;
        private Panel compareStrategyPanel;
        private Label sortLabel;
        private Label TimeFilterLabel;
        private DateTimePicker fromDateTimePicker;
        private Panel panel2;
        private Label UntilLabel;
        private Label FromLabel;
        private Button timeFilterButton;
        private DateTimePicker untilDateTimePicker;
    }
}