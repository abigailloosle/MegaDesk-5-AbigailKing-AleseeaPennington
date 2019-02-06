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
using Newtonsoft.Json;

namespace MegaDesk_3_AbigailKing
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void btnCancelViewAll_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"quotes.json"))
                {
                    string allQuotes = reader.ReadToEnd();
                    //Console.WriteLine("All Quotes: " + allQuotes);

                    List<DeskQuote> deskQuotes = new List<DeskQuote>();
                    //Console.WriteLine("Desk Quotes: " + deskQuotes);

                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                    //Console.WriteLine("Desk Quotes: " + deskQuotes);
                    

                    dataGridView1.DataSource = deskQuotes.Select(d => new
                    {
                        QuoteDate = d.QuoteDate,
                        CustomerName = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.Drawers,
                        SurfaceMaterial = d.Desk.SurfaceMaterial,
                        DeliveryType = d.DeliveryType,
                        QuoteAmount = d.QuoteAmount
                    }).ToList();
                    //Console.WriteLine("Data Grid View 1: " + deskQuotes);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No desk quotes have been created yet.");
            }
            
        }
    }
}





/*List<DeskQuote> deskQuotes = new List<DeskQuote>();

using (StreamReader reader = new StreamReader(@"quotes.json"))
{
    Console.WriteLine("Reader: " + reader);

    string allQuotes = reader.ReadToEnd();
    Console.WriteLine("All Quotes: " + allQuotes);

    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);*/
/*Console.WriteLine(allQuotes.Desk);*/


/*Console.WriteLine("Desk Quotes: " + deskQuotes);

var convertedJson = JsonConvert.SerializeObject(deskQuotes);
Console.WriteLine(" Converted Json: " + convertedJson);*/

/*foreach (string "Desk" in convertedJson)
{
    string[] arrRow = convertedJson.Split(new char[] { ',' });
    dataGridView1.Rows.Add(arrRow);
}*/
/*}*/
