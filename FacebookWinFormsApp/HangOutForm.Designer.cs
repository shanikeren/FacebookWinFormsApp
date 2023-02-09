
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
            this.HeadLineLabel = new System.Windows.Forms.Label();
            this.InitLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WhereToLabel = new System.Windows.Forms.Label();
            this.WhenLabel = new System.Windows.Forms.Label();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.InitiatorTextBox = new System.Windows.Forms.TextBox();
            this.WhereTextBox = new System.Windows.Forms.TextBox();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.WhenTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SeatsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SeatsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadLineLabel
            // 
            this.HeadLineLabel.AutoSize = true;
            this.HeadLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HeadLineLabel.Location = new System.Drawing.Point(36, 26);
            this.HeadLineLabel.Name = "HeadLineLabel";
            this.HeadLineLabel.Size = new System.Drawing.Size(105, 36);
            this.HeadLineLabel.TabIndex = 0;
            this.HeadLineLabel.Text = "Details";
            // 
            // InitLabel
            // 
            this.InitLabel.AutoSize = true;
            this.InitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.InitLabel.Location = new System.Drawing.Point(90, 94);
            this.InitLabel.Name = "InitLabel";
            this.InitLabel.Size = new System.Drawing.Size(80, 25);
            this.InitLabel.TabIndex = 1;
            this.InitLabel.Text = "Initiator:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PhoneLabel.Location = new System.Drawing.Point(91, 152);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(75, 25);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(92, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Where From:";
            // 
            // WhereToLabel
            // 
            this.WhereToLabel.AutoSize = true;
            this.WhereToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhereToLabel.Location = new System.Drawing.Point(93, 275);
            this.WhereToLabel.Name = "WhereToLabel";
            this.WhereToLabel.Size = new System.Drawing.Size(106, 25);
            this.WhereToLabel.TabIndex = 4;
            this.WhereToLabel.Text = "To Where:";
            // 
            // WhenLabel
            // 
            this.WhenLabel.AutoSize = true;
            this.WhenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhenLabel.Location = new System.Drawing.Point(94, 340);
            this.WhenLabel.Name = "WhenLabel";
            this.WhenLabel.Size = new System.Drawing.Size(65, 25);
            this.WhenLabel.TabIndex = 5;
            this.WhenLabel.Text = "when:";
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SeatLabel.Location = new System.Drawing.Point(95, 406);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(69, 25);
            this.SeatLabel.TabIndex = 6;
            this.SeatLabel.Text = "Seats:";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(463, 493);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(120, 38);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // InitiatorTextBox
            // 
            this.InitiatorTextBox.Location = new System.Drawing.Point(274, 95);
            this.InitiatorTextBox.Name = "InitiatorTextBox";
            this.InitiatorTextBox.Size = new System.Drawing.Size(253, 26);
            this.InitiatorTextBox.TabIndex = 1;
            this.InitiatorTextBox.TextChanged += new System.EventHandler(this.initiatorTextBox_TextChanged);
            // 
            // WhereTextBox
            // 
            this.WhereTextBox.Location = new System.Drawing.Point(274, 275);
            this.WhereTextBox.Name = "WhereTextBox";
            this.WhereTextBox.Size = new System.Drawing.Size(253, 26);
            this.WhereTextBox.TabIndex = 4;
            this.WhereTextBox.TextChanged += new System.EventHandler(this.whereTextBox_TextChanged);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(274, 214);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(253, 26);
            this.FromTextBox.TabIndex = 3;
            this.FromTextBox.TextChanged += new System.EventHandler(this.fromTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(274, 152);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(253, 26);
            this.PhoneTextBox.TabIndex = 2;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // WhenTimePicker
            // 
            this.WhenTimePicker.Location = new System.Drawing.Point(274, 340);
            this.WhenTimePicker.Name = "WhenTimePicker";
            this.WhenTimePicker.Size = new System.Drawing.Size(253, 26);
            this.WhenTimePicker.TabIndex = 5;
            // 
            // SeatsNumeric
            // 
            this.SeatsNumeric.Location = new System.Drawing.Point(274, 408);
            this.SeatsNumeric.Name = "SeatsNumeric";
            this.SeatsNumeric.Size = new System.Drawing.Size(120, 26);
            this.SeatsNumeric.TabIndex = 6;
            this.SeatsNumeric.ValueChanged += new System.EventHandler(this.seatsNumeric_ValueChanged);
            // 
            // HangOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(616, 560);
            this.Controls.Add(this.SeatsNumeric);
            this.Controls.Add(this.WhenTimePicker);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.WhereTextBox);
            this.Controls.Add(this.InitiatorTextBox);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.WhenLabel);
            this.Controls.Add(this.WhereToLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.InitLabel);
            this.Controls.Add(this.HeadLineLabel);
            this.Name = "HangOutForm";
            this.Text = "Hang Out Info";
            ((System.ComponentModel.ISupportInitialize)(this.SeatsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadLineLabel;
        private System.Windows.Forms.Label InitLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WhereToLabel;
        private System.Windows.Forms.Label WhenLabel;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.TextBox InitiatorTextBox;
        private System.Windows.Forms.TextBox WhereTextBox;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.DateTimePicker WhenTimePicker;
        private System.Windows.Forms.NumericUpDown SeatsNumeric;
    }
}