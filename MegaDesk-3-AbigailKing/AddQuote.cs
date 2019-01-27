using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_AbigailKing
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        //private void txtWidth_Validating(object sender, CancelEventArgs e)
        //{
        //    if (txtDepth.Text == string.Empty)
        //    {
        //        MessageBox.Show("Please enter a depth");
        //    }
        //}

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Please enter a only number.");
                e.KeyChar = (char)0;
                //txtDepth.BackColor = Color.Red;
            }
        }

        private void txtDepth_Leave(object sender, EventArgs e)
        {
            int numValue;

            Int32.TryParse(txtWidth.Text, out numValue);

            if (numValue < 24)
            {
                MessageBox.Show("Please enter a number larger than 24 inches.");
            }
            else if (numValue > 96)
            {
                MessageBox.Show("Please enter a number smaller than 96 inches.");
            }
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {
            if (txtDepth.Text == string.Empty)
            {
                MessageBox.Show("Please enter a depth");
            }
        }

        //private void txtDepth_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar < '0' || e.KeyChar > '9')
        //    {
        //        MessageBox.Show("Please enter a only number.");
        //        e.KeyChar = (char)0;
        //        //txtDepth.BackColor = Color.Red;
        //    }
        //}

        private void txtWidth_Leave(object sender, EventArgs e)
        {
            int numValue;

            Int32.TryParse(txtWidth.Text, out numValue);

            if (numValue < 12)
            {
                MessageBox.Show("Please enter a number larger than 12 inches.");
            }
            else if (numValue > 48)
            {
                MessageBox.Show("Please enter a number smaller than 48 inches.");
            }
        }
    }
}
