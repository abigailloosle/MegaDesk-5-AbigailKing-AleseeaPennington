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
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            _deskQuote = deskQuote;

            //set form properties
            txtCustomerName.Text = _deskQuote.CustomerName.ToString();
            txtWidthDis.Text = _deskQuote.Desk.Width.ToString();
            txtDepthDis.Text = _deskQuote.Desk.Depth.ToString();
            txtDrawerDis.Text = _deskQuote.Desk.Drawers.ToString();
            txtSurfaceDis.Text = _deskQuote.Desk.SurfaceMaterial.ToString();
            txtDeliveryDis.Text = _deskQuote.DeliveryType.ToString();
            txtPrice.Text = '$' + _deskQuote.QuoteAmount.ToString();
        }

        private void btnDisplayQuoteClose_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
