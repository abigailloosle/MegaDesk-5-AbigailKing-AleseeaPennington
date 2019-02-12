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
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            //put info into Surface Materials ComboBox
            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                    .Cast<Desk.Surface>()
                    .ToList();

            comboSurfaceSearch.DataSource = materials;

            //comboSurfaceSearch.SelectedIndex = -1;
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                List<DeskQuote> deskQuotes = new List<DeskQuote>();
                //Console.WriteLine("Desk Quotes: " + deskQuotes);

                using (StreamReader reader = new StreamReader(@"quotes.json"))
                {
                    var search = (Desk.Surface)comboSurfaceSearch.SelectedValue;
                    string allQuotes = reader.ReadToEnd();
                    //Console.WriteLine("All Quotes: " + allQuotes);

                    deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(allQuotes);
                    //Console.WriteLine("Desk Quotes: " + deskQuotes);

                    /*I think that the error is after this...*/
                    dataGridView1.DataSource = deskQuotes.Select(d => new
                    {
                        Date = d.QuoteDate,
                        Customer = d.CustomerName,
                        DeskDepth = d.Desk.Depth,
                        DeskWidth = d.Desk.Width,
                        NumDrawers = d.Desk.Drawers,
                        Material = d.Desk.SurfaceMaterial,
                        Delivery = d.DeliveryType,
                        Amount = d.QuoteAmount
                    })
                    .Where(q => q.Material == search)
                    .ToList();
                    // Console.WriteLine("Data Grid View 1: " + deskQuotes);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No desk quotes have been created yet.");
            }
        }
    /* try
     {

         dataGridView1.Rows.Clear();

         string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

         foreach (string deskQuote in deskQuotes)
         {
             string[] arrRow = deskQuote.Split(new char[] { ',' });

             foreach (string text in arrRow)
             {
                 if (text == comboSurfaceSearch.SelectedValue.ToString())
                 {
                     dataGridView1.Rows.Add(arrRow);
                 }
             };
         }
     }
     catch (FileNotFoundException)
     {
         MessageBox.Show("No desk quotes have been created yet.");
     }*/

    }
}

