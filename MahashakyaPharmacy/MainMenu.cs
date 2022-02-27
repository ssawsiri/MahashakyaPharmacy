using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahashakyaPharmacy
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        frmGRN grn = new frmGRN();
        Billing_Window bill = new Billing_Window();
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Hide();
            
            bill.Show();
            
        }

        private void btnGRN_Click(object sender, EventArgs e)
        {
            Hide();
            
            grn.Show();

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            grn.Close();
            bill.Close();
        }
    }
}
