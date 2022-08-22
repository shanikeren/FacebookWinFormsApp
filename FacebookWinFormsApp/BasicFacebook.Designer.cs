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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.visitsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.buttonPlaces = new System.Windows.Forms.Button();
            this.checkinLabel = new System.Windows.Forms.Label();
            this.RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.basic.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsChart)).BeginInit();
            this.SuspendLayout();
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
            this.PagesListBox.Location = new System.Drawing.Point(287, 835);
            this.PagesListBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PagesListBox.Name = "PagesListBox";
            this.PagesListBox.Size = new System.Drawing.Size(1045, 104);
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
            this.EventTextBox.Size = new System.Drawing.Size(1053, 26);
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
            this.PostTextArea.Size = new System.Drawing.Size(1045, 95);
            this.PostTextArea.TabIndex = 6;
            // 
            // PostBtn
            // 
            this.PostBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PostBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PostBtn.Location = new System.Drawing.Point(1359, 395);
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
            this.Posts.Location = new System.Drawing.Point(287, 469);
            this.Posts.Margin = new System.Windows.Forms.Padding(6);
            this.Posts.Name = "Posts";
            this.Posts.Size = new System.Drawing.Size(1042, 324);
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
            this.basic.Size = new System.Drawing.Size(1469, 1051);
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
            this.tabPage1.Size = new System.Drawing.Size(1461, 1018);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
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
            this.label2.Location = new System.Drawing.Point(15, -368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Albums:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Upcoming Event:\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.visitsChart);
            this.tabPage2.Controls.Add(this.listBoxCheckins);
            this.tabPage2.Controls.Add(this.buttonPlaces);
            this.tabPage2.Controls.Add(this.checkinLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage2.Size = new System.Drawing.Size(1426, 1018);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "where to visit?";
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
            this.visitsChart.Location = new System.Drawing.Point(560, 431);
            this.visitsChart.MinimumSize = new System.Drawing.Size(400, 120);
            this.visitsChart.Name = "visitsChart";
            this.visitsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Visits";
            this.visitsChart.Series.Add(series1);
            this.visitsChart.Size = new System.Drawing.Size(715, 353);
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
            this.listBoxCheckins.Size = new System.Drawing.Size(327, 584);
            this.listBoxCheckins.TabIndex = 2;
            // 
            // buttonPlaces
            // 
            this.buttonPlaces.Location = new System.Drawing.Point(30, 86);
            this.buttonPlaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPlaces.Name = "buttonPlaces";
            this.buttonPlaces.Size = new System.Drawing.Size(328, 75);
            this.buttonPlaces.TabIndex = 1;
            this.buttonPlaces.Text = "Check Out where your friends likes to visit";
            this.buttonPlaces.UseVisualStyleBackColor = true;
            this.buttonPlaces.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // checkinLabel
            // 
            this.checkinLabel.AutoSize = true;
            this.checkinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkinLabel.Location = new System.Drawing.Point(24, 34);
            this.checkinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkinLabel.Name = "checkinLabel";
            this.checkinLabel.Size = new System.Drawing.Size(195, 26);
            this.checkinLabel.TabIndex = 0;
            this.checkinLabel.Text = "Recommendations";
            // 
            // RememberMeCheckBox
            // 
            this.RememberMeCheckBox.AutoSize = true;
            this.RememberMeCheckBox.Location = new System.Drawing.Point(19, 277);
            this.RememberMeCheckBox.Name = "RememberMeCheckBox";
            this.RememberMeCheckBox.Size = new System.Drawing.Size(140, 24);
            this.RememberMeCheckBox.TabIndex = 14;
            this.RememberMeCheckBox.Text = "Remember Me";
            this.RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // BasicFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1479, 1061);
            this.Controls.Add(this.basic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BasicFacebookForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "BasicFacebook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.basicFacebook_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.basic.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}