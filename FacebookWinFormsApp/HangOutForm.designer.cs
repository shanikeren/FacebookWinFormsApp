
namespace BasicFacebookFeatures
{
    partial class HangOutForm
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
            this.HeadLindLable = new System.Windows.Forms.Label();
            this.InitiatorLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.WhereToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.WhenLabel = new System.Windows.Forms.Label();
            this.InitiatorTextBox = new System.Windows.Forms.TextBox();
            this.WhereTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.WhenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SeatsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadLindLable
            // 
            this.HeadLindLable.AutoSize = true;
            this.HeadLindLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeadLindLable.Location = new System.Drawing.Point(12, 30);
            this.HeadLindLable.Name = "HeadLindLable";
            this.HeadLindLable.Size = new System.Drawing.Size(127, 40);
            this.HeadLindLable.TabIndex = 0;
            this.HeadLindLable.Text = "Details";
            // 
            // InitiatorLabel
            // 
            this.InitiatorLabel.AutoSize = true;
            this.InitiatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InitiatorLabel.Location = new System.Drawing.Point(84, 96);
            this.InitiatorLabel.Name = "InitiatorLabel";
            this.InitiatorLabel.Size = new System.Drawing.Size(97, 29);
            this.InitiatorLabel.TabIndex = 1;
            this.InitiatorLabel.Text = "Initiator:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneLabel.Location = new System.Drawing.Point(84, 151);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(182, 29);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone Number:";
            // 
            // WhereToLabel
            // 
            this.WhereToLabel.AutoSize = true;
            this.WhereToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhereToLabel.Location = new System.Drawing.Point(84, 207);
            this.WhereToLabel.Name = "WhereToLabel";
            this.WhereToLabel.Size = new System.Drawing.Size(126, 29);
            this.WhereToLabel.TabIndex = 3;
            this.WhereToLabel.Text = "Where To:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FromLabel.Location = new System.Drawing.Point(84, 268);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(153, 29);
            this.FromLabel.TabIndex = 4;
            this.FromLabel.Text = "From Where:";
            // 
            // WhenLabel
            // 
            this.WhenLabel.AutoSize = true;
            this.WhenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhenLabel.Location = new System.Drawing.Point(90, 332);
            this.WhenLabel.Name = "WhenLabel";
            this.WhenLabel.Size = new System.Drawing.Size(81, 29);
            this.WhenLabel.TabIndex = 5;
            this.WhenLabel.Text = "When:";
            // 
            // InitiatorTextBox
            // 
            this.InitiatorTextBox.Enabled = false;
            this.InitiatorTextBox.Location = new System.Drawing.Point(333, 100);
            this.InitiatorTextBox.Name = "InitiatorTextBox";
            this.InitiatorTextBox.Size = new System.Drawing.Size(218, 26);
            this.InitiatorTextBox.TabIndex = 6;
            this.InitiatorTextBox.TextChanged += new System.EventHandler(this.InitiatorTextBox_TextChanged);
            // 
            // WhereTextBox
            // 
            this.WhereTextBox.Location = new System.Drawing.Point(327, 211);
            this.WhereTextBox.Name = "WhereTextBox";
            this.WhereTextBox.Size = new System.Drawing.Size(218, 26);
            this.WhereTextBox.TabIndex = 7;
            this.WhereTextBox.TextChanged += new System.EventHandler(this.WhereTextBox_TextChanged);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(327, 272);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(218, 26);
            this.FromTextBox.TabIndex = 8;
            this.FromTextBox.TextChanged += new System.EventHandler(this.FromTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(333, 151);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(218, 26);
            this.PhoneTextBox.TabIndex = 10;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // WhenTimePicker
            // 
            this.WhenTimePicker.Location = new System.Drawing.Point(333, 334);
            this.WhenTimePicker.Name = "WhenTimePicker";
            this.WhenTimePicker.Size = new System.Drawing.Size(200, 26);
            this.WhenTimePicker.TabIndex = 11;
            this.WhenTimePicker.ValueChanged += new System.EventHandler(this.WhenTimePicker_ValueChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SubmitBtn.Location = new System.Drawing.Point(89, 545);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(141, 37);
            this.SubmitBtn.TabIndex = 13;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(90, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seats:";
            // 
            // SeatsNumeric
            // 
            this.SeatsNumeric.Location = new System.Drawing.Point(338, 400);
            this.SeatsNumeric.Name = "SeatsNumeric";
            this.SeatsNumeric.Size = new System.Drawing.Size(120, 26);
            this.SeatsNumeric.TabIndex = 15;
            this.SeatsNumeric.ValueChanged += new System.EventHandler(this.SeatsNumeric_ValueChanged);
            // 
            // HangOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(639, 639);
            this.Controls.Add(this.SeatsNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.WhenTimePicker);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.WhereTextBox);
            this.Controls.Add(this.InitiatorTextBox);
            this.Controls.Add(this.WhenLabel);
            this.Controls.Add(this.FromLabel);
            this.Controls.Add(this.WhereToLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.InitiatorLabel);
            this.Controls.Add(this.HeadLindLable);
            this.Name = "HangOutForm";
            this.Text = "Hang Out Info";
            ((System.ComponentModel.ISupportInitialize)(this.SeatsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLindLable;
        private System.Windows.Forms.Label InitiatorLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label WhereToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label WhenLabel;
        private System.Windows.Forms.TextBox InitiatorTextBox;
        private System.Windows.Forms.TextBox WhereTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.DateTimePicker WhenTimePicker;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SeatsNumeric;
    }
}