namespace BillingApp
{
    partial class loginForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Mlab_Login_Form = new MetroFramework.Controls.MetroLabel();
            this.MTex_Password = new MetroFramework.Controls.MetroTextBox();
            this.MTex_Username = new MetroFramework.Controls.MetroTextBox();
            this.MBtn_login = new MetroFramework.Controls.MetroButton();
            this.Password = new MetroFramework.Controls.MetroLabel();
            this.Username = new MetroFramework.Controls.MetroLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.Mlab_Login_Form);
            this.metroPanel1.Controls.Add(this.MTex_Password);
            this.metroPanel1.Controls.Add(this.MTex_Username);
            this.metroPanel1.Controls.Add(this.MBtn_login);
            this.metroPanel1.Controls.Add(this.Password);
            this.metroPanel1.Controls.Add(this.Username);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(152, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(508, 318);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // Mlab_Login_Form
            // 
            this.Mlab_Login_Form.AutoSize = true;
            this.Mlab_Login_Form.Location = new System.Drawing.Point(216, 56);
            this.Mlab_Login_Form.Name = "Mlab_Login_Form";
            this.Mlab_Login_Form.Size = new System.Drawing.Size(77, 19);
            this.Mlab_Login_Form.TabIndex = 6;
            this.Mlab_Login_Form.Text = "Login Form";
            this.Mlab_Login_Form.UseCustomBackColor = true;
            this.Mlab_Login_Form.UseCustomForeColor = true;
            this.Mlab_Login_Form.UseMnemonic = false;
            this.Mlab_Login_Form.UseStyleColors = true;
            this.Mlab_Login_Form.UseWaitCursor = true;
            this.Mlab_Login_Form.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // MTex_Password
            // 
            // 
            // 
            // 
            this.MTex_Password.CustomButton.Image = null;
            this.MTex_Password.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.MTex_Password.CustomButton.Name = "";
            this.MTex_Password.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.MTex_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Password.CustomButton.TabIndex = 1;
            this.MTex_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Password.CustomButton.UseSelectable = true;
            this.MTex_Password.CustomButton.Visible = false;
            this.MTex_Password.Lines = new string[0];
            this.MTex_Password.Location = new System.Drawing.Point(146, 157);
            this.MTex_Password.MaxLength = 32767;
            this.MTex_Password.Name = "MTex_Password";
            this.MTex_Password.PasswordChar = '\0';
            this.MTex_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Password.SelectedText = "";
            this.MTex_Password.SelectionLength = 0;
            this.MTex_Password.SelectionStart = 0;
            this.MTex_Password.ShortcutsEnabled = true;
            this.MTex_Password.Size = new System.Drawing.Size(246, 39);
            this.MTex_Password.TabIndex = 5;
            this.MTex_Password.UseSelectable = true;
            this.MTex_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTex_Username
            // 
            // 
            // 
            // 
            this.MTex_Username.CustomButton.Image = null;
            this.MTex_Username.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.MTex_Username.CustomButton.Name = "";
            this.MTex_Username.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.MTex_Username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTex_Username.CustomButton.TabIndex = 1;
            this.MTex_Username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTex_Username.CustomButton.UseSelectable = true;
            this.MTex_Username.CustomButton.Visible = false;
            this.MTex_Username.Lines = new string[0];
            this.MTex_Username.Location = new System.Drawing.Point(146, 100);
            this.MTex_Username.MaxLength = 32767;
            this.MTex_Username.Name = "MTex_Username";
            this.MTex_Username.PasswordChar = '\0';
            this.MTex_Username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MTex_Username.SelectedText = "";
            this.MTex_Username.SelectionLength = 0;
            this.MTex_Username.SelectionStart = 0;
            this.MTex_Username.ShortcutsEnabled = true;
            this.MTex_Username.Size = new System.Drawing.Size(246, 39);
            this.MTex_Username.TabIndex = 4;
            this.MTex_Username.UseSelectable = true;
            this.MTex_Username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MTex_Username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MBtn_login
            // 
            this.MBtn_login.Location = new System.Drawing.Point(195, 219);
            this.MBtn_login.Name = "MBtn_login";
            this.MBtn_login.Size = new System.Drawing.Size(129, 29);
            this.MBtn_login.TabIndex = 3;
            this.MBtn_login.Text = "Login";
            this.MBtn_login.UseCustomBackColor = true;
            this.MBtn_login.UseCustomForeColor = true;
            this.MBtn_login.UseMnemonic = false;
            this.MBtn_login.UseSelectable = true;
            this.MBtn_login.UseStyleColors = true;
            this.MBtn_login.UseWaitCursor = true;
            this.MBtn_login.Click += new System.EventHandler(this.MBtn_login_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(30, 157);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(63, 19);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.UseCustomBackColor = true;
            this.Password.UseCustomForeColor = true;
            this.Password.UseStyleColors = true;
            this.Password.UseWaitCursor = true;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(30, 100);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(68, 19);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.UseCustomBackColor = true;
            this.Username.UseCustomForeColor = true;
            this.Username.UseStyleColors = true;
            this.Username.UseWaitCursor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel Username;
        private MetroFramework.Controls.MetroButton MBtn_login;
        private MetroFramework.Controls.MetroLabel Password;
        private MetroFramework.Controls.MetroTextBox MTex_Password;
        private MetroFramework.Controls.MetroTextBox MTex_Username;
        private MetroFramework.Controls.MetroLabel Mlab_Login_Form;
        private System.Windows.Forms.Splitter splitter1;
    }
}