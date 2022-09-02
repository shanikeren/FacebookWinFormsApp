using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookLogic;

namespace BasicFacebookFeatures
{
    public partial class HangOutForm : Form
    {
        private InitProfile m_LoggedInUser;
        private HangOutFacade m_HangOutFacade;

        public HangOutForm()
        {
            InitializeComponent();
        }

        public HangOutForm(bool i_IsCreator)
        {
            InitializeComponent();
            if(i_IsCreator == false)
            {
                disableEditing();
            }
        }

        private void disableEditing()
        {
            this.InitiatorTextBox.Enabled = false;
            this.WhereTextBox.Enabled = false;
            this.FromTextBox.Enabled = false;
            this.PhoneTextBox.Enabled = false;
            this.WhenTimePicker.Enabled = false;
        }

        public HangOutForm(InitProfile i_LoggedInUser)
        {
            m_HangOutFacade = new HangOutFacade(i_LoggedInUser);
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            InitiatorTextBox.Text = i_LoggedInUser.Name;
            m_HangOutFacade.CurrOffer.When = DateTime.Now.Date;
        }

        public void SetForDisplay(HangOutOffer i_HangOutOffer)
        {
            setForInitiator(false);

        }

        private void setForInitiator(bool i_IsInitiating)
        {
            InitiatorTextBox.Enabled = i_IsInitiating;
            WhereTextBox.Enabled = i_IsInitiating;
            PhoneTextBox.Enabled = i_IsInitiating;
            WhenTimePicker.Enabled = i_IsInitiating;

            SubmitBtn.Enabled = i_IsInitiating;
            SeatsNumeric.Enabled = i_IsInitiating;

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(isValidInfo() == true)
            {
            
                m_HangOutFacade.CreateHangOut();
                MessageBox.Show("Your offer was published:)");
                this.Close();

            }
            else
            {
                MessageBox.Show("One of more of the details is wrong. Please check it again.");
            }

        }

        private bool isValidInfo()
        {
            bool isValidate = true;

            isValidate = (PhoneTextBox.Text != string.Empty && WhereTextBox.Text != string.Empty && FromTextBox.Text != string.Empty) &&
                            (SeatsNumeric.Value > 0) && (WhenTimePicker.Value.Date >= DateTime.Now.Date);

            return isValidate;
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.InitiatorPhone = (sender as TextBox).Text;
        }

        private void WhereTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.WhereTo = (sender as TextBox).Text;

        }

        private void FromTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.FromWhere = (sender as TextBox).Text;
        }

        private void SeatsNumeric_ValueChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.MaxCarPassengers = (int)(sender as NumericUpDown).Value;
        }

        private void WhenTimePicker_ValueChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.When = WhenTimePicker.Value;
        }

        private void InitiatorTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.InitiatorName = (sender as TextBox).Text;
        }
    }
}
