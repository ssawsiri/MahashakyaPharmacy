using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahashakyaPharmacy.Reports
{
    public partial class Invoice_Form : MetroFramework.Forms.MetroForm
    {

        DataBase_Connect obj = new DataBase_Connect();
        
        public Invoice_Form()
        {
            InitializeComponent();
            
        }

        private void Invoice_Form_Load(object sender, EventArgs e)
        {
            DataTable dt = obj.view_data("select max(billNo) from tblSales");
            int bill_no = int.Parse(dt.Rows[0][0].ToString());
            // TODO: This line of code loads data into the 'Invoice_Report.tblSales' table. You can move, or remove it, as needed.
            this.tblSalesTableAdapter.Fill(this.Invoice_Report.tblSales, bill_no);
            
            this.reportViewerInvoice.RefreshReport();
        }
    }
}
