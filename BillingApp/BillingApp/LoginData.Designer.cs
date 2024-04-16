namespace BillingApp
{
    partial class login
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
            this.Mlab_Login = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lab_Username = new MetroFramework.Controls.MetroLabel();
            this.lab_UserID = new MetroFramework.Controls.MetroLabel();
            this.lab_Password = new MetroFramework.Controls.MetroLabel();
            this.lab_Email = new MetroFramework.Controls.MetroLabel();
            this.tex_User_ID = new System.Windows.Forms.TextBox();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.tex_Email = new System.Windows.Forms.TextBox();
            this.tex_Username = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mlab_Login
            // 
            this.Mlab_Login.AutoSize = true;
            this.Mlab_Login.BackColor = System.Drawing.Color.Magenta;
            this.Mlab_Login.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Mlab_Login.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Mlab_Login.ForeColor = System.Drawing.Color.Blue;
            this.Mlab_Login.Location = new System.Drawing.Point(367, 0);
            this.Mlab_Login.Name = "Mlab_Login";
            this.Mlab_Login.Size = new System.Drawing.Size(97, 25);
            this.Mlab_Login.TabIndex = 0;
            this.Mlab_Login.Text = "LoginUser";
            this.Mlab_Login.UseCustomBackColor = true;
            this.Mlab_Login.UseCustomForeColor = true;
            this.Mlab_Login.UseStyleColors = true;
            this.Mlab_Login.UseWaitCursor = true;
            this.Mlab_Login.Click += new System.EventHandler(this.Mlab_Login_Click);
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
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
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
            this.metroGrid1.Location = new System.Drawing.Point(52, 210);
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
            this.metroGrid1.Size = new System.Drawing.Size(541, 150);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "User_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Pass";
            this.Column3.HeaderText = "Password";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Status";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Lab_Username
            // 
            this.Lab_Username.AutoSize = true;
            this.Lab_Username.BackColor = System.Drawing.Color.Magenta;
            this.Lab_Username.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Lab_Username.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Lab_Username.Location = new System.Drawing.Point(57, 50);
            this.Lab_Username.Name = "Lab_Username";
            this.Lab_Username.Size = new System.Drawing.Size(97, 25);
            this.Lab_Username.TabIndex = 4;
            this.Lab_Username.Text = "Username";
            this.Lab_Username.UseCustomBackColor = true;
            this.Lab_Username.UseCustomForeColor = true;
            this.Lab_Username.UseStyleColors = true;
            this.Lab_Username.UseWaitCursor = true;
            // 
            // lab_UserID
            // 
            this.lab_UserID.AutoSize = true;
            this.lab_UserID.BackColor = System.Drawing.Color.Magenta;
            this.lab_UserID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_UserID.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_UserID.ForeColor = System.Drawing.Color.Black;
            this.lab_UserID.Location = new System.Drawing.Point(57, 10);
            this.lab_UserID.Name = "lab_UserID";
            this.lab_UserID.Size = new System.Drawing.Size(76, 25);
            this.lab_UserID.TabIndex = 5;
            this.lab_UserID.Text = "User_ID";
            this.lab_UserID.UseCustomBackColor = true;
            this.lab_UserID.UseCustomForeColor = true;
            this.lab_UserID.UseStyleColors = true;
            this.lab_UserID.UseWaitCursor = true;
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.BackColor = System.Drawing.Color.Magenta;
            this.lab_Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_Password.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_Password.Location = new System.Drawing.Point(344, 55);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(92, 25);
            this.lab_Password.TabIndex = 6;
            this.lab_Password.Text = "Password";
            this.lab_Password.UseCustomBackColor = true;
            this.lab_Password.UseCustomForeColor = true;
            this.lab_Password.UseStyleColors = true;
            this.lab_Password.UseWaitCursor = true;
            // 
            // lab_Email
            // 
            this.lab_Email.AutoSize = true;
            this.lab_Email.BackColor = System.Drawing.Color.Magenta;
            this.lab_Email.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lab_Email.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lab_Email.Location = new System.Drawing.Point(356, 5);
            this.lab_Email.Name = "lab_Email";
            this.lab_Email.Size = new System.Drawing.Size(58, 25);
            this.lab_Email.TabIndex = 7;
            this.lab_Email.Text = "Email";
            this.lab_Email.UseCustomBackColor = true;
            this.lab_Email.UseCustomForeColor = true;
            this.lab_Email.UseStyleColors = true;
            this.lab_Email.UseWaitCursor = true;
            // 
            // tex_User_ID
            // 
            this.tex_User_ID.Location = new System.Drawing.Point(153, 10);
            this.tex_User_ID.Name = "tex_User_ID";
            this.tex_User_ID.Size = new System.Drawing.Size(185, 20);
            this.tex_User_ID.TabIndex = 8;
            // 
            // tex_Password
            // 
            this.tex_Password.Location = new System.Drawing.Point(446, 60);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.Size = new System.Drawing.Size(152, 20);
            this.tex_Password.TabIndex = 9;
            // 
            // tex_Email
            // 
            this.tex_Email.Location = new System.Drawing.Point(429, 10);
            this.tex_Email.Name = "tex_Email";
            this.tex_Email.Size = new System.Drawing.Size(152, 20);
            this.tex_Email.TabIndex = 10;
            // 
            // tex_Username
            // 
            this.tex_Username.Location = new System.Drawing.Point(153, 55);
            this.tex_Username.Name = "tex_Username";
            this.tex_Username.Size = new System.Drawing.Size(185, 20);
            this.tex_Username.TabIndex = 11;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Lime;
            this.metroButton1.Location = new System.Drawing.Point(606, 10);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 26);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Submit";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.btn_Delete);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.tex_Username);
            this.metroPanel1.Controls.Add(this.tex_Email);
            this.metroPanel1.Controls.Add(this.tex_Password);
            this.metroPanel1.Controls.Add(this.tex_User_ID);
            this.metroPanel1.Controls.Add(this.lab_Email);
            this.metroPanel1.Controls.Add(this.lab_Password);
            this.metroPanel1.Controls.Add(this.lab_UserID);
            this.metroPanel1.Controls.Add(this.Lab_Username);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(12, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(744, 99);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.Location = new System.Drawing.Point(606, 50);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(122, 26);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseCustomBackColor = true;
            this.btn_Delete.UseCustomForeColor = true;
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.Mlab_Login);
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 31);
            this.panel1.TabIndex = 14;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Mlab_Login;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private MetroFramework.Controls.MetroLabel Lab_Username;
        private MetroFramework.Controls.MetroLabel lab_UserID;
        private MetroFramework.Controls.MetroLabel lab_Password;
        private MetroFramework.Controls.MetroLabel lab_Email;
        private System.Windows.Forms.TextBox tex_User_ID;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.TextBox tex_Email;
        private System.Windows.Forms.TextBox tex_Username;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}