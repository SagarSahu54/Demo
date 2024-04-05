namespace MY_Software
{
    partial class DashBoards
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lab_Homepage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.CB = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_ApplicationClose = new System.Windows.Forms.Button();
            this.lab_Times = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_Selection = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1242, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1258, 66);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // lab_Homepage
            // 
            this.lab_Homepage.AutoSize = true;
            this.lab_Homepage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lab_Homepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Homepage.ForeColor = System.Drawing.Color.Yellow;
            this.lab_Homepage.Location = new System.Drawing.Point(193, 24);
            this.lab_Homepage.Name = "lab_Homepage";
            this.lab_Homepage.Size = new System.Drawing.Size(120, 24);
            this.lab_Homepage.TabIndex = 2;
            this.lab_Homepage.Text = "Home Page";
            this.lab_Homepage.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(652, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hotel Service";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(475, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Food Resturant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(341, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Menu Item";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btn_ApplicationClose);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lab_Times);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Location = new System.Drawing.Point(40, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 412);
            this.panel1.TabIndex = 8;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(20, 92);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // CB
            // 
            this.CB.BackColor = System.Drawing.Color.Black;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.ForeColor = System.Drawing.Color.Yellow;
            this.CB.FormattingEnabled = true;
            this.CB.Location = new System.Drawing.Point(807, 24);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(228, 32);
            this.CB.TabIndex = 10;
            this.CB.Text = "Booking Room";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(67, 278);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(115, 38);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.Text = "LogOut";
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_ApplicationClose
            // 
            this.btn_ApplicationClose.Location = new System.Drawing.Point(36, 352);
            this.btn_ApplicationClose.Name = "btn_ApplicationClose";
            this.btn_ApplicationClose.Size = new System.Drawing.Size(180, 38);
            this.btn_ApplicationClose.TabIndex = 12;
            this.btn_ApplicationClose.Text = "Application Close";
            this.btn_ApplicationClose.UseVisualStyleBackColor = true;
            // 
            // lab_Times
            // 
            this.lab_Times.AutoSize = true;
            this.lab_Times.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_Times.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Times.ForeColor = System.Drawing.Color.Black;
            this.lab_Times.Location = new System.Drawing.Point(16, 63);
            this.lab_Times.Name = "lab_Times";
            this.lab_Times.Size = new System.Drawing.Size(56, 20);
            this.lab_Times.TabIndex = 11;
            this.lab_Times.Text = "Times";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Couple";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 66);
            this.button2.TabIndex = 15;
            this.button2.Text = "Family";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 68);
            this.button3.TabIndex = 16;
            this.button3.Text = "Office & Student";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 62);
            this.button4.TabIndex = 17;
            this.button4.Text = "BirthdayParty";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(270, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 68);
            this.button5.TabIndex = 18;
            this.button5.Text = "Married & Wedding";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(270, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 62);
            this.button6.TabIndex = 19;
            this.button6.Text = "Meeting";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(379, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 346);
            this.panel2.TabIndex = 20;
            // 
            // lab_Selection
            // 
            this.lab_Selection.AutoSize = true;
            this.lab_Selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Selection.Location = new System.Drawing.Point(578, 87);
            this.lab_Selection.Name = "lab_Selection";
            this.lab_Selection.Size = new System.Drawing.Size(110, 25);
            this.lab_Selection.TabIndex = 21;
            this.lab_Selection.Text = "Selection";
            // 
            // DashBoards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 534);
            this.Controls.Add(this.lab_Selection);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_Homepage);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoards";
            this.Text = "DashBoards";
            this.Load += new System.EventHandler(this.DashBoards_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lab_Homepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox CB;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_ApplicationClose;
        private System.Windows.Forms.Label lab_Times;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lab_Selection;
    }
}