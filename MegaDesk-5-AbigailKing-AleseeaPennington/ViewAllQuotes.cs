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
                string[] deskQuotes = File.ReadAllLines(@"quotes.txt");

                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No desk quotes have been created yet.");
            }
        }
    }
}
