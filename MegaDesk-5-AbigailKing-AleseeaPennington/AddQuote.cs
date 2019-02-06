using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk_3_AbigailKing
{
    public partial class AddQuote : Form
    {

        public AddQuote()
        {
            InitializeComponent();

            //put info into Surface Materials ComboBox
            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                    .Cast<Desk.Surface>()
                    .ToList();

            comboSurface.DataSource = materials;

            comboSurface.SelectedIndex = -1;

            //put info into Delivery ComboBox
            var delivery = new List<DeskQuote.Delivery>();

            delivery = Enum.GetValues(typeof(DeskQuote.Delivery))
                    .Cast<DeskQuote.Delivery>()
                    .ToList();

            comboDelivery.DataSource = delivery;

            comboDelivery.SelectedIndex = -1;
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

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            //collect desk dimensions
            var desk = new Desk
            {
                Width = numWidth.Value,
                Depth = numDepth.Value,
                Drawers = (int)numDrawers.Value,
                SurfaceMaterial = (Desk.Surface)comboSurface.SelectedItem
            };

            var newQuote = new DeskQuote
            {
                Desk = desk,
                CustomerName = txtCustomerName.Text,
                QuoteDate = DateTime.Now,
                DeliveryType = (DeskQuote.Delivery)comboDelivery.SelectedValue
            };

            //get quote amount
            try
            {
                var quote = newQuote.GetQuotePrice();

                newQuote.QuoteAmount = quote;
                AddQuoteToFile(newQuote);

                DisplayQuote frmDisplayQuote = new DisplayQuote(newQuote);
                frmDisplayQuote.Show();
                Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.Message);
            }
        

        }

        private void AddQuoteToFile(DeskQuote deskQuote)
        {
            string quotesFile = @"quotes.Json";

            using (StreamWriter streamWriter = File.AppendText(quotesFile))
            {
                streamWriter.WriteLine(
                    $"{deskQuote.QuoteDate}," +
                    $"{deskQuote.CustomerName}," +
                    $"{deskQuote.Desk.Width}," +
                    $"{deskQuote.Desk.Depth}," +
                    $"{deskQuote.Desk.Drawers}," +
                    $"{deskQuote.Desk.SurfaceMaterial}," +
                    $"{deskQuote.DeliveryType}," +
                    $"{deskQuote.QuoteAmount}");
            }
        }
    }
}
