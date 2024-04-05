namespace MY_Software
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lab_UserName = new System.Windows.Forms.Label();
            this.tex_Username = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.lab_Password = new System.Windows.Forms.Label();
            this.lab_EmailID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tex_EmailID = new System.Windows.Forms.TextBox();
            this.tex_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_UserName
            // 
            this.lab_UserName.AutoSize = true;
            this.lab_UserName.Location = new System.Drawing.Point(48, 54);
            this.lab_UserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_UserName.Name = "lab_UserName";
            this.lab_UserName.Size = new System.Drawing.Size(93, 20);
            this.lab_UserName.TabIndex = 0;
            this.lab_UserName.Text = "UserName";
            // 
            // tex_Username
            // 
            this.tex_Username.Location = new System.Drawing.Point(162, 51);
            this.tex_Username.Margin = new System.Windows.Forms.Padding(5);
            this.tex_Username.Name = "tex_Username";
            this.tex_Username.Size = new System.Drawing.Size(322, 26);
            this.tex_Username.TabIndex = 1;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Lime;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Btn_Login.Location = new System.Drawing.Point(244, 205);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(154, 49);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // lab_Password
            // 
            this.lab_Password.AutoSize = true;
            this.lab_Password.Location = new System.Drawing.Point(48, 105);
            this.lab_Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_Password.Name = "lab_Password";
            this.lab_Password.Size = new System.Drawing.Size(86, 20);
            this.lab_Password.TabIndex = 3;
            this.lab_Password.Text = "Password";
            this.lab_Password.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_EmailID
            // 
            this.lab_EmailID.AutoSize = true;
            this.lab_EmailID.Location = new System.Drawing.Point(48, 159);
            this.lab_EmailID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lab_EmailID.Name = "lab_EmailID";
            this.lab_EmailID.Size = new System.Drawing.Size(72, 20);
            this.lab_EmailID.TabIndex = 4;
            this.lab_EmailID.Text = "EmailID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tex_EmailID);
            this.panel1.Controls.Add(this.tex_Password);
            this.panel1.Controls.Add(this.lab_UserName);
            this.panel1.Controls.Add(this.lab_Password);
            this.panel1.Controls.Add(this.tex_Username);
            this.panel1.Controls.Add(this.lab_EmailID);
            this.panel1.Controls.Add(this.Btn_Login);
            this.panel1.Location = new System.Drawing.Point(249, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 298);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tex_EmailID
            // 
            this.tex_EmailID.Location = new System.Drawing.Point(162, 153);
            this.tex_EmailID.Margin = new System.Windows.Forms.Padding(5);
            this.tex_EmailID.Name = "tex_EmailID";
            this.tex_EmailID.Size = new System.Drawing.Size(322, 26);
            this.tex_EmailID.TabIndex = 6;
            // 
            // tex_Password
            // 
            this.tex_Password.Location = new System.Drawing.Point(162, 102);
            this.tex_Password.Margin = new System.Windows.Forms.Padding(5);
            this.tex_Password.Name = "tex_Password";
            this.tex_Password.PasswordChar = '*';
            this.tex_Password.Size = new System.Drawing.Size(322, 26);
            this.tex_Password.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "MY Software Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1142, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_UserName;
        private System.Windows.Forms.TextBox tex_Username;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label lab_Password;
        private System.Windows.Forms.Label lab_EmailID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tex_EmailID;
        private System.Windows.Forms.TextBox tex_Password;
        private System.Windows.Forms.Label label1;
    }
}

