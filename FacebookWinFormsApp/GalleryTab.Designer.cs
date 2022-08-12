
namespace BasicFacebookFeatures
{
    partial class GalleryTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topRatedPicturePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CurrentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(66, 832);
            this.PrevBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(112, 35);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(1052, 832);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(112, 35);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.IndianRed;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.closeBtn.Location = new System.Drawing.Point(1152, 40);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 35);
            this.closeBtn.TabIndex = 3;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1478, 1538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // topRatedPicturePanel
            // 
            this.topRatedPicturePanel.Location = new System.Drawing.Point(207, 894);
            this.topRatedPicturePanel.Name = "topRatedPicturePanel";
            this.topRatedPicturePanel.Size = new System.Drawing.Size(810, 150);
            this.topRatedPicturePanel.TabIndex = 14;
            // 
            // CurrentImage
            // 
            this.CurrentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CurrentImage.Location = new System.Drawing.Point(207, 137);
            this.CurrentImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentImage.Name = "CurrentImage";
            this.CurrentImage.Size = new System.Drawing.Size(810, 730);
            this.CurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CurrentImage.TabIndex = 0;
            this.CurrentImage.TabStop = false;
            // 
            // GalleryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.topRatedPicturePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.CurrentImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GalleryTab";
            this.Size = new System.Drawing.Size(1255, 1093);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentImage;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel topRatedPicturePanel;
    }
}
