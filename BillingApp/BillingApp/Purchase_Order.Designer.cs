namespace BillingApp
{
    partial class SuppilerInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.MTex_Address = new System.Windows.Forms.RichTextBox();
            this.MTex_Pancard = new MetroFramework.Controls.MetroTextBox();
            this.lab_Pancard = new MetroFramework.Controls.MetroLabel();
            this.MTex_Email = new MetroFramework.Controls.MetroTextBox();
            this.MTex_SupplierID = new MetroFramework.Controls.MetroTextBox();
            this.MLab_ClientID = new MetroFramework.Controls.MetroLabel();
            this.MTex_Contact = new MetroFramework.Controls.MetroTextBox();
            this.Mlab_Address = new MetroFramework.Controls.MetroLabel();
            this.MLab_Contact = new MetroFramework.Controls.MetroLabel();
            this.MLab_Email = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.MTex_InvoiceDate = new MetroFramework.Controls.MetroTextBox();
            this.MTex_InvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MLab_CustomerName = new MetroFramework.Controls.MetroLabel();
            this.MTex_ProductID = new MetroFramework.Controls.MetroTextBox();
            this.MCom_ProductName = new MetroFramework.Controls.MetroComboBox();
            this.MTex_Price = new MetroFramework.Controls.MetroTextBox();
            this.MTex_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.MTex_Total = new MetroFramework.Controls.MetroTextBox();
            this.MBtn_AddItem = new MetroFramework.Controls.MetroButton();
            this.MTex_AvailableStock = new MetroFramework.Controls.MetroTextBox();
            this.MTex_MRP = new MetroFramework.Controls.MetroTextBox();
            this.MLab_ProductID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTex_GrandTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btn_GenerateInvoice = new MetroFramework.Controls.MetroButton();
            this.lab_MRP = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.MTex_Address);
            this.metroPanel1.Controls.Add(this.MTex_Pancard);
            this.metroPanel1.Controls.Add(this.lab_Pancard);
            this.metroPanel1.Controls.Add(this.MTex_Email);
            this.metroPanel1.Controls.Add(this.MTex_SupplierID);
            this.metroPanel1.Controls.Add(this.MLab_ClientID);
            this.metroPanel1.Controls.Add(this.MTex_Contact);
            this.metroPanel1.Controls.Add(this.Mlab_Address);
            this.metroPanel1.Controls.Add(this.MLab_Contact);
            this.metroPanel1.Controls.Add(this.MLab_Email);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(868, 235);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // MTex_Address
            // 
            this.MTex_Address.BackColor = System.Drawing.Color.White;
            this.MTex_Address.Location = new System.Drawing.Point(87, 123);
            this.MTex_Address.Name = "MTex_Address";
            this.MTex_Address.Size = new System.Drawing.Size(214, 47);
            this.MTex_Address.TabIndex = 17;
            this.MTex_Address.Text = "";
            // 
            // MTex_Pancard
            // 
            this.MTex_Pancard.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Pancard.CustomButton.Image = null;
            this.MTex_Pancard.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.MTex_Pancard.CustomButton.Name = "";
            this.MTex_Pancard.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Pancard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Pancard.CustomButton.TabIndex = 1;
            this.MTex_Pancard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Pancard.CustomButton.UseSelectable = true;
            this.MTex_Pancard.CustomButton.Visible = false;
            this.MTex_Pancard.Lines = new string[0];
            this.MTex_Pancard.Location = new System.Drawing.Point(360, 89);
            this.MTex_Pancard.MaxLength = 32767;
            this.MTex_Pancard.Name = "MTex_Pancard";
            this.MTex_Pancard.PasswordChar = '\0';
            this.MTex_Pancard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Pancard.SelectedText = "";
            this.MTex_Pancard.SelectionLength = 0;
            this.MTex_Pancard.SelectionStart = 0;
            this.MTex_Pancard.ShortcutsEnabled = true;
            this.MTex_Pancard.Size = new System.Drawing.Size(205, 28);
            this.MTex_Pancard.TabIndex = 16;
            this.MTex_Pancard.UseSelectable = true;
            this.MTex_Pancard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Pancard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lab_Pancard
            // 
            this.lab_Pancard.AutoSize = true;
            this.lab_Pancard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lab_Pancard.Location = new System.Drawing.Point(298, 94);
            this.lab_Pancard.Name = "lab_Pancard";
            this.lab_Pancard.Size = new System.Drawing.Size(56, 19);
            this.lab_Pancard.TabIndex = 15;
            this.lab_Pancard.Text = "Pancard";
            this.lab_Pancard.UseCustomBackColor = true;
            this.lab_Pancard.UseCustomForeColor = true;
            // 
            // MTex_Email
            // 
            this.MTex_Email.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Email.CustomButton.Image = null;
            this.MTex_Email.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.MTex_Email.CustomButton.Name = "";
            this.MTex_Email.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Email.CustomButton.TabIndex = 1;
            this.MTex_Email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Email.CustomButton.UseSelectable = true;
            this.MTex_Email.CustomButton.Visible = false;
            this.MTex_Email.Lines = new string[0];
            this.MTex_Email.Location = new System.Drawing.Point(87, 89);
            this.MTex_Email.MaxLength = 32767;
            this.MTex_Email.Name = "MTex_Email";
            this.MTex_Email.PasswordChar = '\0';
            this.MTex_Email.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Email.SelectedText = "";
            this.MTex_Email.SelectionLength = 0;
            this.MTex_Email.SelectionStart = 0;
            this.MTex_Email.ShortcutsEnabled = true;
            this.MTex_Email.Size = new System.Drawing.Size(205, 28);
            this.MTex_Email.TabIndex = 10;
            this.MTex_Email.UseSelectable = true;
            this.MTex_Email.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Email.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_SupplierID
            // 
            this.MTex_SupplierID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_SupplierID.CustomButton.Image = null;
            this.MTex_SupplierID.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.MTex_SupplierID.CustomButton.Name = "";
            this.MTex_SupplierID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_SupplierID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_SupplierID.CustomButton.TabIndex = 1;
            this.MTex_SupplierID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_SupplierID.CustomButton.UseSelectable = true;
            this.MTex_SupplierID.CustomButton.Visible = false;
            this.MTex_SupplierID.Lines = new string[0];
            this.MTex_SupplierID.Location = new System.Drawing.Point(87, 51);
            this.MTex_SupplierID.MaxLength = 32767;
            this.MTex_SupplierID.Name = "MTex_SupplierID";
            this.MTex_SupplierID.PasswordChar = '\0';
            this.MTex_SupplierID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_SupplierID.SelectedText = "";
            this.MTex_SupplierID.SelectionLength = 0;
            this.MTex_SupplierID.SelectionStart = 0;
            this.MTex_SupplierID.ShortcutsEnabled = true;
            this.MTex_SupplierID.Size = new System.Drawing.Size(205, 28);
            this.MTex_SupplierID.TabIndex = 13;
            this.MTex_SupplierID.UseSelectable = true;
            this.MTex_SupplierID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_SupplierID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MLab_ClientID
            // 
            this.MLab_ClientID.AutoSize = true;
            this.MLab_ClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MLab_ClientID.Location = new System.Drawing.Point(23, 51);
            this.MLab_ClientID.Name = "MLab_ClientID";
            this.MLab_ClientID.Size = new System.Drawing.Size(58, 19);
            this.MLab_ClientID.TabIndex = 14;
            this.MLab_ClientID.Text = "Client ID";
            this.MLab_ClientID.UseCustomBackColor = true;
            this.MLab_ClientID.UseCustomForeColor = true;
            // 
            // MTex_Contact
            // 
            this.MTex_Contact.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Contact.CustomButton.Image = null;
            this.MTex_Contact.CustomButton.Location = new System.Drawing.Point(179, 2);
            this.MTex_Contact.CustomButton.Name = "";
            this.MTex_Contact.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Contact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Contact.CustomButton.TabIndex = 1;
            this.MTex_Contact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Contact.CustomButton.UseSelectable = true;
            this.MTex_Contact.CustomButton.Visible = false;
            this.MTex_Contact.Lines = new string[0];
            this.MTex_Contact.Location = new System.Drawing.Point(358, 51);
            this.MTex_Contact.MaxLength = 32767;
            this.MTex_Contact.Name = "MTex_Contact";
            this.MTex_Contact.PasswordChar = '\0';
            this.MTex_Contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Contact.SelectedText = "";
            this.MTex_Contact.SelectionLength = 0;
            this.MTex_Contact.SelectionStart = 0;
            this.MTex_Contact.ShortcutsEnabled = true;
            this.MTex_Contact.Size = new System.Drawing.Size(205, 28);
            this.MTex_Contact.TabIndex = 9;
            this.MTex_Contact.UseSelectable = true;
            this.MTex_Contact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Contact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Mlab_Address
            // 
            this.Mlab_Address.AutoSize = true;
            this.Mlab_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Mlab_Address.Location = new System.Drawing.Point(12, 123);
            this.Mlab_Address.Name = "Mlab_Address";
            this.Mlab_Address.Size = new System.Drawing.Size(56, 19);
            this.Mlab_Address.TabIndex = 8;
            this.Mlab_Address.Text = "Address";
            this.Mlab_Address.UseCustomBackColor = true;
            this.Mlab_Address.UseCustomForeColor = true;
            // 
            // MLab_Contact
            // 
            this.MLab_Contact.AutoSize = true;
            this.MLab_Contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MLab_Contact.Location = new System.Drawing.Point(298, 51);
            this.MLab_Contact.Name = "MLab_Contact";
            this.MLab_Contact.Size = new System.Drawing.Size(54, 19);
            this.MLab_Contact.TabIndex = 7;
            this.MLab_Contact.Text = "Contact";
            this.MLab_Contact.UseCustomBackColor = true;
            this.MLab_Contact.UseCustomForeColor = true;
            // 
            // MLab_Email
            // 
            this.MLab_Email.AutoSize = true;
            this.MLab_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MLab_Email.Location = new System.Drawing.Point(23, 94);
            this.MLab_Email.Name = "MLab_Email";
            this.MLab_Email.Size = new System.Drawing.Size(41, 19);
            this.MLab_Email.TabIndex = 6;
            this.MLab_Email.Text = "Email";
            this.MLab_Email.UseCustomBackColor = true;
            this.MLab_Email.UseCustomForeColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.Controls.Add(this.MTex_InvoiceDate);
            this.metroPanel2.Controls.Add(this.MTex_InvoiceNo);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(599, 27);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(269, 195);
            this.metroPanel2.TabIndex = 15;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // MTex_InvoiceDate
            // 
            this.MTex_InvoiceDate.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_InvoiceDate.CustomButton.Image = null;
            this.MTex_InvoiceDate.CustomButton.Location = new System.Drawing.Point(164, 2);
            this.MTex_InvoiceDate.CustomButton.Name = "";
            this.MTex_InvoiceDate.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_InvoiceDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_InvoiceDate.CustomButton.TabIndex = 1;
            this.MTex_InvoiceDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_InvoiceDate.CustomButton.UseSelectable = true;
            this.MTex_InvoiceDate.CustomButton.Visible = false;
            this.MTex_InvoiceDate.Lines = new string[0];
            this.MTex_InvoiceDate.Location = new System.Drawing.Point(48, 127);
            this.MTex_InvoiceDate.MaxLength = 32767;
            this.MTex_InvoiceDate.Name = "MTex_InvoiceDate";
            this.MTex_InvoiceDate.PasswordChar = '\0';
            this.MTex_InvoiceDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_InvoiceDate.SelectedText = "";
            this.MTex_InvoiceDate.SelectionLength = 0;
            this.MTex_InvoiceDate.SelectionStart = 0;
            this.MTex_InvoiceDate.ShortcutsEnabled = true;
            this.MTex_InvoiceDate.Size = new System.Drawing.Size(190, 28);
            this.MTex_InvoiceDate.TabIndex = 4;
            this.MTex_InvoiceDate.UseSelectable = true;
            this.MTex_InvoiceDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_InvoiceDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_InvoiceNo
            // 
            this.MTex_InvoiceNo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_InvoiceNo.CustomButton.Image = null;
            this.MTex_InvoiceNo.CustomButton.Location = new System.Drawing.Point(155, 2);
            this.MTex_InvoiceNo.CustomButton.Name = "";
            this.MTex_InvoiceNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_InvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_InvoiceNo.CustomButton.TabIndex = 1;
            this.MTex_InvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_InvoiceNo.CustomButton.UseSelectable = true;
            this.MTex_InvoiceNo.CustomButton.Visible = false;
            this.MTex_InvoiceNo.Lines = new string[0];
            this.MTex_InvoiceNo.Location = new System.Drawing.Point(57, 42);
            this.MTex_InvoiceNo.MaxLength = 32767;
            this.MTex_InvoiceNo.Name = "MTex_InvoiceNo";
            this.MTex_InvoiceNo.PasswordChar = '\0';
            this.MTex_InvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_InvoiceNo.SelectedText = "";
            this.MTex_InvoiceNo.SelectionLength = 0;
            this.MTex_InvoiceNo.SelectionStart = 0;
            this.MTex_InvoiceNo.ShortcutsEnabled = true;
            this.MTex_InvoiceNo.Size = new System.Drawing.Size(181, 28);
            this.MTex_InvoiceNo.TabIndex = 2;
            this.MTex_InvoiceNo.UseSelectable = true;
            this.MTex_InvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_InvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel2.Location = new System.Drawing.Point(98, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "InvoiceDate";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel1.Location = new System.Drawing.Point(98, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "InvoiceNumber";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // MLab_CustomerName
            // 
            this.MLab_CustomerName.AutoSize = true;
            this.MLab_CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MLab_CustomerName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.MLab_CustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MLab_CustomerName.Location = new System.Drawing.Point(367, 0);
            this.MLab_CustomerName.Name = "MLab_CustomerName";
            this.MLab_CustomerName.Size = new System.Drawing.Size(140, 25);
            this.MLab_CustomerName.TabIndex = 5;
            this.MLab_CustomerName.Text = "Purchase order";
            this.MLab_CustomerName.UseCustomBackColor = true;
            this.MLab_CustomerName.UseCustomForeColor = true;
            // 
            // MTex_ProductID
            // 
            this.MTex_ProductID.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_ProductID.CustomButton.Image = null;
            this.MTex_ProductID.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_ProductID.CustomButton.Name = "";
            this.MTex_ProductID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_ProductID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_ProductID.CustomButton.TabIndex = 1;
            this.MTex_ProductID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_ProductID.CustomButton.UseSelectable = true;
            this.MTex_ProductID.CustomButton.Visible = false;
            this.MTex_ProductID.Lines = new string[0];
            this.MTex_ProductID.Location = new System.Drawing.Point(16, 82);
            this.MTex_ProductID.MaxLength = 32767;
            this.MTex_ProductID.Name = "MTex_ProductID";
            this.MTex_ProductID.PasswordChar = '\0';
            this.MTex_ProductID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_ProductID.SelectedText = "";
            this.MTex_ProductID.SelectionLength = 0;
            this.MTex_ProductID.SelectionStart = 0;
            this.MTex_ProductID.ShortcutsEnabled = true;
            this.MTex_ProductID.Size = new System.Drawing.Size(87, 28);
            this.MTex_ProductID.TabIndex = 23;
            this.MTex_ProductID.UseSelectable = true;
            this.MTex_ProductID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_ProductID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MCom_ProductName
            // 
            this.MCom_ProductName.BackColor = System.Drawing.Color.White;
            this.MCom_ProductName.FormattingEnabled = true;
            this.MCom_ProductName.ItemHeight = 23;
            this.MCom_ProductName.Location = new System.Drawing.Point(136, 82);
            this.MCom_ProductName.Name = "MCom_ProductName";
            this.MCom_ProductName.Size = new System.Drawing.Size(199, 29);
            this.MCom_ProductName.TabIndex = 24;
            this.MCom_ProductName.UseSelectable = true;
            this.MCom_ProductName.SelectedIndexChanged += new System.EventHandler(this.MCom_ProductName_SelectedIndexChanged);
            // 
            // MTex_Price
            // 
            this.MTex_Price.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Price.CustomButton.Image = null;
            this.MTex_Price.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_Price.CustomButton.Name = "";
            this.MTex_Price.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Price.CustomButton.TabIndex = 1;
            this.MTex_Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Price.CustomButton.UseSelectable = true;
            this.MTex_Price.CustomButton.Visible = false;
            this.MTex_Price.Lines = new string[0];
            this.MTex_Price.Location = new System.Drawing.Point(381, 82);
            this.MTex_Price.MaxLength = 32767;
            this.MTex_Price.Name = "MTex_Price";
            this.MTex_Price.PasswordChar = '\0';
            this.MTex_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Price.SelectedText = "";
            this.MTex_Price.SelectionLength = 0;
            this.MTex_Price.SelectionStart = 0;
            this.MTex_Price.ShortcutsEnabled = true;
            this.MTex_Price.Size = new System.Drawing.Size(87, 28);
            this.MTex_Price.TabIndex = 25;
            this.MTex_Price.UseSelectable = true;
            this.MTex_Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_Quantity
            // 
            this.MTex_Quantity.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Quantity.CustomButton.Image = null;
            this.MTex_Quantity.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_Quantity.CustomButton.Name = "";
            this.MTex_Quantity.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Quantity.CustomButton.TabIndex = 1;
            this.MTex_Quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Quantity.CustomButton.UseSelectable = true;
            this.MTex_Quantity.CustomButton.Visible = false;
            this.MTex_Quantity.Lines = new string[0];
            this.MTex_Quantity.Location = new System.Drawing.Point(573, 83);
            this.MTex_Quantity.MaxLength = 32767;
            this.MTex_Quantity.Name = "MTex_Quantity";
            this.MTex_Quantity.PasswordChar = '\0';
            this.MTex_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Quantity.SelectedText = "";
            this.MTex_Quantity.SelectionLength = 0;
            this.MTex_Quantity.SelectionStart = 0;
            this.MTex_Quantity.ShortcutsEnabled = true;
            this.MTex_Quantity.Size = new System.Drawing.Size(87, 28);
            this.MTex_Quantity.TabIndex = 26;
            this.MTex_Quantity.UseSelectable = true;
            this.MTex_Quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_Total
            // 
            this.MTex_Total.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_Total.CustomButton.Image = null;
            this.MTex_Total.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_Total.CustomButton.Name = "";
            this.MTex_Total.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_Total.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Total.CustomButton.TabIndex = 1;
            this.MTex_Total.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Total.CustomButton.UseSelectable = true;
            this.MTex_Total.CustomButton.Visible = false;
            this.MTex_Total.Lines = new string[0];
            this.MTex_Total.Location = new System.Drawing.Point(711, 83);
            this.MTex_Total.MaxLength = 32767;
            this.MTex_Total.Name = "MTex_Total";
            this.MTex_Total.PasswordChar = '\0';
            this.MTex_Total.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Total.SelectedText = "";
            this.MTex_Total.SelectionLength = 0;
            this.MTex_Total.SelectionStart = 0;
            this.MTex_Total.ShortcutsEnabled = true;
            this.MTex_Total.Size = new System.Drawing.Size(87, 28);
            this.MTex_Total.TabIndex = 27;
            this.MTex_Total.UseSelectable = true;
            this.MTex_Total.Visible = false;
            this.MTex_Total.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Total.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MBtn_AddItem
            // 
            this.MBtn_AddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MBtn_AddItem.Location = new System.Drawing.Point(685, 72);
            this.MBtn_AddItem.Name = "MBtn_AddItem";
            this.MBtn_AddItem.Size = new System.Drawing.Size(113, 39);
            this.MBtn_AddItem.TabIndex = 28;
            this.MBtn_AddItem.Text = "AddItem";
            this.MBtn_AddItem.UseCustomBackColor = true;
            this.MBtn_AddItem.UseCustomForeColor = true;
            this.MBtn_AddItem.UseSelectable = true;
            this.MBtn_AddItem.Click += new System.EventHandler(this.MBtn_AddItem_Click);
            // 
            // MTex_AvailableStock
            // 
            this.MTex_AvailableStock.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_AvailableStock.CustomButton.Image = null;
            this.MTex_AvailableStock.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_AvailableStock.CustomButton.Name = "";
            this.MTex_AvailableStock.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_AvailableStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_AvailableStock.CustomButton.TabIndex = 1;
            this.MTex_AvailableStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_AvailableStock.CustomButton.UseSelectable = true;
            this.MTex_AvailableStock.CustomButton.Visible = false;
            this.MTex_AvailableStock.Lines = new string[0];
            this.MTex_AvailableStock.Location = new System.Drawing.Point(573, 10);
            this.MTex_AvailableStock.MaxLength = 32767;
            this.MTex_AvailableStock.Name = "MTex_AvailableStock";
            this.MTex_AvailableStock.PasswordChar = '\0';
            this.MTex_AvailableStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_AvailableStock.SelectedText = "";
            this.MTex_AvailableStock.SelectionLength = 0;
            this.MTex_AvailableStock.SelectionStart = 0;
            this.MTex_AvailableStock.ShortcutsEnabled = true;
            this.MTex_AvailableStock.Size = new System.Drawing.Size(87, 28);
            this.MTex_AvailableStock.TabIndex = 29;
            this.MTex_AvailableStock.UseSelectable = true;
            this.MTex_AvailableStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_AvailableStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_MRP
            // 
            this.MTex_MRP.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.MTex_MRP.CustomButton.Image = null;
            this.MTex_MRP.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_MRP.CustomButton.Name = "";
            this.MTex_MRP.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_MRP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_MRP.CustomButton.TabIndex = 1;
            this.MTex_MRP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_MRP.CustomButton.UseSelectable = true;
            this.MTex_MRP.CustomButton.Visible = false;
            this.MTex_MRP.Lines = new string[0];
            this.MTex_MRP.Location = new System.Drawing.Point(474, 83);
            this.MTex_MRP.MaxLength = 32767;
            this.MTex_MRP.Name = "MTex_MRP";
            this.MTex_MRP.PasswordChar = '\0';
            this.MTex_MRP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_MRP.SelectedText = "";
            this.MTex_MRP.SelectionLength = 0;
            this.MTex_MRP.SelectionStart = 0;
            this.MTex_MRP.ShortcutsEnabled = true;
            this.MTex_MRP.Size = new System.Drawing.Size(87, 28);
            this.MTex_MRP.TabIndex = 30;
            this.MTex_MRP.UseSelectable = true;
            this.MTex_MRP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_MRP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MLab_ProductID
            // 
            this.MLab_ProductID.AutoSize = true;
            this.MLab_ProductID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MLab_ProductID.Location = new System.Drawing.Point(16, 60);
            this.MLab_ProductID.Name = "MLab_ProductID";
            this.MLab_ProductID.Size = new System.Drawing.Size(71, 19);
            this.MLab_ProductID.TabIndex = 31;
            this.MLab_ProductID.Text = "Product ID";
            this.MLab_ProductID.UseCustomBackColor = true;
            this.MLab_ProductID.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel3.Location = new System.Drawing.Point(136, 60);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Product ID";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel4.Location = new System.Drawing.Point(381, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(80, 19);
            this.metroLabel4.TabIndex = 33;
            this.metroLabel4.Text = "Selling Price";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(486, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 34;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel6.Location = new System.Drawing.Point(573, 60);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 35;
            this.metroLabel6.Text = "Quantity";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroLabel7.Location = new System.Drawing.Point(464, 19);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(97, 19);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Available Stock";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(24, 456);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(644, 150);
            this.metroGrid1.TabIndex = 37;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product_ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "MRP";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MTex_GrandTotal
            // 
            // 
            // 
            // 
            this.MTex_GrandTotal.CustomButton.Image = null;
            this.MTex_GrandTotal.CustomButton.Location = new System.Drawing.Point(61, 2);
            this.MTex_GrandTotal.CustomButton.Name = "";
            this.MTex_GrandTotal.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.MTex_GrandTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_GrandTotal.CustomButton.TabIndex = 1;
            this.MTex_GrandTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_GrandTotal.CustomButton.UseSelectable = true;
            this.MTex_GrandTotal.CustomButton.Visible = false;
            this.MTex_GrandTotal.Lines = new string[0];
            this.MTex_GrandTotal.Location = new System.Drawing.Point(581, 612);
            this.MTex_GrandTotal.MaxLength = 32767;
            this.MTex_GrandTotal.Name = "MTex_GrandTotal";
            this.MTex_GrandTotal.PasswordChar = '\0';
            this.MTex_GrandTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_GrandTotal.SelectedText = "";
            this.MTex_GrandTotal.SelectionLength = 0;
            this.MTex_GrandTotal.SelectionStart = 0;
            this.MTex_GrandTotal.ShortcutsEnabled = true;
            this.MTex_GrandTotal.Size = new System.Drawing.Size(87, 28);
            this.MTex_GrandTotal.TabIndex = 38;
            this.MTex_GrandTotal.UseSelectable = true;
            this.MTex_GrandTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_GrandTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Yellow;
            this.metroLabel8.Location = new System.Drawing.Point(493, 612);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(76, 19);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Grand Total";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // btn_GenerateInvoice
            // 
            this.btn_GenerateInvoice.BackColor = System.Drawing.Color.Yellow;
            this.btn_GenerateInvoice.Location = new System.Drawing.Point(650, 646);
            this.btn_GenerateInvoice.Name = "btn_GenerateInvoice";
            this.btn_GenerateInvoice.Size = new System.Drawing.Size(199, 39);
            this.btn_GenerateInvoice.TabIndex = 39;
            this.btn_GenerateInvoice.Text = "Submit";
            this.btn_GenerateInvoice.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_GenerateInvoice.UseCustomBackColor = true;
            this.btn_GenerateInvoice.UseCustomForeColor = true;
            this.btn_GenerateInvoice.UseSelectable = true;
            this.btn_GenerateInvoice.Click += new System.EventHandler(this.btn_GenerateInvoice_Click);
            // 
            // lab_MRP
            // 
            this.lab_MRP.AutoSize = true;
            this.lab_MRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lab_MRP.Location = new System.Drawing.Point(486, 61);
            this.lab_MRP.Name = "lab_MRP";
            this.lab_MRP.Size = new System.Drawing.Size(37, 19);
            this.lab_MRP.TabIndex = 40;
            this.lab_MRP.Text = "MRP";
            this.lab_MRP.UseCustomBackColor = true;
            this.lab_MRP.UseCustomForeColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.lab_MRP);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.MLab_ProductID);
            this.metroPanel3.Controls.Add(this.MTex_MRP);
            this.metroPanel3.Controls.Add(this.MTex_AvailableStock);
            this.metroPanel3.Controls.Add(this.MBtn_AddItem);
            this.metroPanel3.Controls.Add(this.MTex_Total);
            this.metroPanel3.Controls.Add(this.MTex_Quantity);
            this.metroPanel3.Controls.Add(this.MTex_Price);
            this.metroPanel3.Controls.Add(this.MCom_ProductName);
            this.metroPanel3.Controls.Add(this.MTex_ProductID);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(12, 310);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(851, 131);
            this.metroPanel3.TabIndex = 41;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.MLab_CustomerName);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 32);
            this.panel1.TabIndex = 42;
            // 
            // SuppilerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(921, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.btn_GenerateInvoice);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.MTex_GrandTotal);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "SuppilerInvoice";
            this.Text = "SuppilerInvoice";
            this.Load += new System.EventHandler(this.SuppilerInvoice_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox MTex_SupplierID;
        private MetroFramework.Controls.MetroLabel MLab_ClientID;
        private MetroFramework.Controls.MetroTextBox MTex_Email;
        private MetroFramework.Controls.MetroTextBox MTex_Contact;
        private MetroFramework.Controls.MetroLabel Mlab_Address;
        private MetroFramework.Controls.MetroLabel MLab_Contact;
        private MetroFramework.Controls.MetroLabel MLab_Email;
        private MetroFramework.Controls.MetroLabel MLab_CustomerName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox MTex_InvoiceDate;
        private MetroFramework.Controls.MetroTextBox MTex_InvoiceNo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox MTex_Pancard;
        private MetroFramework.Controls.MetroLabel lab_Pancard;
        private MetroFramework.Controls.MetroTextBox MTex_ProductID;
        private MetroFramework.Controls.MetroComboBox MCom_ProductName;
        private MetroFramework.Controls.MetroTextBox MTex_Price;
        private MetroFramework.Controls.MetroTextBox MTex_Quantity;
        private MetroFramework.Controls.MetroTextBox MTex_Total;
        private MetroFramework.Controls.MetroButton MBtn_AddItem;
        private MetroFramework.Controls.MetroTextBox MTex_AvailableStock;
        private MetroFramework.Controls.MetroTextBox MTex_MRP;
        private System.Windows.Forms.RichTextBox MTex_Address;
        private MetroFramework.Controls.MetroLabel MLab_ProductID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox MTex_GrandTotal;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btn_GenerateInvoice;
        private MetroFramework.Controls.MetroLabel lab_MRP;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel1;
    }
}