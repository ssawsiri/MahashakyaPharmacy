using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;

namespace MahashakyaPharmacy
{
    public partial class frmGRN : MetroFramework.Forms.MetroForm
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        DataBase_Connect obj = new DataBase_Connect();
        public frmGRN()
        {
            InitializeComponent();
        }

        private void frmGRN_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cmbCamera.Items.Add(device.Name);
            cmbCamera.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtBarCode.Invoke(new MethodInvoker(delegate ()
                {
                    txtBarCode.Text = result.ToString();
                }));
            }
            picBarCode.Image = bitmap;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Close();
        }

       

        private void frmGRN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Information", "Do you want to add the details to Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (txtBarCode.Text == "")
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Bar Code Cannot be Blanked", MessageBoxButtons.OK);
                    else if (txtItemDescription.Text == "")
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Item Description Cannot be Blanked", MessageBoxButtons.OK);
                    else if (txtRecievedQty.Text == "")
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Recieved Qty Cannot be Blanked", MessageBoxButtons.OK);
                    else if (txtRetailPrice.Text == "")
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Retail Price Cannot be Blanked", MessageBoxButtons.OK);
                    else if (txtWholeSalePrice.Text == "")
                        MetroFramework.MetroMessageBox.Show(this, "Error", "Whole Sale Price Cannot be Blanked", MessageBoxButtons.OK);
                    else
                    {
                        decimal wholeSalePrice = decimal.Parse(txtWholeSalePrice.Text);
                        decimal retailPrice = decimal.Parse(txtRetailPrice.Text);
                        int i = obj.save_update_delete("insert into tblInventory (barcode, invoiceNo, recivedDate, itemDescription, wholeSalePrice, retailPrice, recievedQty, expireDate)values ('" + txtBarCode.Text + "', '" + txtInvoiceNo.Text + "', '" + dpicRecievedDate.Value.Date + "', '" + txtItemDescription.Text + "', '" + wholeSalePrice + "', '" + retailPrice + "', '" + txtRecievedQty.Text + "', '" + dpickerExpireDate.Value.Date + "')");

                        if (i == 1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Item Added Successfully", "Data Inserting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            functionClear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Error Occured", "Data Inserting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception error)
                {
                    MetroFramework.MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Information", "Are You Sure Do you want to Clear the Data ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            functionClear();
        }

        public void functionClear ()
        {
            txtBarCode.Clear();
            txtInvoiceNo.Clear();
            txtItemDescription.Clear();
            txtRecievedQty.Clear();
            txtRetailPrice.Clear();
            txtWholeSalePrice.Clear();
        }
    }
}
