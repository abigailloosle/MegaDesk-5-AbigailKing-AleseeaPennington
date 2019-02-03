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

            comboSurfaceSearch.SelectedIndex = -1;
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
            }
        }
    }
}
