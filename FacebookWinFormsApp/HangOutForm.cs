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
using FacebookLogic.Interfaces;


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

        public HangOutForm(InitProfile i_LoggedInUser)
        {
            m_HangOutFacade = HangOutFacade.GetHangOutFacade(i_LoggedInUser);
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            InitiatorTextBox.Text = i_LoggedInUser.Name;
            m_HangOutFacade.CurrOffer.When = DateTime.Now.Date;
      
        }

        private void submitBtn_Click(object sender, EventArgs e)
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

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.InitiatorPhone = (sender as TextBox).Text;
        }

        private void whereTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.WhereTo = (sender as TextBox).Text;

        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.FromWhere = (sender as TextBox).Text;
        }

        private void seatsNumeric_ValueChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.MaxCarPassengers = (int)(sender as NumericUpDown).Value;
        }

        private void whenTimePicker_ValueChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.When = WhenTimePicker.Value;
        }

        private void initiatorTextBox_TextChanged(object sender, EventArgs e)
        {
            m_HangOutFacade.CurrOffer.InitiatorName = (sender as TextBox).Text;
        }
    }
}
