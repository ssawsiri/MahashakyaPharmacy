
namespace MahashakyaPharmacy
{
    partial class Billing_Window
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtTime = new MetroFramework.Controls.MetroTextBox();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.txtBillNo = new MetroFramework.Controls.MetroTextBox();
            this.txtBarcode = new MetroFramework.Controls.MetroTextBox();
            this.txtItemName = new MetroFramework.Controls.MetroTextBox();
            this.txtSubTotal = new MetroFramework.Controls.MetroTextBox();
            this.rdbuttonCash = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.gridItems = new MetroFramework.Controls.MetroGrid();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPayBill = new MetroFramework.Controls.MetroButton();
            this.btnRemove = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbCamera = new MetroFramework.Controls.MetroComboBox();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.txtQty = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscount = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.txtEarnDiscount = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(14, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Loyalty No.";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.txtTime);
            this.metroPanel1.Controls.Add(this.txtDate);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 1000);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(22, 576);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(46, 25);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Total";
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(22, 524);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(126, 25);
            this.metroLabel11.TabIndex = 16;
            this.metroLabel11.Text = "Apply Discount";
            this.metroLabel11.UseCustomBackColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(15, 252);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(39, 25);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Qty";
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // txtTime
            // 
            // 
            // 
            // 
            this.txtTime.CustomButton.Image = null;
            this.txtTime.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtTime.CustomButton.Name = "";
            this.txtTime.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTime.CustomButton.TabIndex = 1;
            this.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTime.CustomButton.UseSelectable = true;
            this.txtTime.CustomButton.Visible = false;
            this.txtTime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTime.Lines = new string[0];
            this.txtTime.Location = new System.Drawing.Point(22, 868);
            this.txtTime.MaxLength = 32767;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.ReadOnly = true;
            this.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.ShortcutsEnabled = true;
            this.txtTime.Size = new System.Drawing.Size(161, 29);
            this.txtTime.TabIndex = 14;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTime.UseSelectable = true;
            this.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(22, 784);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.ReadOnly = true;
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(161, 29);
            this.txtDate.TabIndex = 13;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(14, 840);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(49, 25);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Time";
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(15, 756);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 25);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Date";
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(22, 623);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 25);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Cash or Card";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(22, 470);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 25);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Sub Total";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(14, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Item Name";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(14, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Barcode";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(14, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Bill No.";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1886, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(226, 84);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(202, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.CustomButton.Image = null;
            this.txtBillNo.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtBillNo.CustomButton.Name = "";
            this.txtBillNo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBillNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBillNo.CustomButton.TabIndex = 1;
            this.txtBillNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBillNo.CustomButton.UseSelectable = true;
            this.txtBillNo.CustomButton.Visible = false;
            this.txtBillNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBillNo.Lines = new string[0];
            this.txtBillNo.Location = new System.Drawing.Point(226, 141);
            this.txtBillNo.MaxLength = 32767;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PasswordChar = '\0';
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBillNo.SelectedText = "";
            this.txtBillNo.SelectionLength = 0;
            this.txtBillNo.SelectionStart = 0;
            this.txtBillNo.ShortcutsEnabled = true;
            this.txtBillNo.Size = new System.Drawing.Size(107, 29);
            this.txtBillNo.TabIndex = 4;
            this.txtBillNo.UseSelectable = true;
            this.txtBillNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBillNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBarcode
            // 
            // 
            // 
            // 
            this.txtBarcode.CustomButton.Image = null;
            this.txtBarcode.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.txtBarcode.CustomButton.Name = "";
            this.txtBarcode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBarcode.CustomButton.TabIndex = 1;
            this.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBarcode.CustomButton.UseSelectable = true;
            this.txtBarcode.CustomButton.Visible = false;
            this.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBarcode.Lines = new string[0];
            this.txtBarcode.Location = new System.Drawing.Point(226, 198);
            this.txtBarcode.MaxLength = 32767;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PasswordChar = '\0';
            this.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.SelectionLength = 0;
            this.txtBarcode.SelectionStart = 0;
            this.txtBarcode.ShortcutsEnabled = true;
            this.txtBarcode.Size = new System.Drawing.Size(181, 29);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.UseSelectable = true;
            this.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBarcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.CustomButton.Image = null;
            this.txtItemName.CustomButton.Location = new System.Drawing.Point(308, 1);
            this.txtItemName.CustomButton.Name = "";
            this.txtItemName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemName.CustomButton.TabIndex = 1;
            this.txtItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemName.CustomButton.UseSelectable = true;
            this.txtItemName.CustomButton.Visible = false;
            this.txtItemName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtItemName.Lines = new string[0];
            this.txtItemName.Location = new System.Drawing.Point(226, 257);
            this.txtItemName.MaxLength = 32767;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.ShortcutsEnabled = true;
            this.txtItemName.Size = new System.Drawing.Size(336, 29);
            this.txtItemName.TabIndex = 6;
            this.txtItemName.UseSelectable = true;
            this.txtItemName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSubTotal
            // 
            // 
            // 
            // 
            this.txtSubTotal.CustomButton.Image = null;
            this.txtSubTotal.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtSubTotal.CustomButton.Name = "";
            this.txtSubTotal.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubTotal.CustomButton.TabIndex = 1;
            this.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubTotal.CustomButton.UseSelectable = true;
            this.txtSubTotal.CustomButton.Visible = false;
            this.txtSubTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSubTotal.Lines = new string[0];
            this.txtSubTotal.Location = new System.Drawing.Point(226, 526);
            this.txtSubTotal.MaxLength = 32767;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.SelectionLength = 0;
            this.txtSubTotal.SelectionStart = 0;
            this.txtSubTotal.ShortcutsEnabled = true;
            this.txtSubTotal.Size = new System.Drawing.Size(161, 29);
            this.txtSubTotal.TabIndex = 7;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubTotal.UseSelectable = true;
            this.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubTotal.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // rdbuttonCash
            // 
            this.rdbuttonCash.Checked = true;
            this.rdbuttonCash.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdbuttonCash.Location = new System.Drawing.Point(258, 683);
            this.rdbuttonCash.Name = "rdbuttonCash";
            this.rdbuttonCash.Size = new System.Drawing.Size(75, 28);
            this.rdbuttonCash.Style = MetroFramework.MetroColorStyle.Orange;
            this.rdbuttonCash.TabIndex = 8;
            this.rdbuttonCash.TabStop = true;
            this.rdbuttonCash.Text = "Cash";
            this.rdbuttonCash.UseSelectable = true;
            this.rdbuttonCash.UseStyleColors = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroRadioButton1.Location = new System.Drawing.Point(371, 683);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(75, 28);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroRadioButton1.TabIndex = 9;
            this.metroRadioButton1.Text = "Card";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.UseStyleColors = true;
            // 
            // gridItems
            // 
            this.gridItems.AllowUserToAddRows = false;
            this.gridItems.AllowUserToDeleteRows = false;
            this.gridItems.AllowUserToResizeColumns = false;
            this.gridItems.AllowUserToResizeRows = false;
            this.gridItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItems.ColumnHeadersHeight = 25;
            this.gridItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.colItem,
            this.colUnitPrice,
            this.colQty,
            this.colAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridItems.EnableHeadersVisualStyles = false;
            this.gridItems.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridItems.Location = new System.Drawing.Point(688, 60);
            this.gridItems.Name = "gridItems";
            this.gridItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItems.Size = new System.Drawing.Size(1139, 626);
            this.gridItems.TabIndex = 10;
            this.gridItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.gridItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gridItems_RowsAdded);
            // 
            // BarCode
            // 
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colItem
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.colItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.colItem.Frozen = true;
            this.colItem.HeaderText = "Item";
            this.colItem.MaxInputLength = 50000;
            this.colItem.Name = "colItem";
            this.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItem.Width = 700;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Frozen = true;
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colQty
            // 
            this.colQty.Frozen = true;
            this.colQty.HeaderText = "Qty.";
            this.colQty.Name = "colQty";
            // 
            // colAmount
            // 
            this.colAmount.Frozen = true;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            // 
            // btnAdd
            // 
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.Location = new System.Drawing.Point(258, 384);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 103);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD (F7)";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.UseStyleColors = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnClear.Location = new System.Drawing.Point(443, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 103);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseSelectable = true;
            this.btnClear.UseStyleColors = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPayBill
            // 
            this.btnPayBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPayBill.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPayBill.Location = new System.Drawing.Point(258, 735);
            this.btnPayBill.Name = "btnPayBill";
            this.btnPayBill.Size = new System.Drawing.Size(325, 72);
            this.btnPayBill.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPayBill.TabIndex = 13;
            this.btnPayBill.Text = "PAY THE BILL (F9)";
            this.btnPayBill.UseCustomBackColor = true;
            this.btnPayBill.UseSelectable = true;
            this.btnPayBill.UseStyleColors = true;
            this.btnPayBill.Click += new System.EventHandler(this.btnPayBill_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRemove.Location = new System.Drawing.Point(688, 706);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(342, 68);
            this.btnRemove.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove the Item";
            this.btnRemove.UseSelectable = true;
            this.btnRemove.UseStyleColors = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(688, 21);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(71, 25);
            this.metroLabel7.TabIndex = 15;
            this.metroLabel7.Text = "Camera";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.ItemHeight = 23;
            this.cmbCamera.Location = new System.Drawing.Point(765, 21);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(340, 29);
            this.cmbCamera.TabIndex = 16;
            this.cmbCamera.UseSelectable = true;
            // 
            // picBarCode
            // 
            this.picBarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBarCode.Location = new System.Drawing.Point(1305, 692);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Size = new System.Drawing.Size(560, 313);
            this.picBarCode.TabIndex = 17;
            this.picBarCode.TabStop = false;
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.CustomButton.Image = null;
            this.txtQty.CustomButton.Location = new System.Drawing.Point(68, 1);
            this.txtQty.CustomButton.Name = "";
            this.txtQty.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQty.CustomButton.TabIndex = 1;
            this.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQty.CustomButton.UseSelectable = true;
            this.txtQty.CustomButton.Visible = false;
            this.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQty.Lines = new string[0];
            this.txtQty.Location = new System.Drawing.Point(226, 313);
            this.txtQty.MaxLength = 32767;
            this.txtQty.Name = "txtQty";
            this.txtQty.PasswordChar = '\0';
            this.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQty.SelectedText = "";
            this.txtQty.SelectionLength = 0;
            this.txtQty.SelectionStart = 0;
            this.txtQty.ShortcutsEnabled = true;
            this.txtQty.Size = new System.Drawing.Size(96, 29);
            this.txtQty.TabIndex = 18;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.UseSelectable = true;
            this.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtDiscount
            // 
            // 
            // 
            // 
            this.txtDiscount.CustomButton.Image = null;
            this.txtDiscount.CustomButton.Location = new System.Drawing.Point(49, 1);
            this.txtDiscount.CustomButton.Name = "";
            this.txtDiscount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscount.CustomButton.TabIndex = 1;
            this.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscount.CustomButton.UseSelectable = true;
            this.txtDiscount.CustomButton.Visible = false;
            this.txtDiscount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDiscount.Lines = new string[0];
            this.txtDiscount.Location = new System.Drawing.Point(226, 584);
            this.txtDiscount.MaxLength = 32767;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.SelectionLength = 0;
            this.txtDiscount.SelectionStart = 0;
            this.txtDiscount.ShortcutsEnabled = true;
            this.txtDiscount.Size = new System.Drawing.Size(77, 29);
            this.txtDiscount.TabIndex = 7;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.UseSelectable = true;
            this.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(226, 636);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(161, 29);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotal.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(320, 584);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(136, 25);
            this.metroLabel13.TabIndex = 19;
            this.metroLabel13.Text = "Earned Discount";
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // txtEarnDiscount
            // 
            // 
            // 
            // 
            this.txtEarnDiscount.CustomButton.Image = null;
            this.txtEarnDiscount.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtEarnDiscount.CustomButton.Name = "";
            this.txtEarnDiscount.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtEarnDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEarnDiscount.CustomButton.TabIndex = 1;
            this.txtEarnDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEarnDiscount.CustomButton.UseSelectable = true;
            this.txtEarnDiscount.CustomButton.Visible = false;
            this.txtEarnDiscount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEarnDiscount.Lines = new string[0];
            this.txtEarnDiscount.Location = new System.Drawing.Point(462, 584);
            this.txtEarnDiscount.MaxLength = 32767;
            this.txtEarnDiscount.Name = "txtEarnDiscount";
            this.txtEarnDiscount.PasswordChar = '\0';
            this.txtEarnDiscount.ReadOnly = true;
            this.txtEarnDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEarnDiscount.SelectedText = "";
            this.txtEarnDiscount.SelectionLength = 0;
            this.txtEarnDiscount.SelectionStart = 0;
            this.txtEarnDiscount.ShortcutsEnabled = true;
            this.txtEarnDiscount.Size = new System.Drawing.Size(100, 29);
            this.txtEarnDiscount.TabIndex = 20;
            this.txtEarnDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEarnDiscount.UseSelectable = true;
            this.txtEarnDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEarnDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Billing_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.txtEarnDiscount);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.picBarCode);
            this.Controls.Add(this.cmbCamera);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPayBill);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.rdbuttonCash);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Billing_Window";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Mahashakya Pharmacy - BILLING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Billing_Window_FormClosing);
            this.Load += new System.EventHandler(this.Billing_Window_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Billing_Window_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        public MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel metroLabel4;
        public MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroLabel metroLabel9;
        public MetroFramework.Controls.MetroLabel metroLabel8;
        public MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtBillNo;
        private MetroFramework.Controls.MetroTextBox txtBarcode;
        private MetroFramework.Controls.MetroTextBox txtItemName;
        private MetroFramework.Controls.MetroTextBox txtSubTotal;
        private MetroFramework.Controls.MetroRadioButton rdbuttonCash;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroGrid gridItems;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroTextBox txtTime;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton btnPayBill;
        private MetroFramework.Controls.MetroButton btnRemove;
        public MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbCamera;
        private System.Windows.Forms.PictureBox picBarCode;
        public MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtQty;
        public MetroFramework.Controls.MetroLabel metroLabel12;
        public MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtDiscount;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        public MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox txtEarnDiscount;
    }
}