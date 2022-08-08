
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
            this.CurrentImage = new System.Windows.Forms.PictureBox();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentImage
            // 
            this.CurrentImage.Location = new System.Drawing.Point(141, 61);
            this.CurrentImage.Name = "CurrentImage";
            this.CurrentImage.Size = new System.Drawing.Size(539, 435);
            this.CurrentImage.TabIndex = 0;
            this.CurrentImage.TabStop = false;
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(39, 564);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(75, 23);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(700, 564);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // GalleryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.CurrentImage);
            this.Name = "GalleryTab";
            this.Size = new System.Drawing.Size(822, 699);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentImage;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}
