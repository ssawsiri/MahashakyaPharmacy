
namespace MahashakyaPharmacy
{
    partial class frmGRN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dpicRecievedDate = new MetroFramework.Controls.MetroDateTime();
            this.dpickerExpireDate = new MetroFramework.Controls.MetroDateTime();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtRecievedQty = new MetroFramework.Controls.MetroTextBox();
            this.txtRetailPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtWholeSalePrice = new MetroFramework.Controls.MetroTextBox();
            this.txtItemDescription = new MetroFramework.Controls.MetroTextBox();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.txtBarCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.cmbCamera = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1888, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.dpicRecievedDate);
            this.metroPanel1.Controls.Add(this.dpickerExpireDate);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnSave);
            this.metroPanel1.Controls.Add(this.txtRecievedQty);
            this.metroPanel1.Controls.Add(this.txtRetailPrice);
            this.metroPanel1.Controls.Add(this.txtWholeSalePrice);
            this.metroPanel1.Controls.Add(this.txtItemDescription);
            this.metroPanel1.Controls.Add(this.txtInvoiceNo);
            this.metroPanel1.Controls.Add(this.txtBarCode);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1082, 944);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dpicRecievedDate
            // 
            this.dpicRecievedDate.CustomFormat = "";
            this.dpicRecievedDate.Location = new System.Drawing.Point(732, 335);
            this.dpicRecievedDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpicRecievedDate.Name = "dpicRecievedDate";
            this.dpicRecievedDate.Size = new System.Drawing.Size(244, 29);
            this.dpicRecievedDate.TabIndex = 8;
            this.dpicRecievedDate.Value = new System.DateTime(2022, 2, 17, 0, 0, 0, 0);
            // 
            // dpickerExpireDate
            // 
            this.dpickerExpireDate.CustomFormat = "\"\"";
            this.dpickerExpireDate.Location = new System.Drawing.Point(224, 339);
            this.dpickerExpireDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dpickerExpireDate.Name = "dpickerExpireDate";
            this.dpickerExpireDate.Size = new System.Drawing.Size(236, 29);
            this.dpickerExpireDate.TabIndex = 7;
            this.dpickerExpireDate.Value = new System.DateTime(2022, 2, 16, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Location = new System.Drawing.Point(600, 454);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 78);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSave.Location = new System.Drawing.Point(259, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 78);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRecievedQty
            // 
            // 
            // 
            // 
            this.txtRecievedQty.CustomButton.Image = null;
            this.txtRecievedQty.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtRecievedQty.CustomButton.Name = "";
            this.txtRecievedQty.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRecievedQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRecievedQty.CustomButton.TabIndex = 1;
            this.txtRecievedQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRecievedQty.CustomButton.UseSelectable = true;
            this.txtRecievedQty.CustomButton.Visible = false;
            this.txtRecievedQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRecievedQty.Lines = new string[0];
            this.txtRecievedQty.Location = new System.Drawing.Point(224, 262);
            this.txtRecievedQty.MaxLength = 32767;
            this.txtRecievedQty.Name = "txtRecievedQty";
            this.txtRecievedQty.PasswordChar = '\0';
            this.txtRecievedQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRecievedQty.SelectedText = "";
            this.txtRecievedQty.SelectionLength = 0;
            this.txtRecievedQty.SelectionStart = 0;
            this.txtRecievedQty.ShortcutsEnabled = true;
            this.txtRecievedQty.Size = new System.Drawing.Size(140, 29);
            this.txtRecievedQty.TabIndex = 6;
            this.txtRecievedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRecievedQty.UseSelectable = true;
            this.txtRecievedQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRecievedQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRetailPrice
            // 
            // 
            // 
            // 
            this.txtRetailPrice.CustomButton.Image = null;
            this.txtRetailPrice.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtRetailPrice.CustomButton.Name = "";
            this.txtRetailPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRetailPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRetailPrice.CustomButton.TabIndex = 1;
            this.txtRetailPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRetailPrice.CustomButton.UseSelectable = true;
            this.txtRetailPrice.CustomButton.Visible = false;
            this.txtRetailPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRetailPrice.Lines = new string[0];
            this.txtRetailPrice.Location = new System.Drawing.Point(577, 189);
            this.txtRetailPrice.MaxLength = 32767;
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.PasswordChar = '\0';
            this.txtRetailPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRetailPrice.SelectedText = "";
            this.txtRetailPrice.SelectionLength = 0;
            this.txtRetailPrice.SelectionStart = 0;
            this.txtRetailPrice.ShortcutsEnabled = true;
            this.txtRetailPrice.Size = new System.Drawing.Size(140, 29);
            this.txtRetailPrice.TabIndex = 5;
            this.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRetailPrice.UseSelectable = true;
            this.txtRetailPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRetailPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtWholeSalePrice
            // 
            // 
            // 
            // 
            this.txtWholeSalePrice.CustomButton.Image = null;
            this.txtWholeSalePrice.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.txtWholeSalePrice.CustomButton.Name = "";
            this.txtWholeSalePrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtWholeSalePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWholeSalePrice.CustomButton.TabIndex = 1;
            this.txtWholeSalePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWholeSalePrice.CustomButton.UseSelectable = true;
            this.txtWholeSalePrice.CustomButton.Visible = false;
            this.txtWholeSalePrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtWholeSalePrice.Lines = new string[0];
            this.txtWholeSalePrice.Location = new System.Drawing.Point(224, 189);
            this.txtWholeSalePrice.MaxLength = 32767;
            this.txtWholeSalePrice.Name = "txtWholeSalePrice";
            this.txtWholeSalePrice.PasswordChar = '\0';
            this.txtWholeSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWholeSalePrice.SelectedText = "";
            this.txtWholeSalePrice.SelectionLength = 0;
            this.txtWholeSalePrice.SelectionStart = 0;
            this.txtWholeSalePrice.ShortcutsEnabled = true;
            this.txtWholeSalePrice.Size = new System.Drawing.Size(140, 29);
            this.txtWholeSalePrice.TabIndex = 4;
            this.txtWholeSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWholeSalePrice.UseSelectable = true;
            this.txtWholeSalePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWholeSalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemDescription
            // 
            // 
            // 
            // 
            this.txtItemDescription.CustomButton.Image = null;
            this.txtItemDescription.CustomButton.Location = new System.Drawing.Point(515, 1);
            this.txtItemDescription.CustomButton.Name = "";
            this.txtItemDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtItemDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemDescription.CustomButton.TabIndex = 1;
            this.txtItemDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemDescription.CustomButton.UseSelectable = true;
            this.txtItemDescription.CustomButton.Visible = false;
            this.txtItemDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtItemDescription.Lines = new string[0];
            this.txtItemDescription.Location = new System.Drawing.Point(224, 115);
            this.txtItemDescription.MaxLength = 32767;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.PasswordChar = '\0';
            this.txtItemDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDescription.SelectedText = "";
            this.txtItemDescription.SelectionLength = 0;
            this.txtItemDescription.SelectionStart = 0;
            this.txtItemDescription.ShortcutsEnabled = true;
            this.txtItemDescription.Size = new System.Drawing.Size(543, 29);
            this.txtItemDescription.TabIndex = 3;
            this.txtItemDescription.UseSelectable = true;
            this.txtItemDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(577, 45);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(190, 29);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBarCode
            // 
            // 
            // 
            // 
            this.txtBarCode.CustomButton.Image = null;
            this.txtBarCode.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtBarCode.CustomButton.Name = "";
            this.txtBarCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarCode.CustomButton.TabIndex = 1;
            this.txtBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarCode.CustomButton.UseSelectable = true;
            this.txtBarCode.CustomButton.Visible = false;
            this.txtBarCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBarCode.Lines = new string[0];
            this.txtBarCode.Location = new System.Drawing.Point(224, 45);
            this.txtBarCode.MaxLength = 32767;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.PasswordChar = '\0';
            this.txtBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarCode.SelectedText = "";
            this.txtBarCode.SelectionLength = 0;
            this.txtBarCode.SelectionStart = 0;
            this.txtBarCode.ShortcutsEnabled = true;
            this.txtBarCode.Size = new System.Drawing.Size(190, 29);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.UseSelectable = true;
            this.txtBarCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(470, 43);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Invoice No.";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(577, 339);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(132, 25);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Recieved Date :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(38, 339);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(110, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Expire Date :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(38, 260);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(119, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Recieved Qty.";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(470, 187);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Retail Price";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(38, 187);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(142, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Whole Sale Price";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(38, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Item Description";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(38, 43);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Bar Code No.";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // picBarCode
            // 
            this.picBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBarCode.Location = new System.Drawing.Point(1111, 63);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Size = new System.Drawing.Size(418, 268);
            this.picBarCode.TabIndex = 2;
            this.picBarCode.TabStop = false;
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.ItemHeight = 23;
            this.cmbCamera.Location = new System.Drawing.Point(1112, 338);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(417, 29);
            this.cmbCamera.TabIndex = 11;
            this.cmbCamera.UseSelectable = true;
            // 
            // frmGRN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::MahashakyaPharmacy.Properties.Resources.Mahashakya;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackImage = global::MahashakyaPharmacy.Properties.Resources.Mahashakya;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.picBarCode);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmGRN";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Text = "Good Recieve Note";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGRN_FormClosing);
            this.Load += new System.EventHandler(this.frmGRN_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtBarCode;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroTextBox txtRetailPrice;
        private MetroFramework.Controls.MetroTextBox txtWholeSalePrice;
        private MetroFramework.Controls.MetroTextBox txtItemDescription;
        private MetroFramework.Controls.MetroTextBox txtRecievedQty;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.PictureBox picBarCode;
        private MetroFramework.Controls.MetroComboBox cmbCamera;
        private MetroFramework.Controls.MetroDateTime dpickerExpireDate;
        private MetroFramework.Controls.MetroDateTime dpicRecievedDate;
    }
}