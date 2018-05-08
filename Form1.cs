using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hehhehehhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelRezerw.Hide();
            panelKarta.Hide();
        }

        private void przyciskZarezerwuj_Click(object sender, EventArgs e)
        {
            panelLoty.BringToFront();
           // panelRezerw.Hide();
            panelKarta.Hide();
            panelLoty.Show();
           
            
        }

        private void przyciskDalej_Click(object sender, EventArgs e)
        {
            panelKarta.Show();
            panelRezerw.Hide();
            panelLoty.Hide();
           
        }

        private void przyciskRezerwuj_Click(object sender, EventArgs e)
        {
            panelRezerw.Show();
            panelKarta.Hide();
            panelLoty.Hide();
            
            
        }

       
    }
}
