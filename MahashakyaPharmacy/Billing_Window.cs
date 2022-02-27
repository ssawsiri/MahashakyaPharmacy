using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;
using AForge.Video;


namespace MahashakyaPharmacy
{
    public partial class Billing_Window : MetroFramework.Forms.MetroForm
    {
        DataBase_Connect obj = new DataBase_Connect();
        Form reportform = new Reports.Invoice_Form();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        decimal sum ;
        decimal discount;
        decimal earnDiscount;
        
        public Billing_Window()
        {
            InitializeComponent();
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Billing_Window_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            timer1.Start();
            txtDate.Text = DateTime.Now.ToShortDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cmbCamera.Items.Add(device.Name);
            cmbCamera.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            Bill_Number_Calculation();


        }

        private void Bill_Number_Calculation()
        {
            try
            {
                var newBillNo = 1;
                DataTable dt = obj.view_data("select max(billNo) from tblSales");

                var lastBillNO = int.Parse(dt.Rows[0][0].ToString());
                newBillNo = lastBillNO + 1;
                txtBillNo.Text = newBillNo.ToString();
            }
            catch (Exception error)
            { }
            
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarcode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarcode.Text = result.ToString();
                }));
            }
            picBarCode.Image = bitmap;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Billing_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.F9)
            {
                btnPayBill.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.F7)
            {
                btnAdd.PerformClick();
            }
        }

        private void Billing_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = obj.view_data("select itemDescription from tblInventory where barcode = '" + txtBarcode.Text + "' ");
                txtItemName.Text = dt.Rows[0][0].ToString();
            }
           catch (Exception error)
            {
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int distance;
            if (txtBarcode.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Bar Code Cannot Be Blanked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtItemName.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Item Name Cannot Be Blanked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtQty.Text == "")
                MetroFramework.MetroMessageBox.Show(this, "Quantity Cannot Be Blanked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!int.TryParse(txtQty.Text, out distance))
                MetroFramework.MetroMessageBox.Show(this, "Quantity can be only Numeric Values", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    DataTable dt = obj.view_data("select retailPrice from tblInventory where barcode = '" + txtBarcode.Text + "' ");
                    var retailPrice = decimal.Parse(dt.Rows[0][0].ToString());
                    decimal amount = 0;
                    addingDataGridView(txtBarcode.Text, txtItemName.Text, retailPrice, txtQty.Text, amount = retailPrice * decimal.Parse(txtQty.Text));
                    functionClear();
                }
                catch (Exception error)
                { }
                
            }


            
        }

        

        private void functionClear()
        {
            txtBarcode.Clear();
            txtItemName.Clear();
            txtQty.Clear();

        }

        private void addingDataGridView(string barCode, string itemName, decimal retailPrice, string qty, decimal amount)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(gridItems);
                newRow.Cells[0].Value = barCode;
                newRow.Cells[1].Value = itemName;
                newRow.Cells[2].Value = retailPrice;
                newRow.Cells[3].Value = qty;
                newRow.Cells[4].Value = amount;
                gridItems.Rows.Add(newRow);
            }
            catch(Exception error)
            {
            }          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are you sure do you want to Clear ?", "Are You Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                functionClear();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = obj.view_data("select recievedQty from tblInventory where barcode = '" + txtBarcode.Text + "' ");
                int qty = int.Parse(dt.Rows[0][0].ToString());
                if (int.Parse(txtQty.Text) > qty)
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "You Don't have enough Stock in the Inventory", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                        txtQty.Clear();
                }
            }
            catch (Exception error)
            {

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are you sure do you want to remove the item ? ", "Are you Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (gridItems.Rows.Count == 0)
                    MetroFramework.MetroMessageBox.Show(this, "Nothing to Remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    int row_index = gridItems.CurrentCell.RowIndex;
                    ItemDeduction(row_index);
                    gridItems.Rows.RemoveAt(row_index);
                    
                }
                
            }
            
        }

        private void ItemDeduction(int row_index)
        {
            sum = sum - decimal.Parse(gridItems.Rows[row_index].Cells[4].Value.ToString());
            txtSubTotal.Text = sum.ToString("#,0.00");
            txtTotal.Text = txtSubTotal.Text;
        }

        private void gridItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
            
            for (int i = 0; i <= gridItems.Rows.Count - 1; i++)
            {
                sum = sum + decimal.Parse(gridItems.Rows[i].Cells[4].Value.ToString());

            }

            txtSubTotal.Text = sum.ToString("#,0.00");
            txtTotal.Text = txtSubTotal.Text;

            
            
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            decimal distant;
           
            if (decimal.TryParse(txtDiscount.Text, out distant))
            {
                discount = sum * ((decimal.Parse(txtDiscount.Text) / 100));
                decimal total = sum - discount;
                txtTotal.Text = total.ToString("#, 0.00");
                earnDiscount = sum - total;
                txtEarnDiscount.Text = earnDiscount.ToString("#,0.00");
                
            }
                
            else
                MetroFramework.MetroMessageBox.Show(this, "You Entered a wrong Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        

        private void btnPayBill_Click(object sender, EventArgs e)
        {
            
            string paymentmethod ;
            if (rdbuttonCash.Checked)
                paymentmethod = "Cash";
            else
                paymentmethod = "Card";

            if (gridItems.Rows.Count == 0)
                MetroFramework.MetroMessageBox.Show(this, "There is Nothing to Pay, Please Check Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           else
            {

                try
                {
                    
                    foreach (DataGridViewRow dr in gridItems.Rows)
                    {
                        obj.save_update_delete("insert into tblSales (billNo, barCode, billDate, billTime, itemDescription, price, qty, totalPrice, subTotal,  cashorcard, earnDiscount, totalAmount) values ('" + txtBillNo.Text + "', '" + dr.Cells[0].Value + "','" + txtDate.Text + "', '" + txtTime.Text + "', '" + dr.Cells[1].Value + "', '" + dr.Cells[2].Value + "', '" + dr.Cells[3].Value + "', '" + dr.Cells[4].Value + "', '" + txtSubTotal.Text + "' , '" + paymentmethod + "', '" + txtEarnDiscount.Text + "', '" + txtTotal.Text + "')");
                        obj.save_update_delete("update tblInventory set recievedQty = recievedQty - '" + dr.Cells[3].Value + "' where barcode = '" + dr.Cells[0].Value + "' ");
                    }
  
                }
                catch (Exception error)
                { MetroFramework.MetroMessageBox.Show(this, error.Message, "Error"); }
                    
                reportform.Show();
                this.Close();
                Billing_Window form = new Billing_Window();
                form.Show();
               


            }
           
            
        }

        
    }
}
